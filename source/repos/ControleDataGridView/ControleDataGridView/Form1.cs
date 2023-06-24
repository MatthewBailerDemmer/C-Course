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

namespace ControleDataGridView
{
    public partial class Form1 : Form
    {
        string stringDeConexao = "Data Source=MATHEWS\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True";
        SqlConnection con = null;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringDeComando = "SELECT Id,Nome FROM Cadastro";
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            string stringDeComando = "SELECT Id,Nome FROM Cadastro";
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;

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
