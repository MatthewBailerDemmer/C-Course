using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            array1[0] = 1;
            array1[1] = 10;
            array1[2] = 100;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            Console.WriteLine("--------------------");

            int[] array2 = { 1, 2, 3};
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);

            Console.WriteLine("--------------------");

            int[] array3 = new int[] { 1, 2, 3 };
            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);

            Console.WriteLine("--------------------");

            string[,] array4 = new string[2,3];
            array4[0, 0] = "1";
            array4[0, 1] = "2";
            array4[0, 2] = "3";
            array4[1, 0] = "4";
            array4[1, 1] = "5";
            array4[1, 2] = "6";
            Console.WriteLine(array4[0, 0]);
            Console.WriteLine(array4[0,1]);
            Console.WriteLine(array4[0,2]);
            Console.WriteLine(array4[1,0]);
            Console.WriteLine(array4[1, 1]);
            Console.WriteLine(array4[1, 2]);


            Console.WriteLine("--------------------");

            string[,] array5 = { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(array5[0, 0]);
            Console.WriteLine(array5[0, 1]);
            Console.WriteLine(array5[0, 2]);
            Console.WriteLine(array5[1, 0]);
            Console.WriteLine(array5[1, 1]);
            Console.WriteLine(array5[1, 2]);

            Console.WriteLine("--------------------");

            string[,] array6 = new string[,] { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(array6[0, 0]);
            Console.WriteLine(array6[0, 1]);
            Console.WriteLine(array6[0, 2]);
            Console.WriteLine(array6[1, 0]);
            Console.WriteLine(array6[1, 1]);
            Console.WriteLine(array6[1, 2]);

            Console.WriteLine("--------------------");
            Console.WriteLine(array6.GetLength(0));
            Console.WriteLine(array6.GetLength(1));


            Console.ReadKey();
        }
    }
}
