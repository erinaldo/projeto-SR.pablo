using Dados.Fornecedor;
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

namespace SoftwareGerenciador.Fornecedor
{
    public partial class FrmNovoCorretor : Form
    {
        public FrmNovoCorretor()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(iDTextBox.Text)) { new FornecedorDAL().alterar(tela()); }
                else new FornecedorDAL().inserir(tela());
                MessageBoxEx.Show("Salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro em Salvar um fornecedor!\n Preocure o adm" + ex.StackTrace);
            }
        }
        private FornecedorModel tela()
        {
            var dados = new FornecedorModel();
            if (string.IsNullOrWhiteSpace(iDTextBox.Text)) { dados.ID = 0; } else { dados.ID = Convert.ToInt32(iDTextBox.Text.Trim()); }

            dados.NOME = nOMETextBox.Text.Trim();
            dados.RASAOSOCIAL = RAZAOTextBox.Text.Trim();
            dados.IE = IETextBox.Text.Trim();
            dados.TELEFONE = TELEFONEtextBox.Text.Trim();
            dados.CNPJ = CNPJTextBox.Text.Trim();
            dados.EMAIL = EMAILtextBox.Text.Trim();
            dados.ENDERECO = eNDERECOTextBox.Text.Trim();
            return dados;
        }
    }
}
