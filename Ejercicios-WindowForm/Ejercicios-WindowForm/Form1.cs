using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMasAncho_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += 10;
        }

        private void btnMasAlto_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 10;
        }

        private void btnMenosAlto_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 10;
        }

        private void btnMenosAncho_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 10;
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y - 10 > 0) pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + pictureBox1.Width + 15 < panel3.Location.X + panel3.Width) pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + pictureBox1.Height < panel3.Height ) pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X - 10 > 0) pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
        }
    }
}
