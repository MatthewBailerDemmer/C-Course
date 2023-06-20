using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterandoControlesAPartirDeThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(AlteraProgressBar));
            td.Start();
        }

        public void AlteraProgressBar()
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke((MethodInvoker)(() => AlteraProgressBar()));
            }
            else
            {
                for (int i = 0; i < progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(10);
                }
            }
        }
    }
}
