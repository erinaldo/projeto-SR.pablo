using Dados;
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

namespace SoftwareGerenciador.Produtos
{
    public partial class frmListaImovel : Form
    {
        public frmListaImovel()
        {
            InitializeComponent();
        }
        List<imovelModel> TODOSImovel = null;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }

        private void frmListaProdutos_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        private void InsertarFilas()
        {
            //CONSULTA TODOS OS CLIENTES
            TODOSImovel = new List<imovelModel>();
            TODOSImovel = new imovelDAL().imovel(new imovelModel());
            DGVDADOS.DataSource = null;
            DGVDADOS.Columns.Clear();
            DGVDADOS.DataSource = TODOSImovel;
            Add_ColunaMenu();
            MontarGrid();
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
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "NOME", "SITUACAO", "TIPO", "OCUPACAO", "CONSTRUTORA", "VALORPRECO", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "NOME", "SITUACAO", "TIPO", "OCUPACAO", "CONSTRUTORA", "VALOR", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);


        }
        private void Editar_Click(object sender, EventArgs e)
        {
            FrmCadastroImovel frm = new FrmCadastroImovel();
            if (DGVDADOS.SelectedRows.Count > 0)
            {
                var adm_moduloRetorno = new imovelDAL().CONSULTATODOSPELOID(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value));
                if (adm_moduloRetorno.ID > 0)
                {
                    frm.iDTextBox.Text = adm_moduloRetorno.ID.ToString();

                    if (adm_moduloRetorno.NOME != null) frm.nOMETextBox.Text = adm_moduloRetorno.NOME.ToString();
                    if (adm_moduloRetorno.ID_CATEGORIA > 0) frm.comboCategoria.SelectedValue = adm_moduloRetorno.ID_CATEGORIA;
                    if (adm_moduloRetorno.SITUACAO != null) frm.comboSituacao.Text = adm_moduloRetorno.SITUACAO.ToString();
                    if (adm_moduloRetorno.TIPO != null) frm.comboTipo.Text = adm_moduloRetorno.TIPO.ToString();
                    if (adm_moduloRetorno.ID_CORRETOR > 0) frm.comboFornecedor.SelectedValue = adm_moduloRetorno.ID_CORRETOR;
                    if (adm_moduloRetorno.CIDADE != null) frm.CidadetextBox.Text = adm_moduloRetorno.CIDADE.ToString();
                    if (adm_moduloRetorno.BAIRRO != null) frm.BairrotextBox.Text = adm_moduloRetorno.BAIRRO.ToString();
                    if (adm_moduloRetorno.NUMERO != null) frm.NumerotextBox.Text = adm_moduloRetorno.NUMERO.ToString();
                    if (adm_moduloRetorno.ESTADO != null) frm.EstadotextBox.Text = adm_moduloRetorno.ESTADO.ToString();
                    if (adm_moduloRetorno.COMPLEMENTO != null) frm.ComplementotextBox.Text = adm_moduloRetorno.COMPLEMENTO.ToString();
                    if (adm_moduloRetorno.PROPRIETARIO != null) frm.ProprietariotextBox4.Text = adm_moduloRetorno.PROPRIETARIO.ToString();
                    if (adm_moduloRetorno.LOCALCHAVE != null) frm.LocalChavetextBox.Text = adm_moduloRetorno.LOCALCHAVE.ToString();
                    if (adm_moduloRetorno.ULTIMAATUALIZACAO != null) frm.AtualizacaotextBox.Text = adm_moduloRetorno.ULTIMAATUALIZACAO.ToString();
                    if (adm_moduloRetorno.QUARTOS > 0) frm.QuartostextBox.Text = adm_moduloRetorno.QUARTOS.ToString();
                    if (adm_moduloRetorno.SUITES > 0) frm.SuitetextBox.Text = adm_moduloRetorno.SUITES.ToString();
                    if (adm_moduloRetorno.PAVIMENTO > 0) frm.PavimentotextBox.Text = adm_moduloRetorno.PAVIMENTO.ToString();
                    if (adm_moduloRetorno.GARAGEM > 0) frm.GaragemtextBox.Text = adm_moduloRetorno.GARAGEM.ToString();
                    if (adm_moduloRetorno.SALA > 0) frm.SalastextBox.Text = adm_moduloRetorno.SALA.ToString();
                    if (adm_moduloRetorno.BANHEIRO > 0) frm.BanheirotextBox.Text = adm_moduloRetorno.BANHEIRO.ToString();
                    if (adm_moduloRetorno.AREATERRENO > 0) frm.AreaTerrenotextBox.Text = adm_moduloRetorno.AREATERRENO.ToString();
                    if (adm_moduloRetorno.AREACONSTRUIDA > 0) frm.AreaConstruidatextBox.Text = adm_moduloRetorno.AREACONSTRUIDA.ToString();
                    if (adm_moduloRetorno.IDADEIMOVEL > 0) frm.IdadeImoveltextBox.Text = adm_moduloRetorno.IDADEIMOVEL.ToString();
                    if (adm_moduloRetorno.PRAZOENTREGA > 0) frm.PrazoEntregatextBox.Text = adm_moduloRetorno.PRAZOENTREGA.ToString();
                    if (adm_moduloRetorno.EDIFICIO != null) frm.EdificiotextBox.Text = adm_moduloRetorno.EDIFICIO.ToString();
                    if (adm_moduloRetorno.CONSTRUTORA != null) frm.ConstrutoratextBox.Text = adm_moduloRetorno.CONSTRUTORA.ToString();
                    if (adm_moduloRetorno.DESCRICAO != null) frm.DescricaotextBox.Text = adm_moduloRetorno.DESCRICAO.ToString();
                    if (adm_moduloRetorno.VALORIPTU > 0) frm.ValorIPTUtextBox.Text = Convert.ToDecimal(adm_moduloRetorno.VALORIPTU).ToString();
                    if (adm_moduloRetorno.VALORCODOMINIO > 0) frm.ValorCondominiotextBox.Text = Convert.ToDecimal(adm_moduloRetorno.VALORCODOMINIO).ToString();
                    if (adm_moduloRetorno.VALORPRECO > 0) frm.ValorPrecotextBox.Text = Convert.ToDecimal(adm_moduloRetorno.VALORPRECO).ToString();
                    if (adm_moduloRetorno.VALORALUGUEL > 0) frm.ValorAlugueltextBox.Text = Convert.ToDecimal(adm_moduloRetorno.VALORALUGUEL).ToString();

                    #region imagems

                    if (adm_moduloRetorno.IMAGEM1 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM1.Image = new imovelModel().BuscarImagem1(adm_moduloRetorno.IMAGEM1);
                            frm.foto1 = "Foto Original";
                        }
                        catch { }
                    }
                    if (adm_moduloRetorno.IMAGEM2 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM2.Image = new imovelModel().BuscarImagem2(adm_moduloRetorno.IMAGEM2);
                            frm.foto2 = "Foto Original";
                        }
                        catch { }

                    }
                    if (adm_moduloRetorno.IMAGEM3 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM3.Image = new imovelModel().BuscarImagem3(adm_moduloRetorno.IMAGEM3);
                            frm.foto3 = "Foto Original";
                        }
                        catch { }

                    }
                    #endregion

                    ////ocupação
                    if (adm_moduloRetorno.OCUPACAO == "Inquilino") { frm.InquilinometroRadioButton.Checked = true; }
                    if (adm_moduloRetorno.OCUPACAO == "Proprietário") { frm.ProprietariometroRadioButton.Checked = true; }
                    if (adm_moduloRetorno.OCUPACAO == "Desocupado") { frm.DesocupadometroRadioButton.Checked = true; }

                    //muda o nome do botão pra altera
                    frm.BtnSalvar.Text = "Alterar";
                    frm.ShowDialog();

                    //atualiza a grid
                    InsertarFilas();
                }

            }
            else
                MessageBoxEx.Show("selecione um adm_modulo por favor, para operação!");
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

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBoxEx.Show("Deseja realmente excluir este Imóvel selecionado?", MessageIcon.Question, MessageButton.YesNo);
                if (d == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                    //vai ate o banco de dados e excluir
                    new imovelDAL().Excluir(id);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCadastroImovel frm = new FrmCadastroImovel();
            frm.ShowDialog();

            //atualiza a grid 
            InsertarFilas();
        }

        private void SituaçãocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //consulta o clienteif
                var cliente = new imovelDAL().ListaImovelSituacao(SituaçãocomboBox.Text.Trim());
                if (cliente.Count > 0)
                {
                    DGVDADOS.DataSource = null;
                    DGVDADOS.Columns.Clear();
                    DGVDADOS.DataSource = cliente;
                    Add_ColunaMenu();
                    MontarGrid();
                }
                else
                {
                    DGVDADOS.DataSource = null;
                    DGVDADOS.Columns.Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
    }
}
