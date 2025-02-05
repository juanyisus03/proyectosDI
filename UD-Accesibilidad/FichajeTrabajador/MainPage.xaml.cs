namespace FichajeTrabajador
{
    public partial class MainPage : ContentPage
    {
        public bool estado = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEntrada_Clicked(object sender, EventArgs e)
        {
            if (estado)
            {
                DisplayAlert("Advertencia", "Ya estas dentro", "Ops");
                return;
            }
            else {
                StateLabel.TextColor = (Color) Application.Current.Resources["EntradaColor"];
                StateLabel.Text = "Estado: Dentro";
                estado = true;
                RegistrarFichaje("Trabajador Entrando en la Empresa");
            }
        }

        private void btnSalida_Clicked(object sender, EventArgs e)
        {
            if (!estado)
            {
                DisplayAlert("Advertencia", "Ya estas fuera", "Ops");
                return;
            }
            else
            {
                StateLabel.TextColor = (Color)Application.Current.Resources["SalidaColor"];
                StateLabel.Text = "Estado: Fuera";
                estado = false;
                RegistrarFichaje("Trabajador Entrando en la Empresa");
            }
        }

        private void RegistrarFichaje(string mensaje)
        {
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //Introducimos en el collection view la fecha junto al mensaje
            cvFichaje.ItemsSource = new[] { $"Fecha: {fecha} - {mensaje}."};
        }
    }

}
