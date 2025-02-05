namespace Ejercicios_WindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasAncho = new System.Windows.Forms.Button();
            this.btnMasAlto = new System.Windows.Forms.Button();
            this.btnMenosAncho = new System.Windows.Forms.Button();
            this.btnMenosAlto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbajo);
            this.panel1.Controls.Add(this.btnDerecha);
            this.panel1.Controls.Add(this.btnIzquierda);
            this.panel1.Controls.Add(this.btnArriba);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 142);
            this.panel1.TabIndex = 0;
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(78, 92);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 3;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(131, 63);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(20, 63);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 1;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(78, 34);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenosAlto);
            this.panel2.Controls.Add(this.btnMenosAncho);
            this.panel2.Controls.Add(this.btnMasAlto);
            this.panel2.Controls.Add(this.btnMasAncho);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(256, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 141);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancho :";
            // 
            // btnMasAncho
            // 
            this.btnMasAncho.Location = new System.Drawing.Point(72, 34);
            this.btnMasAncho.Name = "btnMasAncho";
            this.btnMasAncho.Size = new System.Drawing.Size(31, 23);
            this.btnMasAncho.TabIndex = 2;
            this.btnMasAncho.Text = "+";
            this.btnMasAncho.UseVisualStyleBackColor = true;
            this.btnMasAncho.Click += new System.EventHandler(this.btnMasAncho_Click);
            // 
            // btnMasAlto
            // 
            this.btnMasAlto.Location = new System.Drawing.Point(72, 68);
            this.btnMasAlto.Name = "btnMasAlto";
            this.btnMasAlto.Size = new System.Drawing.Size(31, 23);
            this.btnMasAlto.TabIndex = 3;
            this.btnMasAlto.Text = "+";
            this.btnMasAlto.UseVisualStyleBackColor = true;
            this.btnMasAlto.Click += new System.EventHandler(this.btnMasAlto_Click);
            // 
            // btnMenosAncho
            // 
            this.btnMenosAncho.Location = new System.Drawing.Point(133, 33);
            this.btnMenosAncho.Name = "btnMenosAncho";
            this.btnMenosAncho.Size = new System.Drawing.Size(33, 23);
            this.btnMenosAncho.TabIndex = 4;
            this.btnMenosAncho.Text = "-";
            this.btnMenosAncho.UseVisualStyleBackColor = true;
            this.btnMenosAncho.Click += new System.EventHandler(this.btnMenosAncho_Click);
            // 
            // btnMenosAlto
            // 
            this.btnMenosAlto.Location = new System.Drawing.Point(133, 68);
            this.btnMenosAlto.Name = "btnMenosAlto";
            this.btnMenosAlto.Size = new System.Drawing.Size(33, 23);
            this.btnMenosAlto.TabIndex = 5;
            this.btnMenosAlto.Text = "-";
            this.btnMenosAlto.UseVisualStyleBackColor = true;
            this.btnMenosAlto.Click += new System.EventHandler(this.btnMenosAlto_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(19, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 234);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\usuario\\Downloads\\cesped.jpg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 01: Posición y Tamaño";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenosAlto;
        private System.Windows.Forms.Button btnMenosAncho;
        private System.Windows.Forms.Button btnMasAlto;
        private System.Windows.Forms.Button btnMasAncho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

