using System.Collections.ObjectModel;
using ProyectoPreMVVM.Models;


namespace ProyectoPreMVVM
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<Contacto> ListaContactos;

        public MainPage()
        {
            InitializeComponent();

            ListaContactos = new ObservableCollection<Contacto>()
            {
                new Contacto()
                {
                    Nombre = "Leonardo",
                    Apellido = "Lopez",
                    Telefono = "667823622",
                    Sexo = "Masculino"
                },
                new Contacto()
                {
                    Nombre = "Miguelangelo",
                    Apellido = "Ninja",
                    Telefono = "238029830",
                    Sexo = "Tortuga"
                },
                new Contacto()
                {
                    Nombre = "Gumball",
                    Apellido = "Waterson",
                    Telefono = "667324322",
                    Sexo = "Gato"
                },
                new Contacto()
                {
                    Nombre = "Mickey",
                    Apellido = "Mouse",
                    Telefono = "666666666",
                    Sexo = "Ratón"
                },
                new Contacto()
                {
                    Nombre = "María",
                    Apellido = "Delgado",
                    Telefono = "6324983778",
                    Sexo = "Femenino"
                },


            };

            lvAgenda.ItemsSource = ListaContactos;

        }

        private void btnColor_Clicked(object sender, EventArgs e)
        {
            if(FondoAgenda.BackgroundColor == Colors.LightSlateGray)
            {
                FondoAgenda.BackgroundColor = Colors.Black;
                lvAgenda.BackgroundColor = Colors.White;
            }
            else
            {
                FondoAgenda.BackgroundColor = Colors.LightSlateGray;
                lvAgenda.BackgroundColor = Colors.LightSlateGray;
                
            }
        }
    }

}
