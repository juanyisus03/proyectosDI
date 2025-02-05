using System.Collections.ObjectModel;
using TiendaInformatica.Models;

namespace TiendaInformatica.Pages;

public partial class MovilesPage : ContentPage
{
	ObservableCollection<Movil> moviles;
	public MovilesPage()
	{
		InitializeComponent();

		moviles = new ObservableCollection<Movil>() { 
			
			new Movil()
			{
				Nombre = "Iphone 15",
				Valoracion = "40.8",
				Img = "movil1.png",
			},
            new Movil()
            {
                Nombre = "Super NightScape",
                Valoracion = "40.8",
                Img = "movil2.png",
            },
            new Movil()
            {
                Nombre = "Iphone 15 Pro Max",
                Valoracion = "40.8",
                Img = "movil3.png",
            },
        };

        cvMoviles.ItemsSource = moviles;
	}
}