using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace RadioButton_CheckBoxWPF
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

        private void RadioButton11_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton11 selecionado");
        }

        private void RadioButton12_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton12 selecionado");
        }

        private void RadioButton13_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton13 selecionado");
        }

        private void RadioButton14_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton14 selecionado");
        }

        private void RadioButton11_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton11 desmarcado");
        }

        private void RadioButton12_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton12 desmarcado");
        }

        private void RadioButton13_Unloaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton13 desmarcado");
        }

        private void RadioButton13_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton13 desmarcado");

        }

        private void RadioButton14_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton14 desmarcado");
        }

        private void botaoGrupo1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RadioButton radioButtonSelecionadoGropo1 = grid.Children.OfType<RadioButton>().Where(x => (x.IsChecked == true && x.GroupName == "group1")).First();
                MessageBox.Show(radioButtonSelecionadoGropo1.Content.ToString());
            }
            catch(System.InvalidOperationException)
            {
                MessageBox.Show("Não há radioButtons selecionados");
            }
           
        }

        private void checkbox4_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void checkbox3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkbox2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox2 marcado");
        }

        private void checkbox1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox1 marcado");
        }

        private void checkbox1_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox1 desmarcado");
        }

        private void checkbox2_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox2 desmarcado");
        }

        private void botao2_Click(object sender, RoutedEventArgs e)
        {
                IEnumerable<CheckBox> listaCheckBox = grid.Children.OfType<CheckBox>().Where(x => (x.IsChecked == true));
                string mensagem = "";
                if(!listaCheckBox.Any())
                {
                    mensagem = "Não há checkBox selecionados";
                }
                else 
                {
                    foreach (CheckBox checkbox in listaCheckBox)
                {
                    mensagem += checkbox.Content.ToString() + (checkbox == listaCheckBox.Last() ? "." : ", ");
                }
            }
               
                MessageBox.Show("Os checkBox selecionados são: " + mensagem);
        
        }
    }
}
