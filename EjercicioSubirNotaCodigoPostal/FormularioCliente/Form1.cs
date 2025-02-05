using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text;
            lblApellido.Text = txtApellido.Text;
            lblCodigoPostal.Text = control.SelectedCodigoPostal;

            groupBox1.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible=false;
        }
    }
}
