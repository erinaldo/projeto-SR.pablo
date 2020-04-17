using Dados;
using Dados.DepesaseReceitas;
using Dados.imovels;
using Model;
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

namespace SoftwareGerenciador.Lancamentos
{
    public partial class FrmDespesasLancamento : Form
    {
        public FrmDespesasLancamento()
        {
            InitializeComponent();
            carregaCategoria();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }
        private void carregaCategoria()
        {

            var ListaCategoria = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());
            ListaCategoria.Insert(0, new despesasCategoria() { NOME = "SELECIONE" });
            Combocategoriadespesa.DisplayMember = "NOME";
            Combocategoriadespesa.ValueMember = "ID";
            Combocategoriadespesa.DataSource = ListaCategoria;

            combocategoriareceita.DisplayMember = "NOME";
            combocategoriareceita.ValueMember = "ID";
            combocategoriareceita.DataSource = ListaCategoria;

            //Imovel
            var ListaImovél = new imovelDAL().imovel(new imovelModel());
            ListaImovél.Insert(0, new imovelModel() { NOME = "SELECIONE" });
            comboBoxImovel.DisplayMember = "NOME";
            comboBoxImovel.ValueMember = "ID";
            comboBoxImovel.DataSource = ListaImovél;

        }
        public despesas d;
        public receitas C;
        public despesas despesas(despesas d)
        {
            d = new despesas();
            if (!string.IsNullOrEmpty(txtIDdespesas.Text))
                d.ID = Convert.ToInt32(txtIDdespesas.Text.Trim());
            d.ID_CATEGORIA = Convert.ToInt32(Combocategoriadespesa.SelectedValue);

            if (comboBoxImovel.SelectedIndex != 0)
                d.ID_IMOVEL = Convert.ToInt32(comboBoxImovel.SelectedValue);

            d.DATA = datadadespesa.Value;
            d.DESCRICAO = txtdescricaodespesa.Text.Trim();
            d.VALOR = Convert.ToDecimal(txtvalordespesa.Text.Trim());
            return d;
        }
        private receitas receitas(receitas C)
        {
            C = new receitas();
            if (!string.IsNullOrEmpty(txtIDReceitas.Text))
                C.ID = Convert.ToInt32(txtIDReceitas.Text.Trim());
            C.ID_CATEGORIA = Convert.ToInt32(combocategoriareceita.SelectedValue);
            C.DATA = datareceita.Value;
            C.DESCRICAO = txtdescricaoreceita.Text.Trim();
            C.VALOR = Convert.ToDecimal(txtvalorreceita.Text.Trim());
            return C;
        }

        private void BtnSalvarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtvalordespesa.Text))
                {
                    MessageBoxEx.Show("Preenha um valor de despesa pra salvar os dados!");
                    return;
                }
                if (Combocategoriadespesa.SelectedIndex == 0)
                {
                    MessageBoxEx.Show("Sem categoria de despesa pra salvar os dados!");
                    return;
                }
                if (!string.IsNullOrEmpty(txtIDdespesas.Text))
                {
                    new DespesasReceitasDAL().AlterarDespesas(despesas(d));
                    carregagrid();
                    MessageBoxEx.Show("Alterado com sucesso!");
                }
                else//inserir
                {
                    new DespesasReceitasDAL().InserirDespesas(despesas(d));
                    carregagrid();
                    MessageBoxEx.Show("Inserido com sucesso!");
                }
                LimpaTela();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }

        }
        #region procedimentos da categoria


        #endregion
        private void LimpaTela()
        {
            txtIDdespesas.Clear();
            txtdescricaodespesa.Clear();
            txtvalordespesa.Clear();

            txtIDReceitas.Clear();
            txtvalorreceita.Clear();
            txtdescricaoreceita.Clear();
        }
        private void btnlocalizacategoriadespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesaReceitas frm = new FrmCategoriaDespesaReceitas();
            frm.ShowDialog();

            //atualiza os combos
            carregaCategoria();
        }

        private void FrmDespesasLancamento_Load(object sender, EventArgs e)
        {
            carregagrid();
        }
        private void carregagrid()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Date.Month));
            LbMesAtual.Text = "Mês: " + mes.ToString(); 
            var ListaDespesas = new DespesasReceitasDAL().ListaDespesas(DateTime.Now.Date);
            var novaLista = ListaDespesas.Select(c => new
            {
                Id = c.ID,
                Descricao = c.DESCRICAO,
                IDCATEFORIA = c.ID_CATEGORIA,
                Valor = c.VALOR,
                Data = c.DATA,
                IDIMOVEL = c.ID_IMOVEL,
                NOMEImovel = c.imovel.NOME

            }).ToList();

            dgvdadosdespesas.DataSource = null;
            dgvdadosdespesas.DataSource = novaLista;
            MontarGridListaDespesas();

            var ListaReceita = new DespesasReceitasDAL().ListaReceita(DateTime.Now.Date);
            dgvdadosreceita.DataSource = null;
            dgvdadosreceita.DataSource = ListaReceita;
            MontarGridListaReceita();
        }

        private void btnLocalizarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                var dia = dataconsultadespesa.Value.Day;
                var mes = dataconsultadespesa.Value.Month;
                var ano = dataconsultadespesa.Value.Year;
                string novadataInicial = ano + "-" + mes.ToString("00") + "-" + dia;
                var ConsultaData = new DespesasReceitasDAL().ListaDespesasPelaData(novadataInicial);
                var novaLista = ConsultaData.Select(c => new
                {
                    Id = c.ID,
                    Descricao = c.DESCRICAO,
                    IDCATEFORIA = c.ID_CATEGORIA,
                    Valor = c.VALOR,
                    Data = c.DATA,
                    IDIMOVEL = c.ID_IMOVEL,
                    NOMEImovel = c.imovel.NOME

                }).ToList();
                dgvdadosdespesas.DataSource = null;
                dgvdadosdespesas.DataSource = novaLista;
                MontarGridListaDespesas();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }

        }

        private void MontarGridListaDespesas()
        {
            dgvdadosdespesas.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(dgvdadosdespesas);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Id", "DESCRICAO", "IDCATEFORIA", "Valor", "Data", "IDIMOVEL", "NOMEImovel" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "DESCRICAO", "Valor", "Data", "NOMEImovel" });

            dgvdadosdespesas.Columns[6].Width = 320;
            dgvdadosdespesas.Columns[3].DefaultCellStyle.Format = "c";

            ////defini visibilidade
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "DESCRICAO", "Data", "Valor", "NOMEImovel" });

        }
        private void MontarGridListaReceita()
        {
            dgvdadosreceita.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(dgvdadosreceita);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "DESCRICAO", "ID_CATEGORIA", "DATA", "VALOR" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "ID", "DESCRICAO", "ID_CATEGORIA", "DATA", "VALOR" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            dgvdadosreceita.Columns[1].Width = 320;
            dgvdadosreceita.Columns[4].DefaultCellStyle.Format = "c";

            //defini visibilidade
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "DESCRICAO", "DATA", "VALOR" });

        }

        private void dgvdadosdespesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtIDdespesas.Text = Convert.ToString(dgvdadosdespesas.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (!string.IsNullOrEmpty(Convert.ToString(dgvdadosdespesas.Rows[e.RowIndex].Cells[1].Value)))
                    txtdescricaodespesa.Text = Convert.ToString(dgvdadosdespesas.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtvalordespesa.Text = Convert.ToString(dgvdadosdespesas.Rows[e.RowIndex].Cells[3].Value.ToString());
                Combocategoriadespesa.SelectedValue = Convert.ToInt32(dgvdadosdespesas.Rows[e.RowIndex].Cells[2].Value.ToString());
                datadadespesa.Value = Convert.ToDateTime(dgvdadosdespesas.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (dgvdadosdespesas.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
                    comboBoxImovel.SelectedValue = Convert.ToInt32(dgvdadosdespesas.Rows[e.RowIndex].Cells[5].Value);
            }
        }

        private void dgvdadosreceita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIDReceitas.Text = Convert.ToString(dgvdadosreceita.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                if (!string.IsNullOrEmpty(Convert.ToString(dgvdadosreceita.Rows[e.RowIndex].Cells["DESCRICAO"].Value)))
                    txtdescricaoreceita.Text = Convert.ToString(dgvdadosreceita.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString());

                    txtvalorreceita.Text = Convert.ToString(dgvdadosreceita.Rows[e.RowIndex].Cells["VALOR"].Value.ToString());
                combocategoriareceita.SelectedValue = Convert.ToInt32(dgvdadosreceita.Rows[e.RowIndex].Cells["ID_CATEGORIA"].Value.ToString());
                datareceita.Value = Convert.ToDateTime(dgvdadosreceita.Rows[e.RowIndex].Cells["DATA"].Value.ToString());
            }
        }

        private void btnLocalizarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                var dia = dataconsultareceita.Value.Day;
                var mes = dataconsultareceita.Value.Month;
                var ano = dataconsultareceita.Value.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;
                var ConsultaData = new DespesasReceitasDAL().ListaReceitaPelaData(novadataInicial);
                dgvdadosreceita.DataSource = null;
                dgvdadosreceita.DataSource = ConsultaData;
                MontarGridListaReceita();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
        }

        private void BtnSalvarReceitas_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtvalorreceita.Text))
                {
                    MessageBoxEx.Show("Preenha um valor de despesa pra salvar os dados!");
                    return;
                }
                if (combocategoriareceita.SelectedIndex == 0)
                {
                    MessageBoxEx.Show("Sem categoria de despesa pra salvar os dados!");
                    return;
                }
                if (!string.IsNullOrEmpty(txtIDReceitas.Text))
                {
                    new DespesasReceitasDAL().AlterarReceitas(receitas(C));
                    carregagrid();
                    MessageBoxEx.Show("Alterado com sucesso!");
                }
                else//inserir
                {
                    new DespesasReceitasDAL().InserirReceitas(receitas(C));
                    carregagrid();
                    MessageBoxEx.Show("Inserido com sucesso!");
                }
                LimpaTela();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
        }

        private void BtnExcluirDespesas_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBoxEx.Show("Deseja Excluir essa despesa!",MessageIcon.Question,MessageButton.YesNo);
            if(DialogResult.Yes == dialog)
            {
                new DespesasReceitasDAL().ExcluirDespesa(Convert.ToInt32(txtIDdespesas.Text));
                carregagrid();
                MessageBoxEx.Show("Despesa excluida com sucesso...");
            }
        }

        private void BtnExcluirReceitas_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBoxEx.Show("Deseja Excluir essa Receita!", MessageIcon.Question, MessageButton.YesNo);
            if (DialogResult.Yes == dialog)
            {
                new DespesasReceitasDAL().ExcluirReceita(Convert.ToInt32(txtIDReceitas.Text));
                carregagrid();
                MessageBoxEx.Show("Receita excluida com sucesso...");
            }
        }
    }
}
