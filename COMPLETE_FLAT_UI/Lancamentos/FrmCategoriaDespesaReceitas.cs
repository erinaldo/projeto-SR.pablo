using Dados;
using Dados.DepesaseReceitas;
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

namespace SoftwareGerenciador.Lancamentos
{
    public partial class FrmCategoriaDespesaReceitas : Form
    {
        public FrmCategoriaDespesaReceitas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }

        private void BtnSalvarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                despesasCategoria despesasCategoria = new despesasCategoria();

                if (string.IsNullOrEmpty(txtNomeCategoria.Text))
                {
                    MessageBoxEx.Show("Preencha o nome da categoria valido!");
                    return;
                }
                
                despesasCategoria.NOME = txtNomeCategoria.Text.Trim();
                //alterar
                if (!string.IsNullOrEmpty(txtIDcategoria.Text.Trim()))
                {
                    despesasCategoria.ID = Convert.ToInt32(txtIDcategoria.Text);
                    //Alterar
                    Alterar(despesasCategoria);
                    MessageBoxEx.Show("Alterado com sucesso!");
                    CAtegorias();
                }
                else
                {
                    //Salvar
                    Salvar(despesasCategoria);
                    MessageBoxEx.Show("Salvo com sucesso!");
                    CAtegorias();
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
            
        }
        private void Salvar(despesasCategoria despesasCategoria)
        {
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@NOME", despesasCategoria.NOME);
                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO `categoriadespesa`(`NOME`) VALUES (@NOME)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Alterar(despesasCategoria despesasCategoria)
        {
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@NOME", despesasCategoria.NOME);
                conexao.AdicionarParametros("@ID", despesasCategoria.ID);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE `categoriadespesa` SET `NOME`=@NOME WHERE ID=@ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmCategoriaDespesaReceitas_Load(object sender, EventArgs e)
        {
            CAtegorias();



        }
        private void CAtegorias()
        {
            try
            {
                var categorias = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());
                dgvdadosCategorias.DataSource = null;
                dgvdadosCategorias.DataSource = categorias;
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
        }

        private void dgvdadosCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtIDcategoria.Text = Convert.ToString(dgvdadosCategorias.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                txtNomeCategoria.Text = Convert.ToString(dgvdadosCategorias.Rows[e.RowIndex].Cells["NOME"].Value.ToString());
               
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //ecluir uma categoria
                int Codigo = Convert.ToInt32(dgvdadosCategorias.SelectedRows[0].Cells["ID"].Value);
                Deletar(Codigo);
                MessageBoxEx.Show("Deletado com sucesso!");
                CAtegorias();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message);
            }
        }
        private void Deletar(int codigo)
        {
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", codigo);
                conexao.ExecutarManipulacao(CommandType.Text, "DELETE FROM categoriadespesa WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
