using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using TiendaInformatica.Models;

namespace TiendaInformatica.Pages;

public partial class PortatilesPage : ContentPage
{
	ObservableCollection<Portatil> portatiles;
	public PortatilesPage()
	{
		InitializeComponent();

		portatiles = new ObservableCollection<Portatil>()
		{
			new Portatil()
			{
				Nombre = "Lenovo",
				Img = "portatil1.png",
				Valoracion =  "49.5"
			},
            new Portatil()
            {
                Nombre = "Asus",
                Img = "portatil2.png",
                Valoracion =  "49.5"
            },
            new Portatil()
            {
                Nombre = "HP",
                Img = "portatil3.png",
                Valoracion =  "49.5"
            },
        };

		lvPortatiles.ItemsSource = portatiles;
	}
}