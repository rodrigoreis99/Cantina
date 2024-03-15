namespace Cantina
{
    partial class frm_consultaProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.CB_categoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(cantina.DAL.Produto);
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(101, 114);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.Size = new System.Drawing.Size(445, 220);
            this.produtoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Location = new System.Drawing.Point(109, 58);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(53, 13);
            this.lbl_pesquisar.TabIndex = 2;
            this.lbl_pesquisar.Text = "Pesquisar";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pesquisar.Location = new System.Drawing.Point(471, 48);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // CB_categoria
            // 
            this.CB_categoria.DataSource = this.categoriaBindingSource;
            this.CB_categoria.DisplayMember = "Descricao";
            this.CB_categoria.FormattingEnabled = true;
            this.CB_categoria.Location = new System.Drawing.Point(169, 49);
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(296, 21);
            this.CB_categoria.TabIndex = 1;
            this.CB_categoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(cantina.DAL.Categoria);
            // 
            // frm_consultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(688, 420);
            this.Controls.Add(this.CB_categoria);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.produtoDataGridView);
            this.Name = "frm_consultaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtos e Categorias";
            this.Load += new System.EventHandler(this.frm_consultaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.ComboBox CB_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}