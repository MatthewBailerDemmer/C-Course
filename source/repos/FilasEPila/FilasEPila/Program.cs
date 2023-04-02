using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasEPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> FilaDeNomes = new Queue<string>();
            //Adicionando elementos
            FilaDeNomes.Enqueue("Guilherme");
            FilaDeNomes.Enqueue("Maria");
            FilaDeNomes.Enqueue("João");
            FilaDeNomes.Enqueue("Vagner");

            //Retirando elementos
            string nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            Console.WriteLine("--------------------------");
            //Espiando elementos
            string nomeEspiado = FilaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            Console.WriteLine("--------------------------");

            //Stack
            Stack<string> PilhaDeNomes = new Stack<string>();

            //Adicionando elementos
            PilhaDeNomes.Push("Mariana");
            PilhaDeNomes.Push("Joaquina");
            PilhaDeNomes.Push("José");
            PilhaDeNomes.Push("Aline");

            //removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);

            Console.WriteLine("--------------------------");
            //Espiando elementos
            string nomeEspiado2 = PilhaDeNomes.Peek();
            Console.WriteLine(nomeEspiado2);

            //Possuem os mesmos métodos das listas
            //Count
            //Clear
            //Concat
            //Conteins
            //...


            Console.ReadKey();

        }
    }
}
