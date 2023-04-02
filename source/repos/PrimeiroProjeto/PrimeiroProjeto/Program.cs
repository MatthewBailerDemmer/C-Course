using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento");
            string Documento = Console.ReadLine();


            Console.WriteLine("Digite o nome da sua rua");
            string NomeDaRua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe seu  gênero. Pressione F para feminino e M para masculino");
            string Genero = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Voce tem  " + Idade + " anos de idade");
            Console.WriteLine("O numero do seu documento é:" + Documento);
            Console.WriteLine("O nome da sua rua é  " + NomeDaRua);
            Console.WriteLine("O numero da sua casas e " + NumeroDaCasa);
            Console.WriteLine("O seu genero é " + Genero);
            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadKey();




        }
    }
}
