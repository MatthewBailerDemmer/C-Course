using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos_de_classes
{
    internal class Program
    {
        public class Carro {

            //MODIFICADORES_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
            //public - todos podem acessar o atributo
            //private - somente a nossa classe pode acessar o atributo
            public string marca;
            private double velocidade;

            public void ConfiguraVelocidade(double VelocidadeFinal)
            {
                velocidade = VelocidadeFinal;
            }
        }
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.marca = "honda";
            //Atributos privados só podem ser acessados de dentro da própria classe
            //meuCarro.velocidade = 100;
        }
    }
}
