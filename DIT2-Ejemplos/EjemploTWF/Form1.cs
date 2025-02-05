using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EjemploTWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                lstNombres.Items.Add(txtNombre.Text);
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lstNombres.SelectedItem != null) lstNombres.Items.Remove(lstNombres.SelectedItem);
            else  lstNombres.Items.Clear();
            txtNombre.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter) btnAnadir_Click(sender, e);
        }
    }
}
