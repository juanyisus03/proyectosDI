namespace Ejemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            //Establecer una pagina de navegacion
            var BarrNavPage = new NavigationPage(new MainPage());

        }
    }
}
