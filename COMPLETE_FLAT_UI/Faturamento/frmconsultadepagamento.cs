using Dados;
using Dados.CLIENTE;
using Dados.contrato;
using Dados.Contrato_imprestimo;
using Dados.PARAMETROS;
using Model;
using SoftwareGerenciador.adm_modulo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace SoftwareGerenciador.Faturamento
{
    public partial class frmconsultadepagamento : Form
    {
        public frmconsultadepagamento()
        {
            InitializeComponent();
        }
        public Parametros ParametrosDados;
        private void frmconsultadepagamento_Load(object sender, EventArgs e)
        {
            try
            {

                //Clientes no combo
                var listaprodutos = new CLIENTEDAL().CONSULTATODOS();
                listaprodutos.Insert(0, new cliente() { NOME = "SELECIONE" });
                ComboNomeCliente.DisplayMember = "NOME";
                ComboNomeCliente.ValueMember = "ID";
                ComboNomeCliente.DataSource = listaprodutos;

                ComboNomeClienteiMPRESTIMO.DisplayMember = "NOME";
                ComboNomeClienteiMPRESTIMO.ValueMember = "ID";
                ComboNomeClienteiMPRESTIMO.DataSource = listaprodutos;
                //LocalizarPeladata();
                LocalizarClienteDePlanosParaTela();

                //localizar parcelas de imprestimo
                LocalizarClienteDeImprestimo();
                Parametros();

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message);
            }


        }

        private void Parametros()
        {
            try
            {
                ParametrosDados = new Parametros();
                ParametrosDados = new ParametrosDal().Todos(new Parametros());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MontarGrid()
        {
            DGVDADOS.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOS);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID_CONTRATO", "NOME","PLANO", "DATA_VENCIMENTO", "VALOR", "N_MENSALIDADE", "SITUACAO","VALORFRACIONADO", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Nº", "Nome","Plano",  "Dt.Vencimento", "R$ Mensal", "nº Mensalidade", "Situação","R$ Fracionado", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);


        }
        //private void Add_ColunaMenu()
        //{

        //    var coluna = new DataGridViewComboBoxColumn();
        //    coluna.Name = "SituacaDinamica";
        //    coluna.HeaderText = "Situação Dinâmica";
        //    // Populando a coluna ComboBox com itens de um ArrayList
        //    var lista = new ArrayList();
        //    lista.Add("VISTA");
        //    lista.Add("PRAZO");
        //    lista.Add("ATACADO");
        //    lista.Add("ALTERNATIVO");
        //    lista.Add("CUSTO");
        //    DGVDADOS.Columns.Add(coluna);
        //    coluna.Items.AddRange(lista.ToArray());

        //}
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Add_ColunaMenu()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOS.Columns.Add(imageColumn);
            //DGVDADOSIMPRESTIMO.Columns.Add(imageColumn);
            imageColumn.HeaderText = "Menu";
            imageColumn.Name = "Menu";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.Width = 60;
        }
        private void Add_ColunaMenuImprestimo()
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = Properties.Resources.iconfinder_menu_alt_134216;
            DGVDADOSIMPRESTIMO.Columns.Add(imageColumn);
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
                        Tarefas.Items[0].Visible = true;
                        Tarefas.Items[1].Visible = true;
                        Tarefas.Items[2].Visible = false;
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

        private void FAZERPAGAMENTO_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value.ToString());
                int CodigoContrato = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value);

                frmReceberPagamento pagamento = new frmReceberPagamento();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente.ToString();
                pagamento.CodigoContrato = CodigoContrato;
                pagamento.ShowDialog();

                LocalizarClienteDePlanosParaTela();

                ////atualiza novamente a grid
                ////trazer os cliente e seu ultimo pagamento
                //DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-90));
                //DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                //var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, CodigoContrato);
                //DGVDADOS.DataSource = null;
                ////ECLUIR COLUNAS EXISTENTES
                //DGVDADOS.Columns.Clear();
                ////adiconar colunas

                //DGVDADOS.DataSource = Situacao;
                //Add_ColunaMenu();
                //MontarGrid();

                ////definir R$ em um Campo
                //DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }

        private void DGVDADOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value != null && e.Value.Equals("NAO PAGO") || e.Value.Equals("CANCELADO") || e.Value.Equals("ATRASADO"))
                {

                    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                else if (e.Value != null && e.Value.Equals("PAGO") || e.Value.Equals("GRATIS (BONUS)"))
                {

                    DGVDADOS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;

                }
            }

        }

        private async void criarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
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

                        smtp.Credentials = new System.Net.NetworkCredential(ParametrosDados.EMAIL.ToString(), ParametrosDados.SENHA.ToString().Trim());

                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(ParametrosDados.EMAIL.ToString().Trim());

                            //if (!string.IsNullOrWhiteSpace(textBoxPara.Text)) //para o email
                            //{

                            string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
                            var ClienteTela = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);
                            if (ClienteTela.EMAILPARTICULAR == null) { MessageBoxEx.Show("Cliente não tem E-mail cadastrado!"); return; }
                            mail.To.Add(new System.Net.Mail.MailAddress(ClienteTela.EMAILPARTICULAR.ToString().Trim()));
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
                            DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
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

                            mail.Subject = "Cobrança de Mensalidade";// asunto
                            mail.Body += "<h1>CARTA DE COBRANÇA</h1><br />" +
                                "Ola,( " + DGVDADOS.SelectedRows[0].Cells["NOME"].Value + " )<br /> " +
                                  "Consta em nossos cadastros que o pagamento referente (ao serviço de rastreamento veicular), (Mês de " + mes + ") . Com vencimento na data ( " + dataDesmenbrada + "), ainda está em aberto.<br /> " +
                                "Valor da mensalidade R$: " + DGVDADOS.SelectedRows[0].Cells["VALOR"].Value + ".<br /> <br /><br />" +
                                "Caso tenha alguma dúvida ou oposição ao processo e também haja interesse em realizar a quitação do valor, <br /> " +
                                "   peço que entre em contato por um dos números ficaremos felizes em atendê-lo. <br /> <br /> " +
                                "Atenciosamente,<br /> " +
                                "Setor Administrativo";// texto

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

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //consulta o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(ComboNomeCliente.Text.Trim());
                //localicar um contrato que estar ativo desse cliente
                var contratoAtivo = new ContratoDAL().ConsultacontratoAtivo(cliente.ID, "ATIVO");
                if (contratoAtivo.ID > 0)
                {
                    //trazer os cliente e seu ultimo pagamento
                    DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(+120));
                    DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                    var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, contratoAtivo.ID);

                    if (Situacao.Rows.Count > 0)
                    {
                        DGVDADOS.DataSource = null;
                        //ECLUIR COLUNAS EXISTENTES
                        DGVDADOS.Columns.Clear();
                        //adiconar colunas

                        DGVDADOS.DataSource = Situacao;
                        Add_ColunaMenu();
                        MontarGrid();

                        //definir R$ em um Campo
                        DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
                        DGVDADOS.Columns[7].DefaultCellStyle.Format = "c";
                    }
                    else
                        MessageBoxEx.Show("Não tem parcelas cadatrada para esse contrato!");
                }
                else
                    MessageBoxEx.Show("Nenhum contrato (ATIVO) pra esse cliente");

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void ComboNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboNomeCliente.SelectedIndex == 0)
            {
                LocalizarClienteDePlanosParaTela();
            }
        }
        private void LocalizarClienteDeImprestimo()
        {
            //trazer os cliente e seu ultimo pagamento
            DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
            DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
            var Situacao = new ContratoImprestimoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
            DGVDADOSIMPRESTIMO.DataSource = null;
            //ECLUIR COLUNAS EXISTENTES
            DGVDADOSIMPRESTIMO.Columns.Clear();
            //adiconar colunas

            DGVDADOSIMPRESTIMO.DataSource = Situacao;
            Add_ColunaMenuImprestimo();
            MontarGridImprestimo();

            //definir R$ em um Campo
            DGVDADOSIMPRESTIMO.Columns[5].DefaultCellStyle.Format = "c";
            DGVDADOSIMPRESTIMO.Columns[6].DefaultCellStyle.Format = "c";
        }
        private void LocalizarClienteDePlanosParaTela()
        {
            //trazer os cliente e seu ultimo pagamento
            DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-120));
            DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date);//Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
            var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
            DGVDADOS.DataSource = null;
            //ECLUIR COLUNAS EXISTENTES
            DGVDADOS.Columns.Clear();
            //adiconar colunas

            DGVDADOS.DataSource = Situacao;
            Add_ColunaMenu();
            MontarGrid();

            //definir R$ em um Campo
            DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
            DGVDADOS.Columns[7].DefaultCellStyle.Format = "c";
        }
        private void LocalizarPeladata()
        {
            try
            {
                var Situacao = new ContratoDAL().ConsultaData(dataPesquisar.Value);
                DGVDADOS.DataSource = null;
                //ECLUIR COLUNAS EXISTENTES
                DGVDADOS.Columns.Clear();
                //adiconar colunas

                DGVDADOS.DataSource = Situacao;
                Add_ColunaMenu();
                MontarGrid();

                //definir R$ em um Campo
                DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message + ex.StackTrace);
            }
            
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            try
            {
                LocalizarPeladata();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }

        }

        private void mensagemWatsappToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
            var ClienteTela = new CLIENTEDAL().CONSULTATODOSPELONOME(NomeCliente);
            if (ClienteTela.TELEFONE1 == null) { MessageBoxEx.Show("Cliente não tem telefone cadastrado!"); return; }
            if (!string.IsNullOrEmpty(ClienteTela.TELEFONE1.ToString()))
            {
                DateTime data = Convert.ToDateTime(DGVDADOS.SelectedRows[0].Cells["DATA_VENCIMENTO"].Value);
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                int dia = data.Day;
                int ano = data.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(data.DayOfWeek));
                string dataDesmenbrada = dia + " / " + mes + " / " + ano;

                Link.Text = @"https://api.whatsapp.com/send?phone=55" + ClienteTela.TELEFONE1.ToString().Replace(" ", "").Replace("-", "").Replace("(","").Replace(")", "") + "&text=Ola(" + ClienteTela.NOME.ToString() + " )" +
                          "Consta em nossos cadastros que o pagamento referente (ao aluguel), (Mês de " + mes + ") . Com vencimento na data ( " + dataDesmenbrada + "), ainda está em aberto." +
                        "Valor da mensalidade R$: " + DGVDADOS.SelectedRows[0].Cells["VALOR"].Value + "." +
                        "Caso tenha alguma dúvida ou oposição ao processo e também haja interesse em realizar a quitação do valor," +
                        "   peço que entre em contato por um dos números ficaremos felizes em atendê-lo." +
                        "Atenciosamente " +
                        "Setor Administrativo JB aluguéis";
                //enviar watsap
                System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(Link.Text);
                pStart.Start();
            }


        }

        private void DGVDADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ////-------CON EFECTO SLIDING
            //if (panelMenu.Width == 220)
            //{
            //    //panelMenu.Visible = true;
            //    this.tmContraerMenu.Start();
            //}
            //else if (panelMenu.Width == 5)
            //{
            //    panelMenu.Visible = true;
            //    this.tmExpandirMenu.Start();
            //}
           
        }

        private void BtnFazerPagamentoBotao_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeCliente = Convert.ToString(DGVDADOS.SelectedRows[0].Cells["NOME"].Value);
                int CodigoContrato = Convert.ToInt32(DGVDADOS.SelectedRows[0].Cells["ID_CONTRATO"].Value);

                frmReceberPagamento pagamento = new frmReceberPagamento();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente.ToString();
                pagamento.CodigoContrato = CodigoContrato;
                pagamento.ShowDialog();

                LocalizarClienteDePlanosParaTela();

                ////trazer os cliente e seu ultimo pagamento
                //DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-90));
                //DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                //var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal);
                //DGVDADOS.DataSource = null;
                ////ECLUIR COLUNAS EXISTENTES
                //DGVDADOS.Columns.Clear();
                ////adiconar colunas

                //DGVDADOS.DataSource = Situacao;
                //Add_ColunaMenu();
                //MontarGrid();

                ////definir R$ em um Campo
                //DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            //if (panelMenu.Width <= 5)
            //    this.tmContraerMenu.Stop();
            //else
            //    panelMenu.Width = panelMenu.Width - 5;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            //if (panelMenu.Width >= 220)
            //    this.tmExpandirMenu.Stop();
            //else
            //    panelMenu.Width = panelMenu.Width + 5;
        }

        private void ComboNomeCliente_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //consulta o cliente
            //    var cliente = new CLIENTEDAL().CONSULTATODOSPELONOMEcomlike(ComboNomeCliente.Text.Trim());
            //    //localicar um contrato que estar ativo desse cliente
            //    var contratoAtivo = new ContratoDAL().ConsultacontratoAtivo(cliente.ID, "ATIVO");

            //    //trazer os cliente e seu ultimo pagamento
            //    DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(-90));
            //    DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
            //    var Situacao = new ContratoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, contratoAtivo.ID);

            //    if (Situacao.Rows.Count > 0)
            //    {
            //        DGVDADOS.DataSource = null;
            //        //ECLUIR COLUNAS EXISTENTES
            //        DGVDADOS.Columns.Clear();
            //        //adiconar colunas

            //        DGVDADOS.DataSource = Situacao;
            //        Add_ColunaMenu();
            //        MontarGrid();

            //        //definir R$ em um Campo
            //        DGVDADOS.Columns[4].DefaultCellStyle.Format = "c";
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            //}
        }

        
        private void DGVDADOSIMPRESTIMO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DGVDADOSIMPRESTIMO.Columns[e.ColumnIndex].HeaderText == "Tarefas")//QTD
                    {

                        Tarefas.Show(Cursor.Position.X - 50, Cursor.Position.Y + 13);
                        Tarefas.Items[0].Visible = false;
                        Tarefas.Items[1].Visible = false;
                        Tarefas.Items[2].Visible = true;
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
        private void MontarGridImprestimo()
        {
            DGVDADOSIMPRESTIMO.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            var objBlControleGrid = new FormataGrid(DGVDADOSIMPRESTIMO);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "ID_CONTRATO", "NOME", "PLANO","DATA_VENCIMENTO", "VALOR_PRESTACAO","VALOR_JUROS", "N_MENSALIDADE", "SITUACAO", "Menu" });

            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "CONTRATO Nº", "NOME","PLANO", "DATAVENCIMENTO", "VALOR PRESTACAO","JUROS", "N_MENSALIDADE", "SITUACAO", "Tarefas" });

            //Define quais as larguras respectivas das colunas 
            //objBlControleGrid.DefinirLarguras(new List<int>() { 0.23, }, DGVDADOS.Width - 3); //5 + 15 + 25 + 10 + 15 + 15 + 15 = 100

            //Define quais os alinhamentos respectivos do componentes das colunas 
            //objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda" });

            //Define a altura das linhas respectivas da Grid 
            //objBlControleGrid.DefinirAlturaLinha(30);


        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void fazerPagamentoImprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeCliente = Convert.ToString(DGVDADOSIMPRESTIMO.SelectedRows[0].Cells["NOME"].Value.ToString());
                int CodigoContrato = Convert.ToInt32(DGVDADOSIMPRESTIMO.SelectedRows[0].Cells["ID_CONTRATO"].Value);

                frmReceberPagamentoImprestimo pagamento = new frmReceberPagamentoImprestimo();
                pagamento.LBnomedoadm_modulo.Text = NomeCliente.ToString();
                pagamento.CodigoContrato = CodigoContrato;
                pagamento.ShowDialog();
                
                LocalizarClienteDeImprestimo();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }

        private void DGVDADOSIMPRESTIMO_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value != null && e.Value.Equals("NAO PAGO") || e.Value.Equals("CANCELADO") || e.Value.Equals("ATRASADO"))
                {

                    DGVDADOSIMPRESTIMO.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                else if (e.Value != null && e.Value.Equals("PAGO") || e.Value.Equals("GRATIS (BONUS)"))
                {

                    DGVDADOSIMPRESTIMO.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;

                }
            }
        }

        private void BtnlocalPelaDataImprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                var Situacao = new ContratoImprestimoDAL().ConsultaData(dataPesquisarImprestimo.Value);
                DGVDADOSIMPRESTIMO.DataSource = null;
                //ECLUIR COLUNAS EXISTENTES
                DGVDADOSIMPRESTIMO.Columns.Clear();
                //adiconar colunas

                DGVDADOSIMPRESTIMO.DataSource = Situacao;
                Add_ColunaMenuImprestimo();
                MontarGridImprestimo();

                //definir R$ em um Campo
                DGVDADOSIMPRESTIMO.Columns[4].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro" + ex.Message + ex.StackTrace);
            }
        }

        private void btnLocalizarClienteIMPRESTIMO_Click(object sender, EventArgs e)
        {
            try
            {
                //consulta o cliente
                var cliente = new CLIENTEDAL().CONSULTATODOSPELONOME(ComboNomeCliente.Text.Trim());
                //localicar um contrato que estar ativo desse cliente
                var contratoAtivo = new ContratoImprestimoDAL().ConsultacontratoAtivo(cliente.ID, "ATIVO");

                //trazer os cliente e seu ultimo pagamento
                DateTime dataInicial = Convert.ToDateTime(DateTime.Now.Date.AddDays(+120));
                DateTime datafinal = Convert.ToDateTime(DateTime.Now.Date.AddDays(+30));
                var Situacao = new ContratoImprestimoDAL().ConsultaSituacaoPagamento(dataInicial, datafinal, contratoAtivo.ID);

                if (Situacao.Rows.Count > 0)
                {
                    DGVDADOSIMPRESTIMO.DataSource = null;
                    //ECLUIR COLUNAS EXISTENTES
                    DGVDADOSIMPRESTIMO.Columns.Clear();
                    //adiconar colunas

                    DGVDADOSIMPRESTIMO.DataSource = Situacao;
                    Add_ColunaMenuImprestimo();
                    MontarGridImprestimo();

                    //definir R$ em um Campo
                    DGVDADOSIMPRESTIMO.Columns[4].DefaultCellStyle.Format = "c";
                    DGVDADOSIMPRESTIMO.Columns[5].DefaultCellStyle.Format = "c";
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
    }
}
