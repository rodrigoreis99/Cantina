using cantina.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }
        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.Size = new Size(704, 92);
            this.alunoBindingSource.DataSource = DataContextFactory.DataContext.Aluno;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            this.vendaBindingSource.AddNew();
        }
        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }
        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVEndaBindingSource.Current;
            }
        }
        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }
        private void btn_novaVenda_Click(object sender, EventArgs e)
        {
            this.Size = new Size(704,719);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novaVenda.Enabled = false;

            this.itensVEndaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();
            CB_aluno.Enabled = false;
        }
        private void NovoItem()
        {
            this.itensVEndaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }
        private void btn_novoItem_Click_1(object sender, EventArgs e)
        {
            this.itensVEndaBindingSource.EndEdit();
            DG_vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }
        private void DG_vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }
        private void CB_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_produto.SelectedItem != null)
            {
                var pro = (Produto)CB_produto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }
        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in DG_vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.Valor = total;
        }
        private void btn_finalizarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o Pedido", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVEndaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btn_novoItem.Enabled = false;
                CB_produto.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                btn_finalizarPedido.Enabled = false;
                btn_finalizarVenda.Enabled = true;
                txt_codigo.Enabled = false;
            }
        }
        private void btn_finalizarVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            btn_finalizarVenda.Enabled = false;
            btn_imprimir.Enabled = true;

            CB_pgto.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void CB_pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_pgto.SelectedItem != null)
            {
                var status = (StatusPagamento)CB_pgto.SelectedItem;
                if (status.Codigo == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.Codigo;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btn_finalizar.Enabled = true;
                    txt_dataVencimento.Enabled = false;
                }
                else if (status.Codigo == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.Codigo;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    txt_dataVencimento.Enabled = true;
                    btn_finalizar.Enabled = true;

                }
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            txt_dataVencimento.Enabled = false;
            btn_finalizar.Enabled = false;
            CB_pgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com sucesso");
            DG_vendas.Refresh();
            this.Close();
        }

        private void CB_aluno_SelectedValue(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_aluno.Text))
            {
                lbl_serie.Text = "";
            }
        }
    }
}

