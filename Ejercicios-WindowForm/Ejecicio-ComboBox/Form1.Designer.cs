namespace Ejecicio_ComboBox
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
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.radioWindows = new System.Windows.Forms.RadioButton();
            this.radioLinux = new System.Windows.Forms.RadioButton();
            this.radioMac = new System.Windows.Forms.RadioButton();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.radioMac);
            this.gB1.Controls.Add(this.radioLinux);
            this.gB1.Controls.Add(this.radioWindows);
            this.gB1.Location = new System.Drawing.Point(55, 57);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(200, 166);
            this.gB1.TabIndex = 0;
            this.gB1.TabStop = false;
            this.gB1.Text = "Sistemas Operativos";
            // 
            // radioWindows
            // 
            this.radioWindows.AutoSize = true;
            this.radioWindows.Location = new System.Drawing.Point(25, 40);
            this.radioWindows.Name = "radioWindows";
            this.radioWindows.Size = new System.Drawing.Size(69, 17);
            this.radioWindows.TabIndex = 0;
            this.radioWindows.TabStop = true;
            this.radioWindows.Text = "Windows";
            this.radioWindows.UseVisualStyleBackColor = true;
            this.radioWindows.CheckedChanged += new System.EventHandler(this.radioWindows_CheckedChanged);
            // 
            // radioLinux
            // 
            this.radioLinux.AutoSize = true;
            this.radioLinux.Location = new System.Drawing.Point(25, 75);
            this.radioLinux.Name = "radioLinux";
            this.radioLinux.Size = new System.Drawing.Size(50, 17);
            this.radioLinux.TabIndex = 1;
            this.radioLinux.TabStop = true;
            this.radioLinux.Text = "Linux";
            this.radioLinux.UseVisualStyleBackColor = true;
            this.radioLinux.CheckedChanged += new System.EventHandler(this.radioLinux_CheckedChanged);
            // 
            // radioMac
            // 
            this.radioMac.AutoSize = true;
            this.radioMac.Location = new System.Drawing.Point(25, 108);
            this.radioMac.Name = "radioMac";
            this.radioMac.Size = new System.Drawing.Size(46, 17);
            this.radioMac.TabIndex = 2;
            this.radioMac.TabStop = true;
            this.radioMac.Text = "Mac";
            this.radioMac.UseVisualStyleBackColor = true;
            this.radioMac.CheckedChanged += new System.EventHandler(this.radioMac_CheckedChanged);
            // 
            // cB1
            // 
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(394, 132);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(295, 21);
            this.cB1.TabIndex = 1;
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Software Asociado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.gB1);
            this.Name = "Form1";
            this.Text = "Ejercicio 2: Enlace de Controles";
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.RadioButton radioMac;
        private System.Windows.Forms.RadioButton radioLinux;
        private System.Windows.Forms.RadioButton radioWindows;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Label label1;
    }
}

