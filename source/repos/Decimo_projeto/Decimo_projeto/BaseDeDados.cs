using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using NonoProjeto;
using System.Threading;

namespace Oitavo_Projeto
{
    [DataContract]
    internal class BaseDeDados
    {
        [DataMember]
        private List<CadastroPessoa> listaDePessoas;
        private string caminhoBaseDeDados;

        private Mutex mutexArquivo;
        private Mutex mutexLista;
        private bool baseDisponivel;

        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            mutexLista.WaitOne();
            listaDePessoas.Add(pPessoa);
            mutexLista.ReleaseMutex();
            new Thread(() => 
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                Serializador.Serializa(caminhoBaseDeDados, this);
                mutexArquivo.ReleaseMutex();
                baseDisponivel = true;
            }).Start();
            
        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (listaDePessoasTemp.Count > 0)
                return listaDePessoasTemp;
            else
                return null;
        }

        public List<CadastroPessoa> RemovePessoaPorDoc(string pNumeroDoDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach (CadastroPessoa pessoa in listaDePessoasTemp)
                {

                    mutexLista.WaitOne();
                    listaDePessoas.Remove(pessoa);
                    mutexLista.ReleaseMutex();
                }

                new Thread(() => 
                {
                    baseDisponivel = false;
                    mutexArquivo.WaitOne();
                    Serializador.Serializa(caminhoBaseDeDados, this);
                    mutexArquivo.ReleaseMutex();
                    baseDisponivel = true;
                }).Start();
                return listaDePessoasTemp;
            }
            else
                return null;
        }

        public bool BaseDisponivel()
        {
            return baseDisponivel;
        }

        public BaseDeDados(string caminhoBaseDeDados)
        {
            this.caminhoBaseDeDados = caminhoBaseDeDados;
            mutexLista = new Mutex();
            mutexArquivo = new Mutex();
            baseDisponivel = true;

            new Thread(() =>
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                BaseDeDados BaseDeDadosTemp = Serializador.Desserializa(caminhoBaseDeDados);
                mutexArquivo.ReleaseMutex();
                baseDisponivel = true;
                mutexLista.WaitOne();
                if (BaseDeDadosTemp != null)
                    listaDePessoas = BaseDeDadosTemp.listaDePessoas;
                else
                    listaDePessoas = new List<CadastroPessoa>();
                mutexLista.ReleaseMutex();
            }).Start();
           

        }
    }
}
