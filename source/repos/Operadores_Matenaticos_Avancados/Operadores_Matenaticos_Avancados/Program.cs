using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matenaticos_Avancados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(4, 2));
            Console.WriteLine(Math.Pow(27, 1/3 ));
            Console.WriteLine(Math.Max(4, 8));
            Console.WriteLine(Math.Min(4, 8));
            Console.WriteLine(Math.Abs(-10));

            Console.WriteLine(Math.Sin(30 * (2 * Math.PI) / 360));
            Console.WriteLine(Math.Cos(30 * (2 * Math.PI) / 360));
            Console.WriteLine(Math.Tan(30 * (2 * Math.PI) / 360));
            Console.WriteLine(Math.Asin(Math.Sin(30 * (2 * Math.PI) / 360)) * 360 / (2 * Math.PI)); //arco seno
            Console.WriteLine(Math.Acos(Math.Cos(30 * (2 * Math.PI) / 360)) * 360 / (2 * Math.PI));
            Console.WriteLine(Math.Atan(Math.Tan(30 * (2 * Math.PI) / 360)) * 360 / (2 * Math.PI));

            Console.WriteLine(Math.Ceiling(3.33));// arredondando para cima
            Console.WriteLine(Math.Floor(3.33));// arredondando para baixo

            Console.WriteLine(Math.Log10(100));
            Console.WriteLine(Math.Log(Math.Pow(Math.E, 3))); // Logaritimo na base E

            Console.ReadKey();
        }
    }
}
