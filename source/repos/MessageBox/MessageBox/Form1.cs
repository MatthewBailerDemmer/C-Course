using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoMessageBox_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Eu sou um MessageBox", "Meu primeiro messageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                MessageBox.Show("Usuario clicou em OK", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                MessageBox.Show("Usuario clicou em cancelar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
