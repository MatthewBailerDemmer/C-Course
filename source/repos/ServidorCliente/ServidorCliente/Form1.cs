using ServidorCliente.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorCliente
{
    public partial class Form1 : Form
    {
        ContratoServidorClient contratoServidorClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            textPegaString.Text = contratoServidorClient.PegaStringDoServidor();
            contratoServidorClient.Close(); 
        }

        private void buttonEnviaString_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            contratoServidorClient.EnviaStringProServidor(textEnviaString.Text);
            contratoServidorClient.Close();
        }
    }
}
