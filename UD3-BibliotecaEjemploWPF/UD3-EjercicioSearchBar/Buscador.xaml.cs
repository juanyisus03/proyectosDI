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

namespace UD3_EjercicioSearchBar
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class Buscador : UserControl
    {
        public string TextoBusqueda => txtBuscador.Text;
        public Buscador()
        {
            InitializeComponent();
        }

        private void txtBuscador_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnBorrar.Visibility = (string.IsNullOrEmpty(txtBuscador.Text)) ? Visibility.Hidden : Visibility.Visible;
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txtBuscador.Text = "";
        }
    }
}
