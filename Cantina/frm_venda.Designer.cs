namespace Cantina
{
    partial class frm_venda
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
            System.Windows.Forms.Label codigoAlunoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label serieLabel;
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_aluno = new System.Windows.Forms.ComboBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novaVenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_novoItem = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.CB_produto = new System.Windows.Forms.ComboBox();
            this.itensVEndaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.btn_finalizarVenda = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_finalizarPedido = new System.Windows.Forms.Button();
            this.txt_valorPago = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.DG_vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_serie = new System.Windows.Forms.Label();
            codigoAlunoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVEndaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoAlunoLabel
            // 
            codigoAlunoLabel.AutoSize = true;
            codigoAlunoLabel.Location = new System.Drawing.Point(137, 29);
            codigoAlunoLabel.Name = "codigoAlunoLabel";
            codigoAlunoLabel.Size = new System.Drawing.Size(83, 13);
            codigoAlunoLabel.TabIndex = 1;
            codigoAlunoLabel.Text = "Nome do Aluno:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(155, 520);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 10;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(133, 547);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 12;
            descontoLabel.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(128, 576);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(61, 13);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "Valor Total:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(409, 516);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(61, 13);
            codigoStatusLabel.TabIndex = 19;
            codigoStatusLabel.Text = "Forma Pgto";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(409, 551);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataVencimentoLabel.TabIndex = 21;
            dataVencimentoLabel.Text = "Data Vencimento:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(13, 63);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 17;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(13, 122);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 15;
            valorLabel.Text = "Valor:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(13, 92);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 12;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(13, 32);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 10;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(cantina.DAL.Venda);
            // 
            // CB_aluno
            // 
            this.CB_aluno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoAluno", true));
            this.CB_aluno.DataSource = this.alunoBindingSource;
            this.CB_aluno.DisplayMember = "Nome";
            this.CB_aluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_aluno.FormattingEnabled = true;
            this.CB_aluno.Location = new System.Drawing.Point(233, 26);
            this.CB_aluno.Name = "CB_aluno";
            this.CB_aluno.Size = new System.Drawing.Size(121, 21);
            this.CB_aluno.TabIndex = 2;
            this.CB_aluno.ValueMember = "Codigo";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(cantina.DAL.Aluno);
            // 
            // btn_novaVenda
            // 
            this.btn_novaVenda.Location = new System.Drawing.Point(461, 26);
            this.btn_novaVenda.Name = "btn_novaVenda";
            this.btn_novaVenda.Size = new System.Drawing.Size(75, 23);
            this.btn_novaVenda.TabIndex = 3;
            this.btn_novaVenda.Text = "Nova Venda";
            this.btn_novaVenda.UseVisualStyleBackColor = true;
            this.btn_novaVenda.Click += new System.EventHandler(this.btn_novaVenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_novoItem);
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(dataVencimentoLabel);
            this.groupBox1.Controls.Add(this.CB_produto);
            this.groupBox1.Controls.Add(this.txt_dataVencimento);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.CB_pgto);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.btn_finalizarVenda);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.btn_finalizarPedido);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(this.txt_valorPago);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.DG_vendas);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 618);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // btn_novoItem
            // 
            this.btn_novoItem.Location = new System.Drawing.Point(227, 116);
            this.btn_novoItem.Name = "btn_novoItem";
            this.btn_novoItem.Size = new System.Drawing.Size(75, 23);
            this.btn_novoItem.TabIndex = 13;
            this.btn_novoItem.Text = "Novo Item";
            this.btn_novoItem.UseVisualStyleBackColor = true;
            this.btn_novoItem.Click += new System.EventHandler(this.btn_novoItem_Click_1);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(507, 573);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(105, 23);
            this.btn_finalizar.TabIndex = 23;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // CB_produto
            // 
            this.CB_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVEndaBindingSource, "CodigoProduto", true));
            this.CB_produto.DataSource = this.produtoBindingSource;
            this.CB_produto.DisplayMember = "Descricao";
            this.CB_produto.FormattingEnabled = true;
            this.CB_produto.Location = new System.Drawing.Point(102, 55);
            this.CB_produto.Name = "CB_produto";
            this.CB_produto.Size = new System.Drawing.Size(100, 21);
            this.CB_produto.TabIndex = 18;
            this.CB_produto.ValueMember = "Codigo";
            this.CB_produto.SelectedIndexChanged += new System.EventHandler(this.CB_produto_SelectedIndexChanged);
            // 
            // itensVEndaBindingSource
            // 
            this.itensVEndaBindingSource.DataSource = typeof(cantina.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(cantina.DAL.Produto);
            // 
            // txt_dataVencimento
            // 
            this.txt_dataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataVencimento", true));
            this.txt_dataVencimento.Location = new System.Drawing.Point(507, 547);
            this.txt_dataVencimento.Name = "txt_dataVencimento";
            this.txt_dataVencimento.Size = new System.Drawing.Size(105, 20);
            this.txt_dataVencimento.TabIndex = 22;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(cantina.DAL.ContasReceber);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(102, 119);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 16;
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CodigoStatus", true));
            this.CB_pgto.DataSource = this.statusPagamentoBindingSource;
            this.CB_pgto.DisplayMember = "Status";
            this.CB_pgto.Enabled = false;
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Location = new System.Drawing.Point(491, 513);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(121, 21);
            this.CB_pgto.TabIndex = 20;
            this.CB_pgto.ValueMember = "Codigo";
            this.CB_pgto.SelectedIndexChanged += new System.EventHandler(this.CB_pgto_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(cantina.DAL.StatusPagamento);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(16, 571);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(105, 23);
            this.btn_imprimir.TabIndex = 18;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVEndaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(102, 85);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 14;
            // 
            // btn_finalizarVenda
            // 
            this.btn_finalizarVenda.Enabled = false;
            this.btn_finalizarVenda.Location = new System.Drawing.Point(16, 542);
            this.btn_finalizarVenda.Name = "btn_finalizarVenda";
            this.btn_finalizarVenda.Size = new System.Drawing.Size(106, 23);
            this.btn_finalizarVenda.TabIndex = 17;
            this.btn_finalizarVenda.Text = "Finalizar Venda";
            this.btn_finalizarVenda.UseVisualStyleBackColor = true;
            this.btn_finalizarVenda.Click += new System.EventHandler(this.btn_finalizarVenda_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_codigo.Location = new System.Drawing.Point(102, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 11;
            // 
            // btn_finalizarPedido
            // 
            this.btn_finalizarPedido.Location = new System.Drawing.Point(16, 515);
            this.btn_finalizarPedido.Name = "btn_finalizarPedido";
            this.btn_finalizarPedido.Size = new System.Drawing.Size(106, 23);
            this.btn_finalizarPedido.TabIndex = 16;
            this.btn_finalizarPedido.Text = "Finalizar Pedido";
            this.btn_finalizarPedido.UseVisualStyleBackColor = true;
            this.btn_finalizarPedido.Click += new System.EventHandler(this.btn_finalizarPedido_Click);
            // 
            // txt_valorPago
            // 
            this.txt_valorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valorPago.Location = new System.Drawing.Point(196, 573);
            this.txt_valorPago.Name = "txt_valorPago";
            this.txt_valorPago.ReadOnly = true;
            this.txt_valorPago.Size = new System.Drawing.Size(100, 20);
            this.txt_valorPago.TabIndex = 15;
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(195, 544);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 13;
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_valor.Location = new System.Drawing.Point(195, 513);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 11;
            // 
            // DG_vendas
            // 
            this.DG_vendas.AllowUserToAddRows = false;
            this.DG_vendas.AllowUserToDeleteRows = false;
            this.DG_vendas.AutoGenerateColumns = false;
            this.DG_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.valorTotal});
            this.DG_vendas.DataSource = this.itensVEndaBindingSource;
            this.DG_vendas.Location = new System.Drawing.Point(16, 183);
            this.DG_vendas.Name = "DG_vendas";
            this.DG_vendas.ReadOnly = true;
            this.DG_vendas.Size = new System.Drawing.Size(596, 316);
            this.DG_vendas.TabIndex = 8;
            this.DG_vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // valorTotal
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(367, 29);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(34, 13);
            serieLabel.TabIndex = 4;
            serieLabel.Text = "Serie:";
            // 
            // lbl_serie
            // 
            this.lbl_serie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Serie", true));
            this.lbl_serie.Location = new System.Drawing.Point(407, 29);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(48, 23);
            this.lbl_serie.TabIndex = 5;
            this.lbl_serie.Text = "label1";
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 691);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.lbl_serie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_novaVenda);
            this.Controls.Add(codigoAlunoLabel);
            this.Controls.Add(this.CB_aluno);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVEndaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_aluno;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button btn_novaVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVEndaBindingSource;
        private System.Windows.Forms.DataGridView DG_vendas;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.TextBox txt_valorPago;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finalizarVenda;
        private System.Windows.Forms.Button btn_finalizarPedido;
        private System.Windows.Forms.ComboBox CB_pgto;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker txt_dataVencimento;
        private System.Windows.Forms.Button btn_novoItem;
        private System.Windows.Forms.ComboBox CB_produto;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_serie;
    }
}