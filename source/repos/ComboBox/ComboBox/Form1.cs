using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("O usuário selecionou a opção: " + comboBox2.SelectedItem.ToString(), "Animal selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
