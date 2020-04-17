using Dados;
using Dados.CLIENTE;
using Dados.Fornecedor;
using Model;
using SoftwareGerenciador.Cliente;
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
    public partial class FrmCorretor : Form
    {
        public FrmCorretor()
        {
            InitializeComponent();
        }
        List<FornecedorModel> TODOSfornecedores;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        private void InsertarFilas()
        {
            //CONSULTA TODOS OS fornecedores
            TODOSfornecedores = new List<FornecedorModel>();
            TODOSfornecedores = new FornecedorDAL().ListaFornecedor(new FornecedorModel());
            DGVDADOS.DataSource = null;
            DGVDADOS.Columns.Clear();
            DGVDADOS.DataSource = TODOSfornecedores;
            Add_ColunaMenu();
            MontarGrid();
        }
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "NOME", "RASAOSOCIAL","IE","CNPJ","ENDERECO", "EMAIL", "TELEFONE", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "ID", "NOME", "RASAOSOCIAL", "IE", "CNPJ", "ENDERECO", "EMAIL", "TELEFONE", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);


        }
        private void Add_ColunaMenu()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOS.Columns.Add(imageColumn);
            imageColumn.HeaderText = "Menu";
            imageColumn.Name = "Menu";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.Width = 60;
        }

        private void DGVDADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DGVDADOS.Columns[e.ColumnIndex].HeaderText == "Tarefas")//QTD
                    {

                        Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //if (e.RowIndex >= 0)
                        //{

                        //    Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //var codigoSelecionado = Convert.ToInt32(DGVDADOS.Rows[e.RowIndex].Cells[0].Value);
                        //    //string Nome = Convert.ToString(dgvItens.SelectedRows[0].Cells["Nome"].Value);

                        //}

                    }
                }
            }
            catch (Exception erro)
            {

                MessageBoxEx.Show("Erro no cellContent: " + erro.Message, "Erro", MessageIcon.Error, MessageButton.OK);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNovoCorretor frm = new FrmNovoCorretor();
            frm.ShowDialog();

            //atualiza a grid 
            InsertarFilas();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            FrmNovoCorretor frm = new FrmNovoCorretor();
            if (DGVDADOS.SelectedRows.Count > 0)
            {
                var adm_moduloRetorno = new FornecedorDAL().consultaid(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value));
                if (adm_moduloRetorno.ID > 0)
                {
                    frm.iDTextBox.Text = adm_moduloRetorno.ID.ToString();
                    frm.nOMETextBox.Text = adm_moduloRetorno.NOME.ToString();
                    if (adm_moduloRetorno.RASAOSOCIAL != null)
                        frm.RAZAOTextBox.Text = adm_moduloRetorno.RASAOSOCIAL.ToString();
                    if (adm_moduloRetorno.IE != null)
                        frm.IETextBox.Text = adm_moduloRetorno.IE.ToString();
                    if (adm_moduloRetorno.CNPJ != null)
                        frm.CNPJTextBox.Text = adm_moduloRetorno.CNPJ.ToString();
                    if (adm_moduloRetorno.ENDERECO !=null)
                        frm.eNDERECOTextBox.Text = adm_moduloRetorno.ENDERECO.ToString();
                    if (adm_moduloRetorno.EMAIL != null)
                        frm.EMAILtextBox.Text = adm_moduloRetorno.EMAIL.ToString();
                    if (adm_moduloRetorno.TELEFONE != null)
                        frm.TELEFONEtextBox.Text = adm_moduloRetorno.TELEFONE.ToString();
                   
        
                    //muda o nome do botão pra altera
                    frm.BtnSalvaradm_modulo.Text = "Alterar";
                    frm.ShowDialog();

                    //atualiza a grid
                    InsertarFilas();
                }

            }
            else
                MessageBoxEx.Show("selecione um adm_modulo por favor, para operação!");
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBoxEx.Show("Deseja realmente cancelar este Iten selecionado?", MessageIcon.Question, MessageButton.YesNo);
                if (d == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                    //vai ate o banco de dados e excluir
                    new FornecedorDAL().Excluir(id);
                    MessageBoxEx.Show("Excuido com sucesso!");
                    //atualiza a grid 
                    InsertarFilas();
                }

            }
            catch (Exception)
            {

                MessageBoxEx.Show("Não existe itens para Excluir!", "Informação", MessageIcon.Error, MessageButton.OK);
            }
        }

        private void QuantidadeEstoque_Click(object sender, EventArgs e)
        {
            int IDFoenedor = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
            FrmProdutosFornecedor fornecedor = new FrmProdutosFornecedor(IDFoenedor);
            fornecedor.ShowDialog();
        }
    }
}
