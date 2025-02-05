
using System;

using System.Collections.Generic;



using System.IO;


using System.Text.Json;

using System.Windows.Forms;

namespace Ejercicio_SubirNota_Gim
{
    public partial class Form2 : Form
    {
        private Cliente clienteSeleccionado;
        private List<Cliente> clientes = new List<Cliente> { };
        private string[] ciudades = { "Lucena" , "Cabra", "Montilla", "Priego de Córdoba", "Aguilar de la Frontera", "Puente Genil", "Benamenji", "Álora", "Pizarra", "Torre Del Mar", "Guarroman"};
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbCiudades.DataSource = ciudades;

            bsClientes.DataSource = clientes;
            dataClientes.DataSource = bsClientes;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Cliente clienteNuevo = this.ValidarDatosYCrearCliente();
                foreach (Cliente cliente in clientes)
                {
                    if (clienteNuevo.Codigo.Equals(cliente.Codigo)) {
                        throw new Exception("El codigo ya está en uso, por favor seleccione otro");
                    }   
                }
                clientes.Add(clienteNuevo);
                bsClientes.ResetBindings(false);
                limpiarDatos();
                
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        

       

        private void dataClientes_OnClick(object sender, EventArgs e)
        {
            if (dataClientes.CurrentRow != null)
            {
                string codigo = dataClientes.CurrentRow.Cells[0].Value.ToString();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.Codigo == codigo)
                    {
                        clienteSeleccionado = cliente;
                        break;
                    }

                }

                txtCodigo.Text = codigo;
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtTelefono.Text = clienteSeleccionado.Telefono;
                txtApellido.Text = clienteSeleccionado.Apellido;

                dataFechaNac.Value = DateTime.Parse(clienteSeleccionado.FechaNac);
                for (int i = 0; i < ciudades.Length; i++)
                {
                    if (ciudades[i] == clienteSeleccionado.Ciudad)
                    {
                        cbCiudades.SelectedIndex = i;
                        break;
                    }
                }
            }
            else {
                limpiarDatos();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                Cliente modificado = ValidarDatosYCrearCliente();
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (modificado.Codigo == clientes[i].Codigo)
                    {
                        clientes[i] = modificado;
                        clienteSeleccionado = modificado;
                        bsClientes.ResetBindings(false);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpiarDatos();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (bsClientes.Current != null)
            {
                
                bsClientes.RemoveCurrent();
                bsClientes.Position = -1;
                limpiarDatos();
                
            }
            else {
                MessageBox.Show("Por Favor, Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream s = null;
            StreamReader sr = null;

            try
            {
                s = new FileStream("clientes.json", FileMode.Open);
                sr = new StreamReader(s);
                string txt = sr.ReadToEnd();
                List<Cliente> listado = JsonSerializer.Deserialize<List<Cliente>>(txt);
                clientes.Clear();
                clientes.AddRange(listado);
                bsClientes.ResetBindings(false);
                MessageBox.Show("Clientes cargados con éxito", "Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sr.Close();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sr != null) sr.Close();
            if (s != null) s.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Stream s = null;
            StreamWriter sw = null;
            try
            {
                s = new FileStream("clientes.json", FileMode.OpenOrCreate);                
                sw = new StreamWriter(s);
                
                sw.Write(JsonSerializer.Serialize(clientes));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sw != null) sw.Close();
            if (s != null) s.Close();

        }

        private Cliente ValidarDatosYCrearCliente()
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string ciudad = cbCiudades.SelectedItem.ToString();
            string fecha = dataFechaNac.Text;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono))
            {
                throw new Exception("Por favor, rellene todos los datos del formulario");
            }

            try
            {
                int.Parse(telefono);
            }
            catch
            {
                throw new Exception("Por favor, introduce un número de teléfono válido");
            }


            return new Cliente(codigo, nombre, apellido, fecha, ciudad, telefono);
        }

        private void limpiarDatos()
        {
            txtNombre = null;
            txtApellido = null;
            txtCodigo = null;
            txtTelefono = null;
            dataFechaNac.Value = DateTime.Today;
            cbCiudades.SelectedIndex = 0;
        }
    }
}
