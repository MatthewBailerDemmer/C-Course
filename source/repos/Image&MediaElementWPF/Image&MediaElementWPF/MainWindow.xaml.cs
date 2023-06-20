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

namespace Image_MediaElementWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri enderecoImagem = new Uri(@"D:\C-Course\source\repos\Image&MediaElementWPF\helsyeah.jpg");
            BitmapImage  imagem = new BitmapImage(enderecoImagem);
            image.Source = imagem;

            mediaElement.LoadedBehavior = MediaState.Manual;
            Uri enderecoVideo = new Uri(@"D:\C-Course\source\repos\Image&MediaElementWPF\irrationalSecurity.mp4");
            mediaElement.Source = enderecoVideo;
            mediaElement.Pause();
            mediaElement.Play();
            mediaElement.Stop();
        }
    }
}
