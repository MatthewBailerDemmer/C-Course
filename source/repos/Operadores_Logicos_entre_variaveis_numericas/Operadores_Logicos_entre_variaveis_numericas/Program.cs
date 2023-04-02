using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos_entre_variaveis_numericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;
            Console.WriteLine("O resultado da negação de " + Convert.ToString(var1, 2) + " é " + Convert.ToString(resultadoNegacao, 2));
            

            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resultadoOU = var2 | var3;
            Console.WriteLine("O resultado OU de " + Convert.ToString(var2, 2) + " e "+Convert.ToString(var3, 2)+" é " + Convert.ToString(resultadoOU, 2));

            Console.WriteLine("O resultado E de " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é " + Convert.ToString(var2 & var3, 2));

            Console.WriteLine("O resultado XOR de " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é " + Convert.ToString(var2 ^ var3, 2));

            int var4 = 10;
            int var5 = 20;

            Console.WriteLine("O valor " + var4 + " é maior que (>)" + var5 + " ? " + (var4 > var5));
            Console.WriteLine("O valor " + var5 + " é maior que (<)" + var4 + " ? " + (var5 < var4));
            Console.WriteLine("O valor " + var4 + " é maior que (>)" + var5 + " ? " + (var4 > var5));
           
            Console.WriteLine(var4 + " >= " + var5 + " ?: "+ (var4 >= var5));
            Console.WriteLine(var4 + " <= " + var5 + " ?: " + (var4 <= var5));
            Console.WriteLine(var4 + " >= " + var4 + " ?: " + (var4 >= var4));
            Console.WriteLine(var5 + " >= " + var5 + " ?: " + (var5 >= var5));

            Console.WriteLine(var4 + " == " + var5 + " ?: " + (var4 == var5));
            Console.WriteLine(var4 + " == " + var4 + " ?: " + (var4 == var4));
            Console.WriteLine(var5 + " == " + var5 + " ?: " + (var5 == var5));
           

            Console.ReadKey();

        }
    }
}
