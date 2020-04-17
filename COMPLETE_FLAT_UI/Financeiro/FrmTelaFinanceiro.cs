using Dados;
using Dados.ContaaPagar;
using Dados.contrato;
using Dados.Contrato_imprestimo;
using Dados.DepesaseReceitas;
using DGVPrinterHelper;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SoftwareGerenciador.Financeiro
{
    public partial class FrmTelaFinanceiro : Form
    {
        public FrmTelaFinanceiro()
        {
            InitializeComponent();
            decimal mes = Convert.ToDecimal(DateTime.Now.Date.Month);
            string ano = DateTime.Now.Date.Year.ToString();
            DataConsulta.Text = mes.ToString("00") + ano;
           
        }

        private void consultasdeimprestimo()
        {
            try
            {
                #region Contrato ativos e valores total imprestado e total de ganhos com juros
                var lista = new ContratoImprestimoDAL().ListapelasituacaoContrato("ATIVO");
                decimal ParcelaPagaNormal = 0;
                decimal ParcelasPagaFracionado = 0;
                decimal capitalpaga = 0;
                decimal Juroscapitalpaga = 0;
                decimal totalimprestadoFracionado = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    //localizando as parcelas desse contrato
                    var ListaParcelasNoraml = new ContratoImprestimoDAL().ConsultaParcelasPagasFinanceiroNORMAL(lista[i].ID);
                    for (int l = 0; l < ListaParcelasNoraml.Count; l++)
                    {
                        ParcelaPagaNormal += ListaParcelasNoraml[l].VALOR_PAGO;
                        capitalpaga += ListaParcelasNoraml[l].AMORTIZACAO;//valor do capital recebido da parcela 
                        Juroscapitalpaga += ListaParcelasNoraml[l].VALOR_JUROS;//valor do juros recebido da parcela
                    }

                    var ListaParcelasFracionado = new ContratoImprestimoDAL().ConsultaParcelasPagasFinanceiroFRACIONADO(lista[i].ID);
                    for (int f = 0; f < ListaParcelasFracionado.Count; f++)
                    {
                        ParcelasPagaFracionado += ListaParcelasFracionado[f].VALORFRACIONADO;
                        capitalpaga += ListaParcelasFracionado[f].AMORTIZACAO;//valor do capital recebido da parcela 
                        //Juroscapitalpaga += ListaParcelasFracionado[f].VALOR_JUROS;//valor do juros recebido da parcela 
                    }

                }
                decimal totalimprestado = 0;
                decimal totalimprestadoJuros = 0;
              
                for (int i = 0; i < lista.Count; i++)
                {
                    totalimprestado += Convert.ToDecimal(lista[i].VALOR_IMPRESTADO);
                    totalimprestadoJuros += Convert.ToDecimal(lista[i].VALOR_IMPRESTADO + lista[i].VALOR_JUROS);
                   
                }

                #endregion

                #region Total de recebimentos de imprestimo
                //ferificar o mes
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Date.Month));
                LBConteudo.Text = "Saldo Geral Mensal  Geral( "+ mes.ToString() + ")";
                metroTile4.Text = "Saldo |capital| recebido( " + mes.ToString() + ")";
                metroTiletexto3.Text = "Saldo |juros| recebido( " + mes.ToString() + ")";


                var ResumoRecebimentoMes = new ContratoImprestimoDAL().ResumoRecebimentoMesGrafico(data);
                var RecebimentoFuturo = new ContratoImprestimoDAL().ResumoRecebimentoMesFuturo(data);
                decimal totalPago = 0;
                decimal totalfraciona = 0;
                decimal TotalRecebimentoMesImprestimo = 0;
                decimal TotalRecebimentoFuturo = 0;
                decimal J = 0;
                decimal C = 0;
                for (int i = 0; i < ResumoRecebimentoMes.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(ResumoRecebimentoMes.Rows[i].ItemArray[11].ToString()))
                        totalPago += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[11].ToString());
                    //8 e o capital
                    //7 e o juros
                    if (!string.IsNullOrEmpty(ResumoRecebimentoMes.Rows[i].ItemArray[12].ToString()))
                        totalfraciona += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[12].ToString());

                    if (!string.IsNullOrEmpty(ResumoRecebimentoMes.Rows[i].ItemArray[7].ToString()))
                        J += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[7].ToString());

                    if (!string.IsNullOrEmpty(ResumoRecebimentoMes.Rows[i].ItemArray[8].ToString()))
                        C += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[8].ToString());

                    TotalRecebimentoMesImprestimo = totalPago + totalfraciona;
                   
                }
                for (int r = 0; r < RecebimentoFuturo.Rows.Count; r++)
                {
                    if (!string.IsNullOrEmpty(RecebimentoFuturo.Rows[r].ItemArray[6].ToString()))
                        TotalRecebimentoFuturo += Convert.ToDecimal(RecebimentoFuturo.Rows[r].ItemArray[6].ToString());
                }
                LbTotalValorFuturo.Text = TotalRecebimentoFuturo.ToString("C");
                btnSaldoGeralImprestimo.Text = TotalRecebimentoMesImprestimo.ToString("C");
                LBCApitalMes.Text = C.ToString("C");
                LBJurosMes.Text = J.ToString("C");
                DGVDADOSRecebimentoImprestimo.DataSource = null;
                DGVDADOSRecebimentoImprestimo.DataSource = ResumoRecebimentoMes;
                DGVDADOSRecebimentoImprestimo.Columns[0].Visible = false;
                DGVDADOSRecebimentoImprestimo.Columns[1].Visible = false;
                DGVDADOSRecebimentoImprestimo.Columns[2].Visible = false;
                DGVDADOSRecebimentoImprestimo.Columns[3].Visible = false;
                //DGVDADOSRecebimentoImprestimo.Columns[6].Visible = false;
                DGVDADOSRecebimentoImprestimo.Columns[9].DefaultCellStyle.Format = "c";
                DGVDADOSRecebimentoImprestimo.Columns[11].Visible = true;
                DGVDADOSRecebimentoImprestimo.Columns[11].DefaultCellStyle.Format = "c";
                DGVDADOSRecebimentoImprestimo.Columns[12].DefaultCellStyle.Format = "c";
                //DGVDADOSRecebimentoImprestimo.Columns[12].Width = 200;
                DGVDADOSRecebimentoImprestimo.Columns[14].Visible = false;
                #endregion

                #region valores pra tela

                var j = totalimprestadoJuros - ParcelaPagaNormal - ParcelasPagaFracionado;
                lbtotalimprestadojuros.Text = j.ToString("C");
                lbtotalimprestadojuros.Visible = true;

                lbtotalimprestado.Text = (totalimprestado - capitalpaga).ToString("C");//(totalimprestado - Convert.ToDecimal(lbtotalimprestadojuros.Text.Replace("R$",""))).ToString("C");
                lbtotalimprestado.Visible = true;

                LbtotalCaspitalPago.Text = capitalpaga.ToString("C");
                LbJurospagosdoCapital.Text = Juroscapitalpaga .ToString("C");
                #endregion
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Erro em localizar os contratos ativo. \n Contrate o administrador!");
            }


        }

        private void carregaCategoria()
        {

            var ListaCategoria = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());
            ListaCategoria.Insert(0, new despesasCategoria() { NOME = "SELECIONE" });
            Combocategoriadespesa.DisplayMember = "NOME";
            Combocategoriadespesa.ValueMember = "ID";
            Combocategoriadespesa.DataSource = ListaCategoria;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }
        //carregaGrafico(chartConteudo, "Produtos que deram baixa no estoque", l, "NOME", "NOME", "quantidade");
        private decimal TotalDespesaMes = 0;
        private decimal TotalReceitaMes = 0;
        private decimal TotalRecebimentoMes = 0;
        private decimal TotalContasPagasMes = 0;
        /// <summary>
        /// Metodo que carrega os graficos
        /// </summary>
        /// <param name="pNomeGrafico">Informar o nome do objeto char (grafico)</param>
        /// <param name="pTituloGrafico">Informar o titulo do grafico</param>
        /// <param name="pNomeDataTable">Informar o objeto DataTable usado no dataSource</param>
        /// <param name="pNomeSeries">Informar o nome da serie</param>
        /// <param name="pXValueMember">Informar o campo do eixo X</param>
        /// <param name="pYValueMembers">Informar o campo do eixo Y</param>
        DataTable ResumoDepesaMes;
        public void carregaGraficoDespesaMensal()
        {
            DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
            ResumoDepesaMes = new DespesasReceitasDAL().ResumoDepesaMesGrafico(data);
            TotalDespesaMes = 0;
            for (int i = 0; i < ResumoDepesaMes.Rows.Count; i++)
            {
                TotalDespesaMes += Convert.ToDecimal(ResumoDepesaMes.Rows[i].ItemArray[4].ToString());
            }

            //chartResumoDespesaMensal.Titles.Clear();
            //chartResumoDespesaMensal.Titles.Add("Despesas Total: " + TotalDespesaMes.ToString("C"));
            //chartResumoDespesaMensal.DataSource = ResumoDepesaMes.DefaultView;

            //chartResumoDespesaMensal.Series[0].Name = "Despesas";
            //chartResumoDespesaMensal.Series[0].XValueMember = "DATA";
            //chartResumoDespesaMensal.Series[0].YValueMembers = "VALOR";
            //chartResumoDespesaMensal.Series[0].IsXValueIndexed = true;
            //chartResumoDespesaMensal.Series[0].IsValueShownAsLabel = true;
            //chartResumoDespesaMensal.DataBind();

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

            DGVDADOSDespesa.DataSource = null;
            DGVDADOSDespesa.DataSource = novaLista;
            MontarGridListaDespesas();
        }

        DataTable ResumoContaPagasMes;
        public void carregaGraficoContaPagasMensal()
        {
            DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
            ResumoContaPagasMes = new ContaPagarDAL().ResumoContaPagasMesGrafico(data, null);
            TotalContasPagasMes = 0;
            if (ResumoContaPagasMes.Rows.Count > 0)
            {
                for (int i = 0; i < ResumoContaPagasMes.Rows.Count; i++)
                {
                    TotalContasPagasMes += Convert.ToDecimal(ResumoContaPagasMes.Rows[i].ItemArray[12].ToString());
                }

                DGVDADOSContasPagas.DataSource = null;
                DGVDADOSContasPagas.DataSource = ResumoContaPagasMes;
                DGVDADOSContasPagas.Columns[0].Visible = false;
                DGVDADOSContasPagas.Columns[4].Visible = false;
                DGVDADOSContasPagas.Columns[5].Visible = false;
                DGVDADOSContasPagas.Columns[6].Visible = false;
                DGVDADOSContasPagas.Columns[12].DefaultCellStyle.Format = "c";
                //DGVDADOSContasPagas.Columns[15].DefaultCellStyle.Format = "c";
            }
            else
                DGVDADOSContasPagas.DataSource = null;
        }
        DataTable ResumoReceitaMes;
        public void carregaGraficoReceitaMensal()
        {
            DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
            ResumoReceitaMes = new DespesasReceitasDAL().ResumoreceitaMesGrafico(data);//{11/02/2020 21:38:47}
            TotalReceitaMes = 0;
            for (int i = 0; i < ResumoReceitaMes.Rows.Count; i++)
            {
                TotalReceitaMes += Convert.ToDecimal(ResumoReceitaMes.Rows[i].ItemArray[4].ToString());
            }

            var ListaReceita = new DespesasReceitasDAL().ListaReceita(DateTime.Now.Date);
            DGVDADOSReceitas.DataSource = null;
            DGVDADOSReceitas.DataSource = ListaReceita;
            MontarGridListaReceita();

        }
        DataTable ResumoRecebimentoMes;
        public void carregaGraficoRecebimentoMensal()
        {
            DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
            ResumoRecebimentoMes = new ContratoDAL().ResumoRecebimentoMesGrafico(data);
            TotalRecebimentoMes = 0;
            decimal TotalrecebidoMensal = 0;
            decimal TotalRecebidoFracionado = 0;
            for (int i = 0; i < ResumoRecebimentoMes.Rows.Count; i++)
            {
                if (ResumoRecebimentoMes.Rows[i].ItemArray[8].ToString() != "")
                    TotalrecebidoMensal += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[8].ToString());

                if (ResumoRecebimentoMes.Rows[i].ItemArray[10].ToString() != "")
                    TotalRecebidoFracionado += Convert.ToDecimal(ResumoRecebimentoMes.Rows[i].ItemArray[10].ToString());

                TotalRecebimentoMes = TotalrecebidoMensal + TotalRecebidoFracionado;
            }

            DGVDADOSRecebimento.DataSource = null;
            DGVDADOSRecebimento.DataSource = ResumoRecebimentoMes;
            DGVDADOSRecebimento.Columns[0].Visible = false;
            DGVDADOSRecebimento.Columns[1].Visible = false;
            DGVDADOSRecebimento.Columns[2].Visible = false;
            DGVDADOSRecebimento.Columns[3].Visible = false;
            //DGVDADOSRecebimento.Columns[6].Visible = false;
            DGVDADOSRecebimento.Columns[8].DefaultCellStyle.Format = "c";
            DGVDADOSRecebimento.Columns[10].DefaultCellStyle.Format = "c";
            DGVDADOSRecebimento.Columns[11].Visible = false;
            //DGVDADOSRecebimento.Columns[12].Width = 200;
            //chartResumoRecebimentoMensal.Titles.Clear();
            //chartResumoRecebimentoMensal.Titles.Add("Recebimento Total: " + TotalRecebimentoMes.ToString("C"));
            //chartResumoRecebimentoMensal.DataSource = ResumoRecebimentoMes.DefaultView;

            //chartResumoRecebimentoMensal.Series[0].Name = "Recebimento";
            //chartResumoRecebimentoMensal.Series[0].XValueMember = "FORMA_PAGAMENTO";
            //chartResumoRecebimentoMensal.Series[0].YValueMembers = "VALOR_PAGO";
            //chartResumoRecebimentoMensal.Series[0].IsXValueIndexed = true;
            ////chartResumoRecebimentoMensal.Series[0].IsValueShownAsLabel = true;
            //chartResumoRecebimentoMensal.DataBind();

        }

        private void MontarGridListaDespesas()
        {
            DGVDADOSDespesa.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOSDespesa);
            //Define quais colunas serão visíveis
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "Id", "DESCRICAO", "IDCATEFORIA", "Valor", "Data", "IDIMOVEL", "NOMEImovel" });
            //DGVDADOSDespesa.Columns[1].Width = 290;
            //DGVDADOSDespesa.Columns[6].Width = 400;

            DGVDADOSDespesa.Columns[3].DefaultCellStyle.Format = "c";
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Descricao", "Valor", "Data", "NOMEImovel" });


            ////defini visibilidade
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "DESCRICAO", "Data", "Valor", "NOMEImovel" });

        }
        private void MontarGridListaReceita()
        {
            //DGVDADOSReceitas.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            //var objBlControleGrid = new FormataGrid(DGVDADOSReceitas);
            DGVDADOSReceitas.Columns[2].Visible = false;
            //DGVDADOSReceitas.Columns[1].Width = 400;
            DGVDADOSReceitas.Columns[4].DefaultCellStyle.Format = "c";
            //DGVDADOSReceitas.Columns[4].Width = 200;
            //defini visibilidade
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "DESCRICAO", "DATA", "VALOR" });

        }
        private void FrmTelaFinanceiro_Load(object sender, EventArgs e)
        {
            carregaCategoria();

            carregaGraficoDespesaMensal();
            carregaGraficoReceitaMensal();
            carregaGraficoRecebimentoMensal();
            carregaGraficoContaPagasMensal();

            //consulta da tela de imprestimo
            consultasdeimprestimo();

            BtnTotalDespesaMes.Text = TotalDespesaMes.ToString("C");
            BtnTotalReceitaMes.Text = TotalReceitaMes.ToString("C");
            BtnTotalRecebimentoMes.Text = TotalRecebimentoMes.ToString("C");
            BtnTotalContaPagaMes.Text = TotalContasPagasMes.ToString("C");
            decimal totalSomado = TotalReceitaMes + TotalRecebimentoMes - TotalDespesaMes - TotalContasPagasMes;
            BtnTotalResumoMensal.Text = totalSomado.ToString("C");
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DataConsulta.Text.Replace("  /", "")))
                {
                    carregaGraficoDespesaMensal();
                    carregaGraficoReceitaMensal();
                    carregaGraficoRecebimentoMensal();
                    carregaGraficoContaPagasMensal();

                    //consulta da tela de imprestimo
                    consultasdeimprestimo();

                    BtnTotalDespesaMes.Text = TotalDespesaMes.ToString("C");
                    BtnTotalReceitaMes.Text = TotalReceitaMes.ToString("C");
                    BtnTotalRecebimentoMes.Text = TotalRecebimentoMes.ToString("C");
                    BtnTotalContaPagaMes.Text = TotalContasPagasMes.ToString("C");
                    BtnTotalResumoMensal.Text = Convert.ToDecimal(TotalDespesaMes - TotalReceitaMes - TotalContasPagasMes + TotalRecebimentoMes).ToString("C");
                }
                else
                    MessageBoxEx.Show("Data de Pesquisar Invalida!");

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro na consulta: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Combocategoriadespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combocategoriadespesa.SelectedIndex > 0)
            {

                DateTime data = Convert.ToDateTime("02/" + DataConsulta.Text);
                var ResumoDepesaMes = new DespesasReceitasDAL().ResumoDespesaMesCombo(data, Convert.ToInt32(Combocategoriadespesa.SelectedValue));
                decimal TotalDespesaMesCombo = 0;
                for (int i = 0; i < ResumoDepesaMes.Rows.Count; i++)
                {
                    TotalDespesaMesCombo += Convert.ToDecimal(ResumoDepesaMes.Rows[i].ItemArray[3].ToString());

                }

                LbTotalDespesaCategoria.Visible = true;
                LbTotalDespesaCategoria.Text = TotalDespesaMesCombo.ToString("C");
                DGVDADOSDespesa.DataSource = null;
                DGVDADOSReceitas.DataSource = null;
                DGVDADOSRecebimento.DataSource = null;
                DGVDADOSDespesa.DataSource = ResumoDepesaMes;

                DGVDADOSDespesa.Columns[0].Visible = false;
                //DGVDADOSDespesa.Columns[1].Width = 400;
                DGVDADOSDespesa.Columns[2].Visible = false;
                DGVDADOSDespesa.Columns[5].Visible = false;
                //DGVDADOSDespesa.Columns[6].Width = 400;
            }
            else
                LbTotalDespesaCategoria.Visible = false;
        }

        private void chartResumoRecebimentoMensal_DoubleClick(object sender, EventArgs e)
        {

            FrmResumo resumo = new FrmResumo();
            resumo.LblTextoFonte.Text = "Resumo Detalhado de Recebimento".ToString();
            resumo.DGVDADOS.DataSource = null;
            resumo.DGVDADOS.DataSource = ResumoRecebimentoMes;
            resumo.DGVDADOS.Columns[0].Visible = false;
            resumo.DGVDADOS.Columns[1].Visible = false;
            resumo.DGVDADOS.Columns[2].Visible = false;
            resumo.DGVDADOS.Columns[3].Visible = false;
            resumo.DGVDADOS.Columns[5].Visible = false;
            //resumo.DGVDADOS.Columns[5].Visible = false;
            //resumo.DGVDADOS.Columns[8].DefaultCellStyle.Format = "c";
            resumo.DGVDADOS.Columns[6].Visible = false;
            resumo.DGVDADOS.Columns[10].Visible = false;
            resumo.ShowDialog();
        }

        private void chartResumoDespesaMensal_DoubleClick(object sender, EventArgs e)
        {
            using (FrmResumo resumo = new FrmResumo())
            {
                resumo.LblTextoFonte.Text = "Resumo Detalhado de despesas".ToString();
                resumo.DGVDADOS.DataSource = null;
                resumo.DGVDADOS.DataSource = ResumoDepesaMes;
                resumo.DGVDADOS.Columns[0].Visible = false;
                resumo.DGVDADOS.Columns[2].Visible = false;
                resumo.DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
                resumo.ShowDialog();
            };

        }

        private void chartResumoReceitaAnual_DoubleClick(object sender, EventArgs e)
        {
            using (FrmResumo resumo = new FrmResumo())
            {
                resumo.LblTextoFonte.Text = "Resumo Detalhado de Receitas".ToString();
                resumo.DGVDADOS.DataSource = null;
                resumo.DGVDADOS.DataSource = ResumoReceitaMes;
                resumo.DGVDADOS.Columns[0].Visible = false;
                resumo.DGVDADOS.Columns[2].Visible = false;
                resumo.DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
                resumo.ShowDialog();
            };

        }

        private void BtnConsultaFaturamentoDiario_Click(object sender, EventArgs e)
        {
            var f = new ContratoDAL().FaturamentoDiarioReceitasConsulta(DataFaturamentoDiario.Value);
            decimal t = 0;
            decimal TotalrecebidoMensal = 0;
            decimal TotalRecebidoFracionado = 0;
            for (int i = 0; i < f.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(f.Rows[i].ItemArray[8].ToString()));
                    TotalrecebidoMensal += Convert.ToDecimal(f.Rows[i].ItemArray[8].ToString());

                if (!string.IsNullOrEmpty(f.Rows[i].ItemArray[10].ToString()));
                    TotalRecebidoFracionado += Convert.ToDecimal(f.Rows[i].ItemArray[10].ToString());

                t = TotalrecebidoMensal + TotalRecebidoFracionado;
            }


            LblTotalfaturamentoDiario.Visible = true;
            LblTotalfaturamentoDiario.Text = t.ToString("C");

            DGVDADOSDespesa.DataSource = null;
            DGVDADOSReceitas.DataSource = null;
            DGVDADOSRecebimento.DataSource = f;

            DGVDADOSRecebimento.Columns[0].Visible = false;
            DGVDADOSRecebimento.Columns[1].Visible = false;
            DGVDADOSRecebimento.Columns[2].Visible = false;
            DGVDADOSRecebimento.Columns[3].Visible = false;
            //DGVDADOSRecebimento.Columns[6].Visible = false;
            DGVDADOSRecebimento.Columns[8].DefaultCellStyle.Format = "c";
            DGVDADOSRecebimento.Columns[10].DefaultCellStyle.Format = "c";
            DGVDADOSRecebimento.Columns[11].Visible = false;
            //DGVDADOSRecebimento.Columns[12].Width = 200;
        }

        private void chartResumoRecebimentoMensal_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimirReceitas_Click(object sender, EventArgs e)
        {
            try
            {
                //var listaEmpresa = Sessao.Instance.Empresa;
                this.ImprimirDocumento.DefaultPageSettings.Landscape = true;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Relatórios... RECEITAS";
                printer.SubTitle = string.Format("Data de hoje: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Relatório";
                printer.FooterSpacing = 15;
                printer.PageSettings.Landscape = true;
                printer.PrintDataGridView(DGVDADOSReceitas);
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message);
            }
        }

        private void BtnImprimirDespesas_Click(object sender, EventArgs e)
        {
            try
            {
                //var listaEmpresa = Sessao.Instance.Empresa;
                this.ImprimirDocumento.DefaultPageSettings.Landscape = true;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Relatórios... DESPESAS";
                printer.SubTitle = string.Format("Data de hoje: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Relatório";
                printer.FooterSpacing = 15;
                printer.PageSettings.Landscape = true;
                printer.PrintDataGridView(DGVDADOSDespesa);
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message);
            }
        }

        private void BtnImprimirRecebimento_Click(object sender, EventArgs e)
        {
            try
            {
                //var listaEmpresa = Sessao.Instance.Empresa;
                this.ImprimirDocumento.DefaultPageSettings.Landscape = true;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Relatórios... RECEBIMENTO";
                printer.SubTitle = string.Format("Data de hoje: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Relatório";
                printer.FooterSpacing = 15;
                printer.PageSettings.Landscape = true;
                printer.PrintDataGridView(DGVDADOSRecebimento);
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message);
            }
        }

        private void BtnImprimirRecebimentoImprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                //var listaEmpresa = Sessao.Instance.Empresa;
                this.ImprimirDocumento.DefaultPageSettings.Landscape = true;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Relatórios... RECEBIMENTO IMPRESTIMO";
                printer.SubTitle = string.Format("Data de hoje: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Relatório";
                printer.FooterSpacing = 15;
                printer.PageSettings.Landscape = true;
                printer.PrintDataGridView(DGVDADOSRecebimentoImprestimo);
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message);
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
