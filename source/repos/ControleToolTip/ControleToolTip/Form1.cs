using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleToolTip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 5000;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um toolTip botao1", button1);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um toolTip botao2", button2);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um toolTip checkBox", checkBox1);
        }
    }
}
