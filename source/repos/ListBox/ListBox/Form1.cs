using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Inseto"))
                listBox1.Items.Remove("Inseto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains("Inseto"))
            listBox1.Items.Add("Inseto");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                MessageBox.Show("O usuário selecionou a opção " +listBox1.SelectedItem.ToString());
        }
    }
}
