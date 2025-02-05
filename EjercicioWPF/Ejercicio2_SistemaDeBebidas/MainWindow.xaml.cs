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

namespace Ejercicio2_SistemaDeBebidas
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

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            foreach (String item in lbBebidas.Items)
            {
                if (item == txtBebida.Text) {
                    MessageBox.Show("Por favor, ingrese un nombre válido para la bebida");
                }
            }
            lbBebidas.Items.Add(txtBebida.Text);

            txtCantidad.Content = lbBebidas.Items.Count;
        }

        
        

        private void mainOnLoaded(object sender, RoutedEventArgs e)
        {
            txtCantidad.Content = lbBebidas.Items.Count;
            
        }

        private void lbBebidas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbBebidas.Items.Remove(lbBebidas.SelectedItem);
            btnEliminar.IsEnabled = !(lbBebidas.SelectedItem == null);

        }
    }
}
