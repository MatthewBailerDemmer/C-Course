using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbridorDePastas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("O diretório selecionado foi: " + caminhoDaPasta);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = dialog.SelectedPath;
                MessageBox.Show("O diretório selecionado foi: " + caminhoDaPasta);
            }
        }
    }
}
