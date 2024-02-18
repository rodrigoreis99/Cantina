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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.btn_CadastroCategoria = new System.Windows.Forms.Button();
            this.btn_cadastrarAluno = new System.Windows.Forms.Button();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem});
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
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Aluno";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos/Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriaToolStripMenuItem_Click);
            // 
            // btn_CadastrarProduto
            // 
            this.btn_CadastrarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarProduto.Image = global::Cantina.Properties.Resources.cad_produtos_40x40;
            this.btn_CadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadastrarProduto.Location = new System.Drawing.Point(114, 69);
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
            this.btn_CadastroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroCategoria.ForeColor = System.Drawing.Color.White;
            this.btn_CadastroCategoria.Image = global::Cantina.Properties.Resources.entrada_produtos_40x40;
            this.btn_CadastroCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadastroCategoria.Location = new System.Drawing.Point(22, 69);
            this.btn_CadastroCategoria.Name = "btn_CadastroCategoria";
            this.btn_CadastroCategoria.Size = new System.Drawing.Size(75, 77);
            this.btn_CadastroCategoria.TabIndex = 2;
            this.btn_CadastroCategoria.Text = "Cadastrar Categoria";
            this.btn_CadastroCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadastroCategoria.UseVisualStyleBackColor = false;
            this.btn_CadastroCategoria.Click += new System.EventHandler(this.btn_CadastroCategoria_Click);
            // 
            // btn_cadastrarAluno
            // 
            this.btn_cadastrarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrarAluno.Image = global::Cantina.Properties.Resources.cadastro_clientes_40_x_40;
            this.btn_cadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarAluno.Location = new System.Drawing.Point(22, 162);
            this.btn_cadastrarAluno.Name = "btn_cadastrarAluno";
            this.btn_cadastrarAluno.Size = new System.Drawing.Size(75, 77);
            this.btn_cadastrarAluno.TabIndex = 4;
            this.btn_cadastrarAluno.Text = "Cadastrar Aluno";
            this.btn_cadastrarAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrarAluno.UseVisualStyleBackColor = false;
            this.btn_cadastrarAluno.Click += new System.EventHandler(this.btn_cadastrarAluno_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cantina.Properties.Resources.fundo_sistema_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btn_cadastrarAluno);
            this.Controls.Add(this.btn_CadastrarProduto);
            this.Controls.Add(this.btn_CadastroCategoria);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

