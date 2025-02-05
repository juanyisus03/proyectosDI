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

namespace PersistenciaWPF
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

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text)) 
            {

                Properties.Settings.Default.NombreAlumno = txtNombre.Text;
                Properties.Settings.Default.BecaAlumno = (bool) chkBeca.IsChecked;
                Properties.Settings.Default.Estudios = cbEstudios.SelectedIndex;
                Properties.Settings.Default.Save();
                MessageBox.Show("Datos guardados correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

                txtNombre.Clear();
                chkBeca.IsChecked = false;
                cbEstudios.SelectedIndex = -1;
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debes añadir un nombre", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = Properties.Settings.Default.NombreAlumno;
            chkBeca.IsChecked = Properties.Settings.Default.BecaAlumno;
            cbEstudios.SelectedIndex = Properties.Settings.Default.Estudios;
        }
    }
}
