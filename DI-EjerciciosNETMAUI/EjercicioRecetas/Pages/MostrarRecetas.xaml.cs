namespace EjercicioRecetas.Pages;

public partial class MostrarRecetas : ContentPage
{
	public MostrarRecetas()
	{
		InitializeComponent();
        cvRecetas.ItemsSource = RecetaSingleton.Instance.Recetas;
    }
}