using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicio_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWindows.Checked) {
                cB1.Items.Clear();
                cB1.Text = "";
                cB1.Items.AddRange(new string[] { "MS Office", "MS Visual Studio", "MS Dynamics" });
            }
            else
            {
                cB1.Items.Clear();
            }
        }

        private void radioLinux_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLinux.Checked)
            {
                cB1.Items.Clear();
                cB1.Text = "";
                cB1.Items.AddRange(new string[] { "Libre Office", "GNU GCC", "Apache" });
            }
            else
            {
                cB1.Items.Clear();
            }
        }

        private void radioMac_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMac.Checked)
            {
                cB1.Items.Clear();
                cB1.Text = "";
                cB1.Items.AddRange(new string[] { "iWork", "Xcode", "Light Speed" });
            }
            else
            {
                cB1.Items.Clear();
            }
        }

        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Has seleccionado " + (radioLinux.Checked ? "Linux" : radioMac.Checked ? "Mac" : "Windows") + " con el software " + cB1.SelectedItem.ToString(),"Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
