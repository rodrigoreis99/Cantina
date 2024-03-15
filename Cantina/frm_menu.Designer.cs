namespace Cantina
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_relatorioVendas = new System.Windows.Forms.Button();
            this.btn_ConsultaProduto = new System.Windows.Forms.Button();
            this.btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.btn_CadastroCategoria = new System.Windows.Forms.Button();
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_cadastrarAluno = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.categoriaToolStripMenuItem1,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::Cantina.Properties.Resources.add_16;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Aluno";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::Cantina.Properties.Resources.Search_Globe64;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos/Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Image = global::Cantina.Properties.Resources.money_40x40;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Image = global::Cantina.Properties.Resources.align_center_16;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantina da tia Dora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cantina.Properties.Resources.dora37_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_relatorioVendas);
            this.panel2.Controls.Add(this.btn_ConsultaProduto);
            this.panel2.Controls.Add(this.btn_CadastrarProduto);
            this.panel2.Controls.Add(this.btn_CadastroCategoria);
            this.panel2.Controls.Add(this.btn_venda);
            this.panel2.Controls.Add(this.btn_cadastrarAluno);
            this.panel2.Location = new System.Drawing.Point(227, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 210);
            this.panel2.TabIndex = 7;
            // 
            // btn_relatorioVendas
            // 
            this.btn_relatorioVendas.BackColor = System.Drawing.Color.Transparent;
            this.btn_relatorioVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorioVendas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_relatorioVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_relatorioVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorioVendas.ForeColor = System.Drawing.Color.White;
            this.btn_relatorioVendas.Image = global::Cantina.Properties.Resources.look_view_format_target_document_scope_vision_icon_261579;
            this.btn_relatorioVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_relatorioVendas.Location = new System.Drawing.Point(205, 116);
            this.btn_relatorioVendas.Name = "btn_relatorioVendas";
            this.btn_relatorioVendas.Size = new System.Drawing.Size(75, 77);
            this.btn_relatorioVendas.TabIndex = 7;
            this.btn_relatorioVendas.Text = "Relatório vendas";
            this.btn_relatorioVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_relatorioVendas.UseVisualStyleBackColor = false;
            this.btn_relatorioVendas.Click += new System.EventHandler(this.btn_relatorioVendas_Click);
            // 
            // btn_ConsultaProduto
            // 
            this.btn_ConsultaProduto.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConsultaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultaProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ConsultaProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ConsultaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultaProduto.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultaProduto.Image = global::Cantina.Properties.Resources.search_icon_259672;
            this.btn_ConsultaProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ConsultaProduto.Location = new System.Drawing.Point(23, 116);
            this.btn_ConsultaProduto.Name = "btn_ConsultaProduto";
            this.btn_ConsultaProduto.Size = new System.Drawing.Size(75, 77);
            this.btn_ConsultaProduto.TabIndex = 6;
            this.btn_ConsultaProduto.Text = "Consultar Produto";
            this.btn_ConsultaProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConsultaProduto.UseVisualStyleBackColor = false;
            this.btn_ConsultaProduto.Click += new System.EventHandler(this.btn_ConsultaProduto_Click);
            // 
            // btn_CadastrarProduto
            // 
            this.btn_CadastrarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadastrarProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CadastrarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarProduto.Image = global::Cantina.Properties.Resources.online_ecommerce_buy_bag_cart_basket_shopping_icon_261680__1_;
            this.btn_CadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadastrarProduto.Location = new System.Drawing.Point(115, 23);
            this.btn_CadastrarProduto.Name = "btn_CadastrarProduto";
            this.btn_CadastrarProduto.Size = new System.Drawing.Size(75, 77);
            this.btn_CadastrarProduto.TabIndex = 3;
            this.btn_CadastrarProduto.Text = "Cadastrar Produto";
            this.btn_CadastrarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadastrarProduto.UseVisualStyleBackColor = false;
            this.btn_CadastrarProduto.Click += new System.EventHandler(this.btn_CadastrarProduto_Click);
            // 
            // btn_CadastroCategoria
            // 
            this.btn_CadastroCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadastroCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CadastroCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadastroCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CadastroCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_CadastroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroCategoria.ForeColor = System.Drawing.Color.White;
            this.btn_CadastroCategoria.Image = global::Cantina.Properties.Resources.bag_icon_259652;
            this.btn_CadastroCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadastroCategoria.Location = new System.Drawing.Point(23, 23);
            this.btn_CadastroCategoria.Name = "btn_CadastroCategoria";
            this.btn_CadastroCategoria.Size = new System.Drawing.Size(75, 77);
            this.btn_CadastroCategoria.TabIndex = 2;
            this.btn_CadastroCategoria.Text = "Cadastrar Categoria";
            this.btn_CadastroCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadastroCategoria.UseVisualStyleBackColor = false;
            this.btn_CadastroCategoria.Click += new System.EventHandler(this.btn_CadastroCategoria_Click);
            // 
            // btn_venda
            // 
            this.btn_venda.BackColor = System.Drawing.Color.Transparent;
            this.btn_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_venda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venda.ForeColor = System.Drawing.Color.White;
            this.btn_venda.Image = global::Cantina.Properties.Resources.dollar_money_icon_259677;
            this.btn_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_venda.Location = new System.Drawing.Point(115, 116);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(75, 77);
            this.btn_venda.TabIndex = 5;
            this.btn_venda.Text = "Nova Venda";
            this.btn_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_venda.UseVisualStyleBackColor = false;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_cadastrarAluno
            // 
            this.btn_cadastrarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrarAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrarAluno.Image = global::Cantina.Properties.Resources.demographics_audience_customer_segmentation_market_research_profiling_customer_personas_icon_260963;
            this.btn_cadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarAluno.Location = new System.Drawing.Point(205, 23);
            this.btn_cadastrarAluno.Name = "btn_cadastrarAluno";
            this.btn_cadastrarAluno.Size = new System.Drawing.Size(75, 77);
            this.btn_cadastrarAluno.TabIndex = 4;
            this.btn_cadastrarAluno.Text = "Cadastrar Aluno";
            this.btn_cadastrarAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrarAluno.UseVisualStyleBackColor = false;
            this.btn_cadastrarAluno.Click += new System.EventHandler(this.btn_cadastrarAluno_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Button btn_CadastrarProduto;
        private System.Windows.Forms.Button btn_CadastroCategoria;
        private System.Windows.Forms.Button btn_cadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ConsultaProduto;
        private System.Windows.Forms.Button btn_relatorioVendas;
    }
}

