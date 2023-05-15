using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Para números nós usamos os caracteres # ou 0
            //Se usarmos o # o número é opcional
            //Se usarmos o 0 o número é obrigatório

            maskedTextBoxNumeros.Mask = "##0000";

            //Para letras usamos os caracteres L ou  ?
            // L a letra é obrigatória, ? a letra é opcional

            maskedTextBoxLetras.Mask = "LLLLLLL";

            // Para datas
            maskedTextBoxData.Mask = "00/00/0000";

            //Para placasa de carro
            maskedTextBoxPlacaDeCarro.Mask = "LLL - 0000";

            //Para horas
            maskedTextBoxHora.Mask = "00:00:00";

            //Para números decimais, o marcador de decimal é o ponto
            maskedTextBoxDecimais.Mask = "00.00000";

            //Para senhas
            maskedTextBoxSenha.Mask = "0000";
            maskedTextBoxSenha.PasswordChar = '*';

            //Para celular
            //Para  fazer o caractere da mascara se transformar em literal
            // nós utilizamos \\, utilizamos isso para forçar caracteres
            maskedTextBoxCelular.Mask = "(\\000) \\90000 - 0000";
        }

        private void botaoVerifica_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumeros.MaskCompleted)
                MessageBox.Show("O usuário digitou todos os números obrigatórios");
            else
                MessageBox.Show("O usuário não digitou todos os números obrigatórios" + maskedTextBoxNumeros.Text);
        }
    }
}
