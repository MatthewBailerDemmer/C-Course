using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Olá " + Nome);
 

            Console.WriteLine("Digite sua idade: ");
            string Idade = Console.ReadLine();
            Console.WriteLine("Você tem " + Idade + " anos de idade");

            int IdadeInt = Convert.ToInt32(Idade);

            Console.WriteLine("Pressione qualquer tecla: ");
            string TeclaPressionada = Console.ReadKey(true).KeyChar.ToString();
            string TeclaPressionada2 = Convert.ToString(Console.ReadKey(true).KeyChar);

            Console.WriteLine("Olá. A primeira tecla que voce pressionou foi: " + TeclaPressionada);
            Console.WriteLine("Olá. A segunda tecla que voce pressionou foi: " + TeclaPressionada2);

            Console.Write("Digite Qualque tecla para sair");

            Console.ReadKey();
        }
    }
}
