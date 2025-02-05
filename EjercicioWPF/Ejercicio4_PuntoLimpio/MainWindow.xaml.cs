using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace Ejercicio4_PuntoLimpio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Residuo> Residuos;


        public MainWindow()
        {

            InitializeComponent();
            
            Residuos = new ObservableCollection<Residuo>() {
                new Residuo{
                    Cantidad = 200,
                    Nombre = "Escombro",
                    Tipo = "Obra"
                },
                new Residuo{
                    Cantidad = 50,
                    Nombre = "Pilas",
                    Tipo = "Peligrosos"
                }
            };

            Residuos.CollectionChanged += cambiarTotal;
            lvResiduos.ItemsSource = Residuos;

            cambiarTotal();
            
        }

        private void cambiarTotal(object sender, NotifyCollectionChangedEventArgs e)
        {
            cambiarTotal();
        }

        private void cambiarTotal()
        {
            int cont = 0;
            foreach (var item in Residuos)
            {
                cont += item.Cantidad;
            }
            lbTotalResiduos.Content = cont;
        }

        private void ButtonAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTipo.Text) || !int.TryParse(txtCantidad.Text, out int numero))
            {

                MessageBox.Show("Por favor, rellene todos los campos con valores validos","Error",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            else
            {
                Residuo residuo = new Residuo()
                {
                    Nombre = txtNombre.Text,
                    Tipo = txtTipo.Text,
                    Cantidad = int.Parse(txtCantidad.Text)
                };



                Residuos.Add(residuo);

                txtTipo.Clear();
                txtNombre.Clear();
                txtCantidad.Clear();
            }

        }
        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lvResiduos.Items.Count > 0 && lvResiduos.SelectedItem != null)
            {
                Residuo residuo = (Residuo) lvResiduos.SelectedItem;
                Residuos.Remove(residuo);
            }
        }
    }
}
