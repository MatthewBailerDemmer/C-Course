using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client_Socket_UDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("10.0.0.154"), 80);
            udpClient.Connect(endpoint);

            //Enviando dados para o servidor
            byte[] bufferEnviaDados = Encoding.ASCII.GetBytes("Ola do cliente UDP!");
            udpClient.Send(bufferEnviaDados, bufferEnviaDados.Length);

            //Recebendo dados do servidor
            byte[] bufferDadosRecebidos = new byte[256];
            bufferDadosRecebidos = udpClient.Receive(ref endpoint);
            Console.WriteLine("Dados recebidos do servidor: " + Encoding.ASCII.GetString(bufferDadosRecebidos, 0 , bufferDadosRecebidos.Length));

            //fechando conexão
            udpClient.Close();

            Console.ReadKey();

        }
    }
}
