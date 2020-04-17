using Dados.CLIENTE;
using Dados.contrato;
using Model;
using SoftwareGerenciador.adm_modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareGerenciador.Mensalidade
{
    public partial class frmSelecionaContratoImprestimo : Form
    {
        public frmSelecionaContratoImprestimo()
        {
            InitializeComponent();
        }
        public List<ContratoImprestimo> ListaContratoCliente;
        private void frmSelecionaContrato_Load(object sender, EventArgs e)
        {
            //CLIENTE NO TXT
            if (ListaContratoCliente == null) { ListaContratoCliente = new List<ContratoImprestimo>(); }
            DGVDADOS.DataSource = null;
            //criar um nova lista
           
            var novaLista = ListaContratoCliente.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
            {
                CodigoContrato = c.ID,
                Cliente = c.ClienteContrato.NOME,
                //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                //Status = c.SITUACAO,
                ValorImprestado = c.VALOR_IMPRESTADO,
                juros = c.JUROS,
                 ValorJuros = c.VALOR_JUROS,
                Dia = c.DIA_BASE,
                Situação = c.SITUACAO

            }).ToList();

            DGVDADOS.DataSource = novaLista;
        }

        private void DGVDADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NomeCliente = Convert.ToString(DGVDADOS.Rows[e.RowIndex].Cells[1].Value);
                int codigodoContrato = Convert.ToInt32(DGVDADOS.Rows[e.RowIndex].Cells[0].Value);

                FrmCriarCodicoesPagamentoImprestimo pagamento = new FrmCriarCodicoesPagamentoImprestimo();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente;
                pagamento.CodigoContrato = codigodoContrato;
                pagamento.ShowDialog();
                this.Close();
            }
        }
    }
}
