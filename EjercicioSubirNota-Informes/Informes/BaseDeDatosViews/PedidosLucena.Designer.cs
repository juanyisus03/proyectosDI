namespace Informes.BaseDeDatosViews
{
    partial class PedidosLucena
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferreteriaDataSet = new Informes.FerreteriaDataSet();
            this.pedidosLucenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosLucenaTableAdapter = new Informes.FerreteriaDataSetTableAdapters.PedidosLucenaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosLucenaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PedidosLucenaDataSet";
            reportDataSource1.Value = this.pedidosLucenaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Informes.Informes.PedidosLucena.rdlc";
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
            // pedidosLucenaBindingSource
            // 
            this.pedidosLucenaBindingSource.DataMember = "PedidosLucena";
            this.pedidosLucenaBindingSource.DataSource = this.ferreteriaDataSet;
            // 
            // pedidosLucenaTableAdapter
            // 
            this.pedidosLucenaTableAdapter.ClearBeforeFill = true;
            // 
            // PedidosLucena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosLucena";
            this.Text = "PedidosLucena";
            this.Load += new System.EventHandler(this.PedidosLucena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosLucenaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FerreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource pedidosLucenaBindingSource;
        private FerreteriaDataSetTableAdapters.PedidosLucenaTableAdapter pedidosLucenaTableAdapter;
    }
}