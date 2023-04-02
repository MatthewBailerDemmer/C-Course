using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args) // uma lista é uma coleção de valores do mesmo tipo, tamanho indeterminado, podem ter qualquer tipo
        {
            List<string> ListaDeNomes = new List<string>();

            //Adicionar elementos
            ListaDeNomes.Add("João");
            ListaDeNomes.Add("Marcos");
            ListaDeNomes.Add("Mariana");
            ListaDeNomes.Add("Aline");

            foreach(string str in ListaDeNomes)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("---------------------------");
         

            //Removendo Elementos
            ListaDeNomes.Remove("Marcos");
            foreach (string str in ListaDeNomes)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("---------------------------");
           
            //Removendo Elementos em posições específicas
            ListaDeNomes.RemoveAt(0);
            foreach (string str in ListaDeNomes)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("---------------------------");

            List<string> ListaDeNomes2 = new List<string>();
            ListaDeNomes2.Add("João");
            ListaDeNomes2.Add("Marcos");
            ListaDeNomes2.Add("Mariana");
            ListaDeNomes2.Add("Aline");

            Console.WriteLine("---------------------------");

            //Removendo uma faixa de elementos
            ListaDeNomes2.RemoveRange(1,2);

            foreach (string str in ListaDeNomes2)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("---------------------------");
            //Pegando o número de elementos
            Console.WriteLine("A lista de nomes 2  possui " + ListaDeNomes2.Count() + " elementos");
           
            Console.WriteLine("---------------------------");

            //Concatenando Listas
            List<string> ListaDeNomes3 = new List<string>();
            List<string> ListaDeNomes4 = new List<string>();

            ListaDeNomes3.Add("João");
            ListaDeNomes3.Add("Marcos");
            ListaDeNomes3.Add("Mariana");
            ListaDeNomes3.Add("Aline");

            ListaDeNomes4.Add("Manoel");
            ListaDeNomes4.Add("João");
            ListaDeNomes4.Add("Pedro");
            ListaDeNomes4.Add("Alan");

            List<string> ListaDeNomesConcatenados = ListaDeNomes3.Concat(ListaDeNomes4).ToList();

            foreach (string str in ListaDeNomesConcatenados)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("---------------------------");

            //Verificando se a lista possue determinado valor

            bool contentName = ListaDeNomesConcatenados.Contains("Pedro");
            Console.WriteLine("A lista concatenada contem o nome Pedro? " + contentName);
            contentName = ListaDeNomesConcatenados.Contains("Manoela");
            Console.WriteLine("A lista concatenada contem o nome Manoela? " + contentName);

            Console.WriteLine("---------------------------");

            //Descobrindo o índice de um elemento
            int indice = ListaDeNomesConcatenados.IndexOf("Mariana");
            Console.WriteLine("O indice do nome Marian é: " + indice);

            Console.WriteLine("---------------------------");


            //Operador where
            List<string> listaWhere = ListaDeNomesConcatenados.Where(x => x.StartsWith("M")).ToList();// => = tal que
            foreach (string str in listaWhere)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    
    }
}
