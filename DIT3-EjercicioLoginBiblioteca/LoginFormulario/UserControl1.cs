using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormulario
{
    public partial class UserControl1 : UserControl
    {
        
        public string Usuario => txtNombre.Text;
        public string Pass => txtContrasena.Text;

        public UserControl1()
        {
            InitializeComponent();
            txtContrasena.Visible = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text)) txtContrasena.Visible = true;
            else txtContrasena.Visible = false;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length < 5) {
                MessageBox.Show("El nombre tiene que tener al menos 5 caracteres","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtNombre.Text = string.Empty;
            }

        }
    }
}
