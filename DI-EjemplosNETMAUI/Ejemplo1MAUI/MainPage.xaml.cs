namespace Ejemplo1MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()

        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informacion","Credenciales enviadas","Okey Dokey");
        }
    }

}
