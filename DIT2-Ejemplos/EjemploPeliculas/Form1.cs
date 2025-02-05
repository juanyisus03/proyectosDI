using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPeliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text)) throw new Exception("El contenido no puede estar vacio");
                else if (cbPeliculas.Items.Contains(txtNombre.Text)) throw new Exception("La pelicula ya está en la lista");

                else
                {
                    cbPeliculas.Items.Add(txtNombre.Text);
                    cbPeliculas.Refresh();
                    cbPeliculas.SelectedItem = cbPeliculas.Items[cbPeliculas.Items.Count - 1];
                }

                txtNombre.Clear();
                txtNombre.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show(sender.ToString());
            MessageBox.Show("La pelicula seleccionada es " + cbPeliculas.SelectedItem.ToString());
        }
    }
}
