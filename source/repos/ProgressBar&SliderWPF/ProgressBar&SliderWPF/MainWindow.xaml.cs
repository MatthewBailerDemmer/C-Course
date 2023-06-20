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

namespace ProgressBar_SliderWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool inverte = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            progressBar.Value = inverte ? 100 - slider.Value : slider.Value;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            inverte = !inverte;
            button.Content = inverte ? "Endireita" : "Inverte"; 
        }
    }
}
