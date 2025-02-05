using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_AdivinarNumero
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int intentos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                num1 = int.Parse(numBuscado.Text);
                if (num1 > 0 && num1 < 101)
                {
                    
                    pn2.Site = pn1.Site;
                    pn2.Bounds = pn1.Bounds;
                    pn2.Visible = true;
                    pn1.Visible = false;

                    intentos = 5;
                    label5.Text = "Numero de Intentos: " + intentos;
                    numBuscado.Text = "";
                }
                else
                {
                    throw new Exception("");
                }
            }catch {
                MessageBox.Show("No has introducido un numero entre 1-100","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void reset() {
            pn2.Visible = false;
            pn1.Visible = true;
            intentos = 5;
            num1 = 0;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = int.Parse(numComprobar.Text);
                if (num2 > num1)
                {
                    intentos -= 1;
                    label5.Text = "Numero de Intentos: " + intentos;
                    numComprobar.Text = "";
                    MessageBox.Show("El numero secreto es menor que " + num2, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (num2 < num1)
                {
                    intentos -= 1;
                    label5.Text = "Numero de Intentos: " + intentos;
                    numComprobar.Text = "";
                    MessageBox.Show("El numero secreto es mayor que " + num2, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    MessageBox.Show("Has adivinado el numero secreto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                if (intentos == 0) {
                    MessageBox.Show("Has agotado los intentos el numero secreto era " + num1, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("No has introducido un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
