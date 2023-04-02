using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_a_programacao_orientada_a_objetos
{
    public class Carro
    {
        //Atributos ou variáveis
        private string marca;
        private string modelo;
        private Int32 velocidade;
        private bool carroLigado;


        //Propriedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public Int32 Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool CarroLigado
        {
            get { return carroLigado; }
            set { carroLigado = value; }
        }

        //Métodos
        public void LigarCarro()
        {
            carroLigado = true;
            Console.WriteLine("Ligando o carro da marca " + marca + " e do modelo " + modelo);
        }
        public void DesligarCarro()
        {
            carroLigado = false;
            Console.WriteLine("Desligando o carro da marca " + marca + " e do modelo " + modelo);
        }

        public void AcelerarCarro(Int32 velocidadeFinal)
        {
            if (carroLigado)
            {
                velocidade = velocidadeFinal;
                Console.WriteLine("A velocidade do carro da marca " + marca + " e do modelo " + modelo + " é " + velocidade);
            }
            else
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " esta desligado");
            }
        }
        public void PararCarro()
        {
            if(velocidade == 0)
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " já está parado");
            }
            else
            {
                velocidade = 0;
                Console.WriteLine("A velocidade do carro da marca " + marca + " e do modelo " + modelo + " esta parado");
            }
            
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Carro hondaFit = new Carro();
            hondaFit.Marca = "Honda";
            hondaFit.Modelo = "FIT";
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();
            hondaFit.DesligarCarro();

            Carro fiatUno = new Carro();
            hondaFit.Marca = "Fiat";
            hondaFit.Modelo = "Uno";
            hondaFit.AcelerarCarro(80);
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();
            hondaFit.DesligarCarro();

            Console.ReadKey();
        }
    }
}
