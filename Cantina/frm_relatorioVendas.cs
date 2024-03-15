using cantina.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frm_relatorioVendas : Form
    {
        public frm_relatorioVendas()
        {
            InitializeComponent();
        }

        private void frm_relatorioVendas_Load(object sender, EventArgs e)
        {
            this.relatorio_vendasTableAdapter.Fill(this.dS_Completo.Relatorio_vendas);

            // Atualiza o relatório
            this.reportViewer1.RefreshReport();

            // Vincula o BindingSource aos dados dos alunos
            this.alunoBindingSource.DataSource = DataContextFactory.DataContext.Aluno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            //// Converta as datas dos MaskedTextBoxes para DateTime
            //DateTime dataInicio = DateTime.ParseExact(mkb_dataInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime dataFinal = DateTime.ParseExact(mkb_dataFim.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //// Aplique o filtro

            //contasReceberBindingSource.Filter = $"DataCompra >= #{dataInicio}# AND DataCompra < #{dataFinal}#";
            //this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("aluno", CB_aluno.SelectedValue.ToString()));
            ////this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", mkb_dataInicio.Text.ToString()));
            ////this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", mkb_dataFim.Text.ToString()));
            //this.reportViewer1.RefreshReport();
            #endregion

            DateTime dataInicio;
            DateTime dataFinal;

            if (DateTime.TryParseExact(mkb_dataInicio.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataInicio) &&
                DateTime.TryParseExact(mkb_dataFim.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataFinal))
            {
                // Obtém o ID do aluno selecionado no ComboBox
                int idAluno = Convert.ToInt32(CB_aluno.SelectedValue);

                // Aplique o filtro usando o método personalizado
                this.relatorio_vendasTableAdapter.FillByAlunoEData(this.dS_Completo.Relatorio_vendas, idAluno, dataInicio, dataFinal);

                // Atualize o relatório
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Datas inválidas. Verifique o formato (dd/MM/yyyy).");
            }
        }
    }
}
