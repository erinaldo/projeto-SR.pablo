using Dados.CLIENTE;
using Dados.Contrato_imprestimo;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistemaVersaoWEB.principal
{
    public partial class Imprestimo : System.Web.UI.Page
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
                //trazer os cliente e seu ultimo pagamento
                DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
                DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                SituacaoClientes = new ContratoImprestimoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
                dgvMesa.DataSource = null;
                dgvMesa.DataSource = SituacaoClientes;
                dgvMesa.DataBind();

                var listaprodutos = new CLIENTEDAL().CONSULTATODOS();
                listaprodutos.Insert(0, new cliente() { NOME = "SELECIONE" });
                ListaClienteCombo.DataSource = listaprodutos;
                ListaClienteCombo.DataValueField = "ID";
                ListaClienteCombo.DataTextField = "NOME";
                ListaClienteCombo.DataBind();
                //Session.Remove("DadosLinhaCelecionada");
            }
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
        }

        protected void dgvMesa_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //dgvMesa.PageIndex = e.NewPageIndex;
            //dgvMesa.DataBind();
        }

        protected void dgvMesa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelecionaLinha")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = dgvMesa.Rows[index];


                Session["DadosLinhaCelecionada"] = row;
                Response.Redirect("ReceberImprestimoaspx.aspx");
            }
        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            //trazer os cliente e seu ultimo pagamento
            DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddMonths(-11));
            DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
            SituacaoClientes = new ContratoImprestimoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
            dgvMesa.DataSource = null;
            dgvMesa.DataSource = SituacaoClientes;
            dgvMesa.DataBind();

            //Session["DadosLinhaCelecionada"] = null;
        }

        protected void BtnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //consulta o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(ListaClienteCombo.SelectedItem.ToString());
                //localicar um contrato que estar ativo desse cliente
                var contratoAtivo = new ContratoImprestimoDAL().ConsultacontratoAtivo(cliente.ID, "ATIVO");

               
                if (contratoAtivo.ID > 0)
                {
                    //trazer os cliente e seu ultimo pagamento
                    DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
                    DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+120));
                    var SituacaoAtualizada = new ContratoImprestimoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, contratoAtivo.ID);
                   
                    if (SituacaoAtualizada.Rows.Count > 0)
                    {
                        //Session.Remove("DadosLinhaCelecionada");
                        dgvMesa.DataSource = null;
                        dgvMesa.DataSource = SituacaoAtualizada;
                        dgvMesa.DataBind(); 
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
                //if (e.Row.Cells[8].Text.Equals("ATRASADO"))
                //{
                //    e.Row.BackColor = System.Drawing.Color.Tomato;
                //}
                if (e.Row.Cells[8].Text.Equals("FRACIONADO"))
                {
                    e.Row.BackColor = System.Drawing.Color.Gold;
                }
                if (e.Row.Cells[8].Text.Equals("PAGO"))
                {
                    e.Row.BackColor = System.Drawing.Color.LightGreen;
                }
            }
        }
    }
}