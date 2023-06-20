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

namespace PasswordBoxControle
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

        private void passwordBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(passwordBox.Password);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            textBox.Visibility = Visibility.Visible;
            textBox.Text = passwordBox.Password;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible; 
            textBox.Visibility = Visibility.Collapsed;
            textBox.Text = "";
        }
    }
}
