using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_Arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"D:\nomes.txt";
            string texto1 = "João subiu no telhado\r\n";
            string texto2 = "Luana brigou com ele\r\n";

            //Maneira não muito correta
            string conteudoInicial = File.ReadAllText(caminho);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminho, conteudoFinal);

            File.AppendAllText(@"D:\Teste2.txt", "\r\n "+ texto1 + texto2);

        }
    }
}
