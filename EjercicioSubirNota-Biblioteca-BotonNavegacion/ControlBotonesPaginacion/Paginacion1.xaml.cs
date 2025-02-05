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
        private int total = 10;
        
        public event EventHandler CurrentPageChanged;

        private int _current = 1;

        
        public int Current
        {
            get => _current;
            private set
            {
                if (value >= 1 && value <= total)
                {
                    _current = value;
                    CurrentPageChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Paginacion1()
        {
            InitializeComponent();
            Current = 1;
            total = 10;
            comprobarVisibilidadBotones();
        }

        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            Current = 1;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            Current--;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Current++;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }


        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            Current = total;
            comprobarVisibilidadBotones();
            cambiarLabel();
        }

        private void cambiarLabel()
        {
            lbPaginacion.Content = "Pagina " + Current + " de " + total;
            CurrentPageChanged?.Invoke(this, EventArgs.Empty);
        }

        private void comprobarVisibilidadBotones()
        {
            btnPrimero.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnUltimo.IsEnabled = true;

            if (Current == 1)
            {
                btnPrimero.IsEnabled = false;
                btnAnterior.IsEnabled = false;
            }
            else if (Current == total)
            {
                btnSiguiente.IsEnabled = false;
                btnUltimo.IsEnabled = false;
            }
        }

    }
    
}
