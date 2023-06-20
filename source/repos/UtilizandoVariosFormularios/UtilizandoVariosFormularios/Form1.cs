using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizandoVariosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeuFormulario2 form2 = (MeuFormulario2) Application.OpenForms["xyz"]; 
            if(form2 == null)
            {
                form2 = new MeuFormulario2();
                form2.Name = "xyz";
                form2.Show();
            }
            else
            {
                MessageBox.Show("Formulário já aberto");
            }
           
        }
    }
}
