using Dados.USUARIO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistemaVersaoWEB
{
    public partial class Site_Mobile : MasterPage
    {
        public string Nomeusuario
        {
            get
            {
                return LbNomeusuario.Text;
            }
            set
            {
                LbNomeusuario.Text = value;
            }
        }
        public string NivelUsuario
        {
            get
            {
                return LbNivel.Text;
            }
            set
            {
                LbNivel.Text = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                LbOlaine.Text = "offline";
            }
            else if (Session["Usuario"] != null)
            {
                LoginUsuario usuario = (LoginUsuario)Session["Usuario"];
                LbNomeusuario.Text = usuario.NOME;
                LbNivel.Text = usuario.CARGO;
                LbOlaine.Text = "Online";
            }
        }
        public void MensageBox(String mensagem)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensagem + "');", true);
        }
        protected void BtnEntraLogin_Click(object sender, EventArgs e)
        {
            //CONSULTA O USUARIO
            try
            {
                if (string.IsNullOrEmpty(txtemail.Text) || txtemail.Text == "Usuario")
                {
                    MensageBox("Digite seu usuario!");
                    return;
                }
                if (string.IsNullOrEmpty(txtsenha.Text) || txtsenha.Text == "Senha")
                {
                    MensageBox("Digite sua senha!");
                    return;
                }
                LoginUsuario USUARIO = new USUARIODAL().CONSULTAlOGIN(new LoginUsuario() { LOGIN = txtemail.Text.Trim(), SENHA = txtsenha.Text.Trim() });
                if (USUARIO.ID > 0)
                {
                    Session["Usuario"] = USUARIO;
                    //colocando o usuario na tela principal
                    LbNomeusuario.Text = USUARIO.NOME;
                    LbNivel.Text = USUARIO.CARGO;
                    LbOlaine.Text = "Online";
                    //MensageBox("Usuario Logado");
                }
                else
                    MensageBox("usuario com senha ou login errados. Ferifique os campos.");


            }
            catch (Exception EX)
            {

                MensageBox(EX.ToString());
            }
        }
    }
}