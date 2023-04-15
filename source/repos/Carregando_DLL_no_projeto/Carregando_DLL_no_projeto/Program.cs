using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minha_Primeira_DLL;

namespace Carregando_DLL_no_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A soma de 5 e 6 é: " + Matematica.Soma(5, 6));
            Console.WriteLine("A multiplicacao de 5 e 6 é: " + Matematica.Multiplicacao(5, 6));

            Console.ReadKey();
        }
    }
}
