using EjemplosVentanas.FlyoutPages;

namespace EjemplosVentanas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            /*
            //Establecer una página de Navegacion modificando valores de la barra
            var BarraNavPage = new NavigationPage(new MainPage());
            BarraNavPage.BarBackground = Colors.AliceBlue;
            BarraNavPage.BarTextColor = Colors.DarkRed;
            BarraNavPage.Title = "Ejemplo NavigationPage";

            MainPage = BarraNavPage;
            */

            MainPage = new FlyoutPageDemo();

        }
    }
}
