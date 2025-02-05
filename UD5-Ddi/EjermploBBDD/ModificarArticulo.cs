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
    public partial class ModificarArticulo : Form
    {
        private Articulo articulo = Articulo.Instance;

        public ModificarArticulo()
        {
            InitializeComponent();

            //Cargamos los datos del objeto
            txtNombre.Text = articulo.Nombre;
            txtCantidad.Text = articulo.Cantidad.ToString();
            txtCategoria.Text = articulo.Categoria;
            txtPrecio.Text = articulo.Precio.ToString();

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Creamos la instruccion en 
            string query = "UPDATE Articulos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria, Cantidad = @Cantidad WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LucenaBitConnectionString))
            {
                connection.Open();

                //Vamos a ejecutar el query SQL 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //Añadir los parámetros de insercion de la consulta
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Id", articulo.Id);
                    command.Parameters.AddWithValue("@Precio", Convert.ToDouble(txtPrecio.Text));
                    command.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                    command.Parameters.AddWithValue("@Cantidad", Convert.ToInt16(txtCantidad.Text));

                    //Ejecutamos el comando
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Articulo modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error. Fallo a la hora de modificar el articulo");
                    }

                    this.Close();

                }
            }
        }
    }
}
