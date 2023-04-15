using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_Downcasting
{
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value;}
        }

        public void ImprimeNome()
        {
            Console.WriteLine("O nome da pessoa é " + nome);
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }
}
