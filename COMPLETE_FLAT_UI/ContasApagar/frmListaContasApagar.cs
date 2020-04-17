using Dados;
using Dados.ContaaPagar;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador.ContasApagar
{
    public partial class frmListaContasApagar : Form
    {
        public frmListaContasApagar()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaContasApagar_Load(object sender, EventArgs e)
        {
            ConsultaContasHOJE();
        }
        private void ConsultaContasHOJE()
        {
            try
            {
                var ListaContaHoje = new ContaPagarDAL().ListaConta(null, null, DataInicial.Value, "NAO PAGO");
                var novaLista = ListaContaHoje.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                {
                    ID = c.ID,
                    FORNECDOR = c.fornecedor.NOME,
                    CATEGORIA = c.categoria.NOME,
                    USUARIO = c.usuario.NOME,
                    DATAVENCIMENTO = c.DATAVENCIMENTO,
                    DATAEMISSAO = c.DATAEMISSAO,
                    DATAALERTA = c.DATAALERTA,
                    DESCRICAO = c.DESCRICAO,
                    DATAPAGAMENTO = c.DATAPAGAMENTO,
                    VALORPAGO = c.VALORPAGO,
                    VALORCONTA = c.VALORCONTA,
                    SITUACAO = c.SITUACAO,
                    NUMERODOCUMENTO = c.NUMERODOCUMENTO
                    //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                    //Status = c.SITUACAO,

                }).ToList();
                DGVDADOS.DataSource = null;
                DGVDADOS.Columns.Clear();
                DGVDADOS.DataSource = novaLista;
                Add_ColunaMenu();
                MontarGrid();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Ocorreu um erro na consulta, contrate o administrador ou faça novamente.", "ERRO: " + ex.Message + ex.StackTrace);
            }
        }
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "FORNECDOR", "CATEGORIA", "USUARIO", "DATAVENCIMENTO", "DATAEMISSAO", "DESCRICAO", "DATAPAGAMENTO", "VALORPAGO", "VALORCONTA", "SITUACAO", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "ID", "FORNECDOR", "CATEGORIA", "USUARIO", "DATAVENCIMENTO", "DATAEMISSAO", "DESCRICAO", "DATAPAGAMENTO", "VALORPAGO", "VALORCONTA", "SITUACAO", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);


        }
        private void btnNovoContaApagar_Click(object sender, EventArgs e)
        {
            using (frmcontaApagar frm = new frmcontaApagar())
            {
                frm.ShowDialog();
            }
            ConsultaContasHOJE();
        }

        private void DataFinal_ValueChanged(object sender, EventArgs e)
        {
            MetodoData();
        }
        private void MetodoData()
        {
            try
            {
                try
                {
                    var ListaContaHoje = new ContaPagarDAL().ListaConta(DataInicial.Value, DataFinal.Value, null, string.Empty);
                    var novaLista = ListaContaHoje.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                    {
                        ID = c.ID,
                        FORNECDOR = c.fornecedor.NOME,
                        CATEGORIA = c.categoria.NOME,
                        USUARIO = c.usuario.NOME,
                        DATAVENCIMENTO = c.DATAVENCIMENTO,
                        DATAEMISSAO = c.DATAEMISSAO,
                        DATAALERTA = c.DATAALERTA,
                        DESCRICAO = c.DESCRICAO,
                        DATAPAGAMENTO = c.DATAPAGAMENTO,
                        VALORPAGO = c.VALORPAGO,
                        VALORCONTA = c.VALORCONTA,
                        SITUACAO = c.SITUACAO,
                        NUMERODOCUMENTO = c.NUMERODOCUMENTO
                        //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                        //Status = c.SITUACAO,

                    }).ToList();
                    DGVDADOS.DataSource = null;
                    DGVDADOS.Columns.Clear();
                    DGVDADOS.DataSource = novaLista;
                    Add_ColunaMenu();
                    MontarGrid();
                }
                catch (Exception ex)
                {

                    MessageBoxEx.Show("Ocorreu um erro na consulta, contrate o administrador ou faça novamente.", "ERRO: " + ex.Message + ex.StackTrace);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Ocorreu um erro na consulta, contrate o administrador ou faça novamente.", "ERRO: " + ex.Message + ex.StackTrace);
            }
        }
        private void ConsultaRadioButom(string radio)
        {
            try
            {
                var ListaContaHoje = new ContaPagarDAL().ListaConta(DataInicial.Value, DataFinal.Value, null, radio);
                var novaLista = ListaContaHoje.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                {
                    ID = c.ID,
                    FORNECDOR = c.fornecedor.NOME,
                    CATEGORIA = c.categoria.NOME,
                    USUARIO = c.usuario.NOME,
                    DATAVENCIMENTO = c.DATAVENCIMENTO,
                    DATAEMISSAO = c.DATAEMISSAO,
                    DATAALERTA = c.DATAALERTA,
                    DESCRICAO = c.DESCRICAO,
                    DATAPAGAMENTO = c.DATAPAGAMENTO,
                    VALORPAGO = c.VALORPAGO,
                    VALORCONTA = c.VALORCONTA,
                    SITUACAO = c.SITUACAO,
                    NUMERODOCUMENTO = c.NUMERODOCUMENTO
                    //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                    //Status = c.SITUACAO,

                }).ToList();
                DGVDADOS.DataSource = null;
                DGVDADOS.Columns.Clear();
                DGVDADOS.DataSource = novaLista;
                Add_ColunaMenu();
                MontarGrid();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Ocorreu um erro na consulta, contrate o administrador ou faça novamente.", "ERRO: " + ex.Message + ex.StackTrace);
            }
        }

        private void radioButtonContratosATIVO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonContratosATIVO.Checked == true)
                ConsultaRadioButom("PAGO");
            else if (radioButtonContratosCANCELADO.Checked == true)
                ConsultaRadioButom("NAO PAGO");
        }
        private void Add_ColunaMenu()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOS.Columns.Add(imageColumn);
            imageColumn.HeaderText = "Menu";
            imageColumn.Name = "Menu";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.Width = 60;
        }

        private void DGVDADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DGVDADOS.Columns[e.ColumnIndex].HeaderText == "Tarefas")//QTD
                    {

                        Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //if (e.RowIndex >= 0)
                        //{

                        //    Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //var codigoSelecionado = Convert.ToInt32(DGVDADOS.Rows[e.RowIndex].Cells[0].Value);
                        //    //string Nome = Convert.ToString(dgvItens.SelectedRows[0].Cells["Nome"].Value);

                        //}

                    }
                }
            }
            catch (Exception erro)
            {

                MessageBoxEx.Show("Erro no cellContent: " + erro.Message, "Erro", MessageIcon.Error, MessageButton.OK);
            }
        }

        private void DGVDADOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value != null && e.Value.Equals("NAO PAGO") || e.Value.Equals("CANCELADO") || e.Value.Equals("ATRASADO"))
                {

                    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                else if (e.Value != null && e.Value.Equals("PAGO") || e.Value.Equals("GRATIS (BONUS)"))
                {

                    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;

                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
            //localizar Conta a pagar
            var ContaLocalizada = new ContaPagarDAL().LocalizarConta(Codigo);
            if (ContaLocalizada.ID > 0)
            {
                using (frmcontaApagar frmconta = new frmcontaApagar())
                {
                    frmconta.txtID.Text = ContaLocalizada.ID.ToString();
                    frmconta.comboFornecedor.SelectedValue = ContaLocalizada.ID_FORNECEDOR;
                    frmconta.Combocategoria.SelectedValue = ContaLocalizada.ID_CATEGORIA;
                    frmconta.comboUsuario.SelectedValue = ContaLocalizada.ID_USUARIO;
                    frmconta.dataVencimento.Value = ContaLocalizada.DATAVENCIMENTO;
                    frmconta.dataEmissao.Value = ContaLocalizada.DATAEMISSAO;
                    frmconta.dataAlerta.Value = ContaLocalizada.DATAALERTA;
                    frmconta.txtDescricao.Text = ContaLocalizada.DESCRICAO.ToString();
                    if (ContaLocalizada.DATAPAGAMENTO != null)
                        frmconta.dataPagamento.Value = Convert.ToDateTime(ContaLocalizada.DATAPAGAMENTO);
                    frmconta.txtValorPagamento.Text = ContaLocalizada.VALORPAGO.ToString();
                    frmconta.txtNumeroDocumento.Text = ContaLocalizada.NUMERODOCUMENTO;
                    frmconta.txtvalorDocumento.Text = ContaLocalizada.VALORCONTA.ToString();

                    frmconta.ShowDialog();
                };
                ConsultaContasHOJE();
            }
        }

        private void DataInicial_ValueChanged(object sender, EventArgs e)
        {
            MetodoData();
        }
    }
}
