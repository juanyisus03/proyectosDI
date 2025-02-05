namespace EjermploBBDD
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucenaBitDataSet = new EjermploBBDD.LucenaBitDataSet();
            this.articulosTableAdapter = new EjermploBBDD.LucenaBitDataSetTableAdapters.ArticulosTableAdapter();
            this.dgvArticulosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArticulosNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArticulosPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArticulosCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArticulosCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tienda LucenaBit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(579, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(333, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(120, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Añadir Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvArticulosId,
            this.dgvArticulosNombre,
            this.dgvArticulosPrecio,
            this.dgvArticulosCategoria,
            this.dgvArticulosCantidad});
            this.dataGridView1.DataSource = this.articulosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 250);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "Articulos";
            this.articulosBindingSource.DataSource = this.lucenaBitDataSet;
            // 
            // lucenaBitDataSet
            // 
            this.lucenaBitDataSet.DataSetName = "LucenaBitDataSet";
            this.lucenaBitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // dgvArticulosId
            // 
            this.dgvArticulosId.DataPropertyName = "Id";
            this.dgvArticulosId.HeaderText = "Id";
            this.dgvArticulosId.Name = "dgvArticulosId";
            this.dgvArticulosId.ReadOnly = true;
            // 
            // dgvArticulosNombre
            // 
            this.dgvArticulosNombre.DataPropertyName = "Nombre";
            this.dgvArticulosNombre.HeaderText = "Nombre";
            this.dgvArticulosNombre.Name = "dgvArticulosNombre";
            // 
            // dgvArticulosPrecio
            // 
            this.dgvArticulosPrecio.DataPropertyName = "Precio";
            this.dgvArticulosPrecio.HeaderText = "Precio";
            this.dgvArticulosPrecio.Name = "dgvArticulosPrecio";
            // 
            // dgvArticulosCategoria
            // 
            this.dgvArticulosCategoria.DataPropertyName = "Categoria";
            this.dgvArticulosCategoria.HeaderText = "Categoria";
            this.dgvArticulosCategoria.Name = "dgvArticulosCategoria";
            // 
            // dgvArticulosCantidad
            // 
            this.dgvArticulosCantidad.DataPropertyName = "Cantidad";
            this.dgvArticulosCantidad.HeaderText = "Cantidad";
            this.dgvArticulosCantidad.Name = "dgvArticulosCantidad";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "LucenaBit";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LucenaBitDataSet lucenaBitDataSet;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private LucenaBitDataSetTableAdapters.ArticulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArticulosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArticulosNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArticulosPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArticulosCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArticulosCantidad;
    }
}

