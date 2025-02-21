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

namespace UD5_PUnitariaWPFGestionBebidas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> copas;

        //Hay que definir las variables públicas para poder acceder desde las pruebas unitarias
  //      public ListBox copaListBox {get; set;}
  //      public TextBlock totalCopasTextBlock { get; set; }
         


        public MainWindow()
        {
            InitializeComponent();
            copas = new List<string>();
        }

        public void AgregarCopa_Click(object sender, RoutedEventArgs e)
        {
            string nuevaCopa = copaTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(nuevaCopa))
            {
                copas.Add(nuevaCopa);
                ActualizarListaYTotal();
                copaTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre de la bebida.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void ActualizarListaYTotal()
        {
            copaListBox.Items.Clear();
            foreach (var copa in copas)
            {
                copaListBox.Items.Add(copa);
            }
            totalCopasTextBlock.Text = copas.Count.ToString();
        }

        public void EliminarCopa_Click(object sender, RoutedEventArgs e)
        {
            if (copaListBox.SelectedItem != null)
            {
               copas.Remove(copaListBox.SelectedItem.ToString());
                ActualizarListaYTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una bebida de la lista");
            }
        }

        public void copaListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEliminarCopa.IsEnabled = true;
        }

    }
}
