using System.Collections.ObjectModel;

using EjercicioRecetas;
namespace EjercicioRecetas.Pages;

public partial class BuscarRecetas : ContentPage
{
    ObservableCollection<Receta> RecetasBuscadas;
    ObservableCollection<Receta> Recetas;


    public BuscarRecetas()
    {

        InitializeComponent();
        RecetasBuscadas = new ObservableCollection<Receta>();
        Recetas = RecetaSingleton.Instance.Recetas;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        string txt = buscador.Text;
        cvBuscados.ItemsSource = null;
        RecetasBuscadas.Clear();
        if (!string.IsNullOrWhiteSpace(txt))
        {

            foreach (Receta receta in Recetas)
            {
                if (receta.Nombre.ToLower().Contains(txt.ToLower())) RecetasBuscadas.Add(receta);
                else if (receta.Descripcion.ToLower().Contains(txt.ToLower())) RecetasBuscadas.Add(receta);
            }
        }
        cvBuscados.ItemsSource = RecetasBuscadas;
    }

}