using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //Interface é um protótipo de uma classe(esqueleto/contrato)
        //Ela define os métodos que serão implementados pela classe



        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta(); ;
            meuCarro.Ligar();
            meuCarro.Desligar();
            meuCarro.Acelerar();

            Aviao meuAviao = new Aviao();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta(); ;
            meuAviao.Ligar();
            meuAviao.Desligar();
            meuAviao.Decolar();

            IVeiculo meuVeiculosCarro = new Carro();
            meuVeiculosCarro.AbrirPorta();
            meuVeiculosCarro.FecharPorta(); ;
            meuVeiculosCarro.Ligar();
            meuVeiculosCarro.Desligar();
            //meuVeiculosCarro.Acelerar(); da erro pois não implementam a interface, vem diretamente dela


            IVeiculo meuVeiculoAviao = new Aviao();
            meuVeiculoAviao.AbrirPorta();
            meuVeiculoAviao.FecharPorta(); ;
            meuVeiculoAviao.Ligar();
            meuVeiculoAviao.Desligar();
            //meuVeiculoAviao.Decolar(); da erro pois não implementam a interface, vem diretamente dela
        }
    }
}
