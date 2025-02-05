namespace EjemploMDI_WF
{
    partial class Almazara
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAceitunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ventanaAceitunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip2;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarColorToolStripMenuItem,
            this.cambiarLetraToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(152, 48);
            // 
            // cambiarColorToolStripMenuItem
            // 
            this.cambiarColorToolStripMenuItem.Name = "cambiarColorToolStripMenuItem";
            this.cambiarColorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cambiarColorToolStripMenuItem.Text = "Cambiar Color";
            // 
            // cambiarLetraToolStripMenuItem
            // 
            this.cambiarLetraToolStripMenuItem.Name = "cambiarLetraToolStripMenuItem";
            this.cambiarLetraToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cambiarLetraToolStripMenuItem.Text = "Cambiar Letra";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeLaAplicacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirDeLaAplicacionToolStripMenuItem
            // 
            this.salirDeLaAplicacionToolStripMenuItem.Name = "salirDeLaAplicacionToolStripMenuItem";
            this.salirDeLaAplicacionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirDeLaAplicacionToolStripMenuItem.Text = "Salir de la Aplicacion";
            this.salirDeLaAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicacionToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoAceitunasToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.distribuciónToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // tipoAceitunasToolStripMenuItem
            // 
            this.tipoAceitunasToolStripMenuItem.Name = "tipoAceitunasToolStripMenuItem";
            this.tipoAceitunasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.tipoAceitunasToolStripMenuItem.Text = "Tipo Aceitunas (Ctrl + A)";
            this.tipoAceitunasToolStripMenuItem.Click += new System.EventHandler(this.tipoAceitunasToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.producciónToolStripMenuItem.Text = "Producción (Ctrl + P)";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // distribuciónToolStripMenuItem
            // 
            this.distribuciónToolStripMenuItem.Name = "distribuciónToolStripMenuItem";
            this.distribuciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.distribuciónToolStripMenuItem.Text = "Distribución";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaAceitunasToolStripMenuItem,
            this.ventanaProducciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // ventanaAceitunasToolStripMenuItem
            // 
            this.ventanaAceitunasToolStripMenuItem.Name = "ventanaAceitunasToolStripMenuItem";
            this.ventanaAceitunasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventanaAceitunasToolStripMenuItem.Text = "Ventana Aceitunas";
            this.ventanaAceitunasToolStripMenuItem.Click += new System.EventHandler(this.tipoAceitunasToolStripMenuItem_Click);
            // 
            // ventanaProducciónToolStripMenuItem
            // 
            this.ventanaProducciónToolStripMenuItem.Name = "ventanaProducciónToolStripMenuItem";
            this.ventanaProducciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventanaProducciónToolStripMenuItem.Text = "Ventana Producción";
            this.ventanaProducciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // Almazara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Almazara";
            this.Text = "Almazara de Lucena";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Almazara_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAceitunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanaAceitunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaProducciónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarLetraToolStripMenuItem;
    }
}

