using Dados.CLIENTE;
using Dados.DepesaseReceitas;
using Dados.imovels;
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

namespace SoftwareGerenciador.Mensalidade
{
    public partial class FrmCancelamentoContrato : Form
    {
        public bool Finalizar = false;
        public FrmCancelamentoContrato()
        {
            InitializeComponent();
            carregaCategoria();
            IDImovel = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Finalizar = false;
            Close();
        }
        public int IDImovel = 0;
        private void FrmCancelamento_Load(object sender, EventArgs e)
        {
            
        }
        private void carregaCategoria()
        {

            var ListaCategoria = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());
            ListaCategoria.Insert(0, new despesasCategoria() { NOME = "SELECIONE" });
            combocategoriareceita.DisplayMember = "NOME";
            combocategoriareceita.ValueMember = "ID";
            combocategoriareceita.DataSource = ListaCategoria;

        }

        private void TxtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            CalculoTaxaAcrescimo();
        }
        private void CalculoTaxaAcrescimo()
        {
            try
            {
                txtDesconto.Text = "0";
                if (!string.IsNullOrEmpty(txtvalorparcelasvencidas.Text))
                {
                    if (string.IsNullOrEmpty(TxtPorcentagem.Text.Trim())) { TxtPorcentagem.Text = "0"; }
                    decimal valorTaxa = Convert.ToDecimal(TxtPorcentagem.Text.Trim());
                    decimal porcento = Convert.ToDecimal(valorTaxa / 100);// valor de porcento dividido por 100
                    string v = txtvalorparcelasvencidas.Text.Replace("R$", "").Trim();
                    decimal ValorApagar = Convert.ToDecimal(v);
                    decimal resultado = Convert.ToDecimal(porcento * ValorApagar);

                    //txtvalor.Text = resultado.ToString("F");
                    //somando a porcentagem com o valor a ser pago
                    decimal totalaPagar = Convert.ToDecimal(resultado) + ValorApagar;
                    TxtValorTotalAPagar.Text = totalaPagar.ToString("F");
                    txtvalorreceita.Text = totalaPagar.ToString("F");
                }


            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Confirar os campos da tela: " + ex.Message + ex.StackTrace);
            }
        }
        private void CalculoTaxaDesconto()
        {
            try
            {
                TxtPorcentagem.Text = "0";
                if (!string.IsNullOrEmpty(txtvalorparcelasvencidas.Text))
                {
                    if (string.IsNullOrEmpty(txtDesconto.Text.Trim())) { txtDesconto.Text = "0"; }
                    decimal valorTaxa = Convert.ToDecimal(txtDesconto.Text.Trim());
                    decimal porcento = Convert.ToDecimal(valorTaxa / 100);// valor de porcento dividido por 100
                    string v = txtvalorparcelasvencidas.Text.Replace("R$", "").Trim();
                    decimal ValorApagar = Convert.ToDecimal(v);
                    decimal resultado = Convert.ToDecimal(porcento * ValorApagar);

                    //txtvalor.Text = resultado.ToString("F");
                    //somando a porcentagem com o valor a ser pago
                    decimal totalaPagar = Convert.ToDecimal(resultado) - ValorApagar;
                    TxtValorTotalAPagar.Text = totalaPagar.ToString("F");
                    txtvalorreceita.Text = totalaPagar.ToString("F");
                }


            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Confirar os campos da tela: " + ex.Message + ex.StackTrace);
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalculoTaxaDesconto();
        }
        public receitas C;
        private void BtnFinalizarCancelamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtvalorreceita.Text))
                {
                    MessageBoxEx.Show("Preenha um valor de despesa pra salvar os dados!");
                    return;
                }
                if (combocategoriareceita.SelectedIndex == 0)
                {
                    MessageBoxEx.Show("Sem categoria de despesa pra salvar os dados!");
                    return;
                }

                new DespesasReceitasDAL().InserirReceitas(receitas(C));

                //faz update no cliente no status dele para CANCELADO
                //localizando o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(LbNomeClienteTelaCancelamento.Text.Trim());
                new CLIENTEDAL().UpdateClienteCancelamento(cliente.ID, "CANCELADO");

                //alterar o imovel que estar sendo ultilizado para a situação
                new imovelDAL().AlterarSituacaoImovel(IDImovel, "Disponivel");

                MessageBoxEx.Show("Inserido com sucesso!");
                Finalizar = true;
                Close();
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
        }
        private receitas receitas(receitas C)
        {
            C = new receitas();
            C.ID_CATEGORIA = Convert.ToInt32(combocategoriareceita.SelectedValue);
            C.DATA = DateTime.Now.Date;
            C.DESCRICAO = txtdescricaoreceita.Text.Trim();
            C.VALOR = Convert.ToDecimal(txtvalorreceita.Text.Trim());
            return C;
        }
    }
}
