using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_static_e_palavra_this
{

    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }

        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
    public class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }

    public class MinhaPessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }

        public MinhaPessoa(string nome)
        {
            this.nome = nome;
        }
    }



    internal class Program
    {
       
 
        static void Main(string[] args)
        {
            // objetos de classes não static diferentes ocupam espaços de memória diferentes
            //classe estática utiliza apenas um espaço de memória, compartilhando o mesmo valor mesmo quando há mudanças
            // Todos os atributos e metodos static pertencem a classe e nao ao objeto
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");
            pessoa1.ImprimeNome();
            pessoa1.Nome = "Maria";
            Console.WriteLine("O valor de PI é: " + Calculadora.PI);
            Console.WriteLine("A área é: " + Calculadora.CalculaAreaCircunferencia(2));
            Calculadora calc = new Calculadora();
            //Não podemos acessar o que é static através do nome do objeto, pois ele pertence a classe
        }
    }
}
