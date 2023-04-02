using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        //tipo_de_acesso modificador_de_instancia tipo_de_retorno nome_do_metodo (parametros_de_entrada)
        // modificadores de parametros de entrada
        // ref - o parametro pode ser alterado pelo metodo
        // out o paramentro deve ser alterado pelo metodo

        public static void  Multiplica(double a, double b, ref double result)
        {
            result = a * b;
        }

        public static void Mult(double a, double b, out double result)
        {
            result = a * b;
        }
        public static double Soma(double a, double b)
        {
            double resultadoSoma = a + b;
            return resultadoSoma; // ou return a + b;
        }
        static void Main(string[] args)
        {
            double resultado = Soma(10, 20);
            Console.WriteLine(resultado);
            
            double resul = 0;
            Multiplica(5, 3, ref resul);
            Console.WriteLine(resul);

            resul = 0;
            Mult(5, 3, out resul);
            Console.WriteLine(resul);

            Console.ReadKey();
        }
    }
}
