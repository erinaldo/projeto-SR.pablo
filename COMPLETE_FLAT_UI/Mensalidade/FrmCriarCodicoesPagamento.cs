using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.imovels;
using Model;
using SoftwareGerenciador.Mensalidade;
using System;
using System.Globalization;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace SoftwareGerenciador.adm_modulo
{
    public partial class FrmCriarCodicoesPagamento : Form
    {
        public FrmCriarCodicoesPagamento()
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

            var ListaImovel = new imovelDAL().ListaImovelSituacao("Disponivél");
            ListaImovel.Insert(0, new imovelModel() { NOME = "SELECIONE" });
            comboImovel.DisplayMember = "NOME";
            comboImovel.ValueMember = "ID";
            comboImovel.DataSource = ListaImovel;

        }
        //CONSULTA NOME DO CLIENTE E TRAZ O ID DELE
        private void FrmCriarCodicoesPagamento_Load(object sender, EventArgs e)
        {

            cbNParcela.SelectedIndex = 0;
            //CLIENTE NO TXT
            cliente cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
            iD_CLIENTETextBox.Text = cliente.ID.ToString();
            dIA_BASETextBox.Text = cliente.DIAVENCIMENTO.ToString();
            //ferificar se ja existe dados desse cliente
            var existeContrato = new ContratoDAL().Consulta(new ContratoModel() { ID_CLIENTE = cliente.ID, ID = CodigoContrato });
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
                vALOR_MESTextBox.Text = existeContrato.VALOR_MES.ToString("F");
                dIA_BASETextBox.Text = existeContrato.DIA_BASE.ToString();
                BtnSalvaradm_modulo.Visible = false;
                BtnCriarParcelas.Visible = false;

                groupBoxPlanoContratos.Enabled = false;
                //localizando o imovel
                var ImovelContrato = new imovelDAL().CONSULTATODOSPELOID(existeContrato.ID_IMOVEL);
                if (ImovelContrato.ID > 0)
                {
                    comboImovel.Text = ImovelContrato.NOME.ToString();
                    richTextBoxEditorImovel.Clear();
                    if (ImovelContrato.ID > 0)
                    {
                        richTextBoxEditorImovel.Text = "DETALHES DO IMOVÉL \n" +
                            "Nome: " + ImovelContrato.NOME + "\n" +
                            "Tipo: " + ImovelContrato.TIPO + "\n" +
                            "Situação: " + ImovelContrato.SITUACAO + "\n" +
                            "Cidade: " + ImovelContrato.CIDADE + "\n" +
                            "Bairro: " + ImovelContrato.BAIRRO + "\n" +
                            "Estado: " + ImovelContrato.ESTADO + "\n" +
                            "Quartos: " + ImovelContrato.QUARTOS + "\n" +
                             "Suites: " + ImovelContrato.SUITES + "\n" +
                              "Pavimentos: " + ImovelContrato.PAVIMENTO + "\n" +
                               "Garagem: " + ImovelContrato.GARAGEM + "\n" +
                                "Sala: " + ImovelContrato.SALA + "\n" +
                                 "Banheiro: " + ImovelContrato.BANHEIRO + "\n" +
                                  "Andar: " + ImovelContrato.ANDAR + "\n" +
                                   "Edificio: " + ImovelContrato.EDIFICIO + "\n" +
                                    "Iptu: " + ImovelContrato.VALORIPTU + "\n" +
                                     "Condominio: " + ImovelContrato.VALORCODOMINIO + "\n" +
                                      "Preço: " + ImovelContrato.VALORPRECO.ToString("C") + "\n" +
                        "Valor de aluguel: " + ImovelContrato.VALORALUGUEL.ToString("C") + "\n";
                        comboImovel.Enabled = true;
                    }
                }


                
                //ferificar se existe parcela
                var ExisteParcelas = new ContratoDAL().ConsultaParcelas(existeContrato.ID);

                //ferificar se o contrato estar ativo
                btnStatus.Text = "Situação: " + existeContrato.SITUACAO.ToString() + " Tipo: " + ExisteParcelas[0].PLANO;

                dgvParcelas.Rows.Clear();
                decimal TotalParcial = 0;
                if (ExisteParcelas.Count > 0)
                {
                    dtDataini.Value = Convert.ToDateTime(ExisteParcelas[0].DATA_VENCIMENTO.ToString());

                    for (int i = 0; i < ExisteParcelas.Count; i++)
                    {
                        String[] k = new String[] { ExisteParcelas[i].N_MENSALIDADE.ToString(), ExisteParcelas[i].VALOR.ToString("C"), ExisteParcelas[i].DATA_VENCIMENTO.ToString(), ExisteParcelas[i].DATA_PAGAMENTO.ToString(), ExisteParcelas[i].SITUACAO, ExisteParcelas[i].VALORFRACIONADO.ToString("C") };
                        this.dgvParcelas.Rows.Add(k);

                        TotalParcial += Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                    }
                    cbNParcela.SelectedIndex = ExisteParcelas.Count - 1;
                    txtTotalParcial.Text = TotalParcial.ToString("C");

                }

            }

        }

        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            contratoParcelamento contrato = new contratoParcelamento();
            try
            {
                //validação da tela
                if (comboImovel.SelectedIndex == 0)
                {
                    MessageBoxEx.Show("Valor incorreto!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(vALOR_MESTextBox.Text))
                {
                    MessageBoxEx.Show("Valor incorreto!");
                    return;
                }
                var dados = DADOS();
                if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                {
                    new ContratoDAL().Update(dados);

                    //ja existe algumas parcelas no banco quero acrescentar mas 
                    //excluir primeiro
                    new ContratoDAL().ExcluirParcelas(Convert.ToInt32(iDTextBox.Text));
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        contrato.ID_CONTRATO = Convert.ToInt32(iDTextBox.Text);
                        contrato.VALOR = Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                        contrato.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        if (dgvParcelas.Rows[i].Cells[3].Value.ToString() != "")
                            contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[3].Value);

                        //pega o plano
                        if (RadioAvulso.Checked == true)
                        {
                            contrato.PLANO = "PLANO AVULSO";
                        }
                        else if (RadioVenda.Checked == true)
                        {
                            contrato.PLANO = "PLANO VENDA";
                        }
                        else if (RadioAluguel.Checked == true)
                        {
                            contrato.PLANO = "PLANO ALUGUEL";
                        }

                        contrato.SITUACAO = "NAO PAGO";
                        contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        new ContratoDAL().InserirParcelas(contrato);
                    }

                }
                else
                {
                    int retorno = new ContratoDAL().Salvar(dados);
                    ////inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        contrato.ID_CONTRATO = retorno;
                        contrato.VALOR = Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));
                        contrato.DATA_VENCIMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        //pega o plano
                        if (RadioAvulso.Checked == true)
                        {
                            contrato.PLANO = "PLANO AVULSO";
                        }
                        else if (RadioVenda.Checked == true)
                        {
                            contrato.PLANO = "PLANO VENDA";
                        }
                        else if (RadioAluguel.Checked == true)
                        {
                            contrato.PLANO = "PLANO ALUGUEL";
                        }


                        contrato.SITUACAO = "NAO PAGO";
                        contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        new ContratoDAL().InserirParcelas(contrato);
                    }

                }
                //clocalndo o status do cliente para ATIVO
                //faz update no cliente no status dele para CANCELADO
                //localizando o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
                new CLIENTEDAL().UpdateClienteCancelamento(cliente.ID, "ATIVO");

                //alterar o imovel que estar sendo ultilizado para a situação
                new imovelDAL().AlterarSituacaoImovel(ImovelSelecionado.ID, contrato.PLANO.Trim());

                MessageBoxEx.Show("Contrato ATIVO! Salvos com sucesso.");
                Close();
                this.Dispose();
            }
            catch (Exception ex)
            {

                ExceptionErro.ExibirMenssagemException(ex);
            }


        }

        private ContratoModel DADOS()
        {
            var Contrato = new ContratoModel();
            if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                Contrato.ID = Convert.ToInt32(iDTextBox.Text);
            //dados da tela
            Contrato.ID_CLIENTE = Convert.ToInt32(iD_CLIENTETextBox.Text);
            Contrato.VALOR_MES = Convert.ToDecimal(vALOR_MESTextBox.Text);
            Contrato.DIA_BASE = Convert.ToInt32(dIA_BASETextBox.Text);
            Contrato.SITUACAO = "ATIVO";
            //gravar o aruivo gerado do contrato com o nome do cliente, data , e id do contrato
            Contrato.Documento = @"C: \Users\Public\Pictures\Sample Pictures\Desert.jpg";
            Contrato.ID_IMOVEL = Convert.ToInt32(comboImovel.SelectedValue);
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

        private void SalvarCodiçoes()
        {

            Double totallocal = 0;
            dgvParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbNParcela.Text.Trim().Replace("X", ""));
            if (parcelas == 0) { parcelas = 1; }
            if (!string.IsNullOrEmpty(vALOR_MESTextBox.Text))
            {
                totallocal = Convert.ToDouble(vALOR_MESTextBox.Text);
            }


            double valor = totallocal; //totallocal / parcelas; //valor = this.total/parcelas
            DateTime dt = new DateTime();
            dt = dtDataini.Value;

            int diaParcela = dt.Day;
            int mesParcela = dt.Month;


            for (int i = 1; i <= parcelas; i++)
            {
                String[] k = new String[] { i.ToString(), valor.ToString("C"), dt.Date.ToShortDateString(), "", "NAO PAGO", "0,00" };
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
            //pega todo o valor e soma da grid
            decimal TotalParcial = 0;
            for (int i = 0; i < dgvParcelas.RowCount; i++)
            {
                TotalParcial += Convert.ToDecimal(dgvParcelas.Rows[i].Cells[1].Value.ToString().Replace("R$", ""));

            }
            txtTotalParcial.Text = TotalParcial.ToString("C");


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
                if (dgvParcelas.Rows.Count > 0)
                {
                    double Parcelasvalidas = 0;
                    for (int i = 0; i < dgvParcelas.Rows.Count; i++)
                    {
                        if (dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString() == "")
                        {
                            MessageBoxEx.Show("Ainda existe Parcelas que não foram pagas!\n\n Para Iniciar um novo contrato, precisa pagar todos as parcelas desse contrato.\n\n Parcela: ( " + dgvParcelas.Rows[i].Cells[0].Value.ToString().ToUpper() + " ) não foi paga!");
                        }
                        else
                        {
                            MessageBoxEx.Show("Parabens autorizção concluida para um novo contrato!\n\n Parcela: ( " + dgvParcelas.Rows[i].Cells[0].Value.ToString().ToUpper() + " ) foi " + dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() + ".");
                            Parcelasvalidas = +Parcelasvalidas + 1;
                        }
                    }
                    if (Parcelasvalidas == dgvParcelas.Rows.Count)
                    {
                        DialogResult dialog = MessageBoxEx.Show("Deseja Criar novo Contrato para o cliente?", MessageIcon.Question, MessageButton.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            //ativar o botão salvar
                            BtnSalvaradm_modulo.Visible = true;
                            BtnCriarParcelas.Visible = true;
                            groupBoxPlanoContratos.Enabled = true;
                            //limpa os dados da tela
                            dgvParcelas.Rows.Clear();
                            iDTextBox.Clear();
                            vALOR_MESTextBox.Clear();
                            txtTotalParcial.Clear();
                        }
                    }//Ainda existe Parcelas para ser pagas
                    else
                    {
                        //desativa o botão salvar
                        BtnSalvaradm_modulo.Visible = false;
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
            SalvarCodiçoes();
        }

        private void BtnCancelarContrato_Click(object sender, EventArgs e)
        {
            DialogResult cancelamento = MessageBoxEx.Show("Deseja relamente cancelar este contrato?", MessageIcon.Question, MessageButton.YesNo);
            if (cancelamento == DialogResult.Yes)
            {
                //antes de finalizar o cancelamento
                //ferificar pagamentos
                int QtdParcelasvalidas = 0;
                double valortotalparcelas = 0;
                string valorparcelas = "0";
                if (dgvParcelas.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvParcelas.Rows.Count; i++)
                    {

                        if (string.IsNullOrEmpty(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString()))
                        {
                            string v = Convert.ToString(dgvParcelas.Rows[i].Cells["pco_valor"].Value);
                            valortotalparcelas = +Convert.ToDouble(v.Replace("R$", ""));
                            QtdParcelasvalidas = +QtdParcelasvalidas + 1;
                        }
                    }
                    valorparcelas = Convert.ToString(dgvParcelas.Rows[0].Cells["pco_valor"].Value);
                    using (FrmCancelamentoContrato can = new FrmCancelamentoContrato())
                    {
                        can.LbNomeClienteTelaCancelamento.Text = LBnomedoadm_modulo.Text;
                        can.txtvalordaparcela.Text = valorparcelas;
                        can.txtvalorparcelasvencidas.Text = valortotalparcelas.ToString("C");
                        can.txtQTDparcelasvencidas.Text = QtdParcelasvalidas.ToString();
                        var IDImovel = new imovelDAL().ConsultaimovelNome(comboImovel.Text.Trim());
                        can.IDImovel = IDImovel.ID;
                        can.ShowDialog();

                        if (can.Finalizar)
                        {
                            new ContratoDAL().UpdateSituacao(new ContratoModel() { SITUACAO = "CANCELADO", ID = Convert.ToInt32(iDTextBox.Text) });

                            // AS PARCELAS TMB
                            for (int i = 0; i < dgvParcelas.RowCount; i++)
                            {
                                contratoParcelamento contrato = new contratoParcelamento();
                                contrato.ID_CONTRATO = CodigoContrato;/// numero do contrato
                                contrato.N_MENSALIDADE = Convert.ToInt32(dgvParcelas.Rows[i].Cells["pco_cod"].Value.ToString());//numero da mensalidade
                                if (string.IsNullOrEmpty(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString()))
                                    contrato.DATA_PAGAMENTO = DateTime.Now;//data de hoje que foi feito o cancelamento do contrato
                                else
                                    contrato.DATA_PAGAMENTO = Convert.ToDateTime(dgvParcelas.Rows[i].Cells["DatadePagamento"].Value.ToString());

                                if ((dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "NAO PAGO") || (dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString() == "ATRASADO"))
                                    contrato.SITUACAO = "CANCELADO";
                                else
                                    contrato.SITUACAO = Convert.ToString(dgvParcelas.Rows[i].Cells["Situacao"].Value.ToString());

                                new ContratoDAL().AlterarParcelas(contrato);
                            }
                            MessageBoxEx.Show("Contrato e Parcelas estão Canceladas");
                            BtnNovoContrato.Visible = true;
                            Close();
                        }
                    };
                }
                else
                {
                    MessageBoxEx.Show("Neste contrato nao há parcelas a ser cancelada!");
                    return;
                }

            }
            Close();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtvalorEntrada_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtvalorEntrada);
        }

        private void comboImovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxEditorImovel.Clear();
            try
            {
                var IDImovel = Convert.ToInt32(comboImovel.SelectedValue);
                ImovelSelecionado = new imovelModel();
                ImovelSelecionado = new imovelDAL().CONSULTATODOSPELOID(IDImovel);
                if (ImovelSelecionado.ID > 0)
                {
                    richTextBoxEditorImovel.Text = "DETALHES DO IMOVÉL \n" +
                        "Nome: " + ImovelSelecionado.NOME + "\n" +
                        "Tipo: " + ImovelSelecionado.TIPO + "\n" +
                        "Situação: " + ImovelSelecionado.SITUACAO + "\n" +
                        "Cidade: " + ImovelSelecionado.CIDADE + "\n" +
                        "Bairro: " + ImovelSelecionado.BAIRRO + "\n" +
                        "Estado: " + ImovelSelecionado.ESTADO + "\n" +
                        "Quartos: " + ImovelSelecionado.QUARTOS + "\n" +
                         "Suites: " + ImovelSelecionado.SUITES + "\n" +
                          "Pavimentos: " + ImovelSelecionado.PAVIMENTO + "\n" +
                           "Garagem: " + ImovelSelecionado.GARAGEM + "\n" +
                            "Sala: " + ImovelSelecionado.SALA + "\n" +
                             "Banheiro: " + ImovelSelecionado.BANHEIRO + "\n" +
                              "Andar: " + ImovelSelecionado.ANDAR + "\n" +
                               "Edificio: " + ImovelSelecionado.EDIFICIO + "\n" +
                                "Iptu: " + ImovelSelecionado.VALORIPTU + "\n" +
                                 "Condominio: " + ImovelSelecionado.VALORCODOMINIO + "\n" +
                                  "Preço: " + ImovelSelecionado.VALORPRECO.ToString("C") + "\n" +
                    "Valor de aluguel: " + ImovelSelecionado.VALORALUGUEL.ToString("C") + "\n";
                    vALOR_MESTextBox.Text = ImovelSelecionado.VALORALUGUEL.ToString();
                }
            }
            catch (Exception)
            {

                MessageBoxEx.Show("Ocorreu um erro na consulta desse imovél");
            }
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
            try
            {
                #region Abre o arquivo
                object objemiss = System.Reflection.Missing.Value;
                Word.Application objeWord = new Word.Application();
                string Documento = Application.StartupPath + @"\Pasta de Contratos\CONTRATO DE LOCAÇÃO.docx";
                object DocumentoObjet = Documento;
                Word.Document objeDoc = objeWord.Documents.Open(DocumentoObjet, objemiss);
                #endregion

                #region FAz a alteração cliente
                //consulta pelo nome
                var DadosCliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
                object paramentroNome = "nome";
                Word.Range nome = objeDoc.Bookmarks.get_Item(ref paramentroNome).Range;
                nome.Text = DadosCliente.NOME;
                object NOME = nome;
                objeDoc.Bookmarks.Add("nome", ref NOME);
                //CIDADE
                object paramentroCIDADE = "CIDADE";
                Word.Range CIDADE = objeDoc.Bookmarks.get_Item(ref paramentroCIDADE).Range;
                CIDADE.Text = DadosCliente.CIDADE;
                object CIDADES = CIDADE;
                objeDoc.Bookmarks.Add("CIDADE", ref CIDADES);
                //cpf
                object paramentroCPF = "CPF";
                Word.Range CPF = objeDoc.Bookmarks.get_Item(ref paramentroCPF).Range;
                CPF.Text = DadosCliente.CPFCNPJ;
                object CPFS = CPF;
                objeDoc.Bookmarks.Add("CPF", ref CPFS);
                //ENDERCO
                object paramentroENDERECO = "ENDERECO";
                Word.Range ENDERECO = objeDoc.Bookmarks.get_Item(ref paramentroENDERECO).Range;
                ENDERECO.Text = DadosCliente.ENDERECO;
                object ENDERECOS = ENDERECO;
                objeDoc.Bookmarks.Add("ENDERECO", ref ENDERECOS);
                //RG
                object paramentroRG = "RG";
                Word.Range RG = objeDoc.Bookmarks.get_Item(ref paramentroRG).Range;
                RG.Text = DadosCliente.NUMEROINDETIDADE;
                object RGS = RG;
                objeDoc.Bookmarks.Add("RG", ref RGS);
                #endregion

                #region faz alteração no imovél
                if (ImovelSelecionado.ID > 0)
                {
                    object paramentroBAIRROIMOVEL = "BAIRROIMOVEL";
                    Word.Range BAIRROIMOVEL = objeDoc.Bookmarks.get_Item(ref paramentroBAIRROIMOVEL).Range;
                    BAIRROIMOVEL.Text = ImovelSelecionado.BAIRRO;
                    object BAIRROIMOVELS = BAIRROIMOVEL;
                    objeDoc.Bookmarks.Add("BAIRROIMOVEL", ref BAIRROIMOVELS);
                    //EDEREO DO IMOVEL
                    object paramentroENDERECOIMOVEL = "ENDERECOIMOVEL";
                    Word.Range ENDERECOIMOVEL = objeDoc.Bookmarks.get_Item(ref paramentroENDERECOIMOVEL).Range;
                    ENDERECOIMOVEL.Text = ImovelSelecionado.DESCRICAO + " Nº " + ImovelSelecionado.NUMERO;
                    object ENDERECOIMOVELS = ENDERECOIMOVEL;
                    objeDoc.Bookmarks.Add("ENDERECOIMOVEL", ref ENDERECOIMOVELS);
                    //cidade
                    object paramentroCIDADEIMOVEL = "CIDADEIMOVEL";
                    Word.Range CIDADEIMOVEL = objeDoc.Bookmarks.get_Item(ref paramentroCIDADEIMOVEL).Range;
                    CIDADEIMOVEL.Text = ImovelSelecionado.CIDADE + "-" + ImovelSelecionado.ESTADO;
                    object CIDADEIMOVELS = ENDERECOIMOVEL;
                    objeDoc.Bookmarks.Add("CIDADEIMOVEL", ref CIDADEIMOVELS);
                }
                #endregion

                #region faz alteraçã na data de inicio e data final do pagamento fim do contrato e no dia de pagamento
                //data parainiciar o contrato
                object paramentroDATAINICIO = "DATAINICIO";
                Word.Range DATAINICIO = objeDoc.Bookmarks.get_Item(ref paramentroDATAINICIO).Range;
                DATAINICIO.Text = dtDataini.Value.Date.ToString("dd/MM/yyyy");
                object DATAINICIOS = DATAINICIO;
                objeDoc.Bookmarks.Add("DATAINICIO", ref DATAINICIOS);
                //data para finalizar o contrato
                DateTime DataFinal = new DateTime();
                for (int i = 0; i < dgvParcelas.Rows.Count; i++)
                {
                    DataFinal = Convert.ToDateTime(dgvParcelas.Rows[i].Cells["pco_datavecto"].Value);
                }
                object paramentroDATAFINAL = "DATAFINAL";
                Word.Range DATAFINAL = objeDoc.Bookmarks.get_Item(ref paramentroDATAFINAL).Range;
                DATAFINAL.Text = DataFinal.Date.ToString("dd/MM/yyyy");
                object DATAFINALS = DATAFINAL;
                objeDoc.Bookmarks.Add("DATAFINAL", ref DATAFINALS);

                //dia de pagamento
                object paramentroDIAPAGAMENTO = "DIAPAGAMENTO";
                Word.Range DIAPAGAMENTO = objeDoc.Bookmarks.get_Item(ref paramentroDIAPAGAMENTO).Range;
                DIAPAGAMENTO.Text = dIA_BASETextBox.Text;
                object DIAPAGAMENTOS = DIAPAGAMENTO;
                objeDoc.Bookmarks.Add("DIAPAGAMENTO", ref DIAPAGAMENTOS);
                //VALOR MENSAL
                object paramentroVALORMENSAL = "VALORMENSAL";
                Word.Range VALORMENSAL = objeDoc.Bookmarks.get_Item(ref paramentroVALORMENSAL).Range;
                decimal VALOR = Convert.ToDecimal(vALOR_MESTextBox.Text.ToString());
                VALORMENSAL.Text = VALOR.ToString("C") + "(" + EscreverExtenso(VALOR) + ")";
                object VALORMENSALS = VALORMENSAL;
                objeDoc.Bookmarks.Add("VALORMENSAL", ref VALORMENSALS);
                #endregion
                //data por extensonm
                //desmenbrando a data
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                int dia = DateTime.Now.Day;
                int ano = DateTime.Now.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
                string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
                string DataAtualizada = "Manaus, AM, " + dia + " de " + mes + " de " + ano;

                object paramentroDATAGERADOR = "DATAGERADOR";
                Word.Range DATAGERADOR = objeDoc.Bookmarks.get_Item(ref paramentroDATAGERADOR).Range;
                DATAGERADOR.Text = DataAtualizada;
                object DATAGERADORs = DATAGERADOR;
                objeDoc.Bookmarks.Add("DATAGERADOR", ref DATAGERADORs);

                //NOMECLIENTEASSINA
                object paramentroNOMECLIENTEASSINA = "NOMECLIENTEASSINA";
                Word.Range NOMECLIENTEASSINA = objeDoc.Bookmarks.get_Item(ref paramentroNOMECLIENTEASSINA).Range;
                NOMECLIENTEASSINA.Text = DadosCliente.NOME;
                object NOMECLIENTEASSINAS = NOMECLIENTEASSINA;
                objeDoc.Bookmarks.Add("NOMECLIENTEASSINA", ref NOMECLIENTEASSINAS);
                //RG
                object paramentroRGCLIENTEASSINA = "RGCLIENTEASSINA";
                Word.Range RGCLIENTEASSINA = objeDoc.Bookmarks.get_Item(ref paramentroRGCLIENTEASSINA).Range;
                RGCLIENTEASSINA.Text = DadosCliente.NUMEROINDETIDADE.ToString();
                object RGCLIENTEASSINAS = RGCLIENTEASSINA;
                objeDoc.Bookmarks.Add("RGCLIENTEASSINA", ref RGCLIENTEASSINAS);


                objeWord.Visible = true;


                MessageBoxEx.Show("Arquivo gerado com sucesso sem erros!");
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Ocorreu um erro na Geração do contrato! \n" +
                    "Reveja os campos para geração corretamento do contrato.", "Detalhes" + ex.Message);

            }
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
    }
}
