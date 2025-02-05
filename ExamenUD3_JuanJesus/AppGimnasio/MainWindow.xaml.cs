using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace AppGimnasio
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (controlDNI.DNI != null && controlMembresia.fechaInicio != null && controlMembresia.tipoMembresia != null) {

                DateTime fechaInicio = (DateTime) controlMembresia.fechaInicio;
                
                MessageBox.Show($"Dni: {controlDNI.DNI} \n" +
                    $"Tipo de Membresia: {controlMembresia.tipoMembresia} \n" +
                    $"Fecha de Inicio de la Membresia: {fechaInicio.ToString("dd/MM/yyyy")}", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los datos del formulario.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
