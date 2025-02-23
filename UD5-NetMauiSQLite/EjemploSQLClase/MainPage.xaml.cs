﻿using EjemploSQLClase.Models;
using EjemploSQLClase.Services;

namespace EjemploSQLClase
{
    public partial class MainPage : ContentPage
    {

        private Usuario? userSelected;
        public MainPage()
        {
            InitializeComponent();
            CargarUsuario();
        }

        private async void CargarUsuario()
        { 
            lvUsuarios.ItemsSource = await UsuarioService.GetInstance().ObtenerUsuarios();
        }

        private async void btnAnadir_Clicked(object sender, EventArgs e)
        {
            //Creamos el usuario para añadirlo a la base de datos
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtEdad.Text) || String.IsNullOrEmpty(txtCiudad.Text)) {
               
                await DisplayAlert("Error", "Por favor, rellene todos los campos", "Aceptar");
           
            }
            else
            {
                Usuario usuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Email = txtEmail.Text,
                    Ciudad = txtCiudad.Text

                };

                await UsuarioService.GetInstance().InsertarUsuarioAsync(usuario);
                CargarUsuario();

                //Una vez insertado el usuario se borran los campos
                txtNombre.Text = string.Empty;
                txtEdad.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtCiudad.Text = string.Empty;


            }
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                await UsuarioService.GetInstance().DeleteUsuarioAsync(userSelected);
                userSelected = null;
                btnEliminar.IsEnabled = false;
                CargarUsuario();
            }
            else {
                await DisplayAlert("Error", "Por favor seleccione un usuario de la lista.", "Aceptar");
            }
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Application.Current?.Quit();
        }

        private void lvUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            userSelected = (Usuario) e.SelectedItem;
            btnEliminar.IsEnabled = userSelected != null;
        }

        private void swActivar_Toggled(object sender, ToggledEventArgs e)
        {
            stBBDD.IsEnabled = e.Value;

            if (e.Value) {
                stBBDD.BackgroundColor = Colors.LightCyan;
            }
            else
            {
                stBBDD.BackgroundColor = Colors.White;
            }
        }
    }

}
