using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using NonoProjeto;

namespace Oitavo_Projeto
{
    [DataContract]
    internal class BaseDeDados
    {
        [DataMember]
        private List<CadastroPessoa> listaDePessoas;
        private string caminhoBaseDeDados;

        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
            Serializador.Serializa(caminhoBaseDeDados, this);
        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
                return listaDePessoasTemp;
            else
                return null;
        }

        public List<CadastroPessoa> RemovePessoaPorDoc(string pNumeroDoDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach (CadastroPessoa pessoa in listaDePessoasTemp)
                    listaDePessoas.Remove(pessoa);

                return listaDePessoasTemp;
            }
            else
                return null;
        }

        public BaseDeDados(string caminhoBaseDeDados)
        {
            this.caminhoBaseDeDados = caminhoBaseDeDados;
            BaseDeDados BaseDeDadosTemp = Serializador.Desserializa(caminhoBaseDeDados);
            if (BaseDeDadosTemp != null)
                listaDePessoas = BaseDeDadosTemp.listaDePessoas;
            else
                listaDePessoas = new List<CadastroPessoa>();
            
        }
    }
}
