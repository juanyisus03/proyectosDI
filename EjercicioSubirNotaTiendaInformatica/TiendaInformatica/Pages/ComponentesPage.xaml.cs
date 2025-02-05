using System.Collections.ObjectModel;
using TiendaInformatica.Models;

namespace TiendaInformatica.Pages;

public partial class ComponentesPage : ContentPage
{
	ObservableCollection<Componente> componentes;
	public ComponentesPage()
	{
		InitializeComponent();

		componentes = new ObservableCollection<Componente>() { 
		
			new Componente()
			{
				Nombre = "Placa Base",
				Img = "componente1.png",
				Valoracion = "45.9"
			},
            new Componente()
            {
                Nombre = "Fuente de Alimentación",
                Img = "componente2.png",
                Valoracion = "20.5"
            },
            new Componente()
            {
                Nombre = "Tarjeta Grafica",
                Img = "componente3.png",
                Valoracion = "49"
            }
        };

        clComponentes.ItemsSource = componentes;

	}
}