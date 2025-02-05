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

namespace EjemploEncuesta
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

        private void imgSalir_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnInforme_Click(object sender, RoutedEventArgs e)
        {
            //Creamos una variable para guardar el mensaje
            string informe = "Informe de la encuesta: ";

            foreach (var control in Panel1.Children)
            {
                if (control is RadioButton radioButton && radioButton.IsChecked == true) {
                    informe += "\n Sistema Operativo: " + radioButton.Content;
                }
            }

            foreach (var control in Panel2.Children)
            {
                if (control is CheckBox checkBox && checkBox.IsChecked == true)
                {
                    informe += "\n Especialidad: " + checkBox.Content;
                }
            }

            informe += "\n Numero de horas: " + txtHoras.Text;

            MessageBox.Show(informe, "Estadisticas de la encuesta");
        }
    }
}
