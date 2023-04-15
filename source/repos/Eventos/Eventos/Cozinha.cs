using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Cozinha
    {
        public delegate void MensagemPedidoProntoEventHandler(object fonte, EventArgsPedidoPronto e);
        public event MensagemPedidoProntoEventHandler MensagemPedidoProntoEvent;
        public void EnviaMensagemPedidoPronto(UInt32 pNumeroDoPedido)
        {
            if (MensagemPedidoProntoEvent != null)
            {
                EventArgsPedidoPronto eventArgs = new EventArgsPedidoPronto(pNumeroDoPedido);
                MensagemPedidoProntoEvent(this, eventArgs);
            }
        }
    }
}
