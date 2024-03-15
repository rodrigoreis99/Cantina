using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frm_RelProdutos : Form
    {
        public frm_RelProdutos()
        {
            InitializeComponent();
        }

        private void frm_RelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dS_Rel_Produtos.tb_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtosTableAdapter.Fill(this.dS_Rel_Produtos.tb_produtos);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
