using CadastroBiblioteca;
using CadastroBibliteca;
using System.Windows.Forms;

namespace WProjeto11
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;
        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNomeCompleto.Text, textNumeroDocumento1.Text, Convert.ToDateTime(textBoxDataDeNascimento.Text),
                textBoxNomeDaRua.Text, Convert.ToUInt32(textBoxNumeroCasa.Text));
            baseDeDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show("Usu�rio cadastroado com sucesso", "Cadastro conclu�do");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisaPessoaPorDoc(textBox6.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNome.Text = listaPessoas[0].Nome;
                labelNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelRua.Text = listaPessoas[0].NomeDaRua;
                labelCasa.Text = Convert.ToString(listaPessoas[0].NumeroDaCasa);
            }
            else
            {
                MessageBox.Show("Usu�rio N�o localizado", "Exce��o");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemovePessoaPorDoc(textBox6.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNome.Text = listaPessoas[0].Nome;
                labelNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelRua.Text = listaPessoas[0].NomeDaRua;
                labelCasa.Text = Convert.ToString(listaPessoas[0].NumeroDaCasa);
                MessageBox.Show("Usu�rio exclu�do com sucesso", "Sucesso");
            }
            else
            {
                MessageBox.Show("Usu�rio N�o localizado", "Exce��o");
            }
        }
    }
}