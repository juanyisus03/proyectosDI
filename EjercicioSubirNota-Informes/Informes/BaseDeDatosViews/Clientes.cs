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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.ferreteriaDataSet1.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
