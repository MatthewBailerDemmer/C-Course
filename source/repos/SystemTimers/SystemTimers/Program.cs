using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SystemTimers
{
    internal class Program
    {
        // Um timer é uma funcionalidade que permite que algum método seja executado
        //após um determinado intervalo de tempo
        // Ao criar um objeto do tipo Timer passamos a ele um intervalo de tempo
        // toda a vez que acabar esse intervalo de tempo o timer gera um evento
        // esse evento como consequência executa todas as funções que foram cadastradas nele
        //Funçao para o evento do timer
        static void TimerTick(object sender, EventArgs e) // essa assinatura é padrão para funções cadastradas em um evento de timer
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += TimerTick;
            timer.Start();

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

            timer.Stop();
        }
    }
}
