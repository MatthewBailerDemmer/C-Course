using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_OpenFIleDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog janelaDeArquivos = new OpenFileDialog();
            if (janelaDeArquivos.ShowDialog() == DialogResult.OK)
            {
                string localDoArquivo = janelaDeArquivos.FileName;
                MessageBox.Show(localDoArquivo);
            }
           
        }
    }
}
