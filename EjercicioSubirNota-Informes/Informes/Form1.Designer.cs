namespace Informes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeAntequeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDeClientesDeLucenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.pepidosToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pepidosToolStripMenuItem
            // 
            this.pepidosToolStripMenuItem.Name = "pepidosToolStripMenuItem";
            this.pepidosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pepidosToolStripMenuItem.Text = "Pedidos";
            this.pepidosToolStripMenuItem.Click += new System.EventHandler(this.pepidosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesDeAntequeraToolStripMenuItem,
            this.pedidosDeClientesDeLucenaToolStripMenuItem,
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem,
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem,
            this.productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // clientesDeAntequeraToolStripMenuItem
            // 
            this.clientesDeAntequeraToolStripMenuItem.Name = "clientesDeAntequeraToolStripMenuItem";
            this.clientesDeAntequeraToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.clientesDeAntequeraToolStripMenuItem.Text = "Clientes de Antequera";
            this.clientesDeAntequeraToolStripMenuItem.Click += new System.EventHandler(this.clientesDeAntequeraToolStripMenuItem_Click);
            // 
            // pedidosDeClientesDeLucenaToolStripMenuItem
            // 
            this.pedidosDeClientesDeLucenaToolStripMenuItem.Name = "pedidosDeClientesDeLucenaToolStripMenuItem";
            this.pedidosDeClientesDeLucenaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.pedidosDeClientesDeLucenaToolStripMenuItem.Text = "Pedidos de Clientes de Lucena";
            this.pedidosDeClientesDeLucenaToolStripMenuItem.Click += new System.EventHandler(this.pedidosDeClientesDeLucenaToolStripMenuItem_Click);
            // 
            // pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem
            // 
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem.Name = "pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem";
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem.Text = "Pedidos Productos de la Categoria Adhesivos";
            this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem.Click += new System.EventHandler(this.pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem_Click);
            // 
            // pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem
            // 
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem.Name = "pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem";
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem.Text = "Pedidos cuya cantidad sean menor de 10";
            this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem.Click += new System.EventHandler(this.pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem_Click);
            // 
            // productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem
            // 
            this.productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem.Name = "productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem";
            this.productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem.Text = "Productos con precio mayor de 50 y stock mayor a 15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeAntequeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeClientesDeLucenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosProductosDeLaCategoriaAdhesivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosCuyaCantidadSeanMenorDe10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosConPrecioMayorDe50YStockMayorA15ToolStripMenuItem;
    }
}

