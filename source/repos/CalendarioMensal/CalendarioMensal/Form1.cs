using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioMensal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataInicial = monthCalendar1.SelectionStart;
            DateTime dataFinal = monthCalendar1.SelectionEnd;
            MessageBox.Show("A primeira data é: " + dataInicial.ToString("dd/MM/yyyy") + "\r\n" +
                "A data final é: " + dataFinal.ToString("dd/MM/yyyy"));
        }
    }
}
