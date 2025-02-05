namespace EjemplosVentanas.NavigationPages;

public partial class NavigationPage1 : ContentPage
{
	public NavigationPage1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();

    }
}