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

namespace TextBllock_Label
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

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.FontSize = 20;
            label1.Background = new SolidColorBrush(Colors.Red);
        }

        private void label1_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.FontSize = 10;
            label1.Background = new SolidColorBrush(Colors.White);
        }
    }
}
