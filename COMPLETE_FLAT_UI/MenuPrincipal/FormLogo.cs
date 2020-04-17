using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.Fornecedor;
using Model;
using SoftwareGerenciador.Agenda;
using SoftwareGerenciador.Faturamento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            //quantidade de clientes
            var QuantidadeClientes = new CLIENTEDAL().CONSULTATODOS();
            LbQuantidadeClientes.Text = QuantidadeClientes.Count.ToString() + " :Clientes Cadastrados";

            //quantidade de mensalidades á ser pagas hoje
            var Situacao = new ContratoDAL().ConsultaData(DateTime.Now.Date);
            LbquantidadeClienteMensalidade.Text = Situacao.Rows.Count.ToString() + " :Pagamentos";

            //quantidade de agendamentos do mes
            string Mes = DateTime.Now.Date.Month.ToString();
            //var Mes = MêsAno.Month.ToString();
            //var Ano = MêsAno.Year.ToString();
            var ClientesAgendados = Agendamento(Mes);
            LbQuantidadeAgedamento.Text = ClientesAgendados.Count.ToString() + " :Pré - Agendados";

            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = DateTime.Now.Date.Day;
            int ano = DateTime.Now.Date.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Date.Month));
            //string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.Date.DayOfWeek));
            //string dataDesmenbrada = diasemana + " / " + mes + " / " + ano;
            LbMes.Text = mes.ToString();

            //quantidade de fornecedores cadastrado
            var fornecedores = new FornecedorDAL().ListaFornecedor(new FornecedorModel());
            LbFornecedores.Text = fornecedores.Count.ToString() + " :Fornecedores Cadastrados";
        }
        private List<cliente> Agendamento(string Mes)
        {
            var retorno = new List<cliente>();
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                //conexao.AdicionarParametros("@MesAno", Mes);
                var datatable = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM `cliente` WHERE MONTH(DATAINSTALACAO) = '" + Mes + "'");
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    var dados = Genericos.Popular<cliente>(datatable, i);
                    retorno.Add(dados);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        private void panelAgendamento_Click(object sender, EventArgs e)
        {
            FrmAgendamentoVeicular fm = new FrmAgendamentoVeicular();
            fm.ShowDialog();
        }

        private void panelPagamento_Click(object sender, EventArgs e)
        {
            frmconsultadepagamento frm = new frmconsultadepagamento();
            frm.ShowDialog();
        }
    }
}
