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

namespace Ejermplo1Clase
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Boton llamado {btnEnviar.Content}");
        }

        private void lbOpciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"Boton llamado {lbOpciones.SelectedItem}");
        }
    }
}
