using System.Windows;
using System.Windows.Controls;

namespace Ejercicio3_Pizzeria.Pages
{
    public partial class PaginaSeleccionar : Page
    {
        private static PaginaSeleccionar instance;
        public static PaginaSeleccionar Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaginaSeleccionar();
                }
                return instance;
            }
        }

        private PaginaSeleccionar()
        {
            InitializeComponent();
        }

        private void sCantidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sCantidad.Value = (int)e.NewValue;
        }

        private void btnPasarAPersonalizar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el tipo de pizza y la cantidad seleccionada
            string tipoPizza = ((ComboBoxItem)((ComboBox)FindName("comboTipoPizza")).SelectedItem)?.Content.ToString();
            int cantidadPizza = (int)sCantidad.Value;

            // Verificación de selección
            if (string.IsNullOrEmpty(tipoPizza))
            {
                MessageBox.Show("Por favor, selecciona un tipo de pizza.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Pasar opciones de pizza a PaginaPersonalizar
            PaginaPersonalizar.Instance.SetPizzaOptions(tipoPizza, cantidadPizza);

            // Navegar a la página de personalización usando MainWindow.Instance
            MainWindow.Instance.framePrincipal.Navigate(PaginaPersonalizar.Instance);
        }
    }
}
