using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.BaseDeDatosViews
{
    public partial class PedidosProductosMenor10 : Form
    {
        public PedidosProductosMenor10()
        {
            InitializeComponent();
        }

        private void PedidosProductosMenor10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.PedidosMenor10' Puede moverla o quitarla según sea necesario.
            this.pedidosMenor10TableAdapter.Fill(this.ferreteriaDataSet.PedidosMenor10);

            this.reportViewer1.RefreshReport();
        }
    }
}
