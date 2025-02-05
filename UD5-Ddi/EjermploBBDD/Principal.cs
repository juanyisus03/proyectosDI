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
    public partial class Principal : Form
    {
        //Declaramos las instancias de Alta y Modificar Producto

        public Form AltaArticulo, ModificarArticulo;

        public Articulo articulo = Articulo.Instance;

        public Principal()
        {

            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucenaBitDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarArticulo = new ModificarArticulo();
            ModificarArticulo.ShowDialog();
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);
        }

      

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //comprobamos que selecciona una fila
            if (e.RowIndex >= 0)
            {
                //Extramos la info de las columnas
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                articulo.Id = Convert.ToInt16(filaSeleccionada.Cells["dgvArticulosId"].Value);
                articulo.Nombre = (string)filaSeleccionada.Cells["dgvArticulosNombre"].Value;
                articulo.Categoria = (string)filaSeleccionada.Cells["dgvArticulosCategoria"].Value;
                articulo.Precio = Convert.ToDecimal(filaSeleccionada.Cells["dgvArticulosPrecio"].Value);
                articulo.Cantidad = Convert.ToInt16(filaSeleccionada.Cells["dgvArticulosCantidad"].Value);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla", "");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(articulo.Id != 0) {
                DialogResult borrar = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo);

                if(borrar == DialogResult.Yes)
                {
                    //Procedemos al borrado del articulo en la base de datos
                    string query = "DELETE FROM Articulos WHERE Id = @Id";

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LucenaBitConnectionString))
                    {
                        connection.Open();

                        //Vamos a ejecutar el query SQL 
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            //Añadir los parámetros de insercion de la consulta
                            command.Parameters.AddWithValue("@Id", articulo.Id);
                            

                            //Ejecutamos el comando
                            int filasAfectadas = command.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Articulo borrado correctamente");
                                articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);
                            }
                            else
                            {
                                MessageBox.Show("Error. Fallo a la hora de borrar el articulo");
                            }

                        }
                    }

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaArticulo = new AltaArticulo();
            AltaArticulo.ShowDialog();
            

            //Actualizamos los datos nuevos en la base de datos
            articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);

        }
    }
}
