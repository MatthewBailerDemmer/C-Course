using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando caminhos  de arquivo
            //Primeiro método
            string caminho1 = "D:\\teste.txt";
            //Segunda maneira
            string caminho2 = @"D:\teste.txt";
            FileStream meuArquivo = File.Create(caminho2);
            meuArquivo.Close();

            bool arquivoExiste = File.Exists(caminho2);
           Console.WriteLine(arquivoExiste);

            File.Delete(caminho1);

            //Renomeando ou movendo arquivos
            string caminho3 = "D:\\teste3.txt";
            FileStream meuArquivo2 = File.Create(caminho3);
            meuArquivo2.Close();
            string caminho4 = "D:\\Nova pasta\\teste3";
            File.Delete(caminho4);
            File.Move(caminho3, caminho4);

            //Escrevendo em um arquivo de texto
            string caminho5 = "D:\\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Marcos é um cara muito legal \r\n " +
                "Pedro é um cara muito inteligente";
            File.WriteAllText(caminho5, conteudo);

            //Escrevendo array de strings no nosso arquivo
            string[] conteudoArray = { "Guilhermer", "Marcos", "Pedro", "Maria" };
            File.WriteAllLines(caminho5, conteudoArray);


            //Lendo todo o conteúdo de um arquivo
            string conteudo_lido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudo_lido);

            //Lendo o conteudo de um arquivo e gravando em um array de strings
            Console.WriteLine("-----------------------------------");
            string[] conteudo_lido_array = File.ReadAllLines(caminho5);
            foreach (string nome in conteudo_lido_array)
                Console.WriteLine(nome);

            Console.ReadKey();
        }
    }
}
