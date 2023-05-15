using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxeReadTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoInverte_Click(object sender, EventArgs e)
        {
            string textbox = meuTextBox.Text;
            string richtextbox = meuRichTextBox.Text;

            meuTextBox.Text = richtextbox;
            meuRichTextBox.Text = textbox;
        }
    }
}
