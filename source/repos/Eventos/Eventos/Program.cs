using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //São uma maneira de trocar informações entre objetos
            //de uma classe
            //Eventos possibilitam um objeto avisar outros objetos
            //quando uma coisa acontece
           
            Cozinha cozinhaHamburger = new Cozinha();
            Cozinha cozinhaJaponesa = new Cozinha();

            Tablet tableJoao = new Tablet("João", cozinhaHamburger);
            Tablet tablePedro = new Tablet("Pedro", cozinhaHamburger);
            Tablet tableMaria = new Tablet("Maria", cozinhaHamburger);

            Tablet tableJoana = new Tablet("Joana", cozinhaJaponesa);
            Tablet tableAline = new Tablet("Aline", cozinhaJaponesa);
            Tablet tableMarcos = new Tablet("Marcos", cozinhaJaponesa);

            cozinhaHamburger.EnviaMensagemPedidoPronto(12);
            cozinhaJaponesa.EnviaMensagemPedidoPronto(13);
            
            Console.ReadKey();
        }
    }
}
