using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ControlBotonesPaginacion
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class Paginacion1 : UserControl
    {
        private int total;

        // Evento para notificar cambios de página
        public event EventHandler CurrentPageChanged;

        private int _current = 1; // Página actual
        private int _totalPages = 10; // Total de páginas (puedes configurarlo dinámicamente)

        // Propiedad pública para acceder a la página actual
        public int Current
        {
            get => _current;
            private set
            {
                if (value >= 1 && value <= _totalPages)
                {
                    _current = value;
                    // Dispara el evento cuando cambia la página
                    CurrentPageChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Paginacion1()
        {
            InitializeComponent();
            _current = 1;
            total = 10;
            comprobarVisibilidadBotones();
        }

        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            _current = 1;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            _current--;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            _current++;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }


        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            _current = total;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void cambiarLabel()
        {
            lbPaginacion.Content = "Pagina " + _current + " de " + total;
            CurrentPageChanged?.Invoke(this, EventArgs.Empty);
        }

        private void comprobarVisibilidadBotones()
        {
            btnPrimero.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnUltimo.IsEnabled = true;

            if (_current == 1)
            {
                btnPrimero.IsEnabled = false;
                btnAnterior.IsEnabled = false;
            }
            else if (_current == total)
            {
                btnSiguiente.IsEnabled = false;
                btnUltimo.IsEnabled = false;
            }
        }

    }
    
}
