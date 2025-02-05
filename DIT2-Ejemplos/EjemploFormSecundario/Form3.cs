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
    public partial class Form3 : Form
    {
        List<Ciudad> listCiudades = new List<Ciudad>() { 
            
            new Ciudad(){ 
            
            
                NombreCiudad = "Cordoba",
                PoblacionCiudad = 300000,
                ComunidadCiudad = "Andalucia"
            },
            new Ciudad(){


                NombreCiudad = "Sevilla",
                PoblacionCiudad = 130000,
                ComunidadCiudad = "Andalucia"
            },
            new Ciudad(){
                NombreCiudad = "Badajoz",
                PoblacionCiudad = 130000,
                ComunidadCiudad = "Extremadura"
            },
            new Ciudad(){


                NombreCiudad = "Toledo",
                PoblacionCiudad = 130000,
                ComunidadCiudad = "Castilla-la Mancha"
            }

        };
        
        public Form1 ventanaPrincipal = null;
        
        public Form3(Form1 ventanaPrincipal)
        {
            this.ventanaPrincipal = ventanaPrincipal;
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventanaPrincipal.Show();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
            * Creamos el enlace entre el DataGridView y el List
            */

            //dGVCiudades.DataSource = listCiudades;
            ciudadBindingSource.DataSource = listCiudades;
            dGVCiudades.DataSource = ciudadBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ciudadBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ciudadBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ciudadBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ciudadBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad("Malaga", 571000, "Andalucia");
            listCiudades.Add(ciudad);
            ciudadBindingSource.ResetBindings(false);
        }
    }
}
