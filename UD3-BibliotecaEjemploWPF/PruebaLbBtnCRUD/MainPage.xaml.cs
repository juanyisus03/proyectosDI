namespace PruebaLbBtnCRUD
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            crud.buttonAnadir.Clicked += ButtonAnadir_Clicked;
            crud.buttonModificar.Pressed += ButtonModificar_Pressed;
            crud.buttonModificar.Released += ButtonModificar_Release;

            crud.buttonEliminar.Focused += ButtonElimiar_Focused;
            crud.buttonEliminar.Unfocused += ButtonElimiar_Unfocused;
        }

        private void ButtonElimiar_Unfocused(object? sender, FocusEventArgs e)
        {
            imgCoche.IsVisible = true;
            crud.buttonEliminar.Background = Colors.Red;
        }

        private void ButtonModificar_Release(object? sender, EventArgs e)
        {
            crud.buttonModificar.TextColor = Colors.White;
        }

        private void ButtonModificar_Pressed(object? sender, EventArgs e)
        {

            crud.buttonModificar.TextColor = Colors.Red;

        }

        private void ButtonElimiar_Focused(object? sender, EventArgs e)
        {
            imgCoche.IsVisible = false;
            crud.buttonEliminar.Background = Colors.Orange;
        }

        private void ButtonAnadir_Clicked(object? sender, EventArgs e)
        {
            DisplayAlert("Boton Pulsado", "Boton Añadir Pulsado", "Okey Dokey");
        }
    }

}
