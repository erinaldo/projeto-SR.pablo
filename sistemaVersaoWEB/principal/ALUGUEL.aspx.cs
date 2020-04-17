using Dados.CLIENTE;
using Dados.contrato;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistemaVersaoWEB.principal
{
    public partial class ALUGUEL : System.Web.UI.Page
    {
        public void MensageBox(String mensagem)
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensagem + "');", true);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + mensagem + "');</script>");
        }
        private DataTable SituacaoClientes;
        protected void Page_Load(object sender, EventArgs e)
        {
            
           

            if (!IsPostBack)
            {
                DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
                DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                SituacaoClientes = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
                dgvMesa.DataSource = SituacaoClientes;
                dgvMesa.DataBind();

                //for (int i = 0; i < dgvMesa.Rows.Count; i++)
                //{
                //    dgvMesa.Rows[i].Cells[0].Visible = false;
                //    dgvMesa.Rows[i].Cells[1].Visible = false;
                //}

                var listaprodutos = new CLIENTEDAL().CONSULTATODOS();
                listaprodutos.Insert(0, new cliente() { NOME = "SELECIONE" });
                ListaClienteCombo.DataSource = listaprodutos;
                ListaClienteCombo.DataValueField = "ID";
                ListaClienteCombo.DataTextField = "NOME";
                ListaClienteCombo.DataBind();
                Session.Remove("DadosLinhaCelecionada");
            }
            if (Session["Usuario"] == null)
            {
                Session["Mensagem"] = "Sua sessão expirou!\n\nFaça login novamente";
                MensageBox("Sua sessão expirou!\n\nFaça login novamente");
                Response.Redirect("TelaPrincipla.aspx");
            }
            else if (Session["Usuario"] != null)
            {
                //etCurrentPageName();
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
                //errro: Não é possível converter um objeto do tipo 'ASP.site_master' no tipo 'sistemaVersaoWEB.Site_Mobile'."
            }

        }
        ////Using absolute path
        //public string GetCurrentPageName()
        //{
        //    string sPath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        //    System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
        //    string sRet = oInfo.Name;
        //    return sRet;
        //}
        protected void dgvMesa_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvMesa.PageIndex = e.NewPageIndex;
            dgvMesa.DataBind();
        }

        protected void btnReceber_Command(object sender, CommandEventArgs e)
        {
            ////como trazer seleionar o iten pra colocar na sessao

            //var IdContrato = Convert.ToInt16(e.CommandArgument);

            ////ModeloComanda comanda = new ModeloComanda();
            ////comanda.COMANDA = Convert.ToInt32(dgvMesa.Rows[nr].Cells[1].Text);
            ////comanda.NUMEROMESA = Convert.ToInt32(dgvMesa.Rows[nr].Cells[2].Text);
            ////comanda.STATUS = Convert.ToString(dgvMesa.Rows[nr].Cells[3].Text);
            ////Session["comandaMesas"] = comanda;
            ////MensageBox("Visualizando os pedidos da mesa " + Convert.ToInt32(dgvMesa.Rows[nr].Cells[2].Text));
            //Session["IdContrato"] = IdContrato;
            //Response.Redirect("ReceberAluguel.aspx");
        }

        protected void dgvMesa_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "SelecionaLinha")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = dgvMesa.Rows[index];

                contratoParcelamento Aluguel = new contratoParcelamento();

                //dgvMesa.Rows[i].Cells[0].Visible

                var ID_CONTRATO = row.Cells[0].Text;
                Aluguel.ID_CONTRATO = Convert.ToInt32(ID_CONTRATO);

                var N_MENSALIDADE = row.Cells[1].Text;
                Aluguel.N_MENSALIDADE = Convert.ToInt32(N_MENSALIDADE);

                Aluguel.cliente = new cliente();
                Aluguel.cliente.NOME = row.Cells[2].Text;

                Aluguel.PLANO = row.Cells[3].Text;

                var DATA_VENCIMENTO = row.Cells[4].Text;
                Aluguel.DATA_VENCIMENTO = Convert.ToDateTime(DATA_VENCIMENTO);

                var VAlor = row.Cells[5].Text;
                Aluguel.VALOR = Convert.ToDecimal(VAlor);

                Aluguel.SITUACAO = row.Cells[6].Text;

                if((!string.IsNullOrEmpty(row.Cells[7].Text)) && (row.Cells[7].Text != "&nbsp;")) 
                {
                    var VALORFRACIONADO = row.Cells[7].Text;
                    Aluguel.VALORFRACIONADO = Convert.ToDecimal(VALORFRACIONADO);
                }

                Session["DadosLinhaCelecionada"] = Aluguel;
                Response.Redirect("ReceberAluguel.aspx");
            }
        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
            DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
            SituacaoClientes = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
            dgvMesa.DataSource = null;
            dgvMesa.DataSource = SituacaoClientes;
            dgvMesa.DataBind();

            Session.Remove("DadosLinhaCelecionada");
        }

        protected void BtnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //consulta o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(ListaClienteCombo.SelectedItem.ToString());
                //localicar um contrato que estar ativo desse cliente
                var contratoAtivo = new ContratoDAL().ConsultacontratoAtivo(cliente.ID, "ATIVO");
                if (contratoAtivo.ID > 0)
                {
                    //trazer os cliente e seu ultimo pagamento
                    DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(+120));
                    DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                    var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, contratoAtivo.ID);

                    if (Situacao.Rows.Count > 0)
                    {
                        dgvMesa.DataSource = null;
                        dgvMesa.DataSource = Situacao;
                        dgvMesa.DataBind();

                        Session.Remove("DadosLinhaCelecionada");
                    }
                    else
                        MensageBox("Não tem parcelas cadatrada para esse contrato!");
                }
                else
                    MensageBox("Nenhum contrato(ATIVO) pra esse cliente");

            }
            catch (Exception ex)
            {

            }
        }

        protected void dgvMesa_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //if (e.Row.Cells[6].Text.Equals("NAO PAGO"))
                //{
                //    e.Row.BackColor = System.Drawing.Color.LightCoral;
                //}
                //if (e.Row.Cells[6].Text.Equals("ATRASADO"))
                //{
                //    e.Row.BackColor = System.Drawing.Color.Tomato;
                //}
                if (e.Row.Cells[6].Text.Equals("FRACIONADO"))
                {
                    e.Row.BackColor = System.Drawing.Color.Gold;
                }
                if (e.Row.Cells[6].Text.Equals("PAGO"))
                {
                    e.Row.BackColor = System.Drawing.Color.LightGreen;
                }
            }
        }
    }
}