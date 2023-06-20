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
using Microsoft.Win32;

namespace OpenfileDialogWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.InitialDirectory = @"d:\";
            diag.Filter = "Todos os arquivos|*.*|Arquivos txt|*.txt|Arquivos pfd|*.pdf";
            if(diag.ShowDialog() == true)
            {
                string caminhoArquivo = diag.FileName;
                MessageBox.Show(caminhoArquivo);
            }
        }
    }
}
