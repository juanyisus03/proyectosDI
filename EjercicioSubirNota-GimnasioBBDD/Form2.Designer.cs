using System;

namespace Ejercicio_SubirNota_Gim
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbCiudades = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.gimnasioDataSet = new Ejercicio_SubirNota_Gim.GimnasioDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Ejercicio_SubirNota_Gim.GimnasioDataSetTableAdapters.ClientesTableAdapter();
            this.dgvClienteCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClienteApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClienteFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClienteCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClienteTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataFechaNac);
            this.groupBox1.Controls.Add(this.cbCiudades);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 19);
            this.button5.TabIndex = 18;
            this.button5.Text = "Guardar JSON";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 19);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cargar JSON";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 19);
            this.button3.TabIndex = 16;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 19);
            this.button2.TabIndex = 15;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataFechaNac
            // 
            this.dataFechaNac.CustomFormat = "";
            this.dataFechaNac.Location = new System.Drawing.Point(75, 155);
            this.dataFechaNac.Name = "dataFechaNac";
            this.dataFechaNac.Size = new System.Drawing.Size(198, 20);
            this.dataFechaNac.TabIndex = 13;
            // 
            // cbCiudades
            // 
            this.cbCiudades.FormattingEnabled = true;
            this.cbCiudades.Location = new System.Drawing.Point(72, 200);
            this.cbCiudades.Name = "cbCiudades";
            this.cbCiudades.Size = new System.Drawing.Size(201, 21);
            this.cbCiudades.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 238);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Nac:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(75, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(198, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // dataClientes
            // 
            this.dataClientes.AutoGenerateColumns = false;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClienteCodigo,
            this.dgvClienteNombre,
            this.dgvClienteApellidos,
            this.dgvClienteFecha,
            this.dgvClienteCiudad,
            this.dgvClienteTelefono});
            this.dataClientes.DataSource = this.clientesBindingSource;
            this.dataClientes.Location = new System.Drawing.Point(11, 296);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(737, 149);
            this.dataClientes.TabIndex = 1;
            this.dataClientes.Click += new System.EventHandler(this.dataClientes_OnClick);
            // 
            // gimnasioDataSet
            // 
            this.gimnasioDataSet.DataSetName = "GimnasioDataSet";
            this.gimnasioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gimnasioDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvClienteCodigo
            // 
            this.dgvClienteCodigo.DataPropertyName = "CodigoCliente";
            this.dgvClienteCodigo.HeaderText = "CodigoCliente";
            this.dgvClienteCodigo.Name = "dgvClienteCodigo";
            this.dgvClienteCodigo.ReadOnly = true;
            // 
            // dgvClienteNombre
            // 
            this.dgvClienteNombre.DataPropertyName = "NombreCliente";
            this.dgvClienteNombre.HeaderText = "NombreCliente";
            this.dgvClienteNombre.Name = "dgvClienteNombre";
            this.dgvClienteNombre.ReadOnly = true;
            // 
            // dgvClienteApellidos
            // 
            this.dgvClienteApellidos.DataPropertyName = "ApellidosCliente";
            this.dgvClienteApellidos.HeaderText = "ApellidosCliente";
            this.dgvClienteApellidos.Name = "dgvClienteApellidos";
            this.dgvClienteApellidos.ReadOnly = true;
            // 
            // dgvClienteFecha
            // 
            this.dgvClienteFecha.DataPropertyName = "FechaNacimiento";
            this.dgvClienteFecha.HeaderText = "FechaNacimiento";
            this.dgvClienteFecha.Name = "dgvClienteFecha";
            this.dgvClienteFecha.ReadOnly = true;
            // 
            // dgvClienteCiudad
            // 
            this.dgvClienteCiudad.DataPropertyName = "Ciudad";
            this.dgvClienteCiudad.HeaderText = "Ciudad";
            this.dgvClienteCiudad.Name = "dgvClienteCiudad";
            this.dgvClienteCiudad.ReadOnly = true;
            // 
            // dgvClienteTelefono
            // 
            this.dgvClienteTelefono.DataPropertyName = "Telefono";
            this.dgvClienteTelefono.HeaderText = "Telefono";
            this.dgvClienteTelefono.Name = "dgvClienteTelefono";
            this.dgvClienteTelefono.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 456);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Gestion Clientes Gimnasio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClose);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.ComboBox cbCiudades;
        private System.Windows.Forms.DateTimePicker dataFechaNac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private GimnasioDataSet gimnasioDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GimnasioDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClienteTelefono;
    }
}