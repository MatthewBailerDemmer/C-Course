using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metodos_Async_e_Await
{
    internal class Program
    {
        public static string CompraBolo(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " comprou o bolo, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " voltou para casa, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Abacaxi";
        }

        public static string CompraBexiga(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " comprou a bexiga, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " voltou para casa, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Amarela";
        }
        //------------------------------------------------------------------------------------------
        public static async Task<string> CompraBoloAsync(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " comprou o bolo, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " voltou para casa, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Abacaxi";
        }

        public static async Task<string> CompraBexigaAsync(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " comprou a bexiga, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " voltou para casa, a hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Amarela";
        }

        public static async void FazFesta() // foi necessário criar um novo método para capturar os valores
                                            // das task<string> async pois um await só pode ser declarado em um métdod async
        {
            Task<string> compraBoloTask = CompraBoloAsync("Juliana");
            Task<string> compraBexigaTask = CompraBexigaAsync("Pedro");

            string sabor = await compraBoloTask;
            string cor = await compraBexigaTask;

            Console.WriteLine("O sabor do bolo é: " + sabor);
            Console.WriteLine("A cor da bexiga é: " + cor);
        }
        static void Main(string[] args)
        {
            //string sabor = CompraBolo("Juliana");
            //string cor = CompraBexiga("Pedro");

            FazFesta();

            Console.ReadKey();
        }
    }
}
