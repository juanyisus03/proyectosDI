namespace Ejemplo.NavigationPage;

public partial class NavigationPage1 : ContentPage
{
	public NavigationPage1()
	{
		InitializeComponent();
	}

	private async void btn_volverOnClick(object sender, EventArgs e) { 
		await Navigation.PopAsync();
	}
}