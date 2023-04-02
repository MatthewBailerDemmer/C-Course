using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadoura");
            char opcao = Console.ReadKey(true).KeyChar;

            if(opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("Pressione 1 para alugar top gun");
                Console.WriteLine("Pressione 2 para alugar a bela e a fera");
                Console.WriteLine("Pressione 3 para alugar homem-aranha");
                int opcaoFile = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch(opcaoFile)
                {
                    case 1:
                        Console.WriteLine("Voce alougou top gun");
                        break;
                    case 2:
                        Console.WriteLine("Voce alougou a bela e a fera");
                        break;
                    case 3:
                        Console.WriteLine("Voce alougou homem-aranha");
                        break;
                    default:
                        Console.WriteLine("Opcao desconhecida");
                        break;
                }
            }
            else if(opcao == 'S' || opcao =='s')
            {
                Console.WriteLine("Muito obrigado. Volte Sempre");
            }else
            {
                Console.WriteLine("Opcao desconhecida");
            }

            Console.WriteLine("Pressione qualquer tecla para terminar");
            Console.ReadKey();
        }
    }
}
