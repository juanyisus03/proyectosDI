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
    public partial class ClientesAntequera : Form
    {
        public ClientesAntequera()
        {
            InitializeComponent();
        }

        private void ClientesAntequera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.ClienteAntquera' Puede moverla o quitarla según sea necesario.
            this.clienteAntqueraTableAdapter.Fill(this.ferreteriaDataSet.ClienteAntquera);

            this.reportViewer1.RefreshReport();
        }
    }
}
