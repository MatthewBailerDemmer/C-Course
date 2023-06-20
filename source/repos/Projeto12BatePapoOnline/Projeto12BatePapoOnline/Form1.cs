using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Projeto12BatePapoOnline
{
    public partial class Form1 : Form
    {
        TcpListener  tcpListener;
        TcpClient  tcpClient;
        Thread servidorThread;
        bool podePararThreadServidor;

        public Form1()
        {
            InitializeComponent();
            tcpListener = null;
            tcpClient = null;
            servidorThread = null;
            podePararThreadServidor = false;

        }

        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar o cliente para se conectar em algum servidor de outra aplicação
                TcpClient tcpClient = new TcpClient(textBoxIpDoContato.Text, Convert.ToInt32(textBoxPortaDoContato.Text));
                NetworkStream ns = tcpClient.GetStream(); // abrindo o canal de comunicação

                //Enviando mensagem
                string mensagem = textBoxMeuNome.Text + ": " + richTextBoxMensagensParaEnviar.Text;
                byte[] mensagemBytes = Encoding.ASCII.GetBytes(mensagem);
                ns.Write(mensagemBytes, 0 , mensagemBytes.Length);

                //Fechando conexão
                tcpClient.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAplicarConfigServidor_Click(object sender, EventArgs e)
        {
            PararServidor();

            servidorThread = new Thread(() =>
            {
                tcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(textBoxPortaDoSerivdor.Text));
                tcpListener.Start();

                do
                {
                    try
                    {
                        tcpClient = tcpListener.AcceptTcpClient();
                        NetworkStream ns = tcpClient.GetStream();

                        //Lendo mensagem do cliente
                        byte[] bufferMensagemRecebida = new byte[255];
                        int bytesRecebidos = ns.Read(bufferMensagemRecebida, 0, bufferMensagemRecebida.Length);
                        string mensagemRecebidaStr = Encoding.ASCII.GetString(bufferMensagemRecebida, 0, bytesRecebidos);

                        AtualizaRichTextBox("\r\n " + mensagemRecebidaStr);

                    }
                    catch(SocketException ex) //Quando utilizamos o tcpListener.Stop(); essa exceção é gerada
                    {
                       if((SocketError)ex.ErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } while (podePararThreadServidor == false);
            });
            servidorThread.Start();
        }

        public void AtualizaRichTextBox(string pMensagem)
        {
            if(richTextBoxMensagens.InvokeRequired) 
            {
                richTextBoxMensagens.Invoke((MethodInvoker)(() => AtualizaRichTextBox(pMensagem)));
            }
            else
            {
                richTextBoxMensagens.Text += pMensagem;
            }
        }

        public void PararServidor()
        {
            try
            {
                podePararThreadServidor = true;
                if(tcpListener != null)
                {
                    tcpListener.Stop();
                    tcpListener = null;
                }
                if(tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
                if(servidorThread != null)
                {
                    servidorThread.Join(); //aguarda a thread  ser finalizada
                }

                podePararThreadServidor = false;
            }
            catch(Exception e)
            {

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            PararServidor();
        }
    }
}
