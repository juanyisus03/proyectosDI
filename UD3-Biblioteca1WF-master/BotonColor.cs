using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_Biblioteca1WF
{
    public partial class BotonColor: UserControl
    {
        int contador = 0;
        public BotonColor()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
            button1.BackColor = Color.LightSalmon;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            lb_mensaje.Text = "Clic realizados: " + contador;
        }
    }
}
