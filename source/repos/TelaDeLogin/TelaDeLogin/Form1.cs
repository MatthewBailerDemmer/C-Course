using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            if (botaoLogin.Text == "Login")
            {
                if (textBoxUsuario.Text == "")
                    MessageBox.Show("Digite o nome do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (textBoxUsuario.Text == "Marcelo")
                    {
                        if (maskedTextBoxSenha.Text == "")
                            MessageBox.Show("Digite a senha do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (maskedTextBoxSenha.Text == "1234")
                            {
                                MessageBox.Show("Usuário logado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                label1.Text = "Logado!";
                                label1.ForeColor = Color.Green;
                                textBoxUsuario.Text = "";
                                maskedTextBoxSenha.Text = "";
                                botaoLogin.Text = "Logout";
                            }
                            else
                                MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Usuário incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                label1.Text = "Login";
                label1.ForeColor = Color.Black;
                botaoLogin.Text = "Login";
            }
        }
    }
}
