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

namespace EjemploFrame.Pages
{
    /// <summary>
    /// Lógica de interacción para PaginaPedidos.xaml
    /// </summary>
    public partial class PaginaPedidos : Page
    {
        MainWindow main;
        public PaginaPedidos(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            main.FramePrincipal.GoBack();
            main.FramePrincipal.RemoveBackEntry();
        }
    }
}
