using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void buttonApagaTabela_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "DROP TABLE Cadastro";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
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
                {
                    con.Close();
                }
            }
        }

        private void buttonAdicionaItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "INSERT INTO Cadastro(Id, Nome, Telefone, Idade) VALUES(1, 'joao', 123456789, 23)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
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
                {
                    con.Close();
                }
            }
        }

        private void buttonApagaItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "DELETE FROM Cadastro WHERE Nome = 'Joao'";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
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
                {
                    con.Close();
                }
            }
        }

        private void buttonAtualizaItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "UPDATE Cadastro SET Nome = 'Joao da Silva' WHERE Nome = 'Joao' ";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
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
                {
                    con.Close();
                }
            }
        }

        private void buttonSelectItem1_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "SELECT Nome, Telefone FROM Cadastro";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);

                string conteudo_Nome = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                string conteudo_Telefone = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void buttonVariaveis_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C-Course\\source\\repos\\BancoDeDadosLocalProgramatico\\BancoDeDadosLocalProgramatico\\MeuBancoDeDados.mdf;Integrated Security=True";
            string stringDoComando = "UPDATE Cadastro SET Nome=@Var1 WHERE Nome = 'Joao da Silva'";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@Var1", "Marcelo Pereira");
                adapter.Fill(ds);

                string conteudo_Nome = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                string conteudo_Telefone = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
