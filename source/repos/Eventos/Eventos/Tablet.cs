using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Tablet
    {
        private string nome;
        public void MostraMensagemPedidoProntoNaCozinha(object fonte, EventArgsPedidoPronto e)
        {
            Console.WriteLine("O pedido "+ e.NumeroPedido + " pronto na cozinha, " + nome);
        }
        public Tablet(string pNome, Cozinha pCozinha) 
        {
            nome = pNome;
            pCozinha.MensagemPedidoProntoEvent += MostraMensagemPedidoProntoNaCozinha;
        }
    }
}
