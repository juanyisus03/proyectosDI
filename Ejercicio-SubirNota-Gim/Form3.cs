using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_SubirNota_Gim
{
    public partial class Form3 : Form
    {

        private List<Actividad> actividades = new List<Actividad> {
            new Actividad(){
                Codigo = "A01",
                Descripcion = "Entrenamiento de mancuernas y pesos ligeros",
                Nombre = "Pesas",
                Sala = "Sala 1"
            },
            new Actividad(){
                Codigo = "A02",
                Descripcion = "Entrenamiento de bicicletas estáticas",
                Nombre = "Spining",
                Sala = "Sala 2"
            },
            new Actividad(){
                Codigo = "A03",
                Descripcion = "Relájate y estira los músculos con este ejercicio",
                Nombre = "Yoga",
                Sala = "Sala 3"
            },
            new Actividad(){
                Codigo = "A04",
                Descripcion = "Trae a los peques a aprender a nadar o mejorar",
                Nombre = "Natación",
                Sala = "Sala Cubierta"
            },

        };

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.BackColor = Color.LightCoral;
            listView1.Columns.Add("Código",100);
            listView1.Columns.Add("Nombre", 100);
            listView1.Columns.Add("Sala", 100);
            listView1.Columns.Add("Descripción Actividad", 200);

            foreach (Actividad actividad in actividades)
            {
                ListViewItem item = new ListViewItem(actividad.Codigo);
                item.SubItems.Add(actividad.Nombre);
                item.SubItems.Add(actividad.Sala);
                item.SubItems.Add(actividad.Descripcion);
                listView1.Items.Add(item);
            }
        }

    }
}
