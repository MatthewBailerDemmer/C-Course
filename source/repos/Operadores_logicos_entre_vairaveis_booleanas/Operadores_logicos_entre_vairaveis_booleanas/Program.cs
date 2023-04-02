using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_logicos_entre_vairaveis_booleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;


            Console.WriteLine("A negação de " + var1 + " é "+var1);
            Console.WriteLine("A negação de " + var2 + " é " + var2);


            Console.WriteLine("O  resultado da operacao E entre " + var1 + " e " + var2 + ": " + (var1 & var2));
            Console.WriteLine("O  resultado da operacao E entre " + var1 + " e " + var1 + ": " + (var1 & var1));
            Console.WriteLine("O  resultado da operacao E entre " + var2 + " e " + var2 + ": " + (var2 & var2));

            Console.WriteLine("O  resultado da operacao OU entre " + var2 + " e " + var2 + ": " + (var2 | var2));
            Console.WriteLine("O  resultado da operacao OU entre " + var1 + " e " + var1 + ": " + (var1 | var1));
            Console.WriteLine("O  resultado da operacao OU entre " + var1 + " e " + var2 + ": " + (var1 | var2));

            Console.WriteLine("O  resultado da operacao OU exclusivo entre " + var2 + " e " + var2 + ": " + (var2 ^ var2));
            Console.WriteLine("O  resultado da operacao OU exclusivo entre " + var1 + " e " + var1 + ": " + (var1 ^ var1));
            Console.WriteLine("O  resultado da operacao OU exclusivo entre " + var1 + " e " + var2 + ": " + (var1 ^ var2));


            Console.ReadKey();

            


        }
    }
}
