using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade = 18;
            Idade = 18;
            Console.WriteLine(Idade);
            Idade = 20;
            Console.WriteLine(Idade);
            

            string NomeCompleto = "Matheus Demmer";
            Console.WriteLine(NomeCompleto);
            Console.WriteLine("Matheus Demmer");
            NomeCompleto = "Seila Seilovisk";

            Console.WriteLine(NomeCompleto);

            //byte b = 10000; o valor 10000 é muito grande para uma variável do tipo byte

            var Salario = 10000; // O Compilador adivinha o tipo da variável
            var NomeDaMae = "Joana"; // Uma vez feita a atribuição não se pode mudar o tipo
            //NomeDaMae = 10 -> isso não é possivel pois o compilador já atribuiu o tipo string para a variavel

            DateTime DataDeNascimento = new DateTime(1988, 7, 10, 7, 15, 10);
            Console.WriteLine(DataDeNascimento.Year);
            Console.WriteLine(DataDeNascimento.Month);
            Console.WriteLine(DataDeNascimento.Day);
            Console.WriteLine(DataDeNascimento.Hour);
            Console.WriteLine(DataDeNascimento.Minute);
            Console.WriteLine(DataDeNascimento.Second);

            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);
            Console.WriteLine(NumeroDaCasaInt);

            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);
            Console.WriteLine(NumeroDaCasa2);

            byte b = 35;
            char c = Convert.ToChar(b); // Converte para a tabela ASCII
            Console.WriteLine(c);

            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC);

            double d = 1.6;
            Console.WriteLine(d);

            int conversaoDouble = Convert.ToInt32(d);
            Console.WriteLine(conversaoDouble);

            /*int NumeroGrande = 1000; ;
            byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            Console.WriteLine(NumeroPequeno); -> Isso da Erro */
            Console.ReadKey();
        }
    }
}
