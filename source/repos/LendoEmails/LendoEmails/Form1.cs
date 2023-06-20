using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.Text;

namespace LendoEmails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLerEmail_Click(object sender, EventArgs e)
        {
            Pop3Client cliente = new Pop3Client();
            cliente.Connect("outlook.office.com", 995, true);
            cliente.Authenticate("mathBailer@outlook.com", "matheusbd1999outlook");
            int contadorDeMensagens = cliente.GetMessageCount();
            OpenPop.Mime.Message mensagemEmail = cliente.GetMessage(contadorDeMensagens);
            string mensagemStr;
            if(mensagemEmail.MessagePart.IsMultiPart) // algumas mensagens possuem uma parte HTML
            {
                // recebemos a mensagem por meio de um array de bytes, o indice 0 se referencia ao texto do email
                mensagemStr = Encoding.UTF8.GetString(mensagemEmail.MessagePart.MessageParts[0].Body);
            }
            else
            {
                mensagemStr = Encoding.UTF8.GetString(mensagemEmail.MessagePart.Body);
            }

            cliente.Disconnect(); // devemos sempre desconectar do servidor ao ler uma mensagem
            MessageBox.Show(mensagemEmail.Headers.Subject + "\r\n" +
                            mensagemStr + "\r\n" +
                            mensagemEmail.Headers.From.Address);
        }

        private void buttonApagaEmail_Click(object sender, EventArgs e)
        {
            Pop3Client cliente = new Pop3Client();
            cliente.Connect("outlook.office.com", 995, true);
            cliente.Authenticate("mathBailer@outlook.com", "matheusbd1999outlook");
            int contadorDeMensagens = cliente.GetMessageCount();
            cliente.DeleteMessage(contadorDeMensagens);
            cliente.Disconnect();
        }

        private void buttonApagaTodos_Click(object sender, EventArgs e)
        {
            Pop3Client cliente = new Pop3Client();
            cliente.Connect("outlook.office.com", 995, true);
            cliente.Authenticate("mathBailer@outlook.com", "matheusbd1999outlook");
            int contadorDeMensagens = cliente.GetMessageCount();
            cliente.DeleteAllMessages();
            cliente.Disconnect();
        }
    }
}
