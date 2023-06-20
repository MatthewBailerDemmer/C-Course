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

namespace ComboBox_listBoxWPF
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

        private void meuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ComboBoxItem)meuComboBox.SelectedItem).Content.ToString());

        }

        private void Botao1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Você clicou no primeiro botão");
        }

        private void Botao2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Você clicou no segundo botão");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ListBoxItem)meuListBox.SelectedItem).Content.ToString());
        }
    }
}
