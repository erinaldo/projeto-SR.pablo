using Dados.contrato;
using Dados.Contrato_imprestimo;
using Dados.DepesaseReceitas;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistemaVersaoWEB.principal
{
    public partial class TelaPrincipla : System.Web.UI.Page
    {
        DataTable ResumoRecebimentoMes;
        DataTable ResumoDepesaMes;
        DataTable ResumoReceitaMes;
        private decimal TotalRecebimentoMes = 0;
        private decimal TotalDespesaMes = 0;
        private decimal TotalReceitaMes = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Usuario"] != null)
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

            totalRecebido();
            totalDespesa();
            totalReceita();
            //total em caixa
            decimal totalSomado = TotalReceitaMes + TotalRecebimentoMes - TotalDespesaMes;// - TotalContasPagasMes
            LbGanhosMensaisAlugueis.Text = totalSomado.ToString("C");
            //total de despesa
            LbDespesasdomes.Text = TotalDespesaMes.ToString("C");
            //total de receitas do mes
            LbReceitasMes.Text = TotalReceitaMes.ToString("C");

            consultasdeimprestimo();
        }

        #region Alugueis Resumo Geral
        public void totalRecebido()
        {
            ResumoRecebimentoMes = new ContratoDAL().ResumoRecebimentoMesGrafico(DateTime.Now.Date);// so pega o mes e o ano da data
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
        }

        public void totalDespesa()
        {
            ResumoDepesaMes = new DespesasReceitasDAL().ResumoDepesaMesGrafico(DateTime.Now.Date);
            TotalDespesaMes = 0;
            for (int i = 0; i < ResumoDepesaMes.Rows.Count; i++)
            {
                TotalDespesaMes += Convert.ToDecimal(ResumoDepesaMes.Rows[i].ItemArray[4].ToString());
            }
        }

        public void totalReceita()
        {
            ResumoReceitaMes = new DespesasReceitasDAL().ResumoreceitaMesGrafico(DateTime.Now.Date);//{11/02/2020 21:38:47}
            TotalReceitaMes = 0;
            for (int i = 0; i < ResumoReceitaMes.Rows.Count; i++)
            {
                TotalReceitaMes += Convert.ToDecimal(ResumoReceitaMes.Rows[i].ItemArray[4].ToString());
            }
        }
        #endregion

        #region Porcetagem na tela

        #endregion

        #region Imprestimos
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
                        Juroscapitalpaga += ListaParcelasFracionado[f].VALOR_JUROS;//valor do juros recebido da parcela 
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
                DateTime data = Convert.ToDateTime(DateTime.Now);
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Date.Month));
                //LBConteudo.Text = "Saldo Geral Mensal  Geral( " + mes.ToString() + ")";
                //metroTile4.Text = "Saldo |capital| recebido( " + mes.ToString() + ")";
                //metroTiletexto3.Text = "Saldo |juros| recebido( " + mes.ToString() + ")";


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
                //LbTotalValorFuturo.Text = TotalRecebimentoFuturo.ToString("C");
                LBTotalEmCaixa.Text = TotalRecebimentoMesImprestimo.ToString("C");
                LBTotalRecebidoCapitalDoMes.Text = C.ToString("C");
                LBTotalRecebidoJurosDoMes.Text = J.ToString("C");
               
                #endregion

                #region valores pra tela

                var j = totalimprestadoJuros - ParcelaPagaNormal - ParcelasPagaFracionado;
                LbTotalCapitalJurosNaPraça.Text = j.ToString("C");

                LbTotalCapitalNaPraca.Text = (totalimprestado - capitalpaga).ToString("C");//(totalimprestado - Convert.ToDecimal(lbtotalimprestadojuros.Text.Replace("R$",""))).ToString("C");

                LbtotalCapitaRecebido.Text = capitalpaga.ToString("C");

                LbTotalJurosRecebido.Text = Juroscapitalpaga.ToString("C");
                #endregion
            }
            catch (Exception)
            {

            }


        }
        #endregion
    }
}