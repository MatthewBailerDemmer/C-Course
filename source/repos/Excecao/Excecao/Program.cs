using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    internal class Joao
    {
        public void ImprimeNome()
        {
            Console.WriteLine("João");
        }
    }
    internal class Program
    {
        static Joao joao;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                int resultado = numerador / denominador;
                Console.WriteLine("O resultado da divisão é: " + resultado);

                //Joao joao = new Joao();
                joao.ImprimeNome();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
