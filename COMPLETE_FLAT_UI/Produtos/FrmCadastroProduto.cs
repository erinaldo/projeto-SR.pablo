using Dados.DepesaseReceitas;
using Dados.Fornecedor;
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
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
            carregaCategoriaCorretor();
        }
        public string foto1 = "";
        public string foto2 = "";
        public string foto3 = "";
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
          
        }
        private void carregaCategoriaCorretor()
        {

            var ListaCategoria = new DespesasReceitasDAL().ListaCategoria(new despesasCategoria());
            ListaCategoria.Insert(0, new despesasCategoria() { NOME = "SELECIONE" });
            comboCategoria.DisplayMember = "NOME";
            comboCategoria.ValueMember = "ID";
            comboCategoria.DataSource = ListaCategoria;

            var ListaCorretor = new FornecedorDAL().ListaFornecedor(new FornecedorModel());
            ListaCorretor.Insert(0, new FornecedorModel() { NOME = "SELECIONE" });
            comboFornecedor.DisplayMember = "NOME";
            comboFornecedor.ValueMember = "ID";
            comboFornecedor.DataSource = ListaCorretor;

        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarImagem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto1 = od.FileName;
                pictureBoxIMAGEM1.Load(this.foto1);
            }
        }

        private void btnSalvarImagem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto2 = od.FileName;
                pictureBoxIMAGEM2.Load(this.foto2);
            }
        }

        private void btnSalvarImagem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto3 = od.FileName;
                pictureBoxIMAGEM3.Load(this.foto3);
            }
        }

        private void btnLinpaImagem1_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM1.Image = null;
        }

        private void btnLinpaImagem2_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM2.Image = null;
        }

        private void btnLinpaImagem3_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM3.Image = null;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboCategoria.SelectedIndex == 0)
                {
                    MessageBoxEx.Show("Coloque o dia de vencimento");
                    return;
                }
                if (string.IsNullOrWhiteSpace(iDTextBox.Text))//se o campo id e vazio e pra salvar os dados
                {
                    new imovelDAL().Inserir(Objetoadm_modulo());

                    MessageBoxEx.Show("Inserido com sucesso");
                    Close();
                }
                else //se o campo estiver uma numeração e pra alterar os dados
                {
                    new imovelDAL().Alterar(Objetoadm_modulo());

                    MessageBoxEx.Show("Alterado com sucesso");
                    Close();
                }
            }
            catch (Exception EX)
            {

                MessageBoxEx.Show(EX.ToString());
            }
        }
        private imovelModel Objetoadm_modulo()
        {
            var retorno = new imovelModel()
            {
                //ID = Convert.ToInt32(iDTextBox.Text),
               NOME = nOMETextBox.Text.Trim(),
                ID_CATEGORIA = Convert.ToInt32(comboCategoria.SelectedValue),
                SITUACAO = comboSituacao.Text.Trim(),
                TIPO = comboTipo.Text.Trim(),
                //OCUPACAO = .Text.Trim(),falta
                ID_CORRETOR = Convert.ToInt32(comboFornecedor.SelectedValue),
                CIDADE = CidadetextBox.Text.Trim(),
                BAIRRO = BairrotextBox.Text.Trim(),
                NUMERO = NumerotextBox.Text.Trim(),
                ESTADO = EstadotextBox.Text.Trim(),
                COMPLEMENTO = ComplementotextBox.Text.Trim(),
                PROPRIETARIO = ProprietariotextBox4.Text.Trim(),
                LOCALCHAVE = LocalChavetextBox.Text.Trim(),
                ULTIMAATUALIZACAO = AtualizacaotextBox.Text.Trim(),
                QUARTOS = Convert.ToInt32(QuartostextBox.Text),
                SUITES = Convert.ToInt32(SuitetextBox.Text),
                PAVIMENTO = Convert.ToInt32(PavimentotextBox.Text),
                GARAGEM = Convert.ToInt32(GaragemtextBox.Text),
                SALA = Convert.ToInt32(SalastextBox.Text),
                BANHEIRO = Convert.ToInt32(BanheirotextBox.Text),
                ANDAR = Convert.ToInt32(AndarextBox.Text),
                AREATERRENO = Convert.ToInt32(AreaTerrenotextBox.Text),
                AREACONSTRUIDA = Convert.ToInt32(AreaConstruidatextBox.Text),
                IDADEIMOVEL = Convert.ToInt32(IdadeImoveltextBox.Text),
                PRAZOENTREGA = Convert.ToInt32(PrazoEntregatextBox.Text),
                EDIFICIO = EdificiotextBox.Text,
                CONSTRUTORA = ConstrutoratextBox.Text,
                DESCRICAO = DescricaotextBox.Text,
                VALORIPTU = Convert.ToDecimal(ValorIPTUtextBox.Text),
                VALORCODOMINIO = Convert.ToDecimal(ValorCondominiotextBox.Text),
                VALORPRECO = Convert.ToDecimal(ValorPrecotextBox.Text),
                VALORALUGUEL = Convert.ToDecimal(ValorAlugueltextBox.Text)
            };

            

            if (this.foto1 == "Foto Original")
            {
                var mt = new imovelDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM1 = mt.IMAGEM1;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto1))
                    retorno.CarregaImagem1(this.foto1);
            }
            if (this.foto2 == "Foto Original")
            {
                var mt = new imovelDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM2 = mt.IMAGEM2;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto2))
                    retorno.CarregaImagem2(this.foto2);
            }
            if (this.foto3 == "Foto Original")
            {
                var mt = new imovelDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM3 = mt.IMAGEM3;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto3))
                    retorno.CarregaImagem3(this.foto3);
            }

            //ocupação
            if(InquilinometroRadioButton.Checked == true) { retorno.OCUPACAO = InquilinometroRadioButton.Text; }
            if (ProprietariometroRadioButton.Checked == true) { retorno.OCUPACAO = ProprietariometroRadioButton.Text; }
            if (DesocupadometroRadioButton.Checked == true) { retorno.OCUPACAO = DesocupadometroRadioButton.Text; }

            if (string.IsNullOrWhiteSpace(iDTextBox.Text)) { retorno.ID = 0; } else { retorno.ID = Convert.ToInt32(iDTextBox.Text.Trim()); }
            return retorno;
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                //MessageBoxEx.Show(erro.Message);
            }
        }

        private void ValorIPTUtextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref ValorIPTUtextBox);
        }

        private void ValorCondominiotextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref ValorCondominiotextBox);
        }

        private void ValorPrecotextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref ValorPrecotextBox);
        }

        private void ValorAlugueltextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref ValorAlugueltextBox);

        }
    }
}
