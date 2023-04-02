using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Minupulacao_Arquvios_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "teste5.txt";
            FileStream fs = File.Create("teste5.txt");
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho);
            sw.Write('a');
            sw.Write('-');
            sw.Write("Olá, mundo!\r\n");

            sw.WriteLine("c - Olá, mundo 3");
            sw.WriteLine("c - Olá, mundo 3");

            sw.Close();
            StreamReader sr1 = new StreamReader(caminho);
            char[] buffer = new char[128];
            sr1.Read(buffer, 4, 5);
            sr1.Read(buffer, 8, 7);

            sr1.Close();

            StreamReader sr2 = new StreamReader(caminho);
            string linha = sr2.ReadLine();
            linha = sr2.ReadLine();
            sr2.Close();

            StreamReader sr3 = new StreamReader(caminho);
            string arquivoInteiro = sr3.ReadToEnd();
            sr3.Close();

        }
    }
}
