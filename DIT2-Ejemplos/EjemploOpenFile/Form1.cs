using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploOpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                string ruta = openFileDialog1.FileName;

                string[] fichero = File.ReadAllLines(ruta);

                lb1.Items.Clear();

                foreach(string linea in fichero)
                {
                    lb1.Items.Add(linea);
                }
            }
        }
    }
}
