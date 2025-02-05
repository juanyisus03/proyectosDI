namespace Accesibilidad
{
    public partial class MainPage : ContentPage
    {

        public bool altoContraste = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCambiar_Clicked(object sender, EventArgs e)
        {
            altoContraste = !altoContraste;

            btnCambiar.Text = altoContraste ? "Desactivar modo Alto Contraste": "Activar modo Alto Contraste";
            lbNombre.Style = (Style) App.Current.Resources[ altoContraste ? "AltoContraste" : "Default"];
            lbPassword.Style = (Style) App.Current.Resources[altoContraste ? "AltoContraste" : "Default"];
           
        }
    }

}
