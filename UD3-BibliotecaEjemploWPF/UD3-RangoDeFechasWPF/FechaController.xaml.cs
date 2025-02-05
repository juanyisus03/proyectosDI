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

namespace UD3_RangoDeFechasWPF
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class FechaController : UserControl
    {
        public FechaController()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {


            if (dpFechaIni.SelectedDate.HasValue) {
                DateTime dt = dpFechaIni.SelectedDate.Value.AddDays(1);
                dpFechaFin.SelectedDate = dt;
                
            }

            if (dpFechaIni.SelectedDate.HasValue && dpFechaFin.SelectedDate.HasValue)
            {

                if (dpFechaIni.SelectedDate.Value < dpFechaFin.SelectedDate.Value)
                {
                    lbComprobarFecha.Content = "Fechas Correctas";
                }
                else {
                    lbComprobarFecha.Content = "Fechas Incorrectas";
                }

            }
            else {

                lbComprobarFecha.Content = "Debes seleccionar ambas fechas";
            }

        }
    }
}
