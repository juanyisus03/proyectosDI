using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_PersistenciaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Properties.Settings.Default.BackColor;
            txtUsuario.Text = Properties.Settings.Default.NombreUsuario;


        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {

                BackColor = colorPicker.Color;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardamos la configuracion del color y el nombre del usuario
            Properties.Settings.Default.BackColor = BackColor;
            Properties.Settings.Default.NombreUsuario = txtUsuario.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Datos guardados correctamente" , "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
