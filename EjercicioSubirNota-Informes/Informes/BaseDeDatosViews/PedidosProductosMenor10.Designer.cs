﻿namespace Informes.BaseDeDatosViews
{
    partial class PedidosProductosMenor10
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferreteriaDataSet = new Informes.FerreteriaDataSet();
            this.pedidosMenor10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosMenor10TableAdapter = new Informes.FerreteriaDataSetTableAdapters.PedidosMenor10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosMenor10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Informes.Informes.PedidosMenor10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ferreteriaDataSet
            // 
            this.ferreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.ferreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosMenor10BindingSource
            // 
            this.pedidosMenor10BindingSource.DataMember = "PedidosMenor10";
            this.pedidosMenor10BindingSource.DataSource = this.ferreteriaDataSet;
            // 
            // pedidosMenor10TableAdapter
            // 
            this.pedidosMenor10TableAdapter.ClearBeforeFill = true;
            // 
            // PedidosProductosMenor10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosProductosMenor10";
            this.Text = "PedidosProductosMenor10";
            this.Load += new System.EventHandler(this.PedidosProductosMenor10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosMenor10BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FerreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource pedidosMenor10BindingSource;
        private FerreteriaDataSetTableAdapters.PedidosMenor10TableAdapter pedidosMenor10TableAdapter;
    }
}