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
using System.Threading;
using System.Reflection;
using System.Windows.Threading;

namespace BotaoWPF
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicaram no botão");
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            button1.Margin = new Thickness(4, 4, 4, 4);
            button1.Content = "Mouse sobre o botão";
            button1.FontSize = 16;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            button1.Margin = new Thickness(30, 30, 30, 30);
            button1.Content = "Mouse deixou o botão";
            button1.FontSize = 12;
            
           
        }
    }
}
