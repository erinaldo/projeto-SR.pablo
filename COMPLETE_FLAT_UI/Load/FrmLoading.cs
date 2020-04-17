using SoftwareGerenciador.Agenda;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class FrmLoading : Form
    {
        public Action Worker { get; set; }
        //private FrmAgendamentoVeicular Agendamento;
        //private string OutroTipo = "";
        //public FrmLoading(FrmAgendamentoVeicular frmAgendamento, string tipo)
        //{
        //    InitializeComponent();
        //    this.Agendamento = frmAgendamento;
        //    this.OutroTipo = tipo;
        //}
        public FrmLoading()
        {
            InitializeComponent();
        }


        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    if (OutroTipo == "Manutenção")
        //        Task.Factory.StartNew(MetodoAgemdamento).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        //}

    }
}
