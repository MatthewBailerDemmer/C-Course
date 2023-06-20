using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Cliente_Socket_TCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando o cliente TCP
            TcpClient tcpClient = new TcpClient("localhost", 13);
            NetworkStream ns = tcpClient.GetStream(); // canal de comunicação entre cliente e servidor

            //Enviar dados para o servidor
            byte[] bufferEnviaProServidor = Encoding.ASCII.GetBytes("Ola, do cliente");
            ns.Write(bufferEnviaProServidor, 0, bufferEnviaProServidor.Length);

            //Recebendo dados do servidor
            byte[] bufferRecebeDoServidor = new byte[256];
            int byteLidos = ns.Read(bufferRecebeDoServidor, 0 , bufferRecebeDoServidor.Length);
            Console.WriteLine("Dados recebidos do servidor: " + Encoding.ASCII.GetString(bufferRecebeDoServidor, 0, byteLidos));

            //Finalizando comunicação
            tcpClient.Close();
            ns.Close();

            Console.ReadKey();
        }
    }
}
