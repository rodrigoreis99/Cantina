namespace Cantina
{
    partial class frm_RelProdutos
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
            this.tbprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Rel_Produtos = new Cantina.DS_Rel_Produtos();
            this.tbprodutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_produtosTableAdapter = new Cantina.DS_Rel_ProdutosTableAdapters.tb_produtosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Rel_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbprodutosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cantina.Relatorios.Rel_produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dS_Rel_Produtos
            // 
            this.dS_Rel_Produtos.DataSetName = "DS_Rel_Produtos";
            this.dS_Rel_Produtos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbprodutosBindingSource1
            // 
            this.tbprodutosBindingSource1.DataMember = "tb_produtos";
            this.tbprodutosBindingSource1.DataSource = this.dS_Rel_Produtos;
            // 
            // tb_produtosTableAdapter
            // 
            this.tb_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frm_RelProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Rel_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tbprodutosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Rel_Produtos dS_Rel_Produtos;
        private System.Windows.Forms.BindingSource tbprodutosBindingSource1;
        private DS_Rel_ProdutosTableAdapters.tb_produtosTableAdapter tb_produtosTableAdapter;
    }
}