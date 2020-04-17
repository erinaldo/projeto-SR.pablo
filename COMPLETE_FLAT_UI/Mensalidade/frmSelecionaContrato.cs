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
    public partial class frmSelecionaContrato : Form
    {
        public frmSelecionaContrato()
        {
            InitializeComponent();
        }
        public List<ContratoModel> ListaContratoCliente;
        private void frmSelecionaContrato_Load(object sender, EventArgs e)
        {
            //CLIENTE NO TXT
            if (ListaContratoCliente == null) { ListaContratoCliente = new List<ContratoModel>(); }
            DGVDADOS.DataSource = null;
            //criar um nova lista
           
            var novaLista = ListaContratoCliente.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
            {
                CodigoContrato = c.ID,
                Cliente = c.ClienteContrato.NOME,
                //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                //Status = c.SITUACAO,
                Dia = c.DIA_BASE,
                Valor = c.VALOR_MES,
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

                FrmCriarCodicoesPagamento pagamento = new FrmCriarCodicoesPagamento();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente;
                pagamento.CodigoContrato = codigodoContrato;
                pagamento.ShowDialog();
                this.Close();
            }
        }
    }
}
