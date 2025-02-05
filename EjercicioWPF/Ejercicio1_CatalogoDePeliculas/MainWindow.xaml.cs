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

namespace Ejercicio1_CatalogoDePeliculas
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

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            
            string pelicula = txtPelicula.Text;
            if (!cbPeliculas.Items.Contains(pelicula)) cbPeliculas.Items.Add(pelicula);
            else MessageBox.Show("La pelicula ya existe.");
        }

        private void cbPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPeliculas.SelectedItem != null) MessageBox.Show($"Pelicula Seleccionada: {cbPeliculas.SelectedValue}");
        }
    }
}
