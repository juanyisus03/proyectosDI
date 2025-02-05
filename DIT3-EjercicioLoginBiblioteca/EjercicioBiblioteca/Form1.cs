using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (comprobarUsuario())
            {
                if (comprobarContrasena())
                {
                    MessageBox.Show("Sus datos:" +
                       $"\n -Usuario: {loginPanel.Usuario}  \n -Contraseña: {loginPanel.Pass}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La contraseña debe contener al menos uno de cada:" +
                        "\n -Minuscula \n -Mayuscula \n -Numeros \n-Caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("El usuario tiene que tener solo letras y espacios en blanco", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool comprobarContrasena()
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasSpecial = false;

            string password = loginPanel.Pass;

            foreach(char c in password) { 
                if(char.IsDigit(c)) hasDigit = true;
                else if(char.IsLower(c)) hasLower = true;
                else if (char.IsUpper(c)) hasUpper = true;
                else if(char.IsPunctuation(c)) hasSpecial = true;
            }


            return (hasDigit && hasLower && hasUpper && hasSpecial);
        }

        private bool comprobarUsuario()
        {
            string username = loginPanel.Usuario;

            foreach (char c in username) {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c)) { 
                    return false;
                }
            }

            return true;

        }
    }
}
