using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucenaBitDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);
            // TODO: esta línea de código carga datos en la tabla 'lucenaBitDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);
            // TODO: esta línea de código carga datos en la tabla 'lucenaBitDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
