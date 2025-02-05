using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFormSecundario
{
    public partial class Form2 : Form
    {
        public string[] ciudades = { "Sevilla", "Cadiz", "Huelva",  "Malaga", "Jaen", "Granada", "Almeria", "Cordoba" };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbCiudad.DataSource = ciudades;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
