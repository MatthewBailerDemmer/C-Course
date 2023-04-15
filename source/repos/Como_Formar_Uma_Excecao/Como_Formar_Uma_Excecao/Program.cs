using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_Formar_Uma_Excecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Digite um número positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                {
                    throw new Exception("O número: "+ numero + " é negativo");
                }
                Console.WriteLine("O número: " + numero + " é positivo");
            }
            catch(Exception e)
            {
                Console.WriteLine("EXCEÇÂO: " + e.Message);
            }
            finally 
            { 
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
