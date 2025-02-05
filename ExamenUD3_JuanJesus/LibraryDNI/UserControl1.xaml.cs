using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LibraryDNI
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private List<string> letras = new List<string>() { 
            "T","R","W","A","G","M","Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E"
        };

        public string DNI => txtDNI.Text + letras[cbLetras.SelectedIndex];

        public UserControl1()
        {
            InitializeComponent();
            cbLetras.ItemsSource = letras;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtDNI.Text, @"\d{8}"))
            {
                int num = int.Parse(txtDNI.Text);
                cbLetras.SelectedIndex = num % 23;
            }
            else {
                MessageBox.Show("DNI no válido, use solamente 8 dígitos. \n Ej: 12345678", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cbLetras_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtDNI.Text, @"\d{8}"))
            {
                int num = int.Parse(txtDNI.Text);
                if (cbLetras.SelectedIndex != num % 23)
                {

                    cbLetras.SelectedIndex = num % 23;
                }
            }
            else {
                cbLetras.SelectedIndex = -1;
                txtDNI.Clear();
            }
        }
    }
}
