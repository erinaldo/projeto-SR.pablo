using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.imovels;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistemaVersaoWEB.principal
{
    public partial class ReceberAluguel : System.Web.UI.Page
    {
        contratoParcelamento DadosLinhaSelecionada;
        public void MensageBox(String mensagem)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + mensagem + "');</script>");

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session["Mensagem"] = "Sua sessão expirou!\n\nFaça login novamente";
                MensageBox("Sua sessão expirou!\n\nFaça login novamente");
                Response.Redirect("TelaPrincipla.aspx");
            }
            else if (Session["Usuario"] != null)
            {
                LoginUsuario usuario = (LoginUsuario)Session["Usuario"];
                if (this.Master.AppRelativeVirtualPath == "~/Site.Mobile.Master")//"~/Site.Master"
                {
                    ((Site_Mobile)this.Master).Nomeusuario = usuario.NOME;
                    ((Site_Mobile)this.Master).NivelUsuario = usuario.CARGO;
                }
                else if (this.Master.AppRelativeVirtualPath == "~/Site.Master")//~/Site.Mobile.Master
                {
                    ((SiteMaster)this.Master).Nomeusuario = usuario.NOME;
                    ((SiteMaster)this.Master).NivelUsuario = usuario.CARGO;

                }
            }


            DadosLinhaSelecionada = (contratoParcelamento)Session["DadosLinhaCelecionada"];
            //string id = DadosLinhaSelecionada.ID.ToString();
            //string numero = DadosLinhaSelecionada.Cells[1].Text;
            LbNomeCliente.Text = "Cliente: " + DadosLinhaSelecionada.cliente.NOME;
            //string plano = DadosLinhaSelecionada.Cells[3].Text;
            //string datavenci = DadosLinhaSelecionada.Cells[4].Text;
            //string valor = DadosLinhaSelecionada.Cells[5].Text;
            //string situacao = DadosLinhaSelecionada.Cells[6].Text;
            //string fracionado = DadosLinhaSelecionada.Cells[7].Text;
            //numero da parcela
            //txtvalorPago.Text = DadosLinhaSelecionada.Cells[5].Text;
            LbNumeroParcela.Text = "Parcelas: Nº " + DadosLinhaSelecionada.N_MENSALIDADE;
            LbSituacao.Text = "Situação: " + DadosLinhaSelecionada.SITUACAO;
            LbPlano.Text = "Plano Atual: " + DadosLinhaSelecionada.PLANO;
            LbValorAtual.Text = "Valor: R$ " + DadosLinhaSelecionada.VALOR;
            if(!string.IsNullOrEmpty(DadosLinhaSelecionada.VALORFRACIONADO.ToString()))
            {
                LbValorFrcionado.Visible = true;
                LbValorFrcionado.Text = " - Fracionado: R$ "+DadosLinhaSelecionada.VALORFRACIONADO;
            }
            else
            {
                LbValorFrcionado.Visible = false;
            }
                
            LbDataVencimento.Text = "Vencimento: " + Convert.ToDateTime(DadosLinhaSelecionada.DATA_VENCIMENTO).ToString("dd/MM/yyyy");

            BtnFinalizar.Visible = false;
            BtnFracionado.Visible = false;
        }

        protected void ListaSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaSituacao.Text == "Selecione...")
            {
                BtnFinalizar.Visible = false;
                BtnFracionado.Visible = false;
            }
            else if (ListaSituacao.Text == "PAGO")
            {
                BtnFinalizar.Visible = true;
                BtnFracionado.Visible = false;

            }
            else if (ListaSituacao.Text == "FRACIONADO")
            {
                BtnFinalizar.Visible = false;
                BtnFracionado.Visible = true;
            }
        }

        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ALUGUEL.aspx");
        }

        #region Recebimento completo
        protected void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //validação
                if (string.IsNullOrWhiteSpace(txtvalorPago.Text))
                {
                    MensageBox("Coloque um valor para pagamento!");
                    return;
                }
                if (ListaFormaPagamento.Text == "Selecione...")
                {
                    MensageBox("Selecione uma forma para pagamento!");
                    return;
                }
                if (ListaSituacao.Text == "Selecione...")
                {
                    MensageBox("Situação invalida! Selecione uma situação.");
                    return;
                }
                if (txtDataPagamento.Value == string.Empty)
                {
                    MensageBox("Localize uma data para realização do pagamento.");
                    return;
                }
                var tela = new contratoParcelamento();
                tela.ID_CONTRATO = Convert.ToInt32(DadosLinhaSelecionada.ID_CONTRATO);
                tela.DATA_PAGAMENTO = Convert.ToDateTime(txtDataPagamento.Value);
                tela.VALOR_PAGO = Convert.ToDecimal(txtvalorPago.Text.Trim());
                tela.FORMA_PAGAMENTO = ListaFormaPagamento.Text.Trim();
                tela.SITUACAO = ListaSituacao.Text.Trim();
                //tela.ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                tela.DATA_VENCIMENTO = Convert.ToDateTime(DadosLinhaSelecionada.DATA_VENCIMENTO);
                tela.VALORFRACIONADO = 0;
                //inserir
                new ContratoDAL().ReceberPagamento(tela);
                MensageBox("Recebimento completo realizado com sucesso!");

                //consulta contrato
                var Contrato = new ContratoDAL().ConsultaContratoID(Convert.ToInt32(DadosLinhaSelecionada.ID_CONTRATO));
                var EnderecoImovel = new imovelDAL().CONSULTATODOSPELOID(Contrato.ID_IMOVEL);
                CriarPDFRecibo(DadosLinhaSelecionada.cliente.NOME,
                    EnderecoImovel.NOME + " Bairro: " +
                    EnderecoImovel.BAIRRO,
                    txtvalorPago.Text.Trim(),
                    "Pagamento de Aluguel/Mensalidade!");
               

                #region metodo de Watsapp
                //var ClienteTela = new CLIENTEDAL().CONSULTATODOSPELONOME(DadosLinhaSelecionada.cliente.NOME);
                //if (!string.IsNullOrEmpty(ClienteTela.TELEFONE1.ToString()))
                //{
                //    DateTime data = Convert.ToDateTime(DadosLinhaSelecionada.DATA_VENCIMENTO);
                //    CultureInfo culture = new CultureInfo("pt-BR");
                //    DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                //    int dia = data.Day;
                //    int ano = data.Year;
                //    string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                //    string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                //    string dataDesmenbrada = mes + " / " + ano;

                //    Link.Text = @"https://api.whatsapp.com/send?phone=55" + ClienteTela.TELEFONE1.ToString().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "&text=Pagamento efetuado com sucesso Sr(a) " + ClienteTela.NOME + " " +
                //        ".Caro cliente, segue o comprovante de pagamento mensal com vencimento " + dataDesmenbrada + ", referente ao serviço de rastreamento veicular.Pago em: " + txtDataPagamento.Value + " Valor da mensalidade R$: " + Convert.ToDecimal(txtvalorPago.Text.Trim()).ToString("C") + "" +
                //        ".Na forma de pagamento: " + ListaFormaPagamento.Text.Trim() + ".agradecemos a sua preferência.";
                //    //enviar watsap
                //    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                //    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(Link.Text);
                //    pStart.Start();
                //}
                #endregion

                Response.Redirect("ALUGUEL.aspx");
            }
            catch (Exception ex)
            {

                MensageBox("Email OU mensagem whatsapp.\n\n Não foi enviado por motivo: " + ex.Message);
            }
        }
        #endregion

        protected void BtnFracionado_Click(object sender, EventArgs e)
        {
            try
            {
                //validação
                if (string.IsNullOrWhiteSpace(txtvalorPago.Text))
                {
                    MensageBox("Coloque um valor para pagamento!");
                    return;
                }
                if (ListaFormaPagamento.Text == "Selecione...")
                {
                    MensageBox("Selecione uma forma para pagamento!");
                    return;
                }
                if (ListaSituacao.Text == "Selecione...")
                {
                    MensageBox("Situação invalida! Selecione uma situação.");
                    return;
                }
                if (txtDataPagamento.Value == string.Empty)
                {
                    MensageBox("Localize uma data para realização do pagamento.");
                    return;
                }
                var tela = new contratoParcelamento();
                tela.ID_CONTRATO = Convert.ToInt32(DadosLinhaSelecionada.ID_CONTRATO);
                tela.DATA_PAGAMENTO = Convert.ToDateTime(txtDataPagamento.Value);
                tela.VALORFRACIONADO = Convert.ToDecimal(txtvalorPago.Text.Trim());
                tela.FORMA_PAGAMENTO = ListaFormaPagamento.Text.Trim();
                //tela.ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                tela.DATA_VENCIMENTO = Convert.ToDateTime(DadosLinhaSelecionada.DATA_VENCIMENTO);
                tela.SITUACAO = ListaSituacao.Text.Trim();
                //inserir
                new ContratoDAL().ReceberPagamentoFracionado(tela);
                MensageBox("Recebimento Fracionado realizado com sucesso!");

                Response.Redirect("ALUGUEL.aspx");
            }
            catch (Exception ex)
            {

                MensageBox("Email OU mensagem whatsapp.\n\n Não foi enviado por motivo: " + ex.Message);
            }
        }

        #region Imprimi pdf
        public  void CriarPDFRecibo(string txtcliente, string txtEndereco, string txtimportancia, string txtreferente)
        {
            // C#
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                //var NomeCliente = nome;
                //var DadosCliente = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);

                decimal valor = Convert.ToDecimal(txtimportancia);
                var TextoValorExtersom = EscreverExtenso(valor);

                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);
                var fontRecibo = new PdfSharp.Drawing.XFont("Microsoft Sans Serif", 30);
                var fontTexto = new PdfSharp.Drawing.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Underline);

                // Imagem.
                var caminho = Server.MapPath("Pegasus.png");
                graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(caminho), 0, 30, 200, 100);


                // C#
                // Textos.
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("RECIBO Aluguel", fontRecibo, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 30, page.Width - 60, page.Height - 60));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("Valor", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 60, page.Width - 60, page.Height - 60));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString(valor.ToString("C"), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(60, 80, page.Width - 60, page.Height - 60));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("Recebi (emos) de: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 150, page.Width - 60, page.Height - 60));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString(txtcliente.ToString(), fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(150, 150, page.Width - 60, page.Height - 60));


                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("Endereço: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 170, page.Width - 60, page.Height - 60));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString(txtEndereco.ToString(), fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 170, page.Width - 60, page.Height - 60));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("A importancia de: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 190, page.Width - 60, page.Height - 60));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString(TextoValorExtersom.ToString(), fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(150, 190, page.Width - 60, page.Height - 60));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("Referente: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 210, page.Width - 60, page.Height - 60));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString(txtreferente.ToString(), fontTexto, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 210, page.Width - 60, page.Height - 60));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("Por ser verdade, firmo o presente.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 300, page.Width - 60, page.Height - 60));

                //desmenbrando a data
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                int dia = DateTime.Now.Day;
                int ano = DateTime.Now.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
                string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
                string DataRecibo = "Manaus, AM, " + dia + " de " + mes + " de " + ano;

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Right;
                textFormatter.DrawString(DataRecibo, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 320, page.Width - 60, page.Height - 60));

                string pdfPath = Server.MapPath(@"ReciboGErado.pdf");
                doc.Save(pdfPath);

                WebClient client = new WebClient(); 
                Byte[] buffer = client.DownloadData(pdfPath);
                //Response.Clear();
                Response.ContentType = "application/pdf"; 
                Response.AddHeader("content-length", buffer.Length.ToString()); 
                Response.BinaryWrite(buffer);
                Response.End();
                
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
        #endregion
    }

}