using Dados;
using Dados.PARAMETROS;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class FrmParamentros : Form
    {
        public FrmParamentros()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvaradm_Parametros_Click(object sender, EventArgs e)
        {
            try
            {
                var TodoDados = parametros();
                if (!string.IsNullOrEmpty(TxtID.Text))
                    new ParametrosDal().Alterar(TodoDados);
                else
                    new ParametrosDal().Inserir(TodoDados);
                MessageBoxEx.Show("Parâmetros Inseridos com sucesso!!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.StackTrace);
            }
        }
        private Parametros parametros()
        {
            var dados = new Model.Parametros();
            if (!string.IsNullOrEmpty(TxtID.Text))
                dados.ID = Convert.ToInt32(TxtID.Text.Trim());
            dados.NOMEEMPRESA = TxtNomeEmpresa.Text.Trim();
            dados.EMAIL = txtEmailRemetente.Text.Trim();
            dados.SENHA = TxtSenhaRementente.Text.Trim();
            dados.Porta = txtPorta.Text.Trim();
            dados.smtp = txtSMPT.Text.Trim();
            return dados;
        }

        private void FrmParamentros_Load(object sender, EventArgs e)
        {
            //ferifica se existe parametros inseridos
            var todos = new Dados.PARAMETROS.ParametrosDal().Todos(new Model.Parametros());

            if (todos.ID > 0)
            {
                TxtID.Text = todos.ID.ToString();
                if (todos.EMAIL != null)
                    txtEmailRemetente.Text = todos.EMAIL.ToString();
                if (todos.NOMEEMPRESA != null)
                    TxtNomeEmpresa.Text = todos.NOMEEMPRESA.ToString();
                if (todos.SENHA != null)
                    TxtSenhaRementente.Text = todos.SENHA.ToString();

                if (todos.Porta != null)
                    txtPorta.Text = todos.Porta.ToString();
                if (todos.smtp != null)
                    txtSMPT.Text = todos.smtp.ToString();

                BtnSalvaradm_Parametros.Text = "Alterar";
                BtnSalvaradm_Parametros.Visible = true;
            }
        }

        private async void BtnTesteDeConexaoEmail_Click(object sender, EventArgs e)
        {
            FrmLoading loading = new FrmLoading();
            try
            {

                //enviar email
                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                {
                    smtp.Host = txtSMPT.Text.Trim();
                    smtp.Port = Convert.ToInt32(txtPorta.Text.ToString().Trim());
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new System.Net.NetworkCredential(txtEmailRemetente.Text.ToString().Trim(), TxtSenhaRementente.Text.ToString().Trim());

                    using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                    {
                        //de quem
                        mail.From = new System.Net.Mail.MailAddress(txtEmailRemetente.Text.ToString().Trim());
                        //para quem
                        mail.To.Add(new System.Net.Mail.MailAddress(txtEmailRemetente.Text.ToString().Trim()));


                        var contentID = "Image";
                        var inlineLogo = new Attachment(Application.StartupPath + "/Pegasus.jpg");
                        inlineLogo.ContentId = contentID;
                        inlineLogo.ContentDisposition.Inline = true;
                        inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                        mail.Attachments.Add(inlineLogo);

                        mail.Subject = "Teste de conexão";// asunto
                        mail.Body += "<h1>Agendamento</h1><br />" +
                         "Teste Efetuado com sucesso";


                        mail.IsBodyHtml = true;
                        loading.Show();
                        await smtp.SendMailAsync(mail);
                        loading.Close();
                        MessageBoxEx.Show("Paramentros corretos.\n E-mail Enviando com Sucesso. ");
                        BtnSalvaradm_Parametros.Visible = true;
                    }

                    
                }

            }
            catch (Exception ex)
            {
                loading.Close();
                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }
      
    }
}
