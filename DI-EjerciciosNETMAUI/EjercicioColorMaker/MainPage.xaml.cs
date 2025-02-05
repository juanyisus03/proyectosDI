


namespace EjercicioColorMaker
{
    public partial class MainPage : ContentPage
    {

        int red = 0;
        int blue = 0;
        int green = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnColor_Clicked(object sender, EventArgs e)
        {
            Random rd = new Random();

            red = rd.Next(256);
            green = rd.Next(256);
            blue = rd.Next(256);
            
            cambiarColor();

            slRojo.Value = red;
            slVerde.Value = green;
            slAzul.Value = blue;
        }

        private void slidderValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            red = (int) slRojo.Value;
            green = (int)slVerde.Value;
            blue = (int)slAzul.Value;
            
            cambiarColor();
        }

       

        private void cambiarColor() 
        {
            btnColor.BackgroundColor = Color.FromRgb(red, green, blue);
            panel.BackgroundColor = Color.FromRgb(red, green, blue);
            lbColor.Text = $"Hex Color: {panel.BackgroundColor.ToHex()}";
        }
    }

}
