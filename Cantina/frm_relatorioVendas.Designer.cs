namespace Cantina
{
    partial class frm_relatorioVendas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Relatorio_vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Completo = new Cantina.DS_Completo();
            this.button1 = new System.Windows.Forms.Button();
            this.mkb_dataInicio = new System.Windows.Forms.MaskedTextBox();
            this.mkb_dataFim = new System.Windows.Forms.MaskedTextBox();
            this.CB_aluno = new System.Windows.Forms.ComboBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.relatorio_vendasTableAdapter = new Cantina.DS_CompletoTableAdapters.Relatorio_vendasTableAdapter();
            this.relatoriovendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Completo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Relatorio_vendasBindingSource
            // 
            this.Relatorio_vendasBindingSource.DataMember = "Relatorio_vendas";
            this.Relatorio_vendasBindingSource.DataSource = this.dS_Completo;
            // 
            // dS_Completo
            // 
            this.dS_Completo.DataSetName = "DS_Completo";
            this.dS_Completo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(370, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Relatorio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mkb_dataInicio
            // 
            this.mkb_dataInicio.Location = new System.Drawing.Point(243, 12);
            this.mkb_dataInicio.Mask = "00/00/0000";
            this.mkb_dataInicio.Name = "mkb_dataInicio";
            this.mkb_dataInicio.Size = new System.Drawing.Size(92, 20);
            this.mkb_dataInicio.TabIndex = 1;
            this.mkb_dataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mkb_dataFim
            // 
            this.mkb_dataFim.Location = new System.Drawing.Point(368, 12);
            this.mkb_dataFim.Mask = "00/00/0000";
            this.mkb_dataFim.Name = "mkb_dataFim";
            this.mkb_dataFim.Size = new System.Drawing.Size(100, 20);
            this.mkb_dataFim.TabIndex = 2;
            this.mkb_dataFim.ValidatingType = typeof(System.DateTime);
            // 
            // CB_aluno
            // 
            this.CB_aluno.DataSource = this.alunoBindingSource;
            this.CB_aluno.DisplayMember = "Nome";
            this.CB_aluno.FormattingEnabled = true;
            this.CB_aluno.Location = new System.Drawing.Point(243, 38);
            this.CB_aluno.Name = "CB_aluno";
            this.CB_aluno.Size = new System.Drawing.Size(121, 21);
            this.CB_aluno.TabIndex = 3;
            this.CB_aluno.ValueMember = "Codigo";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(cantina.DAL.Aluno);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Até";
            // 
            // relatorio_vendasTableAdapter
            // 
            this.relatorio_vendasTableAdapter.ClearBeforeFill = true;
            // 
            // relatoriovendasBindingSource
            // 
            this.relatoriovendasBindingSource.DataMember = "Relatorio_vendas";
            this.relatoriovendasBindingSource.DataSource = this.dS_Completo;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(cantina.DAL.ContasReceber);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.RosyBrown;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Relatorio_vendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cantina.Relatorios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1030, 629);
            this.reportViewer1.TabIndex = 7;
            // 
            // frm_relatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_aluno);
            this.Controls.Add(this.mkb_dataFim);
            this.Controls.Add(this.mkb_dataInicio);
            this.Controls.Add(this.button1);
            this.Name = "frm_relatorioVendas";
            this.Text = "frm_relatorioVendas";
            this.Load += new System.EventHandler(this.frm_relatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Completo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mkb_dataInicio;
        private System.Windows.Forms.MaskedTextBox mkb_dataFim;
        private System.Windows.Forms.ComboBox CB_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DS_Completo dS_Completo;
        private DS_CompletoTableAdapters.Relatorio_vendasTableAdapter relatorio_vendasTableAdapter;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.BindingSource relatoriovendasBindingSource;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Relatorio_vendasBindingSource;
    }
}