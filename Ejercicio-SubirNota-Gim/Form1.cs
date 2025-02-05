using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_SubirNota_Gim
{
    public partial class Form1 : Form
    {

        public Form ventanaClientes, ventanaActividades;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void actividadesCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaActividades == null)
            {
                ventanaActividades = new Form3();
                ventanaActividades.MdiParent = this;
                ventanaActividades.Show();
            }
            else
            {
                ventanaActividades.Visible = true;
            }

            if (ventanaClientes != null)
            {
                ventanaClientes.Visible = false;
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control) {
                toolStripMenuItem1_Click(sender, e);
            } else if (e.KeyCode == Keys.A && e.Control) {
                actividadesCtrlAToolStripMenuItem_Click(sender, e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if(ventanaClientes == null)
            {
                ventanaClientes = new Form2();
                ventanaClientes.MdiParent = this;
                ventanaClientes.Show();
            }
            else
            {
                ventanaClientes.Visible = true;
            }

            if (ventanaActividades != null) { 
                ventanaActividades.Visible = false;
            }


        }
    }
}
