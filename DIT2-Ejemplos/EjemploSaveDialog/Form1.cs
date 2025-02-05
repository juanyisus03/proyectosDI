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

namespace EjemploSaveDialog
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Filter = "Text File (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

                    string ruta = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(ruta);
                    sw.Write($"Usuario: {txtUsuario.Text} \n");
                    sw.Write($"Password: {txtPass.Text}");
                    sw.Flush();
                    sw.Close();


                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el fichero: "+ ex.Message);
            }      
        }
    }
}
