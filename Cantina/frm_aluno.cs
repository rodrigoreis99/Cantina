using cantina.DAL;
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
    public partial class frm_aluno : Form
    {
        public frm_aluno()
        {
            InitializeComponent();
        }

        private void frm_aluno_Load(object sender, EventArgs e)
        {
            this.alunoBindingSource.DataSource = DataContextFactory.DataContext.Aluno;
        }
        private bool valida()
        {
            if (txt_aluno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatório");
                txt_aluno.Focus();
                return false;
            }
            return true;
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.alunoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(this.valida())
            {
                this.alunoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Aluno Inserido com sucesso!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.alunoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Aluno excluido com sucesso!");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.alunoBindingSource.CancelEdit();
        }
    }
}
