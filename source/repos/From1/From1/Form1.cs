using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meuBotao.BackColor = Color.Aquamarine;
        }

        private void minaLabel_Click(object sender, EventArgs e)
        {
            minhaLabel.Font = new Font("Arial", 18);
        }

        private void minaLabel_DoubleClick(object sender, EventArgs e)
        {
            minhaLabel.Font = new Font("Arial", 36);
        }

        private void minaLabel_MouseEnter(object sender, EventArgs e)
        {
            minhaLabel.Text = "Mouse sobre a Label";
        }

        private void minaLabel_MouseLeave(object sender, EventArgs e)
        {
            minhaLabel.Text = "Mouse sobre deixou a Label";
        }

        private void meuBotao_MouseEnter(object sender, EventArgs e)
        {
            meuBotao.ForeColor = Color.White;
        }

        private void meuBotao_MouseLeave(object sender, EventArgs e)
        {
            meuBotao.ForeColor = Color.Yellow;
        }
    }
}
