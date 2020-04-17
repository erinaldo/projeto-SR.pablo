using Dados;
using Dados.Agenda;
using Dados.CLIENTE;
using Dados.PARAMETROS;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador.Agenda
{
    public partial class FrmAgendamentoVeicular : Form
    {
        public Parametros ParametrosDados;
        public FrmAgendamentoVeicular()
        {
            InitializeComponent();
        }

        private void FrmAgendamentoVeicular_Load(object sender, EventArgs e)
        {
            Parametros();
        }

        private void copnsultadadosAgendados()
        {
            try
            {
                var DadosBanco = new AgendamentoDAL().ListaAgendamento();
                DGVDADOS.DataSource = null;
                //ECLUIR COLUNAS EXISTENTES
                DGVDADOS.Columns.Clear();
                //adiconar colunas

                DGVDADOS.DataSource = DadosBanco;
                Add_ColunaMenuTarefasAgendados();
                MontarGridAgendamento();

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void consultadedataManutencao()
        {
            try
            {
                //consultar veiculos com agendamento de manutenção da data de instação para 1 ano instalado

                string Mes = DateTime.Now.Date.Month.ToString();
                //var Mes = MêsAno.Month.ToString();
                var Ano = DateTime.Now.Year.ToString();
                var ClientesAgendados = Agendamento(Mes, Ano);
                if (ClientesAgendados.Count == 0) { MessageBoxEx.Show("Nenhum Agendamento pra esse mês!"); }
                DGVDADOS.DataSource = null;
                //ECLUIR COLUNAS EXISTENTES
                DGVDADOS.Columns.Clear();
                //adiconar colunas

                DGVDADOS.DataSource = ClientesAgendados;
                Add_ColunaMenuTarefasManutecao();
                MontarGridmanutencao();
                TratarGridManutencao();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }
        private void MontarGridAgendamento()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "NOME", "DATA_INSTALACAO", "DATA_AGENDAMENTO", "EMAIL", "TELEFONE", "STATUS", "TIPO", "DESCRICAO", "MenuAgendados" });

            //Define quais os cabeçalhos respectivos das colunas 
            //objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cód", "NOME", "DATA INSTALACAO", "DATA AGENDAMENTO", "VEICULO", "PLACA", "EMAIL", "TELEFONE", "STATUS", "TIPO", "TarefasAgendados" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);


        }
        private void MontarGridmanutencao()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            //objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID", "NOME", "DATAMANUTECAO", "VEICULO", "PLACA", "EMAILPARTICULAR", "TELEFONE", "STATUSMANUTENCAO", "MenuManutecao" });

            //Define quais os cabeçalhos respectivos das colunas 
            //objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cód", "NOME", "DATA ULTIMA", "VEICULO", "PLACA", "EMAIL", "TELEFONE", "STATUS", "TarefasManutencao" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);

            objBlControleGrid.DefinirVisibilidade(new List<string> { "NOME", "DATAMANUTECAO", "EMAILPARTICULAR", "TELEFONE", "STATUSMANUTENCAO", "MenuManutecao" });

        }
        private List<cliente> Agendamento(string Mes, string ano)
        {
            var retorno = new List<cliente>();
            try
            {
                DlConexao conexao = new DlConexao();
                conexao.limparParametros();
                //conexao.AdicionarParametros("@MesAno", Mes);
                //SELECT * FROM `cliente` WHERE MONTH(DATAMANUTECAO) = '2020-01-02' AND YEAR(DATAMANUTECAO) = '2020'
                var datatable = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM cliente WHERE MONTH(DATAMANUTECAO) = '" + Mes + "' AND YEAR(DATAMANUTECAO) = '"+ ano + "'");
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    var dados = Genericos.Popular<cliente>(datatable, i);
                    retorno.Add(dados);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
            return retorno;
        }
        public void Update(cliente cliente)
        {
            DlConexao Conexao = new DlConexao();
            try
            {
                Conexao.limparParametros();
                if (cliente.ID > 0)
                {
                    //Conexao.AdicionarParametros("@ID", cliente.ID);
                    //Conexao.AdicionarParametros("@STATUSMANUTENCAO", cliente.STATUSMANUTENCAO);
                    //Conexao.ExecutarManipulacao(CommandType.Text, "UPDATE cliente SET STATUSMANUTENCAO=@STATUSMANUTENCAO WHERE ID = @ID");
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
        public void Update2(cliente cliente)
        {
            DlConexao Conexao = new DlConexao();
            try
            {
                Conexao.limparParametros();
                if (!string.IsNullOrEmpty(cliente.NOME))
                {
                    //Conexao.AdicionarParametros("@NOME", cliente.NOME.Trim());

                    //Conexao.AdicionarParametros("@STATUSMANUTENCAO", cliente.STATUSMANUTENCAO);
                    //Conexao.AdicionarParametros("@DATAMANUTECAO", cliente.DATAMANUTECAO);

                    //Conexao.ExecutarManipulacao(CommandType.Text, "UPDATE cliente SET STATUSMANUTENCAO=@STATUSMANUTENCAO, DATAMANUTECAO = @DATAMANUTECAO WHERE NOME = @NOME");
                }
                
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
        private void Add_ColunaMenuTarefasAgendados()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOS.Columns.Add(imageColumn);
            imageColumn.HeaderText = "MenuAgendados";
            imageColumn.Name = "MenuAgendados";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.Width = 60;
        }
        private void Add_ColunaMenuTarefasManutecao()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOS.Columns.Add(imageColumn);
            imageColumn.HeaderText = "MenuManutecao";
            imageColumn.Name = "MenuManutecao";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.Width = 60;
        }

        private void DGVDADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DGVDADOS.Columns[e.ColumnIndex].HeaderText == "MenuAgendados")//QTD
                    {

                        TarefasAgendados.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //if (e.RowIndex >= 0)
                        //{

                        //    Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        //var codigoSelecionado = Convert.ToInt32(DGVDADOS.Rows[e.RowIndex].Cells[0].Value);
                        //    //string Nome = Convert.ToString(dgvItens.SelectedRows[0].Cells["Nome"].Value);

                        //}

                    }
                    if (DGVDADOS.Columns[e.ColumnIndex].HeaderText == "MenuManutecao")//QTD
                    {

                        TarefasManutencao.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cONCLUIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //faz um update no cliente
                //if (Convert.ToString(DGVDADOS.SelectedRows[0].Cells["TIPO"].Value) == "MANUTENÇÃO") { Update2(new cliente() { NOME = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value), STATUSMANUTENCAO = "CONCLUIDO", DATAMANUTECAO = DateTime.Now }); }


                //faz um update na tabela de agendamento
                new AgendamentoDAL().AlterarAgedamento(new Agendamento() { ID = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value), STATUS = "CONCLUIDO" });
                //consultadedata();
                MessageBoxEx.Show("Concluido com sucesso!");
                copnsultadadosAgendados();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void TratarGridManutencao()
        {
            foreach (DataGridViewRow row in DGVDADOS.Rows)
            {
                if (Convert.ToString(row.Cells["STATUSMANUTENCAO"].Value) != "AGENDADO")
                {
                    // Se for negativo, fica vermelho
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    // Se for negativo, fica vermelho
                    row.DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
                }
                if (Convert.ToString(row.Cells["STATUSMANUTENCAO"].Value) == "CONCLUIDO")
                {
                    // Se for negativo, fica vermelho
                    row.DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
                }
            }
        }
        private void DGVDADOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.Value != null)
            //{
            //    //if (e.Value != null && e.Value.Equals("AGENDADO"))
            //    //{

            //    //    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;

            //    //}
            //    if (e.Value != null && e.Value.Equals("AGENDADO"))
            //    {

            //        DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;

            //    }
            //    else
            //    {

            //        DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSeaGreen;

            //    }
            //    //else if (e.Value != null && e.Value.Equals("AGENDADO"))
            //    //{

            //    //    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);

            //    //}
            //    //else if (e.Value != null && Convert.ToString(e.Value) != "AGENDADO")
            //    //{

            //    //    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Crimson;

            //    //}
            //}

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNovoAgendamento frm = new FrmNovoAgendamento();
            frm.ShowDialog();

            //atualiza a grid com novos Agendamentos
            copnsultadadosAgendados();
        }

        private void radioINSTALCAO_CheckedChanged(object sender, EventArgs e)
        {
            Radio();

        }
        private void Radio()
        {
            if (radioINSTALCAO.Checked == true)
            {
                //Dados da tabela de agendamento
                copnsultadadosAgendados();
            }
            else
            {
                //Dados de consulta prevista para manutenção de veiculos
                consultadedataManutencao();
            }
        }
        private void criarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mensagemWatsappToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNovoAgendamento frm = new FrmNovoAgendamento();
                if (DGVDADOS.SelectedRows.Count > 0)
                {
                    var DadosAgendados = new AgendamentoDAL().Agendamento(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value));
                    if (DadosAgendados.ID > 0)
                    {
                        frm.iDTextBox.Text = DadosAgendados.ID.ToString();
                        frm.nOMETextBox.Text = DadosAgendados.NOME.ToString();
                        if (DadosAgendados.EMAIL != null)
                            frm.EMAILtextBox.Text = DadosAgendados.EMAIL.ToString();
                        if (DadosAgendados.TELEFONE != null)
                            frm.TELEFONEtextBox.Text = DadosAgendados.TELEFONE.ToString();

                        frm.BtnSalvaradm_modulo.Text = "ALTERAR";
                        frm.ShowDialog();

                        //atualiza a grid
                        //Dados da tabela de agendamento
                        copnsultadadosAgendados();
                        radioINSTALCAO.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }


        }

        private void toolStripMenuItemGerarAgendamento_Click(object sender, EventArgs e)
        {
            FrmNovoAgendamento frm = new FrmNovoAgendamento();
            if (DGVDADOS.SelectedRows.Count > 0)
            {

                frm.nOMETextBox.Text = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);

                frm.EMAILtextBox.Text = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["EMAILPARTICULAR"].Value);

                frm.TELEFONEtextBox.Text = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["TELEFONE"].Value);


                frm.ShowDialog();
                //mudo o status dele na tabela cliente pra agendado
                DialogResult Confirmacao = MessageBoxEx.Show("Confirme este agendamento sim ou não?", MessageIcon.Question, MessageButton.YesNo);
                if (Confirmacao == DialogResult.Yes)
                {
                    //string sTATUSCliente = "AGENDADO";
                    //int Codigo = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value);
                    ////faz um update no cliente
                    //Update(new cliente() { ID = Codigo, STATUSMANUTENCAO = sTATUSCliente });
                }

                //atualiza a grid
                //Dados da tabela de agendamento
                copnsultadadosAgendados();
                radioINSTALCAO.Checked = true;
            }

        }

        private void radioMANUTENCAO_CheckedChanged(object sender, EventArgs e)
        {
            Radio();
        }

        private void cANCELADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //cliente
                //faz um update no cliente
                //if (Convert.ToString(DGVDADOS.SelectedRows[0].Cells["TIPO"].Value) == "MANUTENÇÃO") { Update2(new cliente() { NOME = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value), STATUSMANUTENCAO = "PEDENTE", DATAMANUTECAO = DateTime.Now }); }


                //faz um eclui na tabela de agendamento
                new AgendamentoDAL().eXCLUIR(Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID"].Value));
                //consultadedata();
                MessageBoxEx.Show("Cancelado com sucesso!");
                copnsultadadosAgendados();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
        private void Parametros()
        {
            try
            {
                ParametrosDados = new Parametros();
                ParametrosDados = new ParametrosDal().Todos(new Parametros());
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
        private void instalaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MensagemWatsapp("Instalação");
        }
        private void MensagemWatsapp(string AgendaManutencaoWatsapp)
        {
            try
            {
                if (DGVDADOS.SelectedRows[0].Cells["TELEFONE"].Value != null)
                {
                    string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
                    string Telefone = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["TELEFONE"].Value);
                    DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_AGENDAMENTO"].Value);
                    CultureInfo culture = new CultureInfo("pt-BR");
                    DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                    int dia = data.Day;
                    int ano = data.Year;
                    string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                    string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                    string dataDesmenbrada = dia + " / " + mes + " / " + ano;

                    Link.Text = @"https://api.whatsapp.com/send?phone=55" + Telefone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "&text=Ola(" + NomeCliente + " )" +
                              " " + AgendaManutencaoWatsapp + " prevista para o (Mês de " + mes + ") . Data ( " + dataDesmenbrada + "), está aberto." +
                              " Aguardamos sua confirmação." +
                            " Atenciosamente," +
                            " Setor Administrativo";
                    //enviar watsap
                    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(Link.Text);
                    pStart.Start();
                }
                else
                    MessageBoxEx.Show("Nenhum Telefone para o envio!");

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MensagemWatsapp("Manutenção");
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensagemEMAIL("Manutenção");


        }
        public async void MensagemEMAIL(string AgendaManutencaoEMAIL)
        {
            FrmLoading loading = new FrmLoading();
            try
            {

                if ((!string.IsNullOrEmpty(ParametrosDados.EMAIL)) && (!string.IsNullOrEmpty(ParametrosDados.SENHA)))
                {
                    //enviar email
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        smtp.Host = ParametrosDados.smtp.ToString().Trim();
                        smtp.Port = Convert.ToInt32(ParametrosDados.Porta.ToString().Trim());
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;

                        smtp.Credentials = new System.Net.NetworkCredential(ParametrosDados.EMAIL.ToString().Trim(), ParametrosDados.SENHA.ToString().Trim());

                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(ParametrosDados.EMAIL.ToString().Trim());

                            //if (!string.IsNullOrWhiteSpace(textBoxPara.Text)) //para o email
                            //{

                            string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
                            string Email = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["EMAIL"].Value);


                            mail.To.Add(new System.Net.Mail.MailAddress(Email.ToString().Trim()));
                            //"pegasusrastreadores@gmail.com"));
                            //}
                            //else
                            //{
                            //MessageBox.Show("Campo 'para' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // return;
                            //}
                            //if (!string.IsNullOrWhiteSpace(textBoxCC.Text))
                            //mail.CC.Add(new System.Net.Mail.MailAddress(textBoxCC.Text));
                            //if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                            //mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));

                            //desmenbrando a data
                            DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_AGENDAMENTO"].Value);
                            CultureInfo culture = new CultureInfo("pt-BR");
                            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                            int dia = data.Day;
                            int ano = data.Year;
                            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                            string dataDesmenbrada = dia + " / " + mes + " / " + ano;

                            var contentID = "Image";
                            var inlineLogo = new Attachment(Application.StartupPath + "/Pegasus.jpg");
                            inlineLogo.ContentId = contentID;
                            inlineLogo.ContentDisposition.Inline = true;
                            inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                            mail.Attachments.Add(inlineLogo);

                            mail.Subject = "Confirmação de agendamento";// asunto
                            mail.Body += "<h1>Agendamento</h1><br />" +
                             "Ola(" + NomeCliente + " )<br />" +
                                  " " + AgendaManutencaoEMAIL + " prevista para o (Mês de " + mes + ") . Data ( " + dataDesmenbrada + "), está aberto." +
                                  " Aguardamos sua confirmação." +
                                " Atenciosamente," +
                                " Setor Administrativo";

                            mail.IsBodyHtml = true;
                            //foreach (string file in listBoxAttachments.Items)
                            //{
                            //    mail.Attachments.Add(new System.Net.Mail.Attachment(file));
                            //}
                            loading.Show();
                            await smtp.SendMailAsync(mail);
                            loading.Close();
                            MessageBoxEx.Show("E-mail Enviando com Sucesso. ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                loading.Close();
                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void instalaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensagemEMAIL("Instalação");
        }

        private void whatsappWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
                string Telefone = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["TELEFONE"].Value);
                DateTime data = DateTime.Now;
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                //int dia = data.Day;
                //int ano = data.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                //string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                //string dataDesmenbrada = dia + " / " + mes + " / " + ano;

                Link.Text = @"https://api.whatsapp.com/send?phone=55" + Telefone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "&text=Ola(" + NomeCliente + " )" +
                          " Estamos com previsao para o (Mês de " + mes + "), preciso de sua confirmação para o agendamento de manutenção do equipamento instalado em seu veiculo." +
                          " Aguardamos sua confirmação." +
                        " Atenciosamente," +
                        " Setor Administrativo";
                //enviar watsap
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(Link.Text);
                pStart.Start();


            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void TarefasAgendados_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            try
            {
                var DadosBanco = new AgendamentoDAL().ListaAgendamento(dataPesquisar.Value);
                DGVDADOS.DataSource = null;
                //ECLUIR COLUNAS EXISTENTES
                DGVDADOS.Columns.Clear();
                //adiconar colunas

                DGVDADOS.DataSource = DadosBanco;
                Add_ColunaMenuTarefasAgendados();
                MontarGridAgendamento();

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
    }
}
