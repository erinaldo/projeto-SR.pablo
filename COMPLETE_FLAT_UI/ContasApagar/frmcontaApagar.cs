using Dados.ContaaPagar;
using Dados.DepesaseReceitas;
using Dados.FERRAMENTAS;
using Dados.Fornecedor;
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

namespace SoftwareGerenciador.ContasApagar
{
    public partial class frmcontaApagar : Form
    {
        public frmcontaApagar()
        {
            InitializeComponent();
            Inicializacao();
        }

        private void Inicializacao()
        {
            //Iniciar combo fornecedores
            var ListFornecedor = new FornecedorDAL().ListaFornecedor(new FornecedorModel());
            comboFornecedor.ValueMember = "ID";
            comboFornecedor.DisplayMember = "NOME";
            ListFornecedor.Insert(0, new FornecedorModel() { NOME = "Selecione..." });
            comboFornecedor.DataSource = null;
            comboFornecedor.DataSource = ListFornecedor;

            //Iniciar combo categoria
            var ListaCategoria = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());

            Combocategoria.DisplayMember = "NOME";
            Combocategoria.ValueMember = "ID";
            ListaCategoria.Insert(0, new despesasCategoria() { NOME = "Selecione..." });
            Combocategoria.DataSource = null;
            Combocategoria.DataSource = ListaCategoria;

            //Inicar combo Usuario
            var ListaUsuario = new USUARIODAL().CONSULTA(new LoginUsuario());
            comboUsuario.DisplayMember = "NOME";
            comboUsuario.ValueMember = "ID";
            ListaUsuario.Insert(0, new LoginUsuario() { NOME = "Selecione..." });
            comboUsuario.DataSource = null;
            comboUsuario.DataSource = ListaUsuario;
        }

        private void frmcontaApagar_Load(object sender, EventArgs e)
        {
            panelPagamento.Enabled = false;
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                BtnAlterar.Visible = false;
                BtnSalvarContasPagar.Visible = true;
            }else
            {
                BtnAlterar.Visible = true;
                BtnSalvarContasPagar.Visible = false;
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }

        private void checkAtivaDesativa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAtivaDesativa.Checked)
            {
                panelPagamento.Enabled = true;
                panelDados.Enabled = false;
            }
            else
            {
                panelPagamento.Enabled = false;
                panelDados.Enabled = true;
            }
        }

        private void txtvalorDocumento_TextChanged(object sender, EventArgs e)
        {
            MoedaTXT.Moeda(ref txtvalorDocumento);
        }

        private void BtnSalvarContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacao())
                {
                    //dados da tela

                    new ContaPagarDAL().Salvar(Dados());
                    MessageBoxEx.Show("Conta salva com sucesso!");
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Erro em salva Conta á pagar!Entre em contato com administrador...");
            }

        }
        private bool validacao()
        {
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text)) { MessageBoxEx.Show("Numero do documento invalido ou vazio!"); return false; }
            if (string.IsNullOrEmpty(txtDescricao.Text)) { MessageBoxEx.Show("Adicione uma descrição da conta!"); return false; }
            if (Combocategoria.SelectedIndex == 0) { MessageBoxEx.Show("Selecione uma Categoria valida!"); return false; }
            if (comboFornecedor.SelectedIndex == 0) { MessageBoxEx.Show("Selecione um fornecedor valido!"); return false; }
            if (comboUsuario.SelectedIndex == 0) { MessageBoxEx.Show("Selecione um usuario valido!"); return false; }
            if (txtvalorDocumento.Text == "0,00") { MessageBoxEx.Show("Valor do documento da conta invalido!"); return false; }
            return true;

        }

        private ContaPagarModel Dados()
        {
            var conta = new ContaPagarModel();
            {
                if (!string.IsNullOrEmpty(txtID.Text)) { conta.ID = Convert.ToInt32(txtID.Text); }

                if (comboFornecedor.SelectedIndex > 0) { conta.ID_FORNECEDOR = Convert.ToInt32(comboFornecedor.SelectedValue); }
                if (Combocategoria.SelectedIndex > 0) { conta.ID_CATEGORIA = Convert.ToInt32(Combocategoria.SelectedValue); }
                if (comboUsuario.SelectedIndex > 0) { conta.ID_USUARIO = Convert.ToInt32(comboUsuario.SelectedValue); }

                conta.DATAVENCIMENTO = dataVencimento.Value;
                conta.DATAEMISSAO = dataEmissao.Value;
                conta.DATAALERTA = dataAlerta.Value;
                conta.DESCRICAO = txtDescricao.Text.Trim();
                conta.NUMERODOCUMENTO = txtNumeroDocumento.Text.Trim();
                conta.VALORCONTA = Convert.ToDecimal(txtvalorDocumento.Text.Trim());
                if (checkAtivaDesativa.Checked == true)
                {
                    conta.DATAPAGAMENTO = dataPagamento.Value;
                    conta.VALORPAGO = Convert.ToDecimal(txtValorPagamento.Text.Trim());
                    conta.SITUACAO = "PAGO";
                }
                else
                    conta.SITUACAO = "NAO PAGO";
            }
            return conta;
        }

        private void BtnBaixaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                new ContaPagarDAL().UpdateContaPaga(Dados());
                MessageBoxEx.Show("(Baixa) Entrada no finaceiro com sucesso!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Erro em salva Conta á pagar!Entre em contato com administrador...");
            }
        }

        private void txtValorPagamento_TextChanged(object sender, EventArgs e)
        {
            MoedaTXT.Moeda(ref txtValorPagamento);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new ContaPagarDAL().Update(Dados());
                MessageBoxEx.Show("Conta alterada com sucesso!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Erro em salva Conta á pagar!Entre em contato com administrador...");
            }
        }
    }
}


