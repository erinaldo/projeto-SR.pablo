using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.PARAMETROS;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
using SoftwareGerenciador.Mensalidade;
using Dados.imovels;
using Dados.Contrato_imprestimo;
using SoftwareGerenciador.Recibo;

namespace SoftwareGerenciador.adm_modulo
{
    public partial class frmReceberPagamentoImprestimo : Form
    {
        public frmReceberPagamentoImprestimo()
        {
            InitializeComponent();
        }
        public Parametros ParametrosDados;
        public int CodigoContrato { get; set; }
        public cliente ClienteTela;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceberPagamento_Load(object sender, EventArgs e)
        {
            //CLIENTE NO TXT
            ClienteTela = new CLIENTEDAL().CONSULTATODOSPELONOME(LBnomedoadm_modulo.Text.Trim());
            iD_CLIENTETextBox.Text = ClienteTela.ID.ToString();

            //ferificar se existe parcela
            LoadConsultaParcelas();
            Parametros();
            CalculoTaxa();

        }
        public void LoadConsultaParcelas()
        {
            var ExisteParcelas = new ContratoImprestimoDAL().ConsultaParcelas(CodigoContrato);
            if (ExisteParcelas.Count > 0)
            {
                if (ExisteParcelas[0].PLANO == "Plano Imprestimo Price")
                {
                    BtnpagamentoJuros.Visible = false;
                    txtvalorMensalidadeJuros.Visible = false;
                }
                else if (ExisteParcelas[0].PLANO == "Plano Imprestimo Juros")
                {
                    //Ativa Pagamento deJuros
                    BtnpagamentoJuros.Visible = true;
                    txtvalorMensalidadeJuros.Visible = true;

                    //Ativa Pagamento Normal Imprestimo
                    txtvalorMensalidade.Visible = false;
                    txtvalorFracionado.Visible = false;
                    BtnpagamentoFracionado.Visible = false;
                    BtnSalvaradm_modulo.Visible = false;
                    LbValorPrestacao.Visible = false;
                    LbValorFracionado.Visible = false;
                    groupBox1.Visible = false;
                }
                DGVDADOS.DataSource = null;
                DGVDADOS.DataSource = ExisteParcelas;
                //MontarGrid();
                siFrao();
                //total de meses
                txtquantidademeses.Text = ExisteParcelas.Count.ToString();
                //valor da mensalidade
                decimal valormensalidade = Convert.ToDecimal(ExisteParcelas[0].VALOR_PRESTACAO);
                //decimal valorJuros = Convert.ToDecimal(ExisteParcelas[0].VALOR_JUROS);

                //txtvalorMensalidadeIntegral.Text = (valormensalidade + valorJuros).ToString("C");
                txtvalormensal.Text = valormensalidade.ToString("C");
                //txtvalorMensalidade.Text = valormensalidade.ToString("C");
                //txtvalorMensalidadeJuros.Text = valorJuros.ToString("C");
                //total pago
                decimal Mensal = 0;
                decimal totalReceberJuros = 0;
                for (int i = 0; i < ExisteParcelas.Count; i++)
                {
                    Mensal += ExisteParcelas[i].VALOR_PRESTACAO;
                    totalReceberJuros += ExisteParcelas[i].VALOR_JUROS;
                }
                txtvalortotal.Text = (totalReceberJuros + Mensal).ToString("C");
            }
        }
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "DATA_PAGAMENTO", "N_MENSALIDADE", "VALOR", "FORMA_PAGAMENTO" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "ID", "DATA PAGAMENTO", "nº Mês", "VALOR", "FORMA PAGAMENTO" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 10,30,30,30 }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);


        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            //Moeda(ref txtvalorMensalidade);
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
        private void Parametros()
        {
            try
            {
                ParametrosDados = new Parametros();
                ParametrosDados = new ParametrosDal().Todos(new Parametros());
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            try
            {
                //validação
                if (string.IsNullOrWhiteSpace(txtvalorMensalidade.Text))
                {
                    MessageBoxEx.Show("valor invalido!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
                {
                    MessageBoxEx.Show("Situação de pagamento invalido!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
                {
                    MessageBoxEx.Show("Forma de pagamento invalido!");
                    return;
                }
                //valida se foi selçecionado a parcela que nao foi paga
                if (Convert.ToString(DGVDADOS.SelectedRows[0].Cells["SITUACAO"].Value) == "PAGO")
                {
                    MessageBoxEx.Show("Parcela selecionada ja estar paga.\n Invalido!\n\n Selecione a parcela á ser paga.");
                    return;
                }
                var tela = dados();//colhe os dados da tela depois de validar

                //inserir
                new ContratoImprestimoDAL().ReceberPagamento(tela);
                MessageBoxEx.Show("Recebimento realizado com sucesso!");

                //atualiza a datagrid
                //ferificar se existe parcela
                LoadConsultaParcelas();

                DialogResult pgt = MessageBoxEx.Show("Deseja Criar um recibo simples!\n Vou lhe enviar pra tela de criação!", MessageIcon.Question, MessageButton.YesNo);
                if (DialogResult.Yes == pgt)
                {
                    using (FrmRecibo f = new FrmRecibo())
                    {
                        f.ShowDialog();
                    }

                }

                //consulta contrato
                //var Contrato = new ContratoDAL().ConsultaContratoID(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value));
                //var EnderecoImovel = new imovelDAL().CONSULTATODOSPELOID(Contrato.ID_IMOVEL);
                //CriarPDF.CriarPDFRecibo(LBnomedoadm_modulo.Text, 
                //    EnderecoImovel.NOME +" Bairro: "+
                //    EnderecoImovel.BAIRRO, 
                //    txtvalorMensalidade.Text, 
                //    "Pagamento de Aluguel/Mensalidade!");
                //System.Diagnostics.Process.Start("ReciboGErado.pdf");

                //DialogResult watsap = MessageBoxEx.Show("Deseja Enviar Whatsapp?", MessageIcon.Question, MessageButton.YesNo);
                //if(watsap == DialogResult.Yes)
                //{
                //    if (!string.IsNullOrEmpty(ClienteTela.TELEFONE1.ToString()))
                //    {
                //        DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
                //        CultureInfo culture = new CultureInfo("pt-BR");
                //        DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                //        int dia = data.Day;
                //        int ano = data.Year;
                //        string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                //        string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                //        string dataDesmenbrada = mes + " / " + ano;

                //        Link.Text = @"https://api.whatsapp.com/send?phone=55" + ClienteTela.TELEFONE1.ToString().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "&text=Pagamento efetuado com sucesso Sr(a) " + LBnomedoadm_modulo.Text + " .Caro cliente, segue o comprovante de pagamento mensal com vencimento " + dataDesmenbrada + ", referente ao serviço de rastreamento veicular.Pago em: " + datapagamento.Value + " Valor da mensalidade R$: " + txtvalor.Text + ".Na forma de pagamento: " + comboPagamento.Text + ".agradecemos a sua preferência.";
                //        //enviar watsap
                //        System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                //        pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(Link.Text);
                //        pStart.Start();
                //    }
                //}


                //DialogResult Email = MessageBoxEx.Show("Deseja Enviar o E-mail?", MessageIcon.Question, MessageButton.YesNo);
                //if(Email == DialogResult.Yes)
                //{
                //    FrmLoading loading = new FrmLoading();
                //    //enviar email
                //    if ((!string.IsNullOrEmpty(ParametrosDados.EMAIL)) && (!string.IsNullOrEmpty(ParametrosDados.SENHA)))
                //    {
                //        if (ClienteTela.EMAILPARTICULAR == null) { MessageBoxEx.Show("Cliente não tem E-mail cadastrado!"); }
                //        else if (!string.IsNullOrEmpty(ClienteTela.EMAILPARTICULAR.ToString()))
                //        {
                //            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                //            {

                //                //Domínio Servidor    Porta
                //                //@outlook =   smtp - mail.outlook.com   587
                //                //@gmail = smtp.gmail.com  587 ou 465
                //                //@hotmail = smtp.live.com   25 ou 587
                //                smtp.Host = ParametrosDados.smtp.ToString().Trim();
                //                smtp.Port = Convert.ToInt32(ParametrosDados.Porta.ToString().Trim());
                //                smtp.EnableSsl = true;
                //                smtp.UseDefaultCredentials = false;
                //                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //                smtp.Credentials = new System.Net.NetworkCredential(ParametrosDados.EMAIL.ToString().Trim(), ParametrosDados.SENHA.ToString().Trim());


                //                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                //                {
                //                    mail.From = new System.Net.Mail.MailAddress(ParametrosDados.EMAIL.ToString().Trim());

                //                    //if (!string.IsNullOrWhiteSpace(textBoxPara.Text)) //para o email
                //                    //{
                //                    mail.To.Add(new System.Net.Mail.MailAddress(ClienteTela.EMAILPARTICULAR.ToString().Trim())); //"pegasusrastreadores@gmail.com"));

                //                    //desmenbrando a data
                //                    DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
                //                    CultureInfo culture = new CultureInfo("pt-BR");
                //                    DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                //                    int dia = data.Day;
                //                    int ano = data.Year;
                //                    string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                //                    string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                //                    string dataDesmenbrada = mes + " / " + ano;

                //                    var contentID = "Image";
                //                    var inlineLogo = new Attachment(Application.StartupPath + "/Pegasus.jpg");
                //                    inlineLogo.ContentId = contentID;
                //                    inlineLogo.ContentDisposition.Inline = true;
                //                    inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                //                    mail.Attachments.Add(inlineLogo);
                //                    //mail.Body += "<br /><br /><img src=\"cid:" + contentID + "\" height=\"42\" width=\"42\"><br />";

                //                    mail.Subject = "Pagamento de Aluguel";// asunto
                //                    //mail.Body += "Pagamento efetuado com sucesso.<br /> " +
                //                    //    "Sr(a). " + LBnomedoadm_modulo.Text + "<br /> " +
                //                    //      "Caro cliente, segue em anexo o comprovante de pagamento mensal com vencimento " + dataDesmenbrada + " , referente ao serviço de rastreamento veicular.<br /> " +
                //                    //    "Pago em: " + datapagamento.Value + "<br /> " +
                //                    //    "Valor da mensalidade R$: " + txtvalor.Text + " na forma de pagamento: " + comboPagamento.Text + ".<br /> " +
                //                    //    "agradecemos a sua preferência.";// texto

                //                    mail.IsBodyHtml = true;

                //                    CriarPDF(LBnomedoadm_modulo.Text, datapagamento.Value, dataDesmenbrada, comboPagamento.Text, txtvalor.Text);
                //                    //Arquivo
                //                    mail.Attachments.Add(new System.Net.Mail.Attachment(Application.StartupPath + "/Recibo.pdf"));
                //                    loading.Show();
                //                    await smtp.SendMailAsync(mail);
                //                    loading.Close();
                //                    MessageBoxEx.Show("E-mail Enviando com Sucesso. ");
                //                }
                //            }
                //        }
                //    }
                //}

                //ferificar se foi pago a ultima parcelada desse contrato
                if (DGVDADOS.Rows.Count > 0)
                {
                    double Parcelasvalidas = 0;
                    int p = 2;
                    for (int i = 0; i < DGVDADOS.Rows.Count; i++)
                    {
                        if ((DGVDADOS.Rows[i].Cells["VALOR_PAGO"].Value.ToString() != "") && (Convert.ToDecimal(DGVDADOS.Rows[i].Cells["VALOR_PAGO"].Value) > 0))
                            Parcelasvalidas = p++;
                    }
                    if (Parcelasvalidas == DGVDADOS.Rows.Count)
                    {
                        //atualiza o status do contrato
                        new ContratoImprestimoDAL().UpdateSituacao(new ContratoModel() { SITUACAO = "CONCLUIDO", ID = CodigoContrato });

                        DialogResult dialog = MessageBoxEx.Show("Deseja Criar novo Contrato para o cliente?", MessageIcon.Question, MessageButton.YesNo);
                        if (dialog == DialogResult.Yes)
                        {

                            //criar um novo contrato
                            FrmCriarCodicoesPagamentoImprestimo pagamento = new FrmCriarCodicoesPagamentoImprestimo();
                            pagamento.LBnomedoadm_modulo.Text = LBnomedoadm_modulo.Text;
                            pagamento.CodigoContrato = CodigoContrato;
                            pagamento.ShowDialog();
                        }

                    }
                    else
                    {
                        //ferifiar se o usuario quer pagar mas parcelas
                        DialogResult maspagamento = MessageBoxEx.Show("Deseja fazer mas pagamentos?", MessageIcon.Question, MessageButton.YesNo);
                        if (maspagamento == DialogResult.Yes)
                        {
                            LoadConsultaParcelas();

                            //Parametros();
                            CalculoTaxa();
                        }
                        //MontarGrid();
                        siFrao();
                    }

                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro em fazer pagamento.\n\n Motivo: " + ex.Message);
            }


        }
        private void siFrao()
        {
            //MontarGrid();
            DGVDADOS.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVDADOS.Columns[1].Visible = false;
            //DGVDADOS.Columns[8].Visible = false;
            DGVDADOS.Columns[6].DefaultCellStyle.Format = "c";
            DGVDADOS.Columns[7].DefaultCellStyle.Format = "c";
            DGVDADOS.Columns[8].DefaultCellStyle.Format = "c";
            DGVDADOS.Columns[9].DefaultCellStyle.Format = "c";
        }
        private ContratoImprestimoParcela dados()
        {
            var tela = new ContratoImprestimoParcela();
            tela.ID_CONTRATO = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value);
            tela.DATA_PAGAMENTO = datapagamento.Value;

            if (DGVDADOS.CurrentRow.Cells["VALORFRACIONADO"].Value.ToString() != "0")
            {
                decimal Restante = Convert.ToDecimal(txtvalorMensalidade.Text.Trim().Replace("R$", ""));
                decimal fracionado = Convert.ToDecimal(DGVDADOS.CurrentRow.Cells["VALORFRACIONADO"].Value.ToString());
                decimal total = Restante + fracionado;
                tela.VALOR_PAGO = total;
            }
            else
                tela.VALOR_PAGO = Convert.ToDecimal(txtvalorMensalidade.Text.Trim().Replace("R$", ""));

            tela.FORMA_PAGAMENTO = comboPagamento.Text.Trim();
            tela.SITUACAO = ComboSituacao.Text.Trim();
            tela.ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
            tela.DATA_VENCIMENTO = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
            return tela;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            CalculoTaxa();
        }
        private void CalculoTaxa()
        {
            //try
            //{
            //    if (!string.IsNullOrEmpty(txtvalormensal.Text))
            //    {
            //        decimal valorTaxa = Convert.ToDecimal(TxtPorcentagem.Text.Trim());
            //        decimal porcento = Convert.ToDecimal(valorTaxa / 100);// valor de porcento dividido por 100
            //        string v = txtvalormensal.Text.Replace("R$", "").Trim();
            //        decimal ValorApagar = Convert.ToDecimal(v);
            //        decimal resultado = Convert.ToDecimal(porcento * ValorApagar);

            //        //txtvalor.Text = resultado.ToString("F");
            //        //somando a porcentagem com o valor a ser pago
            //        decimal totalaPagar = Convert.ToDecimal(resultado) + ValorApagar;
            //        txtvalorMensalidadeIntegral.Text = totalaPagar.ToString("F");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBoxEx.Show("Confirar os campos da tela: " + ex.Message + ex.StackTrace);
            //}
        }

        private void TxtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //codigo para permiti apenas numeros no texbox
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //else
            //    MessageBoxEx.Show("Caractere não permitido!");
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //codigo para permiti apenas numeros no texbox
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //else
            //    MessageBoxEx.Show("Caractere não permitido!");
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

        private void BtnpagamentoJuros_Click(object sender, EventArgs e)
        {
            //validação
            if (string.IsNullOrWhiteSpace(txtvalorMensalidade.Text))
            {
                MessageBoxEx.Show("valor invalido!");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
            {
                MessageBoxEx.Show("Situação de pagamento invalido!");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
            {
                MessageBoxEx.Show("Forma de pagamento invalido!");
                return;
            }
            //valida se foi selçecionado a parcela que nao foi paga
            if (Convert.ToString(DGVDADOS.SelectedRows[0].Cells["SITUACAO"].Value) == "PAGO")
            {
                MessageBoxEx.Show("Parcela selecionada ja estar paga.\n Invalido!\n\n Selecione a parcela á ser paga.");
                return;
            }

            //faz o pagamento do juros
            var tela = new ContratoImprestimoParcela();
            tela.ID_CONTRATO = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value);
            tela.DATA_PAGAMENTO = datapagamento.Value;
            tela.VALOR_PAGO = Convert.ToDecimal(txtvalorMensalidadeJuros.Text.Trim().Replace("R$", ""));
            tela.FORMA_PAGAMENTO = comboPagamento.Text.Trim();
            tela.SITUACAO = ComboSituacao.Text.Trim();
            tela.ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
            tela.DATA_VENCIMENTO = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
            new ContratoImprestimoDAL().ReceberPagamento(tela);

            DialogResult dialog = MessageBoxEx.Show("Pagamento do Juros realizado com sucesso!\n" +
               "Deseja acrescenta uma parcela para o proximo mes?...\n" +
               "(Se |SIM| irá adiconar mas um pagamento para o proximo mes com o valor de juros do valor imprestado)\n\n\n" +
               "(se |NAO| o sistema interde que nao queres mas gerenciar este contrato, automaticamento ira ser cancelado)\n\n" +
               "ATENÇAO", MessageIcon.Question, MessageButton.YesNo);
            if (DialogResult.Yes == dialog)
            {
                //cria mas uma parcela
                SalvarUmaPagamentoJuros();
            }
            else if (DialogResult.No == dialog)
            {
                new ContratoImprestimoDAL().UpdateSituacao(new ContratoModel() 
                { SITUACAO = "CANCELADO", ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value) });
                MessageBoxEx.Show("Contrato cancelado.");
                this.Close();
            }
            //atualiza a datagrid
            //ferificar se existe parcela
            LoadConsultaParcelas();

        }
        private void SalvarUmaPagamentoJuros()
        {

            try
            {

                //dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(1);//numero de parcelas a ser acrescentada

                //this.totalCompra = Convert.ToDouble(txtvalorMensalidade.Text.Trim().Replace("R$",""));
                //this.totaljuros = Convert.ToDouble(txtValorJuros.Text);

                //Double totallocal = this.totalCompra;
                //Double totaljurosLocal = this.totaljuros;
                //double valor = totallocal / parcelas; //valor da parcela
                //double juros = totaljurosLocal / parcelas;

                #region paga a data do ultimo vencimento
                DateTime dt = new DateTime();
                int NumeroMensalidade = 0;
                for (int i = 0; i < DGVDADOS.Rows.Count; i++)
                {
                    dt = Convert.ToDateTime(DGVDADOS.Rows[i].Cells["DATA_VENCIMENTO"].Value);
                    NumeroMensalidade = Convert.ToInt32(DGVDADOS.Rows[i].Cells["N_MENSALIDADE"].Value);
                }
                #endregion

                int diaParcela = dt.Day;
                int mesParcela = dt.Month;

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
                //grava no banco a parcela acrencetando no contrato
                var contratoParcela = new ContratoImprestimoParcela();
                contratoParcela.ID_CONTRATO = Convert.ToInt32(DGVDADOS.Rows[0].Cells["ID_CONTRATO"].Value);
                contratoParcela.VALOR_PRESTACAO = 0;
                contratoParcela.VALOR_JUROS = Convert.ToDecimal(txtvalorMensalidadeJuros.Text.Trim().Replace("R$", ""));
                contratoParcela.DATA_VENCIMENTO = dt.Date;
                //pega o plano
                contratoParcela.PLANO = "Plano Imprestimo Juros";

                contratoParcela.SITUACAO = "NAO PAGO";
                contratoParcela.N_MENSALIDADE = NumeroMensalidade + 1;
                new ContratoImprestimoDAL().InserirParcelas(contratoParcela);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtvalorFracionado_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtvalorFracionado);
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

        private void BtnpagamentoFracionado_Click(object sender, EventArgs e)
        {
            //validação
            if (string.IsNullOrWhiteSpace(txtvalorMensalidade.Text))
            {
                MessageBoxEx.Show("valor invalido!");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
            {
                MessageBoxEx.Show("Situação de pagamento invalido!");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboSituacao.Text))
            {
                MessageBoxEx.Show("Forma de pagamento invalido!");
                return;
            }
            //valida se foi selçecionado a parcela que nao foi paga
            if (Convert.ToString(DGVDADOS.SelectedRows[0].Cells["SITUACAO"].Value) == "PAGO")
            {
                MessageBoxEx.Show("Parcela selecionada ja estar paga.\n Invalido!\n\n Selecione a parcela á ser paga.");
                return;
            }

            //faz o pagamento do juros
            var tela = new ContratoImprestimoParcela();
            tela.ID_CONTRATO = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value);
            tela.DATA_PAGAMENTO = datapagamento.Value;
            tela.VALORFRACIONADO = Convert.ToDecimal(txtvalorFracionado.Text.Trim().Replace("R$", ""));
            tela.FORMA_PAGAMENTO = comboPagamento.Text.Trim();
            tela.SITUACAO = "FRACIONADO";
            tela.ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
            tela.DATA_VENCIMENTO = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
            new ContratoImprestimoDAL().ReceberPagamentoFracionado(tela);

            //atualiza a datagrid
            //ferificar se existe parcela
            LoadConsultaParcelas();

            //cria mas uma parcela
            //SalvarUmaPagamentoJuros();
            decimal fra = Convert.ToDecimal(DGVDADOS.SelectedRows[0].Cells["VALORFRACIONADO"].Value);
            decimal va = Convert.ToDecimal(txtvalorMensalidade.Text.Trim().Replace("R$", ""));
            decimal res = va - fra;
            MessageBoxEx.Show("Pagamento Fracionado realizado com sucesso!\n" +
                "Falta ( " + res.ToString("C") + " )");
            txtvalorFracionado.Clear();

            DialogResult dialog = MessageBoxEx.Show("Deseja Criar um recibo simples!\n Vou lhe enviar pra tela de criação!", MessageIcon.Question, MessageButton.YesNo);
            if (DialogResult.Yes == dialog)
            {
                using (FrmRecibo f = new FrmRecibo())
                {
                    f.ShowDialog();
                }

            }
            this.Close();
        }

        private void DGVDADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iDTextBox.Text = DGVDADOS.CurrentRow.Cells["ID"].Value.ToString();
                txtvalorMensalidadeJuros.Text = DGVDADOS.CurrentRow.Cells["VALOR_JUROS"].Value.ToString();
                if (DGVDADOS.CurrentRow.Cells["VALORFRACIONADO"].Value.ToString() != "0")
                {
                    decimal prestacao = Convert.ToDecimal(DGVDADOS.CurrentRow.Cells["VALOR_PRESTACAO"].Value.ToString());
                    decimal fracionado = Convert.ToDecimal(DGVDADOS.CurrentRow.Cells["VALORFRACIONADO"].Value.ToString());
                    decimal total = prestacao - fracionado;
                    txtvalorMensalidade.Text = total.ToString();
                }
                else
                    txtvalorMensalidade.Text = DGVDADOS.CurrentRow.Cells["VALOR_PRESTACAO"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Erro no calculo.");
            }

        }
        //public void CriarPDF(string nome,DateTime datapagamento,string dataDesmenbrada, string FormaPAgamento, string Valor)
        //{
        //    // C#
        //    using (var doc = new PdfSharp.Pdf.PdfDocument())
        //    {
        //        var NomeCliente = nome;
        //        var DadosCliente = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);

        //        decimal valor = Convert.ToDecimal(Valor);
        //        var TextoValor = EscreverExtenso(valor);

        //        var FormaPagamento = FormaPAgamento;
        //        var vencimento = dataDesmenbrada;
        //        var CPF = DadosCliente.CPFCNPJ;
        //        var dataBase = DadosCliente.DIAVENCIMENTO;

        //        var page = doc.AddPage();
        //        var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
        //        var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
        //        var font = new PdfSharp.Drawing.XFont("Arial", 14);
        //        var fontTexto = new PdfSharp.Drawing.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Underline);

        //        // Imagem.
        //        var caminho = Application.StartupPath + "\\Pegasus.jpg";
        //        graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(caminho), 0, 30, 200, 100);


        //        // C#
        //        // Textos.
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
        //        textFormatter.DrawString("PEGASUS RASTREADOR", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 30, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
        //        textFormatter.DrawString("VEICULOS", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 50, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
        //        textFormatter.DrawString("Recibo Mensal", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 70, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("Recebi (emos) de: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 150, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("" + NomeCliente, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(150, 150, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("A importancia de: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 170, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("" + TextoValor, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(150, 170, page.Width - 60, page.Height - 60));


        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("Forma de pagamento: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 190, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("" + FormaPagamento, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(170, 190, page.Width - 60, page.Height - 60));


        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("Referente: Serviço de Rastreamento e Monitoramento Veicular", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 210, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("Vencimento: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 230, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
        //        textFormatter.DrawString("" + vencimento, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, 230, page.Width - 60, page.Height - 60));


        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        textFormatter.DrawString("CPF/CNPJ: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 250, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        textFormatter.DrawString("" + CPF, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, 250, page.Width - 60, page.Height - 60));

        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("TIPO: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 270, page.Width - 60, page.Height - 60));
        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("" + Tipo, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, 270, page.Width - 60, page.Height - 60));

        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("COR: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 290, page.Width - 60, page.Height - 60));
        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("" + cor, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, 290, page.Width - 60, page.Height - 60));

        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("Placa: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 310, page.Width - 60, page.Height - 60));
        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("" + placa, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, 310, page.Width - 60, page.Height - 60));

        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("Data de Instalação: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 330, page.Width - 60, page.Height - 60));
        //        //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        //textFormatter.DrawString("" + dataInstalacao, fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(170, 330, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        textFormatter.DrawString("Data base para pagamento: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 350, page.Width - 60, page.Height - 60));
        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
        //        textFormatter.DrawString("Todo dia " + dataBase + " de cada Mês", fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(210, 350, page.Width - 60, page.Height - 60));

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
        //        textFormatter.DrawString("Por ser verdade, firmo o presente.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 390, page.Width - 60, page.Height - 60));

        //        //desmenbrando a data
        //        CultureInfo culture = new CultureInfo("pt-BR");
        //        DateTimeFormatInfo dtfi = culture.DateTimeFormat;

        //        int dia = DateTime.Now.Day;
        //        int ano = DateTime.Now.Year;
        //        string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
        //        string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
        //        string DataRecibo = "Manaus, AM, " + dia + " de " + mes + " de " + ano;

        //        textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Right;
        //        textFormatter.DrawString(DataRecibo, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 420, page.Width - 60, page.Height - 60));

        //        //salva
        //        doc.Save("Recibo.pdf");
        //        //System.Diagnostics.Process.Start("Recibo.pdf");
        //    }
        //}

    }
}
