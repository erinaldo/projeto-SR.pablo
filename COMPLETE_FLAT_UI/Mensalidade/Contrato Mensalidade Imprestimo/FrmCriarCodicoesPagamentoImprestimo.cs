using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.Contrato_imprestimo;
using Dados.imovels;
using Model;
using SoftwareGerenciador.Mensalidade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace SoftwareGerenciador.adm_modulo
{
    public partial class FrmCriarCodicoesPagamentoImprestimo : Form
    {
        public FrmCriarCodicoesPagamentoImprestimo()
        {
            InitializeComponent();
            carregaImovel();
        }
        public imovelModel ImovelSelecionado;
        public int CodigoContrato { get; set; }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregaImovel()
        {

            //var ListaImovel = new imovelDAL().ListaImovelSituacao("Disponivél");
            //ListaImovel.Insert(0, new imovelModel() { NOME = "SELECIONE" });
            //comboImovel.DisplayMember = "NOME";
            //comboImovel.ValueMember = "ID";
            //comboImovel.DataSource = ListaImovel;

        }
        //CONSULTA NOME DO CLIENTE E TRAZ O ID DELE
        private void FrmCriarCodicoesPagamento_Load(object sender, EventArgs e)
        {

            cbNParcela.SelectedIndex = 0;
            //CLIENTE NO TXT
            cliente cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
            iD_CLIENTETextBox.Text = cliente.ID.ToString();
            dIA_BASETextBox.Text = cliente.DIAVENCIMENTO.ToString();
            TxtdiaBaseJuros.Text = cliente.DIAVENCIMENTO.ToString();
            //ferificar se ja existe dados desse cliente
            var existeContrato = new ContratoImprestimoDAL().Consulta(new ContratoImprestimo() { ID_CLIENTE = cliente.ID, ID = CodigoContrato });
            if (existeContrato.ID > 0)
            {
                if (existeContrato.SITUACAO == "ATIVO")
                    BtnNovoContrato.Visible = false;
                else if (existeContrato.SITUACAO == "CANCELADO")
                {
                    BtnNovoContrato.Visible = true;
                    BtnCancelarContrato.Visible = false;
                }

                iDTextBox.Text = existeContrato.ID.ToString();
                iD_CLIENTETextBox.Text = existeContrato.ID_CLIENTE.ToString();
               

                //ferificar se existe parcela
                var ExisteParcelas = new ContratoImprestimoDAL().ConsultaParcelas(existeContrato.ID);

                //ferificar se o contrato estar ativo
                btnStatus.Text = "Situação: "+existeContrato.SITUACAO.ToString() + " Tipo: " + ExisteParcelas[0].PLANO;
                if(ExisteParcelas[0].PLANO == "Plano Imprestimo Price")
                {
                    vALOR_MESTextBox.Text = existeContrato.VALOR_IMPRESTADO.ToString("F");
                    TxtPorcentagem.Text = existeContrato.JUROS.Replace("%", "");

                    dIA_BASETextBox.Text = existeContrato.DIA_BASE.ToString();
                    btnCriaParcelasJUROS.Visible = false;
                    BtnSalvarParcelaJuros.Visible = false;
                    BtnSalvaradm_modulo.Visible = false;
                    BtnCriarParcelas.Visible = false;

                    dgvParcelas.Rows.Clear();
                    decimal TotalParcial = 0;
                    decimal TotalJuros = 0;
                    if (ExisteParcelas.Count > 0)
                    {
                        dtDataini.Value = Convert.ToDateTime(ExisteParcelas[0].DATA_VENCIMENTO.ToString());

                        for (int i = 0; i < ExisteParcelas.Count; i++)
                        {
                            String[] k = new String[] { ExisteParcelas[i].N_MENSALIDADE.ToString(), ExisteParcelas[i].VALOR_PRESTACAO.ToString("C"),
                            ExisteParcelas[i].VALOR_JUROS.ToString("C"),ExisteParcelas[i].AMORTIZACAO.ToString("C"),
                         ExisteParcelas[i].SALDODEVEDOR.ToString("C"),
                            ExisteParcelas[i].DATA_VENCIMENTO.ToString(), ExisteParcelas[i].DATA_PAGAMENTO.ToString(), ExisteParcelas[i].SITUACAO };
                            this.dgvParcelas.Rows.Add(k);

                            TotalParcial += Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                            TotalJuros += Convert.ToDecimal(dgvParcelas.Rows[i].Cells[2].Value.ToString().Replace("R$", ""));
                        }
                        cbNParcela.SelectedIndex = ExisteParcelas.Count - 1;
                        //txtTotalParcial.Text = (TotalParcial + TotalJuros).ToString("C");

                    }
                }
                //"Plano Imprestimo Juros";
                else if (ExisteParcelas[0].PLANO == "Plano Imprestimo Juros")
                {
                    txtvalorImprestadoJUROS.Text = existeContrato.VALOR_IMPRESTADO.ToString("F");
                    txtJurosPORCENTO.Text = existeContrato.JUROS.Replace("%", "");

                    dIA_BASETextBox.Text = existeContrato.DIA_BASE.ToString();
                    btnCriaParcelasJUROS.Visible = false;
                    BtnSalvarParcelaJuros.Visible = false;
                    BtnSalvaradm_modulo.Visible = false;
                    BtnCriarParcelas.Visible = false;

                    dgvParcelasSAC.Rows.Clear();
                    if (ExisteParcelas.Count > 0)
                    {
                        dateTimeDataInicialJURSOS.Value = Convert.ToDateTime(ExisteParcelas[0].DATA_VENCIMENTO.ToString());

                        for (int i = 0; i < ExisteParcelas.Count; i++)
                        {
                            String[] k = new String[] { ExisteParcelas[i].N_MENSALIDADE.ToString(), ExisteParcelas[i].VALOR_PRESTACAO.ToString("C"), ExisteParcelas[i].VALOR_JUROS.ToString("C"), ExisteParcelas[i].AMORTIZACAO.ToString("C"),
                         ExisteParcelas[i].SALDODEVEDOR.ToString("C"), ExisteParcelas[i].DATA_VENCIMENTO.ToString(), ExisteParcelas[i].DATA_PAGAMENTO.ToString(), ExisteParcelas[i].SITUACAO.ToString() };
                            this.dgvParcelasSAC.Rows.Add(k);
                        }
                      
                    }
                }

            }

        }

        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            ContratoImprestimoParcela contratoParcela = new ContratoImprestimoParcela();
            try
            {
                //validação da tela

                if (string.IsNullOrWhiteSpace(vALOR_MESTextBox.Text))
                {
                    MessageBoxEx.Show("Valor incorreto!");
                    return;
                }
                var dados = DADOS();
                if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                {
                    //new ContratoImprestimoDAL().Update(dados);

                    ////ja existe algumas parcelas no banco quero acrescentar mas 
                    ////excluir primeiro
                    //new ContratoDAL().ExcluirParcelas(Convert.ToInt32(iDTextBox.Text));
                    //for (int i = 0; i < dgvParcelas.RowCount; i++)
                    //{

                    //    contrato.ID_CONTRATO = Convert.ToInt32(iDTextBox.Text);
                    //    contrato.VALOR = Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                    //    contrato.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                    //    if (dgvParcelas.Rows[i].Cells[3].Value.ToString() != "")
                    //        contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[3].Value);
                    //    //unico plano
                    //    contrato.PLANO = "Plano Imprestimo";

                    //    contrato.SITUACAO = "NAO PAGO";
                    //    contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                    //    new ContratoDAL().InserirParcelas(contrato);
                    //}

                }
                else
                {
                    int retorno = new ContratoImprestimoDAL().Salvar(dados);
                    ////inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        contratoParcela.ID_CONTRATO = retorno;
                        contratoParcela.VALOR_PRESTACAO = Convert.ToDecimal(dgvParcelas.Rows[i].Cells["valorprestacao"].Value.ToString().Replace("R$", ""));
                        contratoParcela.VALOR_JUROS = Convert.ToDecimal(dgvParcelas.Rows[i].Cells["juros"].Value.ToString().Replace("R$", ""));
                        contratoParcela.AMORTIZACAO = Convert.ToDecimal(dgvParcelas.Rows[i].Cells["Amortizacao"].Value.ToString().Replace("R$", ""));
                        contratoParcela.SALDODEVEDOR = Convert.ToDecimal(dgvParcelas.Rows[i].Cells["SaldoDevedor"].Value.ToString().Replace("R$", ""));
                        contratoParcela.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells["datavencimento"].Value);
                        //pega o plano
                        contratoParcela.PLANO = "Plano Imprestimo Price";

                        contratoParcela.SITUACAO = Convert.ToString(dgvParcelas.Rows[i].Cells["Situacao"].Value);
                        contratoParcela.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells["Nparcela"].Value);
                        new ContratoImprestimoDAL().InserirParcelas(contratoParcela);
                    }

                }
                //clocalndo o status do cliente para ATIVO
                //faz update no cliente no status dele para CANCELADO
                //localizando o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
                new CLIENTEDAL().UpdateClienteCancelamento(cliente.ID, "ATIVO");

                MessageBoxEx.Show("Contrato ATIVO! Salvos com sucesso.");
                Close();

            }
            catch (Exception ex)
            {

                ExceptionErro.ExibirMenssagemException(ex);
            }
        }

        private ContratoImprestimo DADOS()
        {
            var Contrato = new ContratoImprestimo();
            if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                Contrato.ID = Convert.ToInt32(iDTextBox.Text);
            //dados da tela
            Contrato.ID_CLIENTE = Convert.ToInt32(iD_CLIENTETextBox.Text);
            Contrato.VALOR_IMPRESTADO = Convert.ToDecimal(vALOR_MESTextBox.Text);
            Contrato.JUROS = TxtPorcentagem.Text + "%";
            decimal TotalJuros = 0;
            for (int i = 0; i < dgvParcelas.RowCount; i++)
            {
                TotalJuros += Convert.ToDecimal(dgvParcelas.Rows[i].Cells["juros"].Value.ToString().Replace("R$", ""));
            }
            Contrato.VALOR_JUROS = TotalJuros;
            Contrato.DIA_BASE = Convert.ToInt32(dIA_BASETextBox.Text);
            Contrato.SITUACAO = "ATIVO";
            return Contrato;
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception erro)
            {
                MessageBoxEx.Show(erro.Message);
            }
        }

        private void vALOR_MESTextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref vALOR_MESTextBox);
        }
        public double totalCompra = 0;
        public double totaljuros = 0;
        private void SalvarCodiçoesPrice()
        {

            try
            {

                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcela.Text.Trim().Replace("X", ""));
                if (parcelas == 0) { parcelas = 1; }

                //this.totalCompra = Convert.ToDouble(vALOR_MESTextBox.Text);
                //this.totaljuros = Convert.ToDouble(txtValorJuros.Text);

                //Double totallocal = this.totalCompra;
                //Double totaljurosLocal = this.totaljuros;
                //double valor = totallocal / parcelas; //valor da parcela
                //double juros = totaljurosLocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtDataini.Value;

                int diaParcela = dt.Day;
                int mesParcela = dt.Month;


                #region Criar o calculo price do valor imprestado
                decimal valorImprestado = Convert.ToDecimal(vALOR_MESTextBox.Text);
                decimal porcento = Convert.ToDecimal(TxtPorcentagem.Text.ToString());
                int parcela = Convert.ToInt32(cbNParcela.Text.Replace("X", ""));
                var retorno = SistemaDeAmortizacaoPrice.CalcularParcelas(valorImprestado, porcento, parcela);

                retorno.Remove(retorno[0]);
                #endregion


                //lbTotal.Text = this.totalCompra.ToString("C");
                int Nparcela = 0;
                for (int i = 0; i < retorno.Count; i++)
                {

                    Nparcela = Nparcela + 1;
                    String[] k = new String[] { Nparcela.ToString(), retorno[i].Prestacao.ToString("C"), retorno[i].Juros.ToString("C"), retorno[i].Amortizacao.ToString("C"),
                         retorno[i].SaldoDevedor.ToString("C"), dt.Date.ToShortDateString(), "", "NAO PAGO" };
                    this.dgvParcelas.Rows.Add(k);

                    dt = dt.AddMonths(1);
                    if (dt.Month != 2)//se não for fevereiro
                    {
                        int mesParcelaVigente = dt.Month;
                        int anoParcelaVigente = dt.Year;

                        if (dt.Day != diaParcela)
                        {
                            int dia = 0;

                            //verificar se mes tem 31 dias
                            if (mesParcelaVigente != 4 && mesParcelaVigente != 6 && mesParcelaVigente != 9 && mesParcelaVigente != 11)
                                dia = diaParcela;
                            else dia = 30;

                            if (dt.Month != 2)//diferente de fevereiro
                                dt = new DateTime(anoParcelaVigente, mesParcelaVigente, dia);
                            else
                                //monta data verificando se mes é diferente de janeiro, pois se diminuir 1 do mes de janeiro dá exception
                                dt = new DateTime(anoParcelaVigente, mesParcelaVigente != 1 ? mesParcelaVigente - 1 : mesParcelaVigente, dia);
                        }
                    }
                }
                //pnFinalizaCompra.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void cbNParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SalvarCodiçoes();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtDataini_ValueChanged(object sender, EventArgs e)
        {
            //SalvarCodiçoes();
        }

        private void BtnNovoContrato_Click(object sender, EventArgs e)
        {
            try
            {
                //ferifica se todas a parcelas na grid estam pagas
                // se sim o botao de novo contrato e ativado
                if ((dgvParcelas.Rows.Count > 0) || (dgvParcelasSAC.Rows.Count > 0))
                {
                    double ParcelasvalidasPrice = 0;
                    for (int i = 0; i < dgvParcelas.Rows.Count; i++)
                    {
                        if (string.IsNullOrEmpty(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString()))
                        {
                            MessageBoxEx.Show("Ainda existe Parcelas que não foram pagas!\n\n Para Iniciar um novo contrato, precisa pagar todos as parcelas desse contrato.\n\n Parcela: ( " + dgvParcelas.Rows[i].Cells[0].Value.ToString().ToUpper(CultureInfo.CurrentCulture) + " ) não foi paga!");
                        }
                        else
                        {
                            MessageBoxEx.Show("Parabens autorizção concluida para um novo contrato!\n\n Parcela: ( " + dgvParcelas.Rows[i].Cells[0].Value.ToString().ToUpper(CultureInfo.CurrentCulture) + " ) foi " + dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() + ".");
                            ParcelasvalidasPrice = +ParcelasvalidasPrice + 1;
                        }
                    }
                    if ((ParcelasvalidasPrice == dgvParcelas.Rows.Count) ||(dgvParcelasSAC.Rows.Count > 0))
                    {
                        DialogResult dialog = MessageBoxEx.Show("Deseja Criar novo Contrato para o cliente?", MessageIcon.Question, MessageButton.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            
                            //limpa os dados da tela
                            dgvParcelas.Rows.Clear();
                            dgvParcelasSAC.Rows.Clear();
                            iDTextBox.Clear();
                            vALOR_MESTextBox.Clear();
                            txtvalorImprestadoJUROS.Clear();
                            //txtTotalParcial.Clear();
                            TxtPorcentagem.Clear();
                            txtJurosPORCENTO.Clear();
                            cbNParcela.SelectedIndex = 0;

                            btnCriaParcelasJUROS.Visible = true;
                            BtnSalvarParcelaJuros.Visible = true;
                            BtnSalvaradm_modulo.Visible = true;
                            BtnCriarParcelas.Visible = true;
                        }
                    }//Ainda existe Parcelas para ser pagas
                    else
                    {
                        //desativa o botão salvar
                        BtnSalvaradm_modulo.Visible = false;
                        BtnSalvarParcelaJuros.Visible = false;
                        MessageBoxEx.Show("Cancele o contrato antes para criar um novo! \n Ainda existe parcelas do contrato á pagar...");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }

        private void BtnCriarParcelas_Click(object sender, EventArgs e)
        {
            //validação
            if ((string.IsNullOrWhiteSpace(TxtPorcentagem.Text) || (TxtPorcentagem.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira uma porcentagem ( % ).");
                return;
            }
            if ((string.IsNullOrWhiteSpace(vALOR_MESTextBox.Text) || (vALOR_MESTextBox.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira um valor para calculo ( % ).");
                return;
            }
            SalvarCodiçoesPrice();
        }

        private void BtnCancelarContrato_Click(object sender, EventArgs e)
        {
            DialogResult cancelamento = MessageBoxEx.Show("Deseja relamente cancelar este contrato?", MessageIcon.Question, MessageButton.YesNo);
            if (cancelamento == DialogResult.Yes)
            {
                new ContratoImprestimoDAL().UpdateSituacao(new ContratoModel() { SITUACAO = "CANCELADO", ID = Convert.ToInt32(iDTextBox.Text) });

                // AS PARCELAS TMB do contrato Price
                for (int i = 0; i < dgvParcelas.RowCount; i++)
                {
                    ContratoImprestimoParcela contrato = new ContratoImprestimoParcela();
                    contrato.ID_CONTRATO = CodigoContrato;/// numero do contrato
                    contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells["Nparcela"].Value.ToString());//numero da mensalidade
                    if (string.IsNullOrEmpty(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString()))
                        contrato.DATA_PAGAMENTO = DateTime.Now.Date;//data de hoje que foi feito o cancelamento do contrato
                    else
                        contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString());

                    if ((dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "NAO PAGO") ||
                        (dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "ATRASADO") ||
                        (dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "JUROS") ||
                        (dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "FRACIONADO"))
                        contrato.SITUACAO = "CANCELADO";
                    else
                        contrato.SITUACAO = Convert.ToString(dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString());

                    new ContratoImprestimoDAL().AlterarParcelas(contrato);
                }
                // AS PARCELAS TMB do contrato Juros
                for (int i = 0; i < dgvParcelasSAC.RowCount; i++)
                {
                    ContratoImprestimoParcela contrato = new ContratoImprestimoParcela();
                    contrato.ID_CONTRATO = CodigoContrato;/// numero do contrato
                    contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelasSAC.Rows[i].Cells["Nparcelajuros"].Value.ToString());//numero da mensalidade
                    if (string.IsNullOrEmpty(dgvParcelasSAC.Rows[i].Cells["DatadePagamentojuros"].Value.ToString()))
                        contrato.DATA_PAGAMENTO = DateTime.Now.Date;//data de hoje que foi feito o cancelamento do contrato
                    else
                        contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelasSAC.Rows[i].Cells["DatadePagamentojuros"].Value.ToString());

                    if ((dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value.ToString() == "NAO PAGO") ||
                        (dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value.ToString() == "ATRASADO") ||
                        (dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value.ToString() == "JUROS") ||
                        (dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value.ToString() == "FRACIONADO"))
                        contrato.SITUACAO = "CANCELADO";
                    else
                        contrato.SITUACAO = Convert.ToString(dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value.ToString());

                    new ContratoImprestimoDAL().AlterarParcelas(contrato);
                }
                MessageBoxEx.Show("Contrato e Parcelas estão Canceladas");
                BtnNovoContrato.Visible = true;
                Close();


            }
            Close();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioVenda_CheckedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if(ImovelSelecionado.VALORPRECO > 0)
            //    {

            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBoxEx.Show("Ocorreu um erro na consulta desse imovél");
            //}
        }

        private void BtnGerarContrato_Click(object sender, EventArgs e)
        {

        }
        // O método EscreverExtenso recebe um valor do tipo decimal
        public static string EscreverExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += Escrever_Valor_Extenso(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " E " : string.Empty);
                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " DE";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES"
| valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                valor_por_extenso += " DE";
                            else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
                                valor_por_extenso += " DE";
                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " REAL";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " REAIS";
                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " E ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " CENTAVO";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " CENTAVOS";
                }
                return valor_por_extenso;
            }
        }

        static string Escrever_Valor_Extenso(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                else if (a == 2) montagem += "DUZENTOS";
                else if (a == 3) montagem += "TREZENTOS";
                else if (a == 4) montagem += "QUATROCENTOS";
                else if (a == 5) montagem += "QUINHENTOS";
                else if (a == 6) montagem += "SEISCENTOS";
                else if (a == 7) montagem += "SETECENTOS";
                else if (a == 8) montagem += "OITOCENTOS";
                else if (a == 9) montagem += "NOVECENTOS";
                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                    else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                    else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                    else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                    else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";
                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "UM";
                    else if (c == 2) montagem += "DOIS";
                    else if (c == 3) montagem += "TRÊS";
                    else if (c == 4) montagem += "QUATRO";
                    else if (c == 5) montagem += "CINCO";
                    else if (c == 6) montagem += "SEIS";
                    else if (c == 7) montagem += "SETE";
                    else if (c == 8) montagem += "OITO";
                    else if (c == 9) montagem += "NOVE";
                return montagem;
            }
        }


        private void TxtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            //CalculoTaxa();
            Moeda(ref TxtPorcentagem);
        }
        private void CalculoTaxa()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtvalorImprestadoJUROS.Text))
                {
                    decimal valorTaxa = Convert.ToDecimal(txtJurosPORCENTO.Text.Trim().Replace("0,", ""));
                    decimal porcento = Convert.ToDecimal(valorTaxa / 100);// valor de porcento dividido por 100
                    string v = txtvalorImprestadoJUROS.Text.Replace("R$", "").Trim();
                    decimal ValorApagar = Convert.ToDecimal(v);
                    decimal resultado = Convert.ToDecimal(porcento * ValorApagar);

                    txtJurosPlano2.Text = resultado.ToString("F");
                    //somando a porcentagem com o valor a ser pago
                    decimal totalaPagar = Convert.ToDecimal(resultado) + ValorApagar;
                    //txtvalorTotalAPagar.Text = totalaPagar.ToString("F");
                }


            }
            catch (Exception)
            {
                MessageBoxEx.Show("Confirar os campos da tela:");
            }
        }

        private void iD_CLIENTETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void CriaParcelasSAC()
        {
            //validação
            if ((string.IsNullOrWhiteSpace(txtJurosPORCENTO.Text) || (txtJurosPORCENTO.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira uma porcentagem ( % ).");
                return;
            }
            if ((string.IsNullOrWhiteSpace(txtvalorImprestadoJUROS.Text) || (txtvalorImprestadoJUROS.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira um valor para calculo ( % ).");
                return;
            }

            SalvarCodiçoesSAC();
        }

        private void SalvarCodiçoesSAC()
        {
            //try
            //{

            //    dgvParcelasSAC.Rows.Clear();
            //    int parcelas = Convert.ToInt32(ComboBoxParcelaSAC.Text.Trim().Replace("X", ""));
            //    if (parcelas == 0) { parcelas = 1; }

            //    //this.totalCompra = Convert.ToDouble(vALOR_MESTextBox.Text);
            //    //this.totaljuros = Convert.ToDouble(txtValorJuros.Text);

            //    //Double totallocal = this.totalCompra;
            //    //Double totaljurosLocal = this.totaljuros;
            //    //double valor = totallocal / parcelas; //valor da parcela
            //    //double juros = totaljurosLocal / parcelas;
            //    DateTime dt = new DateTime();
            //    dt = dateTimeDataInicialJURSOS.Value;

            //    int diaParcela = dt.Day;
            //    int mesParcela = dt.Month;

            //    #region Criar o calculo price do valor imprestado
            //    decimal valorImprestado = Convert.ToDecimal(txtvalorImprestadoJUROS.Text);
            //    decimal porcento = Convert.ToDecimal(txtJurosPORCENTO.Text.ToString());
            //    int parcela = Convert.ToInt32(ComboBoxParcelaSAC.Text.Replace("X", ""));
            //    var retorno = SistemaDeAmortizacaoConstante.CalcularParcelas(valorImprestado, porcento, parcela);

            //    retorno.Remove(retorno[0]);
            //    #endregion

            //    #region Calculo monta grid
            //    //lbTotal.Text = this.totalCompra.ToString("C");
            //    int Nparcela = 0;
            //    for (int i = 0; i < retorno.Count; i++)
            //    {

            //        Nparcela = Nparcela + 1;
            //        String[] k = new String[] { Nparcela.ToString(), retorno[i].Prestacao.ToString("C"), retorno[i].Juros.ToString("C"), retorno[i].Amortizacao.ToString("C"),
            //             retorno[i].SaldoDevedor.ToString("C"), dt.Date.ToShortDateString(), "", "NAO PAGO" };
            //        this.dgvParcelasSAC.Rows.Add(k);

            //        dt = dt.AddMonths(1);
            //        if (dt.Month != 2)//se não for fevereiro
            //        {
            //            int mesParcelaVigente = dt.Month;
            //            int anoParcelaVigente = dt.Year;

            //            if (dt.Day != diaParcela)
            //            {
            //                int dia = 0;

            //                //verificar se mes tem 31 dias
            //                if (mesParcelaVigente != 4 && mesParcelaVigente != 6 && mesParcelaVigente != 9 && mesParcelaVigente != 11)
            //                    dia = diaParcela;
            //                else dia = 30;

            //                if (dt.Month != 2)//diferente de fevereiro
            //                    dt = new DateTime(anoParcelaVigente, mesParcelaVigente, dia);
            //                else
            //                    //monta data verificando se mes é diferente de janeiro, pois se diminuir 1 do mes de janeiro dá exception
            //                    dt = new DateTime(anoParcelaVigente, mesParcelaVigente != 1 ? mesParcelaVigente - 1 : mesParcelaVigente, dia);
            //            }
            //        }
            //    }
            //    //pnFinalizaCompra.Visible = true;
            //    #endregion

            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void txtvalorSAC_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtvalorImprestadoJUROS);
        }

        private void txtJurosSAC_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtJurosPORCENTO);
        }

        private void dgvParcelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string NomeCliente = LBnomedoadm_modulo.Text.Trim();
                int NumeroParcela = Convert.ToInt32(dgvParcelas.SelectedRows[0].Cells["Nparcela"].Value);
                DateTime DataVencimento = Convert.ToDateTime(dgvParcelas.SelectedRows[0].Cells["datavencimento"].Value);
                decimal ValorPrestacao = Convert.ToDecimal(dgvParcelas.SelectedRows[0].Cells["valorprestacao"].Value.ToString().Replace("R$", ""));
                int QuantidadeParcela = Convert.ToInt32(cbNParcela.Text.Replace("X", ""));
                using (Form fr = new frmBasico(NomeCliente, NumeroParcela, DataVencimento, ValorPrestacao, QuantidadeParcela))
                {
                    fr.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBoxEx.Show("Erro em Gerar impressão de parcela selecionada...");
            }

        }

        private void btnCriaParcelasJUROS_Click(object sender, EventArgs e)
        {
            //validação
            if ((string.IsNullOrWhiteSpace(txtJurosPORCENTO.Text) || (txtJurosPORCENTO.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira uma porcentagem ( % ).");
                return;
            }
            if ((string.IsNullOrWhiteSpace(txtvalorImprestadoJUROS.Text) || (txtvalorImprestadoJUROS.Text == "0,00")))
            {
                MessageBoxEx.Show("Erro em gerar parcelas... \n Negado!\n" +
                    "Insira um valor para calculo ( % ).");
                return;
            }
            #region Salvar na grid so Juros
            dgvParcelasSAC.Rows.Clear();

            double valorJuros = Convert.ToDouble(txtJurosPlano2.Text);
            double ValorSaldoDevedor = Convert.ToDouble(txtvalorImprestadoJUROS.Text);
            DateTime dt = new DateTime();
            dt = dateTimeDataInicialJURSOS.Value;

            int diaParcela = dt.Day;
            int mesParcela = dt.Month;

            String[] k = new String[] { 1.ToString(),string.Empty, valorJuros.ToString("C"), string.Empty,
                         ValorSaldoDevedor.ToString("C"), dt.Date.ToShortDateString(), "", "NAO PAGO" };
            this.dgvParcelasSAC.Rows.Add(k);

            dt = dt.AddMonths(1);
            if (dt.Month != 2)//se não for fevereiro
            {
                int mesParcelaVigente = dt.Month;
                int anoParcelaVigente = dt.Year;

                if (dt.Day != diaParcela)
                {
                    int dia = 0;

                    //verificar se mes tem 31 dias
                    if (mesParcelaVigente != 4 && mesParcelaVigente != 6 && mesParcelaVigente != 9 && mesParcelaVigente != 11)
                        dia = diaParcela;
                    else dia = 30;

                    if (dt.Month != 2)//diferente de fevereiro
                        dt = new DateTime(anoParcelaVigente, mesParcelaVigente, dia);
                    else
                        //monta data verificando se mes é diferente de janeiro, pois se diminuir 1 do mes de janeiro dá exception
                        dt = new DateTime(anoParcelaVigente, mesParcelaVigente != 1 ? mesParcelaVigente - 1 : mesParcelaVigente, dia);
                }
            }
            #endregion
        }

        private void txtJurosPORCENTO_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtJurosPORCENTO);
            CalculoTaxa();
        }


        private void txtvalorImprestadoJUROS_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtvalorImprestadoJUROS);
        }

        private void dgvParcelasSAC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvarParcelaJuros_Click(object sender, EventArgs e)
        {
            ContratoImprestimoParcela contratoParcela = new ContratoImprestimoParcela();
            try
            {

                var Contrato = new ContratoImprestimo();
                if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                    Contrato.ID = Convert.ToInt32(iDTextBox.Text);
                //dados da tela
                Contrato.ID_CLIENTE = Convert.ToInt32(iD_CLIENTETextBox.Text);
                Contrato.VALOR_IMPRESTADO = Convert.ToDecimal(txtvalorImprestadoJUROS.Text);
                Contrato.JUROS = txtJurosPORCENTO.Text + "%";
                Contrato.VALOR_JUROS = Convert.ToDecimal(dgvParcelasSAC.Rows[0].Cells["jurosJuros"].Value.ToString().Replace("R$", ""));
                Contrato.DIA_BASE = Convert.ToInt32(TxtdiaBaseJuros.Text);
                Contrato.SITUACAO = "ATIVO";

                if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                {
                    //new ContratoImprestimoDAL().Update(dados);

                    ////ja existe algumas parcelas no banco quero acrescentar mas 
                    ////excluir primeiro
                    //new ContratoDAL().ExcluirParcelas(Convert.ToInt32(iDTextBox.Text));
                    //for (int i = 0; i < dgvParcelas.RowCount; i++)
                    //{

                    //    contrato.ID_CONTRATO = Convert.ToInt32(iDTextBox.Text);
                    //    contrato.VALOR = Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                    //    contrato.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                    //    if (dgvParcelas.Rows[i].Cells[3].Value.ToString() != "")
                    //        contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[3].Value);
                    //    //unico plano
                    //    contrato.PLANO = "Plano Imprestimo";

                    //    contrato.SITUACAO = "NAO PAGO";
                    //    contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                    //    new ContratoDAL().InserirParcelas(contrato);
                    //}

                }
                else
                {
                    int retorno = new ContratoImprestimoDAL().Salvar(Contrato);
                    ////inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelasSAC.RowCount; i++)
                    {

                        contratoParcela.ID_CONTRATO = retorno;
                        contratoParcela.VALOR_PRESTACAO = 0;
                        contratoParcela.VALOR_JUROS = Convert.ToDecimal(dgvParcelasSAC.Rows[i].Cells["jurosJuros"].Value.ToString().Replace("R$", ""));
                        contratoParcela.AMORTIZACAO = 0;
                        contratoParcela.SALDODEVEDOR = Convert.ToDecimal(dgvParcelasSAC.Rows[i].Cells["SaldoDevedorjuros"].Value.ToString().Replace("R$", ""));
                        contratoParcela.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelasSAC.Rows[i].Cells["datavencimentojuros"].Value);
                        //pega o plano
                        contratoParcela.PLANO = "Plano Imprestimo Juros";

                        contratoParcela.SITUACAO = Convert.ToString(dgvParcelasSAC.Rows[i].Cells["Situacaojuros"].Value);
                        contratoParcela.N_MENSALIDADE = Convert.ToInt32(dgvParcelasSAC.Rows[i].Cells["Nparcelajuros"].Value);
                        new ContratoImprestimoDAL().InserirParcelas(contratoParcela);
                    }

                }
                //clocalndo o status do cliente para ATIVO
                //faz update no cliente no status dele para CANCELADO
                //localizando o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
                new CLIENTEDAL().UpdateClienteCancelamento(cliente.ID, "ATIVO");

                MessageBoxEx.Show("Contrato ATIVO! Salvos com sucesso.");
                Close();

            }
            catch (Exception ex)
            {

                ExceptionErro.ExibirMenssagemException(ex);
            }
        }
    }
}
