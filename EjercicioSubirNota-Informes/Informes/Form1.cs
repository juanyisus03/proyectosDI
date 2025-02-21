using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informes.BaseDeDatosViews;

namespace Informes
{
    public partial class Form1 : Form
    {

        private Form ventanaActiva;

      

        private void cerrarVentana()
        {
            if (ventanaActiva != null)
            {
                ventanaActiva.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new Clientes();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();

        }

        private void pepidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new Pedidos();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new Productos();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }

        private void clientesDeAntequeraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cerrarVentana();
            ventanaActiva = new ClientesAntequera();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }

        private void pedidosDeClientesDeLucenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new PedidosLucena();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }

        private void pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new PedidosProductosAdhesivos();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }

        private void pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentana();
            ventanaActiva = new PedidosProductosMenor10();
            ventanaActiva.MdiParent = this;
            ventanaActiva.Show();
        }
    }
}
