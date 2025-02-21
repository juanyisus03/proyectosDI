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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.ferreteriaDataSet.Pedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
