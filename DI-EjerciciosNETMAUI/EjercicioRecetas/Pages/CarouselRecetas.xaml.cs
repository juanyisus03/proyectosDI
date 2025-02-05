namespace EjercicioRecetas.Pages;

public partial class CarouselRecetas : ContentPage
{
	public CarouselRecetas()
	{
		InitializeComponent();
		crlRecetas.ItemsSource = RecetaSingleton.Instance.Recetas;
	}
}