using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjermploBBDD
{
    public partial class AltaArticulo : Form
    {
        public AltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Creamos la instruccion en 
            string query = "INSERT INTO Articulos (Nombre, Precio, Categoria, Cantidad) VALUES (@Nombre, @Precio, @Categoria, @Cantidad) ";

            using ( SqlConnection connection = new SqlConnection(Properties.Settings.Default.LucenaBitConnectionString))
            { 
                connection.Open();

                //Vamos a ejecutar el query SQL 
                using (SqlCommand command = new SqlCommand(query, connection)) {
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
                    else {
                        MessageBox.Show("Error. Fallo a la hora de insertar el articulo");
                    }

                    this.Close();

                }
            }
        }
    }
}
