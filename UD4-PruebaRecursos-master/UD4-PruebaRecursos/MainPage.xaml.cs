namespace UD4_PruebaRecursos
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void txtDatos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDatos.Text.Length > 3)
            {
                VisualStateManager.GoToState(txtDatos, "Valid");
            }
            else
            {
                VisualStateManager.GoToState(txtDatos, "InValid");
            }
        }
    }

}
