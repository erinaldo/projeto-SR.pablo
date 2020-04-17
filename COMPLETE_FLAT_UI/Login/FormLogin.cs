using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dados;
using Dados.USUARIO;
using Model;
using System.Data;

namespace SoftwareGerenciador
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Senha")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Senha";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //CONSULTA O USUARIO
            try
            {
                if (string.IsNullOrEmpty(txtuser.Text) || txtuser.Text == "Usuario")
                {
                    MessageBoxEx.Show("Digite seu usuario!");
                    return;
                }
                if (string.IsNullOrEmpty(txtpass.Text) || txtpass.Text == "Senha")
                {
                    MessageBoxEx.Show("Digite sua senha!");
                    return;
                }
                LoginUsuario USUARIO = new USUARIODAL().CONSULTAlOGIN(new LoginUsuario() { LOGIN = txtuser.Text.Trim(), SENHA = txtpass.Text.Trim() });
                if (USUARIO.ID > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    Sessao.Instance.SalvaUsuarioSessao(USUARIO);
                }
                else
                    MessageBoxEx.Show("usuario com senha ou login errados. Ferifique os campos.");


            }
            catch (Exception EX)
            {

                MessageBoxEx.Show(EX.ToString());
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void BtnTestarConexão_Click(object sender, EventArgs e)
        {
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                conexao.ExecutaConsultas(CommandType.Text, "select * from usuario");
                MessageBoxEx.Show("Conecção ativa com o servidor.");
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro de conecção com o banco de dados.\n\n Detalhes: "+ ex.Message + ex.StackTrace);
            }
        }
    }
}
