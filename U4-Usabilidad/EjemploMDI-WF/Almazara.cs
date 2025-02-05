using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMDI_WF
{
    public partial class Almazara : Form
    {

        //Declaramos dos formularios hijos 
        public Form paginaAceitunas, paginaProduccion;

        public Almazara()
        {
            InitializeComponent();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //Vamos a crear una instancia de Produccion
            if (paginaProduccion == null)
            {
                paginaProduccion = new Produccion();
                paginaProduccion.MdiParent = this;
                paginaProduccion.Show();
            }
            else
            {
                paginaProduccion.Visible = true;
                
            }

            if (paginaAceitunas != null)
            {
                paginaAceitunas.Visible = false;
                
            }

            
        }

        private void salirDeLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Almazara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {

                tipoAceitunasToolStripMenuItem_Click(sender, e);

            }
            else if (e.Control && e.KeyCode == Keys.P) { 
                producciónToolStripMenuItem_Click(sender, e);
            }
        }

        private void tipoAceitunasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Vamos a crear una instancia de Aceituna
            if (paginaAceitunas == null)
            {
                paginaAceitunas = new Aceitunas();
                paginaAceitunas.MdiParent = this;
                paginaAceitunas.Show();
            }
            else
            {
                paginaAceitunas.Visible = true;
                
            }

            if (paginaProduccion != null)
            {
                paginaProduccion.Visible = false;
            }

            
        }
    }
}
