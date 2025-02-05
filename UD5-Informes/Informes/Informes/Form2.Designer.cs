namespace Informes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lucenaBitDataSet = new LucenaBitDataSet();
            this.lucenaBitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosTableAdapter = new LucenaBitDataSetTableAdapters.ArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Articulos2DS";
            reportDataSource1.Value = this.articulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Informes.Informes.Articulos2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // lucenaBitDataSet
            // 
            this.lucenaBitDataSet.DataSetName = "LucenaBitDataSet";
            this.lucenaBitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lucenaBitDataSetBindingSource
            // 
            this.lucenaBitDataSetBindingSource.DataSource = this.lucenaBitDataSet;
            this.lucenaBitDataSetBindingSource.Position = 0;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "Articulos";
            this.articulosBindingSource.DataSource = this.lucenaBitDataSetBindingSource;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucenaBitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LucenaBitDataSet lucenaBitDataSet;
        private System.Windows.Forms.BindingSource lucenaBitDataSetBindingSource;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private LucenaBitDataSetTableAdapters.ArticulosTableAdapter articulosTableAdapter;
    }
}