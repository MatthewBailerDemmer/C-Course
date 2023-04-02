using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuracao_avancada
{
    internal class Program
    {
        public static double PegaDouble(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Convert.ToDouble(Console.ReadLine());
        }
        public static void Divide()
        {
            double numerador = PegaDouble("Digite o numerador");
            double denominador = PegaDouble("Digite o denominador");
            double resultadoDivisao = numerador / denominador;
            Console.WriteLine(resultadoDivisao);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Divide();
        }
    }
}
