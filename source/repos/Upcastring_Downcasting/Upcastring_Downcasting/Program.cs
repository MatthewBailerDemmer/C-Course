using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario meuFuncionario = new Funcionario("João", 10000);
            Pessoa minhaPessoa = meuFuncionario; //upcastring
            minhaPessoa.ImprimeNome();
            

            Pessoa minhaPessoa2 = new Pessoa("Manuel");
            // Funcionario meuFuncionario2 = (Funcionario)minhaPessoa2; downcastring não funciona pois faltam informações
            Funcionario meuFuncionario2 = (Funcionario)minhaPessoa;
            meuFuncionario2.ImprimeSalario();
            Console.ReadKey();
        }
    }
}
