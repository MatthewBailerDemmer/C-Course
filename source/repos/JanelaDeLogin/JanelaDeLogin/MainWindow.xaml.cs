using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanelaDeLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botaoMostrar_Click(object sender, RoutedEventArgs e)
        {
            passwordBoxSenha.Visibility = Visibility.Collapsed;
            textBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = passwordBoxSenha.Password;
        }

        private void botaoMostrar_MouseLeave(object sender, MouseEventArgs e)
        {
            textBoxSenha.Visibility = Visibility.Collapsed;
            passwordBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = "";
        }

        private void botaoLogin_Click(object sender, RoutedEventArgs e)
        {
            if (botaoLogin.Content.ToString() == "Entrar")
            {
                if (textBoxUsuario.Text == "Maria")
                {
                    if (passwordBoxSenha.Password == "1234")
                    {
                        //Usuário logado no sistema
                        MessageBox.Show("Usuário Logado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                        botaoLogin.Content = "Sair";
                        botaoLogin.Background = new SolidColorBrush(Colors.Green);
                        passwordBoxSenha.Password = "";
                        MeuPrograma meuPrograma = new MeuPrograma();
                        meuPrograma.Show();
                    }
                    else
                    {
                        //Senha está incorreta
                        MessageBox.Show("Senha Incorreta!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    //Usuário está incorreto
                    MessageBox.Show("Usuário Incorreta!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                botaoLogin.Content = "Entrar";
                botaoLogin.Background = new SolidColorBrush(Color.FromArgb(221, 221, 221, 221));
            }
        }
    }
}
