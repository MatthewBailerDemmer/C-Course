using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_Downcasting
{
    internal class Funcionario: Pessoa
    {
        private uint salario;
        public void ImprimeSalario()
        {
            Console.WriteLine("O salário de " + Nome + " é " + salario);
        }
        public Funcionario(string nome, uint salario): base(nome)
        {
            this.salario = salario;
        }
    }
}
