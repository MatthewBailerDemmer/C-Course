using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuServidorWebService meuServidorLocal = new MeuServidorWebService("http://10.0.0.154:80/MeuServidorLocal");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
