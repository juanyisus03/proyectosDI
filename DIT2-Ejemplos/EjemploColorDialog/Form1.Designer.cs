namespace EjemploColorDialog
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnVentana = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(193, 79);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(465, 37);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Ejemplo Ventana ColorDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVentana);
            this.groupBox1.Controls.Add(this.btnPanel);
            this.groupBox1.Location = new System.Drawing.Point(138, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadro de Dialogo";
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(51, 47);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(75, 23);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.Text = "Color Panel";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnVentana
            // 
            this.btnVentana.Location = new System.Drawing.Point(271, 46);
            this.btnVentana.Name = "btnVentana";
            this.btnVentana.Size = new System.Drawing.Size(107, 23);
            this.btnVentana.TabIndex = 1;
            this.btnVentana.Text = "Color Ventana";
            this.btnVentana.UseVisualStyleBackColor = true;
            this.btnVentana.Click += new System.EventHandler(this.btnVentana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVentana;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

