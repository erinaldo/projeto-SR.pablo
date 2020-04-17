using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.Contrato_imprestimo;
using Model;
using SoftwareGerenciador.adm_modulo;
using SoftwareGerenciador.Mensalidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class FormListaadm_modulos : Form
    {
        public FormListaadm_modulos()
        {
            InitializeComponent();
        }
        List<cliente> TODOSCLIENTES = null;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaadm_modulos_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }


        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormNovoadm_modulo frm = new FormNovoadm_modulo();
            if (DGVDADOS.SelectedRows.Count > 0)
            {
                var adm_moduloRetorno = new CLIENTEDAL().CONSULTATODOSPELOID(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value));
                if (adm_moduloRetorno.ID > 0)
                {
                    frm.iDTextBox.Text = adm_moduloRetorno.ID.ToString();
                    frm.nOMETextBox.Text = adm_moduloRetorno.NOME.ToString();
                    if (adm_moduloRetorno.OBS != null)
                        frm.oBSTextBox.Text = adm_moduloRetorno.OBS.ToString();

                    if (adm_moduloRetorno.DIAVENCIMENTO != null)
                        frm.dIAVENCIMENTOTextBox.Text = adm_moduloRetorno.DIAVENCIMENTO.ToString();

                    if (adm_moduloRetorno.EMAILPARTICULAR != null)
                        frm.eMAILPARTICULARTextBox.Text = adm_moduloRetorno.EMAILPARTICULAR.ToString();

                    if (adm_moduloRetorno.TELEFONE2 != null)
                        frm.tELEFONE2TextBox.Text = adm_moduloRetorno.TELEFONE2.ToString().Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                    if (adm_moduloRetorno.CPFCNPJ != null)
                        frm.cPFCNPJTextBox.Text = adm_moduloRetorno.CPFCNPJ.ToString();
                    if (adm_moduloRetorno.TELEFONE1 != null)
                        frm.tELEFONE1TextBox.Text = adm_moduloRetorno.TELEFONE1.ToString().Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                    if (adm_moduloRetorno.ENDERECO != null)
                        frm.eNDERECOTextBox.Text = adm_moduloRetorno.ENDERECO.ToString();
                    if (adm_moduloRetorno.BAIRRO != null)
                        frm.bAIRROTextBox.Text = adm_moduloRetorno.BAIRRO.ToString();
                    if (adm_moduloRetorno.CIDADE != null)
                        frm.cIDADETextBox.Text = adm_moduloRetorno.CIDADE.ToString();
                    if (adm_moduloRetorno.CEP != null)
                        frm.cEPTextBox.Text = adm_moduloRetorno.CEP.ToString();

                    if (adm_moduloRetorno.NUMEROINDETIDADE != null)
                        frm.nUMEROINDETIDADETextBox.Text = adm_moduloRetorno.NUMEROINDETIDADE.ToString();

                    if (adm_moduloRetorno.FOTO != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));

                        frm.imagemadm_modulo.Image = new cliente().BuscarImagem(adm_moduloRetorno.FOTO);
                        frm.foto = "Foto Original";
                    }
                    if (adm_moduloRetorno.IMAGEM1 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM1.Image = new cliente().BuscarImagem1(adm_moduloRetorno.IMAGEM1);
                            frm.foto1 = "Foto Original";
                        }
                        catch { }
                    }
                    if (adm_moduloRetorno.IMAGEM2 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM2.Image = new cliente().BuscarImagem2(adm_moduloRetorno.IMAGEM2);
                            frm.foto2 = "Foto Original";
                        }
                        catch { }

                    }
                    if (adm_moduloRetorno.IMAGEM3 != null)
                    {
                        //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                        try
                        {
                            frm.pictureBoxIMAGEM3.Image = new cliente().BuscarImagem3(adm_moduloRetorno.IMAGEM3);
                            frm.foto3 = "Foto Original";
                        }
                        catch { }

                    }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (FormNovoadm_modulo frm = new FormNovoadm_modulo())
            {
                frm.ShowDialog();
            }

            //atualiza a grid 
            InsertarFilas();
        }

        private void InsertarFilas()
        {
            //CONSULTA TODOS OS CLIENTES
            TODOSCLIENTES = new List<cliente>();
            TODOSCLIENTES = new CLIENTEDAL().CONSULTATODOS();
            DGVDADOS.DataSource = null;
            DGVDADOS.Columns.Clear();
            DGVDADOS.DataSource = TODOSCLIENTES;
            Add_ColunaMenu();
            MontarGrid();
        }
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "NOME", "DATA", "DIAVENCIMENTO", "EMAILPARTICULAR", "TELEFONE1", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "ID", "NOME", "DATA", "DIAVENCIMENTO", "EMAILPARTICULAR", "TELEFONE", "Tarefas" });

            //Define quais as larguras respectivas das colunas
            //objBlControleGrid.DefinirLarguras(new List<int>() {10, 40,10,10,10,10,10}, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);


        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormNovoadm_modulo frm = Owner as FormNovoadm_modulo;
            //FormMembresia frm = new FormMembresia();

            //frm.txtid.Text = DGVDADOS.CurrentRow.Cells[0].Value.ToString();
            //frm.txtnombre.Text = DGVDADOS.CurrentRow.Cells[1].Value.ToString();
            //frm.txtapellido.Text = DGVDADOS.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // a parti do Id excluir
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

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBoxEx.Show("Deseja realmente excluir este cliente selecionado?", MessageIcon.Question, MessageButton.YesNo);
                if (d == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                    //vai ate o banco de dados e excluir
                    new CLIENTEDAL().Excluir(id);
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

        private void criarCondiçoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value.ToString());

            cliente cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);
            var existeContrato = new ContratoDAL().ConsultaContratos(new ContratoModel() { ID_CLIENTE = cliente.ID });

            if (existeContrato.Count > 0)
            {
                //consulta todos os contratos desse cliente
                frmSelecionaContrato pagamento = new frmSelecionaContrato();
                pagamento.ListaContratoCliente = existeContrato;
                pagamento.ShowDialog();
            }
            else if (existeContrato.Count <= 0)
            {
                FrmCriarCodicoesPagamento pagamento = new FrmCriarCodicoesPagamento();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente;
                pagamento.CodigoContrato = 0;
                pagamento.ShowDialog();
            }
        }

        private void receberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReceberPagamento pagamento = new frmReceberPagamento();
            ////aqui mando o codigo do cliente para criar codiçoes de pagamaneto.
            //pagamento.LBnomedoadm_modulo.Text = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value.ToString());
            //pagamento.ShowDialog();

        }

        private void NomeClientetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //consulta o clienteif
                if (!string.IsNullOrWhiteSpace(NomeClientetextBox.Text))
                {
                    var cliente = new CLIENTEDAL().CONSULTATODOSPELONOMEcomlike(NomeClientetextBox.Text.Trim());
                    if (cliente.Count > 0)
                    {
                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                        DGVDADOS.DataSource = cliente;
                        Add_ColunaMenu();
                        MontarGrid();
                    }
                    else
                        InsertarFilas();
                }
                else
                    InsertarFilas();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void ConsultaRadioCOntrato()
        {
            try
            {
                if (radioButtonContratosATIVO.Checked == true)
                {
                    var Ativo = new CLIENTEDAL().CONSULTATODOSContratosATIVOS("ATIVO");
                    DGVDADOS.DataSource = null;
                    DGVDADOS.Columns.Clear();
                    DGVDADOS.DataSource = Ativo;
                    Add_ColunaMenu();
                    MontarGrid();
                }
                else
                {
                    var Ativo = new CLIENTEDAL().CONSULTATODOSContratosATIVOS("CANCELADO");
                    DGVDADOS.DataSource = null;
                    DGVDADOS.Columns.Clear();
                    DGVDADOS.DataSource = Ativo;
                    Add_ColunaMenu();
                    MontarGrid();
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void radioButtonContratosATIVO_CheckedChanged(object sender, EventArgs e)
        {
            ConsultaRadioCOntrato();
        }

        private void radioButtonContratosCANCELADO_CheckedChanged(object sender, EventArgs e)
        {
            ConsultaRadioCOntrato();
        }

        private void contratoDeMensalidImprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value.ToString());

            cliente cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);
            var existeContrato = new ContratoImprestimoDAL().ConsultaContratos(new ContratoImprestimo() { ID_CLIENTE = cliente.ID });

            if (existeContrato.Count > 0)
            {
                //consulta todos os contratos desse cliente
                using (frmSelecionaContratoImprestimo pagamento = new frmSelecionaContratoImprestimo())
                {
                    pagamento.ListaContratoCliente = existeContrato;
                    pagamento.ShowDialog();
                }

            }
            else if (existeContrato.Count <= 0)
            {
                using (FrmCriarCodicoesPagamentoImprestimo pagamento = new FrmCriarCodicoesPagamentoImprestimo())
                {
                    pagamento.LBnomedoadm_modulo.Text = NomeCliente;
                    pagamento.CodigoContrato = 0;
                    pagamento.ShowDialog();
                }
                  
            }
        }
    }
}
