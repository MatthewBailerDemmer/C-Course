using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBrowserDialog
{
    //Só conseguimos selecionar pastas
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("O diretório selecionado foi: " + caminhoDaPasta);
            }
        }
    }
}
