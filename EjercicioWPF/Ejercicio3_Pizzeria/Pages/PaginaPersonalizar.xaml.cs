using System.Windows;
using System.Windows.Controls;

namespace Ejercicio3_Pizzeria.Pages
{
    public partial class PaginaPersonalizar : Page
    {
        private static PaginaPersonalizar instance;
        public static PaginaPersonalizar Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaginaPersonalizar();
                }
                return instance;
            }
        }

        private string tipoPizza;
        private int cantidadPizza;

        private PaginaPersonalizar()
        {
            InitializeComponent();
        }

        public void SetPizzaOptions(string tipo, int cantidad)
        {
            tipoPizza = tipo;
            cantidadPizza = cantidad;

            // Mensaje de confirmación (o podrías actualizar controles en la UI)
            MessageBox.Show($"Tipo de Pizza: {tipoPizza}\nCantidad: {cantidadPizza}", "Detalles del Pedido");
        }

        private void btnVolverInicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.framePrincipal.GoBack();
        }
    }
}
