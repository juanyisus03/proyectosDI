using Ejercicio3_Pizzeria.Pages;
using System.Windows;

namespace Ejercicio3_Pizzeria
{
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;

      

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Navegar a la página de selección inicial solo al cargar la ventana, evitando ciclos
            framePrincipal.Navigate(PaginaSeleccionar.Instance);
        }
    }
}
