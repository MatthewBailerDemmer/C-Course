using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoTab1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void BotaoTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void BotaoMudaFundoTab1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].BackColor = Color.Yellow;
        }
    }
}
