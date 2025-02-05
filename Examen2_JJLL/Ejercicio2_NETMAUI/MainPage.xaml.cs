
using Android.App;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace Ejercicio2_NETMAUI
{
    public partial class MainPage : TabbedPage
    {

        ObservableCollection<Coche> Coches;
        public MainPage()
        {
            InitializeComponent();
            Coches = new ObservableCollection<Coche>() {

                new Coche("Ford", "ford.jpg", 20220),
                new Coche("Seat Cordoba", "seatcordoba.jpg", 34930),
                new Coche("Toyora", "toyota.jpg", 11220)

            };

            crlCoches.ItemsSource = Coches;
        }

        private void btnMostrar_Clicked(object sender, EventArgs e)
        {
            vslDatos.IsVisible = true;
            txtMostrarModelo.Text = txtModelo.Text;
            txtMostrarCombustible.Text = txtCombustible.Text;
            txtMostrarProvincia.Text = txtProvincia.Text;
        }

        private void btnOcultar_Clicked(object sender, EventArgs e)
        {
            vslDatos.IsVisible = false;

        }

        private void btnSelecionar_Clicked(object sender, EventArgs e)
        {
            Coche coche = (Coche) crlCoches.CurrentItem;

            txtSeleccionado.Text = $"El coche seleccionado es el {coche.Nombre} y cuesta {coche.Precio}€";
            
        }

        private void crlCoches_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            txtSeleccionado.Text = "";
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMensaje.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {

            }
            else { 
                txtConfirmar.Text = $"El mensaje ha sido enviado {txtNombre.Text}";
            }
        }
    }

    class Coche
    {
        public string RutaImg { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Coche(string nombre, string img, int precio)
        {

            this.Nombre = nombre;
            this.RutaImg = img;
            this.Precio = precio;
        }

        public Coche() { }

    }
}
