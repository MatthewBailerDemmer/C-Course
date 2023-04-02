using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Veiculo
    {
        private uint numeroRodas;
        private uint numeroPortas;
        private uint velocidade;
        private bool estaLigado;

        public uint NumeroRodas
        {
            get { return numeroRodas; }
        }
        public uint NumeroPortas
        {
            get { return numeroPortas; }
        }
        public uint Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool EstaLigado
        {
            get { return estaLigado; }
        }

        public void Ligar()
        {
            estaLigado = true;
            Console.WriteLine("Veículo Ligado");
        }
        public void Desligar()
        {
            estaLigado = false;
            Console.WriteLine("Veículo Desligado");
        }

        public Veiculo(uint pNumeroRodas, uint pNumeroPortas)
        {
            this.numeroRodas = pNumeroRodas;
            this.numeroPortas = pNumeroPortas;
            velocidade = 0;
            estaLigado = false;
        }
    }
}
