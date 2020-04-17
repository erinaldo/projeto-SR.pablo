using Dados;
using Dados.USUARIO;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador.Login
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }

        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnome.Text))
                {
                    MessageBoxEx.Show("Coloque o seu nome!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtlogin.Text))
                {
                    MessageBoxEx.Show("Coloque o seu nome de login!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtsenha.Text))
                {
                    MessageBoxEx.Show("Coloque o sua senha!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCargo.Text))
                {
                    MessageBoxEx.Show("Coloque o seu Cargo!");
                    return;
                }
                var dadostela = dados();
                if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                {
                    //Update//
                    new USUARIODAL().Alterar(dadostela);
                    MessageBoxEx.Show("Alterado com sucesso");
                    Close();
                }
                else
                {
                    //inserir
                    new USUARIODAL().Inserir(dadostela);
                    MessageBoxEx.Show("Inserido com sucesso");
                    Close();
                }
            }
            catch (Exception ex)
            {

                ExceptionErro.ExibirMenssagemException(ex);
            }
           

        }
        private LoginUsuario dados()
        {
            var tela = new LoginUsuario();
            if (!string.IsNullOrWhiteSpace(iDTextBox.Text))
                tela.ID = Convert.ToInt32( iDTextBox.Text.Trim());

            tela.NOME = txtnome.Text.Trim();
            tela.LOGIN = txtlogin.Text.Trim();
            tela.SENHA = txtsenha.Text.Trim();
            tela.CARGO = txtCargo.Text.Trim();

            return tela;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //TRAZ TODO OS USUARIOS
            var ListadeUsuario = new USUARIODAL().CONSULTA(new LoginUsuario() );
            DGVDADOS.DataSource = null;
            DGVDADOS.DataSource = ListadeUsuario;
        }

        private void DGVDADOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iDTextBox.Text = DGVDADOS.CurrentRow.Cells["ID"].Value.ToString();
            txtnome.Text = DGVDADOS.CurrentRow.Cells["NOME"].Value.ToString();
            txtlogin.Text = DGVDADOS.CurrentRow.Cells["LOGIN"].Value.ToString();
            txtsenha.Text = DGVDADOS.CurrentRow.Cells["SENHA"].Value.ToString();
            txtCargo.Text = DGVDADOS.CurrentRow.Cells["CARGO"].Value.ToString();
        }
    }
}
