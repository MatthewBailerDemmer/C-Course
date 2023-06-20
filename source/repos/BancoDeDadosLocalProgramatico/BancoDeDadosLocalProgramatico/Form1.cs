using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDadosLocalProgramatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCriarTabela_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "CREATE TABLE Cadastro (Id int, Nome nchar(64), Telefone nchar(9), Idade int)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
    }
}
