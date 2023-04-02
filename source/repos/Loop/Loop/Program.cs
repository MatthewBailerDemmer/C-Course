using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            int j = 0;

            while(j < 100)
            {
                Console.WriteLine("Bom dia");
                j += 10;
            }

            int k = 0;
            do
            {
                Console.WriteLine("Boa Tarde");
                k += 100;
            } while (k < 1000);
            
            string[] nomes = { "Guilherme", "João", "Pedro", "Maria", "Paula" };
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            
            
            Console.ReadKey();


        }
    }
}
