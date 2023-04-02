using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forcando_Excecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Excreva um número positivo");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                    throw new Exception("O número " + numero + " é menor que zero");
                else
                    Console.WriteLine("Voce digitou o numero: " + numero);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();

            }
        }
    }
}
