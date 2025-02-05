namespace EjemploControles
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnImg_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informacion", "Has pulsado la imagen", "okey dokey");
        }
    }

}
