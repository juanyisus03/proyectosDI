﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.Informes
{
    public partial class InformePerifecos : Form
    {
        public InformePerifecos()
        {
            InitializeComponent();
        }

        private void InformePerifecos_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
