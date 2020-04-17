
using Dados;
using Dados.Agenda;
using Dados.ContaaPagar;
using Dados.contrato;
using Dados.Contrato_imprestimo;
using Dados.Fornecedor;
using Model;
using MySql.Data.MySqlClient;
using SoftwareGerenciador.Agenda;
using SoftwareGerenciador.ContasApagar;
using SoftwareGerenciador.Faturamento;
using SoftwareGerenciador.Financeiro;
using SoftwareGerenciador.Fornecedor;
using SoftwareGerenciador.Lancamentos;
using SoftwareGerenciador.Login;
using SoftwareGerenciador.Mensalidade;
using SoftwareGerenciador.Produtos;
using SoftwareGerenciador.Recibo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
namespace SoftwareGerenciador
{
    public partial class FormMenuPrincipal : Form
    {
        //Constructor

        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            hideSubMenu();
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Sistema esta sendo fechado!", "Sistema", MessageIcon.Question, MessageButton.YesNo);

            backup();
            Application.ExitThread();

            Application.Exit();
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FrmTelaFinanceiro());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
            //colocar o usuario que ta na sessa na tela de informações

            LbNOMEUSUARIO.Text = Sessao.Instance.Usuario.NOME;
            LbNOMELOGUINUSUARIO.Text = Sessao.Instance.Usuario.CARGO;
            //IMAGEM

        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        //METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------
        private void btnListaadm_modulos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormListaadm_modulos());

            //FormListaadm_modulos fm = new FormListaadm_modulos();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            //FormMembresia frm = new FormMembresia();
            //frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmconsultadepagamento());
            //frmconsultadepagamento frm = new frmconsultadepagamento();
            //frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(frm);
        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuario());
            //FrmUsuario fm = new FrmUsuario();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void BtnFinanceiro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnContasaPagar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAgendamentoVeicular fm = new FrmAgendamentoVeicular();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPendriver_Click(object sender, EventArgs e)
        {

            //PenDrive fm = new PenDrive();
            //fm.ro
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);

            PenDrive FPenDrive = new PenDrive();
            PenDrive.Rotina = "EXPORTA";
            FPenDrive.ShowDialog();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCorretor());
            //FrmCorretor fm = new FrmCorretor();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmListaImovel());
            //frmListaImovel fm = new frmListaImovel();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void BtnLancamentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDespesasLancamento());
            //FrmDespesasLancamento fm = new FrmDespesasLancamento();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }
        public void Alert(string msg1, string msg2, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg1, msg2, type);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ferificar o mes
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Date.Month));
            LbMes.Text = mes.ToString();

            //variaveis Alugueis
            DataTable SituacaoAluguel = new DataTable();
            DataTable SituacaoImprestimo = new DataTable();
            //Contas á pagar
            List<ContaPagarModel> LIstPagarFornecedo = new List<ContaPagarModel>();
            //variaveis Aluguesi
            DataTable SituacaoAluguelAtrasado = new DataTable();
            DataTable SituacaoImprestimoAtrasado = new DataTable();
            //if (minutos == 1)//(minutos == 57 && segundos == 1 && milisegundos >= 600)
            if ((DateTime.Now.Second == 30) && (DateTime.Now.Millisecond >= 900))
            {
                //quantidade de mensalidades á ser pagas hoje
                SituacaoAluguel = new ContratoDAL().ConsultaData(DateTime.Now.Date);
                SituacaoImprestimo = new ContratoImprestimoDAL().ConsultaData(DateTime.Now.Date);

                //Dados de Situação de Atraso
                DateTime dataFinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
                SituacaoAluguelAtrasado = new ContratoDAL().ConsultaData(DateTime.Now, dataFinal, "ATRASADO");
                SituacaoImprestimoAtrasado = new ContratoImprestimoDAL().ConsultaData(DateTime.Now, dataFinal, "ATRASADO");

                //conta á pagar
                var ResumoContaPagasMes = new ContaPagarDAL().ContasAlerta();
                if (ResumoContaPagasMes.Rows.Count > 0)
                {

                    for (int i = 0; i < ResumoContaPagasMes.Rows.Count; i++)
                    {
                        ContaPagarModel conta = new ContaPagarModel();
                        conta.fornecedor = new FornecedorModel();
                        var NomeFornecedor = new FornecedorDAL().consultaid(Convert.ToInt32(ResumoContaPagasMes.Rows[i].ItemArray[1]));
                        conta.fornecedor.NOME = NomeFornecedor.NOME;
                        conta.VALORCONTA = Convert.ToDecimal(ResumoContaPagasMes.Rows[i].ItemArray[9]);
                        conta.DATAVENCIMENTO = Convert.ToDateTime(ResumoContaPagasMes.Rows[i].ItemArray[4]);
                        LIstPagarFornecedo.Add(conta);
                    }
                }

                listViewConteudo.Items.Clear();
                string[] Conteudo = new string[12];
                Conteudo[0] = "     PAGT. HOJE";
                Conteudo[1] = "QTD. Alugueis Hoje: " + "(" + SituacaoAluguel.Rows.Count.ToString() + ")";
                Conteudo[2] = "QTD. Imprestimo Hoje: " + "(" + SituacaoImprestimo.Rows.Count.ToString() + ")";
                Conteudo[3] = "";
                Conteudo[4] = "";
                Conteudo[5] = "     PAGT. ATRASADO";
                Conteudo[6] = "QTD. Alugueis: " + "(" + SituacaoAluguelAtrasado.Rows.Count.ToString() + ")";
                Conteudo[7] = "QTD. Imprestimo: " + "(" + SituacaoImprestimoAtrasado.Rows.Count.ToString() + ")";
                Conteudo[8] = "";
                Conteudo[9] = "";
                Conteudo[10] = "     CONTA Á PAGAR";
                Conteudo[11] = "Conta á pagar\n (" + LIstPagarFornecedo.Count + ")";
                listViewConteudo.Items.AddRange(Conteudo);
            }

            if (DateTime.Now.Hour == 16)//toda as 5 da tarde atualizar a situação de pendencias
            {

                //ferificar parcelas em atraso menor que o dia de ontem e altualizar a situação pra atrasado
                //trazer os cliente e seu ultimo pagamento
                DateTime dataFinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
                var SituacaoAluguelAtrasado16 = new ContratoDAL().ConsultaData(DateTime.Now, dataFinal, "NAO PAGO");
                var SituacaoImprestimoAtrasado16 = new ContratoImprestimoDAL().ConsultaData(DateTime.Now, dataFinal, "NAO PAGO");

                //atualizando as parcelas em atraso para situação de (atrasado)
                for (int i = 0; i < SituacaoAluguelAtrasado16.Rows.Count; i++)
                {
                    try
                    {
                        var atrasado = new contratoParcelamento()
                        {
                            ID_CONTRATO = Convert.ToInt32(SituacaoAluguelAtrasado16.Rows[i].ItemArray[0].ToString()),
                            DATA_VENCIMENTO = Convert.ToDateTime(SituacaoAluguelAtrasado16.Rows[i].ItemArray[3]),
                            N_MENSALIDADE = Convert.ToInt32(SituacaoAluguelAtrasado16.Rows[i].ItemArray[5].ToString()),
                            SITUACAO = "ATRASADO"
                        };
                        new ContratoDAL().AlterarParcelasAtradadas(atrasado);
                    }
                    catch (Exception EX) { MessageBoxEx.Show("Erro em atualizar parcelas em atraso" + EX.Message); }
                }

                //atualizando as parcelas em atraso para situação de (atrasado)
                for (int i = 0; i < SituacaoImprestimoAtrasado16.Rows.Count; i++)
                {
                    try
                    {
                        var atrasado = new ContratoImprestimoParcela()
                        {
                            ID_CONTRATO = Convert.ToInt32(SituacaoImprestimoAtrasado16.Rows[i].ItemArray[0].ToString()),
                            DATA_VENCIMENTO = Convert.ToDateTime(SituacaoImprestimoAtrasado16.Rows[i].ItemArray[3]),
                            N_MENSALIDADE = Convert.ToInt32(SituacaoImprestimoAtrasado16.Rows[i].ItemArray[6].ToString()),
                            SITUACAO = "ATRASADO"
                        };
                        new ContratoImprestimoDAL().AlterarParcelasAtradadas(atrasado);
                    }
                    catch (Exception EX) { MessageBoxEx.Show("Erro em atualizar parcelas em atraso" + EX.Message); }
                }
            }
        }
        //private List<cliente> ConsultarClientesdeManutencao(string Mes)
        //{
        //    var retorno = new List<cliente>();
        //    try
        //    {
        //        DlConexao conexao = new DlConexao();
        //        conexao.limparParametros();
        //        //conexao.AdicionarParametros("@MesAno", Mes);
        //        var datatable = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM `cliente` WHERE MONTH(DATAMANUTECAO) = '" + Mes + "'");
        //        for (int i = 0; i < datatable.Rows.Count; i++)
        //        {
        //            var dados = Genericos.Popular<cliente>(datatable, i);
        //            retorno.Add(dados);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
        //    }
        //    return retorno;
        //}
        private List<cliente> PreAgendamento(string Mes)
        {
            var retorno = new List<cliente>();
            try
            {
                //DlConexao conexao = new DlConexao();
                //conexao.limparParametros();
                ////conexao.AdicionarParametros("@MesAno", Mes);
                //var datatable = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM `cliente` WHERE MONTH(DATA) = '" + Mes + "'");
                //for (int i = 0; i < datatable.Rows.Count; i++)
                //{
                //    var dados = Genericos.Popular<cliente>(datatable, i);
                //    retorno.Add(dados);
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        private void BtnResumoFinanceiro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTelaFinanceiro());
            //FrmTelaFinanceiro fm = new FrmTelaFinanceiro();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void LbPagamentoAtraso_Click(object sender, EventArgs e)
        {

        }
        private void CriaPasta(string PastaValida)
        {
            //Criamos um com o nome folder
            if (!Directory.Exists(PastaValida))
                Directory.CreateDirectory(PastaValida);

            if (!CurrentUserSecurity.HasAccess(new DirectoryInfo(PastaValida), System.Security.AccessControl.FileSystemRights.CreateDirectories))
            {
                MessageBox.Show("Sem permissão ao caminho " + PastaValida, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void backup()
        {
            try
            {

                // define o nome do arquivo de backup de acordo com a data e hora.
                string dia = DateTime.Now.Day.ToString("00");
                string mes = DateTime.Now.Month.ToString("00");
                string ano = DateTime.Now.Year.ToString("0000");
                string hora = DateTime.Now.ToLongTimeString().Replace(":", "");
                string nomeDoArquivo = ano + "_" + mes + "_" + dia + "_" + hora;

                string pasta = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory()) + "\\BACHUP";
                CriaPasta(pasta);
                if (!CurrentUserSecurity.HasAccess(new DirectoryInfo(pasta), System.Security.AccessControl.FileSystemRights.CreateDirectories))
                {
                    MessageBox.Show("Sem permissão ao caminho " + pasta, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Arquivo = pasta + "\\" + nomeDoArquivo + ".sql";
                using (MySqlConnection conn = new MySqlConnection(new DadosDaConexao().getWebConfig("MySql")))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            //mb.ExportInfo.EnableEncryption = true;
                            //mb.ExportInfo.EncryptionPassword = "qwerty";
                            mb.ExportToFile(Arquivo);
                            conn.Close();
                            MessageBoxEx.Show("Cópia do banco de dados realizado com sucesso.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro em criar o bachup.. preocure o adm" + ex.Message + " Caminho: " + ex.StackTrace);
            }
        }
        public class CurrentUserSecurity
        {
            static WindowsIdentity _currentUser;
            static WindowsPrincipal _currentPrincipal;

            static CurrentUserSecurity()
            {
                _currentUser = WindowsIdentity.GetCurrent();
                _currentPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            }

            public static bool HasAccess(DirectoryInfo directory, FileSystemRights right)
            {
                // Obtenha a coleção de regras de autorização que se aplicam ao diretório.
                AuthorizationRuleCollection acl = directory.GetAccessControl()
                    .GetAccessRules(true, true, typeof(SecurityIdentifier));
                return HasFileOrDirectoryAccess(right, acl);
            }

            public static bool HasAccess(FileInfo file, FileSystemRights right)
            {
                // Obtenha a coleção de regras de autorização que se aplicam ao arquivo.
                AuthorizationRuleCollection acl = file.GetAccessControl()
                    .GetAccessRules(true, true, typeof(SecurityIdentifier));
                return HasFileOrDirectoryAccess(right, acl);
            }

            private static bool HasFileOrDirectoryAccess(FileSystemRights right,
                                                  AuthorizationRuleCollection acl)
            {
                bool allow = false;
                bool inheritedAllow = false;
                bool inheritedDeny = false;

                for (int i = 0; i < acl.Count; i++)
                {
                    FileSystemAccessRule currentRule = (FileSystemAccessRule)acl[i];
                    // Se a regra atual se aplicar ao usuário atual.
                    if (_currentUser.User.Equals(currentRule.IdentityReference) ||
                        _currentPrincipal.IsInRole(
                                        (SecurityIdentifier)currentRule.IdentityReference))
                    {

                        if (currentRule.AccessControlType.Equals(AccessControlType.Deny))
                        {
                            if ((currentRule.FileSystemRights & right) == right)
                            {
                                if (currentRule.IsInherited)
                                {
                                    inheritedDeny = true;
                                }
                                else
                                { //"Negar" não herdado tem precedência geral.
                                    return false;
                                }
                            }
                        }
                        else if (currentRule.AccessControlType
                                                        .Equals(AccessControlType.Allow))
                        {
                            if ((currentRule.FileSystemRights & right) == right)
                            {
                                if (currentRule.IsInherited)
                                {
                                    inheritedAllow = true;
                                }
                                else
                                {
                                    allow = true;
                                }
                            }
                        }
                    }
                }

                if (allow)
                { // Allow" não herdado tem precedência sobre regras herdadas.
                    return true;
                }
                return inheritedAllow && !inheritedDeny;
            }

        }
        private void BtnGerarBoleto_Click(object sender, EventArgs e)
        {
            //var ObjBoleto = new Boletos();
            //var steImpressora = string.Empty;
            //var blnImorimir = false;
            //var intCopias = 1;

            //try
            //{
            //    ObjBoleto.Banco = Banco.Instancia(756);
            //    ObjBoleto.Banco.Cedente = new Cedente();
            //    ObjBoleto.Banco.Cedente.CPFCNPJ = "951.699.542-04";
            //    ObjBoleto.Banco.Cedente.Nome = "JV INFORMATICA";
            //    ObjBoleto.Banco.Cedente.Observacoes = "Aguardando o pagamento";

            //    var Conta = new ContaBancaria();
            //    Conta.Agencia = "1234";
            //    Conta.DigitoAgencia = "0";
            //    Conta.OperacaoConta = "0";
            //    Conta.Conta = "123456789";
            //    Conta.DigitoConta = "0";
            //    Conta.CarteiraPadrao = "1";

            //    Conta.VariacaoCarteiraPadrao = "01";
            //    Conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples;
            //    Conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro;
            //    Conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa;
            //    Conta.TipoDocumento = TipoDocumento.Tradicional;

            //    var Ender = new Endereco();
            //    Ender.LogradouroEndereco = "rua cosme ferreira";
            //    Ender.LogradouroNumero = "2515";
            //    Ender.LogradouroComplemento = "px ao colegio ";
            //    Ender.Bairro = "Colonia Antonio Aleixo";
            //    Ender.Cidade = "Manaus";
            //    Ender.UF = "AM";
            //    Ender.CEP = "69085-040";

            //    ObjBoleto.Banco.Cedente.Codigo = "25252";
            //    ObjBoleto.Banco.Cedente.CodigoDV = "6";
            //    ObjBoleto.Banco.Cedente.CodigoTransmissao = "0000";

            //    ObjBoleto.Banco.Cedente.ContaBancaria = Conta;
            //    ObjBoleto.Banco.Cedente.Endereco = Ender;

            //    ObjBoleto.Banco.FormataCedente();


            //    //Gerar O Boleto 1 ou varios
            //    var titulo = new Boleto(ObjBoleto.Banco);

            //    titulo.Sacado = new Sacado();
            //    titulo.Sacado.CPFCNPJ = "951.699.542-04";
            //    titulo.Sacado.Endereco = new Endereco()
            //    {
            //        Bairro = "",
            //        CEP = "",
            //        Cidade = "",
            //        LogradouroComplemento = "",
            //        LogradouroEndereco = "",
            //        LogradouroNumero = "",
            //        UF = ""
            //    };
            //    titulo.Sacado.Nome = "";
            //    titulo.Sacado.Observacoes = "";
            //    titulo.CodigoOcorrencia = "01";
            //    titulo.DescricaoOcorrencia = "Remessa registrada";
            //    titulo.NumeroDocumento = "1";
            //    titulo.NumeroControleParticipante = "12";
            //    titulo.NossoNumero = "1234546" + 1;
            //    titulo.DataEmissao = DateTime.Now;
            //    titulo.DataVencimento = DateTime.Now.Date.AddDays(15);
            //    titulo.ValorTitulo = 200; titulo.Aceite = "N";
            //    titulo.EspecieDocumento = TipoEspecieDocumento.DM;
            //    titulo.DataDesconto = DateTime.Now.Date.AddDays(15);
            //    titulo.ValorDesconto = 45;


            //    //parte de multa
            //    titulo.DataMulta = DateTime.Now.Date.AddDays(15);
            //    titulo.PercentualMulta = 2;
            //    titulo.ValorMulta = titulo.ValorTitulo * titulo.PercentualMulta / 100;
            //    titulo.MensagemInstrucoesCaixa = "Cobrar Multa de " + titulo.ValorMulta + "apos a data de vencimento";

            //    //parte juros de mora
            //    titulo.DataJuros = DateTime.Now.Date.AddDays(15);
            //    titulo.PercentualJurosDia = 10 / 30;
            //    titulo.ValorJurosDia = titulo.ValorTitulo * titulo.PercentualJurosDia / 100;
            //    titulo.MensagemInstrucoesCaixa = "Cobrar Multa de " + titulo.ValorMulta + "por dia";

            //    //valida o boleto e faz a gravação
            //    if (Directory.Exists(Application.StartupPath + "\remessa.txt"))
            //        Directory.Delete(Application.StartupPath + "\remessa.txt");

            //    var ms = new MemoryStream();
            //    var remessa = new ArquivoRemessa(ObjBoleto.Banco, TipoArquivo.CNAB240, 1);
            //    remessa.GerarArquivoRemessa(ObjBoleto, ms);
            //    var arquivo = new FileStream(Application.StartupPath + "remessa.txt", FileMode.Create, FileAccess.ReadWrite);
            //    ms.CopyTo(arquivo);
            //    arquivo.Close();
            //    ms.Close();

            //    //formata arquivo remessa
            //    var Lerarquivo = new StreamReader(Application.StartupPath + "\remessa.txt");
            //    var Refazarquivo = new StreamWriter(Application.StartupPath + "\remessa.txt");

            //    var strtexto = string.Empty;
            //    var conta1 = 0;
            //    while (Lerarquivo.Peek() != -1)
            //    {
            //        strtexto = Lerarquivo.ReadLine();
            //        conta1 = strtexto.Length;
            //    }



            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormListaadm_modulos());
            //FormListaadm_modulos fm = new FormListaadm_modulos();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void imóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmListaImovel());
            //frmListaImovel fm = new frmListaImovel();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void corretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCorretor());
            //FrmCorretor fm = new FrmCorretor();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void agendarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAgendamentoVeicular());
            //FrmAgendamentoVeicular fm = new FrmAgendamentoVeicular();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuario());
            //FrmUsuario fm = new FrmUsuario();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCategoriaDespesaReceitas());
            //FrmCategoriaDespesaReceitas fm = new FrmCategoriaDespesaReceitas();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void gerarDespesaReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDespesasLancamento());
            //FrmDespesasLancamento fm = new FrmDespesasLancamento();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void consultarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmContratos());
            //FrmContratos fm = new FrmContratos();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmRecibo());
            //FrmRecibo fm = new FrmRecibo();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormListaadm_modulos());
            //FormListaadm_modulos fm = new FormListaadm_modulos();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void imovélToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmListaImovel());
            //frmListaImovel fm = new frmListaImovel();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void configuraçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmParamentros());
            //FrmParamentros fm = new FrmParamentros();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //backup();
        }

        private void BtnContasPagar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmListaContasApagar());
            //frmListaContasApagar fm = new frmListaContasApagar();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


    }
}
