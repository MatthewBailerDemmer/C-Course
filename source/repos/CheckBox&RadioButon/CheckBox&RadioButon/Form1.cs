using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_RadioButon
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                MessageBox.Show("CheckBox 1 selecionado", "CheckBox Selecionado");
            else
                MessageBox.Show("CheckBox 1 não selecionado", "CheckBox Selecionado");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                MessageBox.Show("CheckBox 2 selecionado", "CheckBox Selecionado");
            else
                MessageBox.Show("CheckBox 2 não selecionado", "CheckBox Selecionado");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                MessageBox.Show("CheckBox 3 selecionado", "CheckBox Selecionado");
            else
                MessageBox.Show("CheckBox 3 não selecionado", "CheckBox Selecionado");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "radioButton1 selecionado";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "radioButton2 selecionado";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "radioButton3 selecionado";
        }

        private void BotaoAplicar_Click(object sender, EventArgs e)
        {
            List <RadioButton> listRadioButton = groupBox1.Controls.OfType<RadioButton>().ToList();
            foreach(RadioButton radioButton in listRadioButton)
            {
                if (radioButton.Checked)
                    MessageBox.Show("RadioButton selecionado: " + radioButton.Text, "RadioButton Selecionado");
               
            }
        }
    }
}
