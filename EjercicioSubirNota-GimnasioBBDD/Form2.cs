
using System;

using System.Collections.Generic;
using System.IO;


using System.Text.Json;

using System.Windows.Forms;

namespace Ejercicio_SubirNota_Gim
{
    public partial class Form2 : Form
    {
        private Cliente clienteSeleccionado;
        private Form1 ventanaPrincipal;
        private string[] ciudades = { "Lucena" , "Cabra", "Montilla", "Priego de Córdoba", "Aguilar de la Frontera", "Puente Genil", "Benamenji", "Álora", "Pizarra", "Torre Del Mar", "Guarroman"};
        public Form2(Form1 ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gimnasioDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gimnasioDataSet.Clientes);
            cbCiudades.DataSource = ciudades;

            
        }

        private void Form2_FormClose(object sender, FormClosedEventArgs e)
        {
            ventanaPrincipal.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Cliente clienteNuevo = this.ValidarDatosYCrearCliente();

                string query = "INSERT INTO Clientes (NombreCliente, ApellidosCliente, FechaNacimiento,Ciudad, Telefono,) VALUES (@Nombre, @Apellidos, @Precio, @Categoria, @Cantidad) ";

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LucenaBitConnectionString))
                {
                    connection.Open();

                    //Vamos a ejecutar el query SQL 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //Añadir los parámetros de insercion de la consulta
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@Precio", Convert.ToDouble(txtPrecio.Text));
                        command.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                        command.Parameters.AddWithValue("@Cantidad", Convert.ToInt16(txtCantidad.Text));

                        //Ejecutamos el comando
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Articulo creado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error. Fallo a la hora de insertar el articulo");
                        }

                        this.Close();

                    }
                }

                limpiarDatos();
                
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        

       

        private void dataClientes_OnClick(object sender, EventArgs e)
        {
            if (dataClientes.CurrentRow != null)
            {
                clienteSeleccionado = new Cliente();
                clienteSeleccionado.Codigo = dataClientes.CurrentRow.Cells["dgvClienteCodigo"].Value.ToString();
                clienteSeleccionado.Nombre = dataClientes.CurrentRow.Cells["dgvClienteNombre"].Value.ToString();
                clienteSeleccionado.Telefono = dataClientes.CurrentRow.Cells["dgvClienteTelefono"].Value.ToString();
                clienteSeleccionado.Apellido = dataClientes.CurrentRow.Cells["dgvClienteApellidos"].Value.ToString();
                clienteSeleccionado.FechaNac = dataClientes.CurrentRow.Cells["dgvClienteFecha"].Value.ToString();


                txtCodigo.Text = clienteSeleccionado.Codigo;
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtTelefono.Text = clienteSeleccionado.Telefono;
                txtApellido.Text = clienteSeleccionado.Apellido;

                dataFechaNac.Value = DateTime.Parse(clienteSeleccionado.FechaNac);
                for (int i = 0; i < ciudades.Length; i++)
                {
                    if (ciudades[i] == clienteSeleccionado.Ciudad)
                    {
                        cbCiudades.SelectedIndex = i;
                        break;
                    }
                }
            }
            else {
                limpiarDatos();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                Cliente modificado = ValidarDatosYCrearCliente();
                modificado.Codigo = clienteSeleccionado.Codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpiarDatos();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataClientes.CurrentRow != null)
            {
                
               
                limpiarDatos();
                
            }
            else {
                MessageBox.Show("Por Favor, Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private Cliente ValidarDatosYCrearCliente()
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string ciudad = cbCiudades.SelectedItem.ToString();
            string fecha = dataFechaNac.Text;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono))
            {
                throw new Exception("Por favor, rellene todos los datos del formulario");
            }

            try
            {
                int.Parse(telefono);
            }
            catch
            {
                throw new Exception("Por favor, introduce un número de teléfono válido");
            }


            return new Cliente(codigo, nombre, apellido, fecha, ciudad, telefono);
        }

        private void limpiarDatos()
        {
            txtNombre = null;
            txtApellido = null;
            txtCodigo = null;
            txtTelefono = null;
            dataFechaNac.Value = DateTime.Today;
            cbCiudades.SelectedIndex = 0;
        }
    }
}
