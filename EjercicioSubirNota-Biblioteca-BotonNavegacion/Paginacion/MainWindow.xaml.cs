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

namespace Paginacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cambiarImagen(1);
            paginacion.CurrentPageChanged += Paginador_CurrentPageChanged;

        }

        private void Paginador_CurrentPageChanged(object sender, EventArgs e) {
            int current = paginacion.Current;            
            cambiarImagen(current);
        }

        private void cambiarImagen(int inx)
        {
            switch (inx) {
                case 1:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/aguila.png"));
                    break;
                case 2:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/animales.png"));
                    break;
                case 3:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/cerdo.png"));
                    break;
                case 4:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/conejo.png"));
                    break;
                case 5:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/elefante.png"));
                    break;
                case 6:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/erizo.png"));
                    break;
                case 7:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/iguana.png"));
                    break;
                case 8:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/leon.png"));
                    break;
                case 9:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/panda.png"));
                    break;
                case 10:
                    imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/tigre.png"));
                    break;
            }

        }
    }
}
