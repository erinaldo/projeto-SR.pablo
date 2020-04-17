using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados.Agenda;
using Dados.imovels;
using Model;

namespace SoftwareGerenciador.Agenda
{
    public partial class FrmNovoAgendamento : Form
    {
        public int codigoSalvo = 0;
        public FrmNovoAgendamento()
        {
            InitializeComponent();
            carregaImovel();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void carregaImovel()
        {

            var ListaImovel = new imovelDAL().imovel(new imovelModel());
            ListaImovel.Insert(0, new imovelModel() { NOME = "SELECIONE" });
            comboImovel.DisplayMember = "NOME";
            comboImovel.ValueMember = "ID";
            comboImovel.DataSource = ListaImovel;

        }
        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nOMETextBox.Text))
                {
                    MessageBoxEx.Show("Preenha o nome da agendador");
                    return;
                }
                var Validados = ColheDados();
                //Alterar

                if (!string.IsNullOrEmpty(iDTextBox.Text))
                {
                    new AgendamentoDAL().Alterar(Validados);
                    MessageBoxEx.Show("Agendamento alterado com sucesso!");
                    Close();
                }
                else //Salvar
                {
                    new AgendamentoDAL().Inserir(Validados);
                    MessageBoxEx.Show("Agendado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: "+ ex.Message + ex.StackTrace);
            }
           
                
        }
        private Agendamento ColheDados()
        {
            Agendamento agendamento = new Agendamento();
            if (!string.IsNullOrEmpty(iDTextBox.Text))
                agendamento.ID = Convert.ToInt32(iDTextBox.Text);

            if (!string.IsNullOrEmpty(nOMETextBox.Text))
                agendamento.NOME = nOMETextBox.Text.Trim();
         
            if (!string.IsNullOrEmpty(EMAILtextBox.Text))
                agendamento.EMAIL = EMAILtextBox.Text.Trim();
            if (!string.IsNullOrEmpty(TELEFONEtextBox.Text))
                agendamento.TELEFONE = TELEFONEtextBox.Text.Trim();
            if (!string.IsNullOrEmpty(TxtDescrcao.Text))
                agendamento.DESCRICAO = TxtDescrcao.Text.Trim();

            if (comboImovel.SelectedIndex != 0)
                agendamento.ID_PRODUTO = Convert.ToInt32(comboImovel.SelectedValue);

            agendamento.DATA_AGENDAMENTO = DateTime.Now.Date;
            agendamento.STATUS = "AGENDADO";
            return agendamento;
        }

        private void comboSTATUS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboTIPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmNovoAgendamento_Load(object sender, EventArgs e)
        {
           
        }
    }
}
