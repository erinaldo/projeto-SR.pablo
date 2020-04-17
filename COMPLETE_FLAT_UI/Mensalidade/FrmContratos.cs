using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using SoftwareGerenciador.adm_modulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace SoftwareGerenciador.Mensalidade
{
    public partial class FrmContratos : Form
    {
        public FrmContratos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {
            todos();
        }
        public void todos()
        {
            var TodosContratos = new ContratoDAL().ConsultaTodosContratos();

            //criar um nova lista

            var novaLista = TodosContratos.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
            {
                CodigoContrato = c.ID,
                Cliente = c.ClienteContrato.NOME,
                //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                //Status = c.SITUACAO,
                Dia = c.DIA_BASE,
                Valor = c.VALOR_MES,
                Situação = c.SITUACAO

            }).ToList();

            int Qtd = 0;
            Qtd = novaLista.Count;
            LbNumeroDeContratos.Text = Qtd.ToString();

            DGVDADOS.DataSource = null;
            DGVDADOS.Columns.Clear();
            DGVDADOS.DataSource = novaLista;
            Add_ColunaMenu();
            MontarGrid();
        }
        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "NOME", "DATA", "DIAVENCIMENTO", "EMAILPARTICULAR", "TELEFONE1", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "CodigoContrato", "Cliente", "Dia", "Valor", "Situação", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10,50,10,10,10,10 }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

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

        private void Editar_Click(object sender, EventArgs e)
        {
            var NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["Cliente"].Value.ToString());
            int codigodoContrato = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["CodigoContrato"].Value.ToString());

            FrmCriarCodicoesPagamento pagamento = new FrmCriarCodicoesPagamento();
            pagamento.LBnomedoadm_modulo.Text = NomeCliente;
            pagamento.CodigoContrato = codigodoContrato;
            pagamento.ShowDialog();
            this.Close();
        }

        private void NomeClientetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //consulta o clienteif
                if (!string.IsNullOrWhiteSpace(NomeClientetextBox.Text))
                {
                    var cliente = new ContratoDAL().CONSULTATODOSPELONOMEcomlike(NomeClientetextBox.Text.Trim());
                    if (cliente.Count > 0)
                    {
                        var novaLista = cliente.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                        {
                            CodigoContrato = c.ID,
                            Cliente = c.ClienteContrato.NOME,
                            //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                            //Status = c.SITUACAO,
                            Dia = c.DIA_BASE,
                            Valor = c.VALOR_MES,
                            Situação = c.SITUACAO

                        }).ToList();

                        int Qtd = 0;
                        Qtd = novaLista.Count;
                        LbNumeroDeContratos.Text = Qtd.ToString();

                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                        DGVDADOS.DataSource = novaLista;
                        Add_ColunaMenu();
                        MontarGrid();
                    }
                    else
                        todos();
                }
                else
                    todos();
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
        public void ConsultaRadioCOntrato()
        {
            try
            {
                if (radioButtonContratosATIVO.Checked == true)
                {
                    var cliente = new ContratoDAL().CONSULTATODOSPELOSITUACAO("ATIVO");
                    if (cliente.Count > 0)
                    {
                        var novaLista = cliente.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                        {
                            CodigoContrato = c.ID,
                            Cliente = c.ClienteContrato.NOME,
                            //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                            //Status = c.SITUACAO,
                            Dia = c.DIA_BASE,
                            Valor = c.VALOR_MES,
                            Situação = c.SITUACAO

                        }).ToList();

                        int Qtd = 0;
                        Qtd = novaLista.Count;
                        LbNumeroDeContratos.Text = Qtd.ToString();

                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                        DGVDADOS.DataSource = novaLista;
                        Add_ColunaMenu();
                        MontarGrid();
                    }
                    else
                    {
                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                    }
                }
                else
                {
                    var cliente = new ContratoDAL().CONSULTATODOSPELOSITUACAO("CANCELADO");
                    if (cliente.Count > 0)
                    {
                        var novaLista = cliente.Select(c => new //esse c aqui pode usar qualquer letra... entendi meu mano .. nossa cada detalhe heim
                        {
                            CodigoContrato = c.ID,
                            Cliente = c.ClienteContrato.NOME,
                            //DataInstalacao = (c.ClienteContrato.DATAINSTALACAO == DateTime.MinValue) ? "Sem data" : c.ClienteContrato.DATAINSTALACAO.ToShortDateString(),
                            //Status = c.SITUACAO,
                            Dia = c.DIA_BASE,
                            Valor = c.VALOR_MES,
                            Situação = c.SITUACAO

                        }).ToList();

                        int Qtd = 0;
                        Qtd = novaLista.Count;
                        LbNumeroDeContratos.Text = Qtd.ToString();

                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                        DGVDADOS.DataSource = novaLista;
                        Add_ColunaMenu();
                        MontarGrid();
                    }
                    else
                    {
                        DGVDADOS.DataSource = null;
                        DGVDADOS.Columns.Clear();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void radioButtonContratosCANCELADO_CheckedChanged(object sender, EventArgs e)
        {
            ConsultaRadioCOntrato();
        }
    }
}
