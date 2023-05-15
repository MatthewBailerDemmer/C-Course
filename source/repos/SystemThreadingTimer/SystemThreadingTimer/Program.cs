using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SystemThreadingTimer
{
    internal class Program
    {
        //Método executado pelo timer
        static void TimerTick(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
        static void Main(string[] args)
        {
            TimerCallback tbcb = new TimerCallback(TimerTick);
            Timer meuTimer = new Timer(tbcb, null, 0, 1000); //Função callback recebendo como parametro a função a ser executada
                                                             //, objeto parametro da função de evento,
                                                             //tempo de espera a mais, tempo padrão timer

            Console.WriteLine("Pressione qualquer teclar para sair");
            Console.ReadKey();

            meuTimer.Dispose();

        }
    }
}
