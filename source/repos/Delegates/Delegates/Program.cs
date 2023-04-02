using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        //Delegate armazena referencias a métodos pode ser comparado a uma callback
        //Quando chamado ele executa todos os métodos aos quais guarda referência

        public delegate double MeuDelegate(double a, double c);
        public static double Soma(double a, double b)
        {
            return a + b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }

        public static void ExecutaOperacao(MeuDelegate minhaOp)
        {
            Console.WriteLine(minhaOp(50, 20));
        }
        static void Main(string[] args) 
        {
            MeuDelegate minhaOp;
            minhaOp = Soma;
            double resuD = minhaOp(10, 20);
            Console.WriteLine(resuD);

            minhaOp += Mult;
            minhaOp += Div;
            Console.WriteLine("---------------------------");
            resuD = minhaOp(10, 20);
            Console.WriteLine(resuD);

            Console.WriteLine("---------------------------");
            ExecutaOperacao(Mult);
            
            Console.ReadKey();
        }
    }
}
