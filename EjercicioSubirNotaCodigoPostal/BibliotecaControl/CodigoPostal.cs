using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BibliotecaControl
{
    public partial class CodigoPostal: UserControl
    {

        public string SelectedCodigoPostal;

        List<string> filterCodigosPostales = new List<string>();

        List<string> CodigosPostales = new List<string>() {
            "08001", "28001", "29001", "41001", 
            "46001","03001", "24001", "33001", 
            "07001", "22001", "44001", "45001", 
            "38001", "51001", "52001", "32001", 
            "40001", "26001", "19001", "34001",  
        };

        public CodigoPostal()
        {
            InitializeComponent();
            cbCodigoPostal.Items.AddRange(CodigosPostales.ToArray());
        }

        private void lbCodigoPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCodigoPostal.SelectedIndex != -1)
            {
                cbCodigoPostal.SelectedItem = lbCodigoPostal.SelectedItem;
                SelectedCodigoPostal = (string)lbCodigoPostal.SelectedItem;
            }
            else {
                SelectedCodigoPostal = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            if (string.IsNullOrWhiteSpace(codigo) || !Regex.IsMatch(codigo, @"\d{1,5}")) {
                MessageBox.Show("Código Postal no válido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                buscarCodigo();
            }
        }

        private void buscarCodigo()
        {
            filterCodigosPostales.Clear();

            foreach (var item in CodigosPostales)
            {
                if (item.Contains(textBox1.Text))
                {
                    filterCodigosPostales.Add(item);
                }
            }
            lbCodigoPostal.Items.Clear();
            lbCodigoPostal.Items.AddRange(filterCodigosPostales.ToArray());
        }

       
    }
}
