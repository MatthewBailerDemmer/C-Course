using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoDragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            textBox1.BackColor = Color.Red;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] arquivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = arquivos[0];
            textBox1.BackColor = Color.White;
        }

        private void textBox1_DragLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
        }
    }
}
