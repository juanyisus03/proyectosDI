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

namespace LibraryMembresia
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {


        private List<string> tipoMembresiaList = new List<string>() { 
            "Básico", "Premium", "VIP"
        };
        public DateTime? fechaInicio => dpInicio.SelectedDate;
        public string tipoMembresia { 
            get {

                if (lvMembresia.SelectedIndex == -1)
                {
                    return null;
                }
                else {
                    return tipoMembresiaList[lvMembresia.SelectedIndex];
                }
            
            }}
        public UserControl1()
        {
            InitializeComponent();
            lvMembresia.ItemsSource = tipoMembresiaList;
        }

        private void dpInicio_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpInicio.SelectedDate > DateTime.Now) { 
                dpInicio.SelectedDate = DateTime.Now;
                MessageBox.Show("No puedes poner una fecha futura","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
