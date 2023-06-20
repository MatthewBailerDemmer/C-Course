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
            janelaDeArquivos.InitialDirectory = "D:\\";
            janelaDeArquivos.Filter = "Arquivos txt|*.txt|Arquvis jpg|*.jpg|Todos os arquivos|*.*";
            //*.* -> Todos as extensões de arquivos
            if (janelaDeArquivos.ShowDialog() == DialogResult.OK)
            {
                string localDoArquivo = janelaDeArquivos.FileName;
                MessageBox.Show(localDoArquivo);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog janelaDeArquivos = new OpenFileDialog();
            janelaDeArquivos.InitialDirectory = "D:\\";
            janelaDeArquivos.Filter = "Arquivos txt|*.txt|Arquvis jpg|*.jpg|Todos os arquivos|*.*";
            janelaDeArquivos.Multiselect = true;
            //*.* -> Todos as extensões de arquivos
            if (janelaDeArquivos.ShowDialog() == DialogResult.OK)
            {
                string[] localDosArquivos = janelaDeArquivos.FileNames;
                string result = "";
                foreach(string localDoArquivo in localDosArquivos)
                    result += localDoArquivo + " ";
                MessageBox.Show(result);
            }
        }
    }
}
