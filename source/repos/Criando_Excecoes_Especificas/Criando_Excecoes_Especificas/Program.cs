using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Excecoes_Especificas
{
    internal class Program
    {
        static void VerificaNumero(int numero)
        {
            if (numero < 0)
                throw new NumeroNegativoException(numero);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número expecifico");
                int numero = Convert.ToInt32(Console.ReadLine());
            VerificaNumero(numero);
                Console.WriteLine("O número: " + numero + " é positivo");
            }
            catch (NumeroNegativoException e)
            {
                Console.WriteLine("EXCEÇÃO: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();

            }
           
        }
    }
}
