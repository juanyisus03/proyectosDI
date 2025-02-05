using PuntoLimpioNetMaui;
using System.Collections.ObjectModel;

namespace PuntoLimpioNetMaui;

public partial class MainPage : ContentPage
{
    private ObservableCollection<Residuo> Residuos;

    public MainPage()
    {
        InitializeComponent();
        Residuos = new ObservableCollection<Residuo>() {
                new Residuo{
                    Cantidad = 200,
                    Nombre = "Escombro",
                    Tipo = "Obra"
                },
                new Residuo{
                    Cantidad = 50,
                    Nombre = "Pilas",
                    Tipo = "Peligrosos"
                }
            };
        lvResiduos.ItemsSource = Residuos;
        cambiarContador();
    }

    private void ButtonAgregar_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtTipo.Text) &&  int.TryParse(txtCantidad.Text, out int cantidad))
        {
            Residuo nuevoResiduo = new Residuo
            {
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Cantidad = cantidad
            };

            Residuos.Add(nuevoResiduo);
            cambiarContador();
            ClearInputs();
        }
        else
        {
            DisplayAlert("Error", "Por favor, llena todos los campos correctamente.", "OK");
        }
    }

    private void ButtonEliminar_Click(object sender, EventArgs e)
    {
        if (lvResiduos.SelectedItem != null)
        {
            Residuos.Remove((Residuo)lvResiduos.SelectedItem);
            cambiarContador();
        }
        else
        {
            DisplayAlert("Error", "Por favor, selecciona un residuo para eliminar.", "OK");
        }
    }

    private void ClearInputs()
    {
        txtNombre.Text = string.Empty;
        txtTipo.Text = string.Empty;
        txtCantidad.Text = string.Empty;
    }

    private void cambiarContador()
    {
        int sum = 0;
        foreach (Residuo r in Residuos)
        {
            sum += r.Cantidad;
        }
        lbTotalResiduos.Text = $"{sum}"; 
    }
}
