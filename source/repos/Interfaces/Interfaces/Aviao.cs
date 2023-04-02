using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aviao: IVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("O carro está ligado");
        }
        public void Desligar()
        {
            Console.WriteLine("O carro está desligado");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta está aberta");
        }
        public void FecharPorta()
        {
            Console.WriteLine("A porta está fechada");
        }
        public void Decolar()
        {
            Console.WriteLine("O avião decolou");
        }
    }
}
