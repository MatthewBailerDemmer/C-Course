using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oitavo_Projeto
{
    internal class CadastroPessoa
    {
        private string nome;
        private string numeroDoDocumento;
        private DateTime dataDeNascimento;
        private string nomeDaRua;
        private UInt32 numeroDaCasa;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string NumeroDoDocumento
        {
            get { return numeroDoDocumento; }
            set { numeroDoDocumento = value; }
        }
        public DateTime DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public string NomeDaRua
        {
            get { return nomeDaRua; }
            set { nomeDaRua = value; }
        }

        public UInt32 NumeroDaCasa
        {
            get { return numeroDaCasa; }
            set { numeroDaCasa = value;}
        }

        public CadastroPessoa(string nome, string numeroDoDocumento, DateTime dataDeNascimento, string nomeDaRua, UInt32 numeroDaCasa)
        {
            this.nome = nome;
            this.numeroDoDocumento = numeroDoDocumento;
            this.dataDeNascimento = dataDeNascimento;
            this.nomeDaRua = nomeDaRua;
            this.numeroDaCasa = numeroDaCasa;


        }

    }
}
