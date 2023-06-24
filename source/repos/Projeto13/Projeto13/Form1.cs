using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Projeto13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\Projeto13\\Projeto13\\BaseCadastro.mdf;Integrated Security=True";
            string stringDeComando = "INSERT INTO TabelaCadastro (Nome, Documento, Nascimento, Endereco, Numero) VALUES " +
                "(@VarNome, @VarDocumento, @VarNascimento, @VarEndereco, @VarNumero)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarNome", textBoxNomeCompleto.Text);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxDocumento.Text);
                sqlCommand.Parameters.AddWithValue("@VarNascimento", textBoxDataDeNascimento.Text);
                sqlCommand.Parameters.AddWithValue("@VarEndereco", textBoxNomeDaRua.Text);
                sqlCommand.Parameters.AddWithValue("@VarNumero", textBoxNúmeroDaCasa.Text);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\Projeto13\\Projeto13\\BaseCadastro.mdf;Integrated Security=True";
            string stringDeComando = "Select Nome, Documento, Nascimento, Endereco, Numero FROM TabelaCadastro WHERE Documento = @VarDocumento";

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxPesquisaDocumento.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(dt);
                dataGridViewCadastro.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\Projeto13\\Projeto13\\BaseCadastro.mdf;Integrated Security=True";
            string stringDeComando = "DELETE FROM TabelaCadastro WHERE Documento = @VarDocumento";

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxPesquisaDocumento.Text);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    
    }
}
