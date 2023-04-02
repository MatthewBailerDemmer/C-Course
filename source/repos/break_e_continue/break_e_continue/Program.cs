using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_e_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("Pressione C para continue ou B para break");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if(tecla == "C" || tecla == "c")
                {
                    continue;
                }else if(tecla == "B" || tecla == "b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }

            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
