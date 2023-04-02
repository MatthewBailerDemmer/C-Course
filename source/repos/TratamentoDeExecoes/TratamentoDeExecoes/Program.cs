using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            
            
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / i;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceção genérica");
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
            }
            Console.ReadKey();
        }
    }
}
