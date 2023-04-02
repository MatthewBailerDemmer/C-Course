using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoDeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação
            string name = "Guilherme";
            char letra = name[4];
            Console.WriteLine(letra);

            //Concatenar string
            string sobrenome = " Silva Sauro";
            string nomecompleto = name + sobrenome;
            Console.WriteLine(nomecompleto);

            //Operador Concat
            string nomecompleto2 = String.Concat(name, sobrenome);
            Console.WriteLine(nomecompleto2);

            //Substituição de string
            string endereco = "Rua Das Rosas Verdes";
            endereco = endereco.Replace("Verdes", "Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings
            string endereco2 = "Rua Das Rosas Verdes";
            endereco2 = endereco2.Replace("Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua Das Rosas Verdes";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);

            //Captalização de strings
            string nome2 = "Joao da Silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            //Contém
            string nome3 = "Joao da Silva";
            bool contem = nome3.Contains("Joao");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);

            //Localização de textos
            string nome4 = "Joao da Silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            //Numero de caracteres
            string nome6 = "Joao da Silva";
            int numeroDeCaracteres = nome6.Length;
            Console.WriteLine(numeroDeCaracteres);

            //SubString
            string nome7 = "Joao da Silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //Formatacao composta
            string nome8 = "Joao {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Sauro");
            string nomeCompleto6 = String.Format(nome8, "da Silva", "Sauro");
            Console.WriteLine(nomeCompleto6);


            Console.ReadKey();
        }
    }
}
