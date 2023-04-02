using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Aviao: Veiculo
    {
        private uint altitude;
        public uint Altitude
        {
            get { return altitude; }
        }

        public void Decolar(uint pVelocidade, uint pAltitude)
        {
            if (EstaLigado)
            {
                Console.WriteLine("Aviao Decolando...");
                altitude = pAltitude;
                Velocidade = pVelocidade;
                Console.WriteLine("Velocidade do aviao: " + Velocidade);
                Console.WriteLine("Altitude do aviao: " + altitude);
            }
            else
                Console.WriteLine("Aviao Desligado");
        }

        public void Pousar()
        {
          
                Console.WriteLine("Aviao Pousando...");
                altitude = 0;
                Velocidade = 0;
                Console.WriteLine("Velocidade do aviao: " + Velocidade);
                Console.WriteLine("Altitude do aviao: " + altitude);
        
        }

        public Aviao(uint pNumeroRodas, uint pNumeroPortas): base(pNumeroRodas,pNumeroPortas)
        {
            altitude = 0;
        }
    }
}
