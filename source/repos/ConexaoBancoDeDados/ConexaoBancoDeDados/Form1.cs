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
using System.Linq.Expressions;

namespace ConexaoBancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCriarTabela_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Cadastro (Id int, Nome nchar(64))";
            SqlConnection  con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
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

        private void buttonDeletarTabela_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "DROP TABLE Cadastro";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
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

        private void buttonInserirItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "INSERT INTO Cadastro (Id, Nome) VALUES (1, 'Marcia')";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
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

        private void buttonApagarItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "DELETE FROM Cadastro WHERE Nome='Marcia'";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
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

        private void buttonAutalizaItem_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "UPDATE Cadastro SET Nome='Marcia Silva' WHERE Nome='Marcia'";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
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

        private void buttonPegaItens_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "SELECT Id, Nome FROM Cadastro";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string coluna0 = row.ItemArray[0].ToString(); // ItemArray = coluna
                    string coluna1 = row.ItemArray[1].ToString();

                    MessageBox.Show(coluna0 + " - " + coluna1);
                }
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

        private void buttonVariaveis_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
            string stringDeComando = "UPDATE Cadastro SET Nome=@Var1 WHERE Nome='Marcia'";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@Var1", "Joana Maria");
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
