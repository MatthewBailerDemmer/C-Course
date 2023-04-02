using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadroesMatematicosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 15.5;
            double num2 = 10;
            Console.WriteLine(num1 +" + "+ num2 +" = "+(num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));

            int num3 = 4;
            int num4 = 3;
            Console.WriteLine(num3 + " % " + num4 + " = " + (num3 % num4));

            double num5 = 10;
            num5 += 10;
            Console.WriteLine(num5 - 10 + " += " + 10 + " = " + (num5));
            num5 = 10;
            num5 -= 10;
            Console.WriteLine(num5 + 10 + " -= " + 10 + " = " + (num5));
            num5 = 10;
            num5 *= 10;
            Console.WriteLine(num5 / 10 + " *= " + 10 + " = " + (num5));
            num5 = 10;
            num5 /= 10;
            Console.WriteLine(num5 * 10 + " /= " + 10 + " = " + (num5));

            num5 = 10;
            Console.WriteLine(num5 + "++" + " = " +  (++num5));
            num5 = 10;
            Console.WriteLine(num5 + "--" + " = " + (--num5));




            Console.ReadKey();


        }
    }
}
