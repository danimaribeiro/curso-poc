namespace Poc.Pedidos
{
    partial class RelatorioPedidos
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
            this.PedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pocDataSet = new Poc.Pedidos.pocDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PedidosTableAdapter = new Poc.Pedidos.pocDataSetTableAdapters.PedidosTableAdapter();
            this.pocDataSet1 = new Poc.Pedidos.pocDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosBindingSource
            // 
            this.PedidosBindingSource.DataMember = "Pedidos";
            this.PedidosBindingSource.DataSource = this.pocDataSet;
            // 
            // pocDataSet
            // 
            this.pocDataSet.DataSetName = "pocDataSet";
            this.pocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Poc.Pedidos.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(808, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // PedidosTableAdapter
            // 
            this.PedidosTableAdapter.ClearBeforeFill = true;
            // 
            // pocDataSet1
            // 
            this.pocDataSet1.DataSetName = "pocDataSet1";
            this.pocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioPedidos";
            this.Text = "RelatorioPedidos";
            this.Load += new System.EventHandler(this.RelatorioPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PedidosBindingSource;
        private pocDataSet pocDataSet;
        private pocDataSetTableAdapters.PedidosTableAdapter PedidosTableAdapter;
        private pocDataSet1 pocDataSet1;
    }
}