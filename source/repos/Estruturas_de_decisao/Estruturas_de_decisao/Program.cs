using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a sua idade");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());
            if(Idade >= 18) {

                Console.WriteLine("Voce é maior de idade");
            }
            else
            {
                Console.WriteLine("Voce não é maior de idade");

            }

            Console.WriteLine("digite a seu salário");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());

            if (Salario < 10000)
            {

                Console.WriteLine("Voce ganha menos de um salário mínimo");
            }
            else if(Salario < 2000)
            {
                Console.WriteLine("Voce ganha menos que 2 salários mínimos");

            }
            else
            {
                Console.WriteLine("Voce ganha mais que 2 salários mínimos");
            }


            Console.WriteLine("Pressione uma tecla do seu teclado: ");
            char tecla = Console.ReadKey().KeyChar;
            switch (tecla)
            {
                case 'a':
                    Console.WriteLine("Voce pressionou a");
                    break;
                case 'b':
                    Console.WriteLine("Voce pressionou b");
                    break;
                default:
                    Console.WriteLine("Voce não pressionou nem a nem b");
                    break;
            }



            Console.ReadKey();


        }
    }
}
