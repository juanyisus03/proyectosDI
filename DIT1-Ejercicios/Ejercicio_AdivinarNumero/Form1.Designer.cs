namespace Ejercicio_AdivinarNumero
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
            this.components = new System.ComponentModel.Container();
            this.pn1 = new System.Windows.Forms.Panel();
            this.numBuscado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pn2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numComprobar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.numBuscado);
            this.pn1.Controls.Add(this.label2);
            this.pn1.Controls.Add(this.label1);
            this.pn1.Controls.Add(this.button1);
            this.pn1.Location = new System.Drawing.Point(43, 35);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(294, 244);
            this.pn1.TabIndex = 0;
            // 
            // numBuscado
            // 
            this.numBuscado.Location = new System.Drawing.Point(163, 94);
            this.numBuscado.Name = "numBuscado";
            this.numBuscado.PasswordChar = '*';
            this.numBuscado.Size = new System.Drawing.Size(100, 20);
            this.numBuscado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numeros Secreto (0-100)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comenzar Juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.label5);
            this.pn2.Controls.Add(this.numComprobar);
            this.pn2.Controls.Add(this.label3);
            this.pn2.Controls.Add(this.label4);
            this.pn2.Controls.Add(this.btnComprobar);
            this.pn2.Location = new System.Drawing.Point(361, 35);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(294, 244);
            this.pn2.TabIndex = 4;
            this.pn2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numeros de Intentos: ";
            // 
            // numComprobar
            // 
            this.numComprobar.Location = new System.Drawing.Point(145, 104);
            this.numComprobar.Name = "numComprobar";
            this.numComprobar.PasswordChar = '*';
            this.numComprobar.Size = new System.Drawing.Size(100, 20);
            this.numComprobar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Introduzca numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jugador 2";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(31, 142);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(112, 23);
            this.btnComprobar.TabIndex = 0;
            this.btnComprobar.Text = "Comprobar numero";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numBuscado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.TextBox numComprobar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label5;
    }
}

