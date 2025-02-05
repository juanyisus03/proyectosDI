using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_AplicacionEscritorioWindowsForms
{
    public partial class Form1 : Form
    {

        private List<Pedido> pedidos = new List<Pedido>() {
            new Pedido(){
                Descripcion = "Placa Base Asus",
                Codigo = "10",
                Fecha = "10-10-2021"
            },
            new Pedido(){
                Descripcion = "Altavoces Energy Sistem",
                Codigo = "20",
                Fecha = "10-9-2024"
            },
            new Pedido(){
                Descripcion = "Teclado Acer",
                Codigo = "30",
                Fecha = "12-8-2023"
            }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bsPedidos.DataSource = pedidos;
            dgPedidos.DataSource = bsPedidos;
            bsPedidos.ResetBindings(false);
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {            
            bsPedidos.DataSource = null;
            bsPedidos.ResetBindings(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool borrado = false;
            int codigo = (int) numCodigo.Value;

            foreach (Pedido pedido in pedidos)
            {
                if (codigo == int.Parse(pedido.Codigo) && bsPedidos.DataSource != null) { 
                    pedidos.Remove(pedido);
                    borrado = true;
                    bsPedidos.ResetBindings(false);
                    break;
                }
            }

            if (borrado)
            {
                MessageBox.Show("Pedido Borrado Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Pedido No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPedidos_Click(object sender, EventArgs e)
        {
            if (bsPedidos.DataSource != null && dgPedidos.SelectedRows[0].Cells[1].Value != null)
            {
                numCodigo.Value = int.Parse(dgPedidos.SelectedRows[0].Cells[1].Value.ToString());
            }
        }
    }
}
