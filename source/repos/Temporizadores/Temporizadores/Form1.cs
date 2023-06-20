using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizadores
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerPorCodigo;
        public Form1()
        {
            InitializeComponent();
            timerPorCodigo = new System.Windows.Forms.Timer();
            timerPorCodigo.Enabled = false;
            timerPorCodigo.Interval = 5000;
            timerPorCodigo.Tick += TimerPorCodigo_Tick;
        }

        private void TimerPorCodigo_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer por código: " + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void BotaoHabilitar_Click(object sender, EventArgs e)
        {
            TimerInterfaceGrafica.Enabled = true;
        }

        private void BotaoDesabilitar_Click(object sender, EventArgs e)
        {
            TimerInterfaceGrafica.Enabled = false;
        }

        private void TimerInterfaceGrafica_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer por interface: " + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void botaoHabilitaCodigo_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = true;
        }

        private void desabilitaPorCodigo_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = false;
        }
    }
}
