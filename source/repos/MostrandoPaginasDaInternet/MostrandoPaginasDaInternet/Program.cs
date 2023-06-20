using System;
using System.Text;
using System.Net;


namespace MostrandoPaginasDaInternet
{
    internal class Program
    {
        public static string dadosMinhaPrimeiraPagina =
            "<!DOCTYPE html>"+
            "<html>" +
                "<head>"+
                    "<title>C# completo</title>"+
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>"+
                    "<h1>Olá, essa é a minha primeira página do meu próprio servidor web</h1>" +
                    "<h2>Esse é o melhor curos de C# do mundo, nenhum outro curso ensina tanta coisa</h2>"+
                "</body>"+
           "</html>";

        public static string dadosPaginaDesconhecida =
             "< !DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title>C# completo</title>" +
                    "< meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<h1>Página inválida</h1>" +
                    "<h2>Essa página não existe no servidor</h2>" +
                "</body>" +
           "</html>";
        static void Main(string[] args)
        {
            //string url = "http://localhost:80/";
            string url = "http://*:80/";
            byte[] dados;
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Console.WriteLine("Iniciando servidor WEB");
            Console.WriteLine("URL " + url);

            bool deveContinuarExecutando = true;
            //O certo era colocar esse while em uma thread
            while(deveContinuarExecutando)
            {
                //Aguardando conexões
                Console.WriteLine("Aguardando por conexões:");
                HttpListenerContext conexao = httpListener.GetContext();
                Console.WriteLine("Conexão estabelecida");

                //Conexão Estabelecida
                HttpListenerRequest req = conexao.Request;
                HttpListenerResponse rep = conexao.Response;

                if(req.HttpMethod  == "GET")
                {
                    switch(req.Url.AbsolutePath)
                    {
                        case "/favicon.ico":
                            dados = new byte[0];
                            break;
                        case "/minhaPrimeiraPagina":
                            dados = Encoding.UTF8.GetBytes(dadosMinhaPrimeiraPagina);
                            break;
                        default:
                            dados = Encoding.UTF8.GetBytes(dadosPaginaDesconhecida);
                            break;
                    }
                }
                else
                {
                    dados = Encoding.UTF8.GetBytes(dadosPaginaDesconhecida);
                }
                
                //Preenchendo a resposta
                rep.ContentType = "text/html";
                rep.ContentEncoding = Encoding.UTF8;
                rep.ContentLength64 = dados.LongLength;

                //Enviar a resposta de volta
                rep.OutputStream.WriteAsync(dados, 0, dados.Length);
                rep.Close();

            }
            httpListener.Close();
        }
    }
}
