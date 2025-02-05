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
    public partial class Form1 : Form
    {
        public Form Informe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.articulosTableAdapter.Fill(this.lucenaBitDataSet.Articulos);

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (rbTotal.Checked)
            {
                //Mostrar el informe de todos los articulos
                Informe = new Form2();
                Informe.ShowDialog();
            }
            else if (rbPerifericos.Checked)
            {

                Informe = new Informes.InformePerifecos();
                Informe.ShowDialog();

            }
        }
    }
}
