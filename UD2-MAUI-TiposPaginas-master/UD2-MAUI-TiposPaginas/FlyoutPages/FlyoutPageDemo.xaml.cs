namespace UD2_MAUI_TiposPaginas;

public partial class FlyoutPageDemo : FlyoutPage
{

    // Variables para almacenar las instancias de las páginas
    private Page pagina1Instance;
   

    public FlyoutPageDemo()
	{
		InitializeComponent();
        // Inicializar las instancias si es necesario
        pagina1Instance = new Pagina1Flyout();

    }

    

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Detail = pagina1Instance;
        IsPresented = false;
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Detail = PaginaDetailInicio;
        IsPresented = false;
    }
}