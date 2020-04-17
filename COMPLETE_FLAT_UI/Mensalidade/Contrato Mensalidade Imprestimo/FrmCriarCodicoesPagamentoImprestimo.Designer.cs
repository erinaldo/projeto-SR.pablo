namespace SoftwareGerenciador.adm_modulo
{
    partial class FrmCriarCodicoesPagamentoImprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label vALOR_MESLabel;
            System.Windows.Forms.Label dIA_BASELabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LBnomedoadm_modulo = new MetroFramework.Controls.MetroLabel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iD_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.vALOR_MESTextBox = new System.Windows.Forms.TextBox();
            this.dIA_BASETextBox = new System.Windows.Forms.TextBox();
            this.dtDataini = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbNParcela = new MetroFramework.Controls.MetroComboBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.Nparcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorprestacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amortizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDevedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadePagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnNovoContrato = new System.Windows.Forms.Button();
            this.BtnCancelarContrato = new System.Windows.Forms.Button();
            this.BtnCriarParcelas = new System.Windows.Forms.Button();
            this.groupBoxPlanoContratos = new System.Windows.Forms.GroupBox();
            this.TxtPorcentagem = new System.Windows.Forms.TextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metrolanoContratosPrice = new MetroFramework.Controls.MetroTabPage();
            this.BtnSalvaradm_modulo = new System.Windows.Forms.Button();
            this.metrolanoContratoJUROS = new MetroFramework.Controls.MetroTabPage();
            this.BtnSalvarParcelaJuros = new System.Windows.Forms.Button();
            this.txtJurosPlano2 = new System.Windows.Forms.TextBox();
            this.dgvParcelasSAC = new System.Windows.Forms.DataGridView();
            this.Nparcelajuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDevedorjuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimentojuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadePagamentojuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacaojuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvalorImprestadoJUROS = new System.Windows.Forms.TextBox();
            this.txtJurosPORCENTO = new System.Windows.Forms.TextBox();
            this.TxtdiaBaseJuros = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCriaParcelasJUROS = new System.Windows.Forms.Button();
            this.dateTimeDataInicialJURSOS = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            vALOR_MESLabel = new System.Windows.Forms.Label();
            dIA_BASELabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.groupBoxPlanoContratos.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metrolanoContratosPrice.SuspendLayout();
            this.metrolanoContratoJUROS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasSAC)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.Location = new System.Drawing.Point(19, 32);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            iDLabel.Visible = false;
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iD_CLIENTELabel.Location = new System.Drawing.Point(93, 55);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(115, 17);
            iD_CLIENTELabel.TabIndex = 6;
            iD_CLIENTELabel.Text = "MOME CLIENTE:";
            // 
            // vALOR_MESLabel
            // 
            vALOR_MESLabel.AutoSize = true;
            vALOR_MESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            vALOR_MESLabel.Location = new System.Drawing.Point(29, 15);
            vALOR_MESLabel.Name = "vALOR_MESLabel";
            vALOR_MESLabel.Size = new System.Drawing.Size(115, 17);
            vALOR_MESLabel.TabIndex = 8;
            vALOR_MESLabel.Text = "Valor Imprestado";
            // 
            // dIA_BASELabel
            // 
            dIA_BASELabel.AutoSize = true;
            dIA_BASELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dIA_BASELabel.Location = new System.Drawing.Point(413, 15);
            dIA_BASELabel.Name = "dIA_BASELabel";
            dIA_BASELabel.Size = new System.Drawing.Size(74, 17);
            dIA_BASELabel.TabIndex = 10;
            dIA_BASELabel.Text = "DIA BASE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label8.Location = new System.Drawing.Point(613, 15);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(128, 17);
            label8.TabIndex = 35;
            label8.Text = "Taxa Juros ao mês";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(29, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 17);
            label1.TabIndex = 36;
            label1.Text = "Valor Imprestado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(413, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 17);
            label2.TabIndex = 38;
            label2.Text = "DIA BASE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(612, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 17);
            label3.TabIndex = 46;
            label3.Text = "Taxa Juros ao mês";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(413, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 17);
            label4.TabIndex = 49;
            label4.Text = " ( R$ ) Juros";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.btnStatus);
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(988, 38);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatus.BackColor = System.Drawing.Color.IndianRed;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(454, 1);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(374, 37);
            this.btnStatus.TabIndex = 30;
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contrato de Imprestimo";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(950, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LBnomedoadm_modulo
            // 
            this.LBnomedoadm_modulo.AutoSize = true;
            this.LBnomedoadm_modulo.Location = new System.Drawing.Point(214, 55);
            this.LBnomedoadm_modulo.Name = "LBnomedoadm_modulo";
            this.LBnomedoadm_modulo.Size = new System.Drawing.Size(107, 19);
            this.LBnomedoadm_modulo.TabIndex = 4;
            this.LBnomedoadm_modulo.Text = "Nome do cliente";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(63, 24);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(84, 23);
            this.iDTextBox.TabIndex = 5;
            this.iDTextBox.Visible = false;
            // 
            // iD_CLIENTETextBox
            // 
            this.iD_CLIENTETextBox.Enabled = false;
            this.iD_CLIENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iD_CLIENTETextBox.Location = new System.Drawing.Point(153, 24);
            this.iD_CLIENTETextBox.Name = "iD_CLIENTETextBox";
            this.iD_CLIENTETextBox.Size = new System.Drawing.Size(55, 23);
            this.iD_CLIENTETextBox.TabIndex = 7;
            this.iD_CLIENTETextBox.Visible = false;
            this.iD_CLIENTETextBox.TextChanged += new System.EventHandler(this.iD_CLIENTETextBox_TextChanged);
            // 
            // vALOR_MESTextBox
            // 
            this.vALOR_MESTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.vALOR_MESTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.vALOR_MESTextBox.Location = new System.Drawing.Point(32, 35);
            this.vALOR_MESTextBox.Name = "vALOR_MESTextBox";
            this.vALOR_MESTextBox.Size = new System.Drawing.Size(375, 29);
            this.vALOR_MESTextBox.TabIndex = 9;
            this.vALOR_MESTextBox.Text = "0,00";
            this.vALOR_MESTextBox.TextChanged += new System.EventHandler(this.vALOR_MESTextBox_TextChanged);
            // 
            // dIA_BASETextBox
            // 
            this.dIA_BASETextBox.Enabled = false;
            this.dIA_BASETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dIA_BASETextBox.Location = new System.Drawing.Point(416, 35);
            this.dIA_BASETextBox.Name = "dIA_BASETextBox";
            this.dIA_BASETextBox.Size = new System.Drawing.Size(192, 29);
            this.dIA_BASETextBox.TabIndex = 11;
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(32, 89);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(375, 29);
            this.dtDataini.TabIndex = 16;
            this.dtDataini.ValueChanged += new System.EventHandler(this.dtDataini_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(179, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Data de Inicio de Pagamento";
            // 
            // cbNParcela
            // 
            this.cbNParcela.FormattingEnabled = true;
            this.cbNParcela.ItemHeight = 23;
            this.cbNParcela.Items.AddRange(new object[] {
            "1 X",
            "2 X",
            "3 X",
            "4 X",
            "5 X",
            "6 X",
            "7 X",
            "8 X",
            "9 X",
            "10 X",
            "11 X",
            "12 X",
            "13 X",
            "14 X",
            "15 X",
            "16 X",
            "17 X",
            "18 X",
            "19 X",
            "20 X",
            "21 X",
            "22 X",
            "23 X",
            "24 X",
            "25 X",
            "26 X",
            "27 X",
            "28 X",
            "29 X",
            "30 X",
            "31 X",
            "32 X",
            "33 X",
            "34 X",
            "35 X",
            "36 X",
            "37 X",
            "38 X",
            "39 X",
            "40 X",
            "41 X",
            "42 X",
            "43 X",
            "44 X",
            "45 X",
            "46 X",
            "47 X",
            "48 X",
            "49 X",
            "50 X",
            "51 X",
            "52 X",
            "53 X",
            "54 X",
            "55 X",
            "56 X",
            "57 X",
            "58 X",
            "59 X",
            "60 X",
            "61 X",
            "62 X",
            "63 X",
            "64 X",
            "65 X",
            "66 X",
            "67 X",
            "68 X",
            "69 X",
            "70 X",
            "71 X",
            "72 X",
            "73 X",
            "74 X",
            "75 X",
            "76 X",
            "77 X",
            "78 X",
            "79 X",
            "80 X",
            "81 X",
            "82 X",
            "83 X",
            "84 X",
            "85 X",
            "86 X",
            "87 X",
            "88 X",
            "89 X",
            "90 X",
            "91 X",
            "92 X",
            "93 X",
            "94 X",
            "95 X",
            "96 X",
            "97 X",
            "98 X",
            "99 X"});
            this.cbNParcela.Location = new System.Drawing.Point(416, 89);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(192, 29);
            this.cbNParcela.TabIndex = 18;
            this.cbNParcela.SelectedIndexChanged += new System.EventHandler(this.cbNParcela_SelectedIndexChanged);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeColumns = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParcelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nparcela,
            this.valorprestacao,
            this.Juros,
            this.Amortizacao,
            this.SaldoDevedor,
            this.datavencimento,
            this.DatadePagamento,
            this.Situacao});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dgvParcelas.Location = new System.Drawing.Point(0, 149);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(980, 289);
            this.dgvParcelas.TabIndex = 25;
            this.dgvParcelas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellDoubleClick);
            // 
            // Nparcela
            // 
            this.Nparcela.Frozen = true;
            this.Nparcela.HeaderText = "Nº da Parcela";
            this.Nparcela.Name = "Nparcela";
            // 
            // valorprestacao
            // 
            this.valorprestacao.Frozen = true;
            this.valorprestacao.HeaderText = "Valor da Prestação";
            this.valorprestacao.Name = "valorprestacao";
            this.valorprestacao.Width = 130;
            // 
            // Juros
            // 
            this.Juros.Frozen = true;
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            // 
            // Amortizacao
            // 
            this.Amortizacao.Frozen = true;
            this.Amortizacao.HeaderText = "Amortizacao";
            this.Amortizacao.Name = "Amortizacao";
            // 
            // SaldoDevedor
            // 
            this.SaldoDevedor.Frozen = true;
            this.SaldoDevedor.HeaderText = "Saldo Devedor";
            this.SaldoDevedor.Name = "SaldoDevedor";
            // 
            // datavencimento
            // 
            this.datavencimento.Frozen = true;
            this.datavencimento.HeaderText = "Data do vencimento";
            this.datavencimento.Name = "datavencimento";
            this.datavencimento.Width = 200;
            // 
            // DatadePagamento
            // 
            this.DatadePagamento.Frozen = true;
            this.DatadePagamento.HeaderText = "Data de Pagamento";
            this.DatadePagamento.Name = "DatadePagamento";
            this.DatadePagamento.Width = 150;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(416, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Nº de Parcelas";
            // 
            // BtnNovoContrato
            // 
            this.BtnNovoContrato.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnNovoContrato.FlatAppearance.BorderSize = 0;
            this.BtnNovoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnNovoContrato.ForeColor = System.Drawing.Color.White;
            this.BtnNovoContrato.Location = new System.Drawing.Point(292, 14);
            this.BtnNovoContrato.Name = "BtnNovoContrato";
            this.BtnNovoContrato.Size = new System.Drawing.Size(155, 37);
            this.BtnNovoContrato.TabIndex = 27;
            this.BtnNovoContrato.Text = "Novo Contrato";
            this.BtnNovoContrato.UseVisualStyleBackColor = false;
            this.BtnNovoContrato.Click += new System.EventHandler(this.BtnNovoContrato_Click);
            // 
            // BtnCancelarContrato
            // 
            this.BtnCancelarContrato.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCancelarContrato.FlatAppearance.BorderSize = 0;
            this.BtnCancelarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCancelarContrato.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarContrato.Location = new System.Drawing.Point(453, 14);
            this.BtnCancelarContrato.Name = "BtnCancelarContrato";
            this.BtnCancelarContrato.Size = new System.Drawing.Size(181, 37);
            this.BtnCancelarContrato.TabIndex = 28;
            this.BtnCancelarContrato.Text = "Cancelar Contrato";
            this.BtnCancelarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarContrato.UseVisualStyleBackColor = false;
            this.BtnCancelarContrato.Click += new System.EventHandler(this.BtnCancelarContrato_Click);
            // 
            // BtnCriarParcelas
            // 
            this.BtnCriarParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCriarParcelas.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCriarParcelas.FlatAppearance.BorderSize = 0;
            this.BtnCriarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCriarParcelas.ForeColor = System.Drawing.Color.White;
            this.BtnCriarParcelas.Location = new System.Drawing.Point(812, 27);
            this.BtnCriarParcelas.Name = "BtnCriarParcelas";
            this.BtnCriarParcelas.Size = new System.Drawing.Size(157, 37);
            this.BtnCriarParcelas.TabIndex = 29;
            this.BtnCriarParcelas.Text = "Criar Parcelas";
            this.BtnCriarParcelas.UseVisualStyleBackColor = false;
            this.BtnCriarParcelas.Click += new System.EventHandler(this.BtnCriarParcelas_Click);
            // 
            // groupBoxPlanoContratos
            // 
            this.groupBoxPlanoContratos.BackColor = System.Drawing.Color.White;
            this.groupBoxPlanoContratos.Controls.Add(this.BtnNovoContrato);
            this.groupBoxPlanoContratos.Controls.Add(this.iD_CLIENTETextBox);
            this.groupBoxPlanoContratos.Controls.Add(iD_CLIENTELabel);
            this.groupBoxPlanoContratos.Controls.Add(this.iDTextBox);
            this.groupBoxPlanoContratos.Controls.Add(iDLabel);
            this.groupBoxPlanoContratos.Controls.Add(this.BtnCancelarContrato);
            this.groupBoxPlanoContratos.Controls.Add(this.LBnomedoadm_modulo);
            this.groupBoxPlanoContratos.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPlanoContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlanoContratos.Location = new System.Drawing.Point(0, 38);
            this.groupBoxPlanoContratos.Name = "groupBoxPlanoContratos";
            this.groupBoxPlanoContratos.Size = new System.Drawing.Size(988, 85);
            this.groupBoxPlanoContratos.TabIndex = 32;
            this.groupBoxPlanoContratos.TabStop = false;
            this.groupBoxPlanoContratos.Text = "Planos do contrato";
            // 
            // TxtPorcentagem
            // 
            this.TxtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtPorcentagem.Location = new System.Drawing.Point(614, 35);
            this.TxtPorcentagem.Name = "TxtPorcentagem";
            this.TxtPorcentagem.Size = new System.Drawing.Size(192, 29);
            this.TxtPorcentagem.TabIndex = 34;
            this.TxtPorcentagem.Text = "0,00";
            this.TxtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPorcentagem.TextChanged += new System.EventHandler(this.TxtPorcentagem_TextChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metrolanoContratosPrice);
            this.metroTabControl1.Controls.Add(this.metrolanoContratoJUROS);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 123);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(988, 477);
            this.metroTabControl1.TabIndex = 98;
            // 
            // metrolanoContratosPrice
            // 
            this.metrolanoContratosPrice.Controls.Add(this.dgvParcelas);
            this.metrolanoContratosPrice.Controls.Add(vALOR_MESLabel);
            this.metrolanoContratosPrice.Controls.Add(dIA_BASELabel);
            this.metrolanoContratosPrice.Controls.Add(this.BtnSalvaradm_modulo);
            this.metrolanoContratosPrice.Controls.Add(label8);
            this.metrolanoContratosPrice.Controls.Add(this.vALOR_MESTextBox);
            this.metrolanoContratosPrice.Controls.Add(this.TxtPorcentagem);
            this.metrolanoContratosPrice.Controls.Add(this.dIA_BASETextBox);
            this.metrolanoContratosPrice.Controls.Add(this.cbNParcela);
            this.metrolanoContratosPrice.Controls.Add(this.metroLabel2);
            this.metrolanoContratosPrice.Controls.Add(this.metroLabel3);
            this.metrolanoContratosPrice.Controls.Add(this.BtnCriarParcelas);
            this.metrolanoContratosPrice.Controls.Add(this.dtDataini);
            this.metrolanoContratosPrice.HorizontalScrollbarBarColor = true;
            this.metrolanoContratosPrice.Location = new System.Drawing.Point(4, 35);
            this.metrolanoContratosPrice.Name = "metrolanoContratosPrice";
            this.metrolanoContratosPrice.Size = new System.Drawing.Size(980, 438);
            this.metrolanoContratosPrice.TabIndex = 0;
            this.metrolanoContratosPrice.Text = "Planos 1 (Tabela Price (Sistema Francês de Amortizações)";
            this.metrolanoContratosPrice.VerticalScrollbarBarColor = true;
            // 
            // BtnSalvaradm_modulo
            // 
            this.BtnSalvaradm_modulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvaradm_modulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvaradm_modulo.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnSalvaradm_modulo.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_modulo.Location = new System.Drawing.Point(812, 81);
            this.BtnSalvaradm_modulo.Name = "BtnSalvaradm_modulo";
            this.BtnSalvaradm_modulo.Size = new System.Drawing.Size(157, 37);
            this.BtnSalvaradm_modulo.TabIndex = 12;
            this.BtnSalvaradm_modulo.Text = "Salvar Contrato";
            this.BtnSalvaradm_modulo.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_modulo.Click += new System.EventHandler(this.BtnSalvaradm_modulo_Click);
            // 
            // metrolanoContratoJUROS
            // 
            this.metrolanoContratoJUROS.Controls.Add(this.BtnSalvarParcelaJuros);
            this.metrolanoContratoJUROS.Controls.Add(label4);
            this.metrolanoContratoJUROS.Controls.Add(this.txtJurosPlano2);
            this.metrolanoContratoJUROS.Controls.Add(this.dgvParcelasSAC);
            this.metrolanoContratoJUROS.Controls.Add(label1);
            this.metrolanoContratoJUROS.Controls.Add(label2);
            this.metrolanoContratoJUROS.Controls.Add(label3);
            this.metrolanoContratoJUROS.Controls.Add(this.txtvalorImprestadoJUROS);
            this.metrolanoContratoJUROS.Controls.Add(this.txtJurosPORCENTO);
            this.metrolanoContratoJUROS.Controls.Add(this.TxtdiaBaseJuros);
            this.metrolanoContratoJUROS.Controls.Add(this.metroLabel1);
            this.metrolanoContratoJUROS.Controls.Add(this.btnCriaParcelasJUROS);
            this.metrolanoContratoJUROS.Controls.Add(this.dateTimeDataInicialJURSOS);
            this.metrolanoContratoJUROS.HorizontalScrollbarBarColor = true;
            this.metrolanoContratoJUROS.Location = new System.Drawing.Point(4, 35);
            this.metrolanoContratoJUROS.Name = "metrolanoContratoJUROS";
            this.metrolanoContratoJUROS.Size = new System.Drawing.Size(980, 438);
            this.metrolanoContratoJUROS.TabIndex = 1;
            this.metrolanoContratoJUROS.Text = "Plano 2 ( Pagamento só de juros )";
            this.metrolanoContratoJUROS.VerticalScrollbarBarColor = true;
            // 
            // BtnSalvarParcelaJuros
            // 
            this.BtnSalvarParcelaJuros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvarParcelaJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvarParcelaJuros.FlatAppearance.BorderSize = 0;
            this.BtnSalvarParcelaJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarParcelaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnSalvarParcelaJuros.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarParcelaJuros.Location = new System.Drawing.Point(812, 80);
            this.BtnSalvarParcelaJuros.Name = "BtnSalvarParcelaJuros";
            this.BtnSalvarParcelaJuros.Size = new System.Drawing.Size(0, 37);
            this.BtnSalvarParcelaJuros.TabIndex = 50;
            this.BtnSalvarParcelaJuros.Text = "Salvar Contrato";
            this.BtnSalvarParcelaJuros.UseVisualStyleBackColor = false;
            this.BtnSalvarParcelaJuros.Click += new System.EventHandler(this.BtnSalvarParcelaJuros_Click);
            // 
            // txtJurosPlano2
            // 
            this.txtJurosPlano2.Enabled = false;
            this.txtJurosPlano2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtJurosPlano2.Location = new System.Drawing.Point(416, 90);
            this.txtJurosPlano2.Name = "txtJurosPlano2";
            this.txtJurosPlano2.Size = new System.Drawing.Size(192, 29);
            this.txtJurosPlano2.TabIndex = 48;
            this.txtJurosPlano2.Text = "0,00";
            this.txtJurosPlano2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvParcelasSAC
            // 
            this.dgvParcelasSAC.AllowUserToAddRows = false;
            this.dgvParcelasSAC.AllowUserToDeleteRows = false;
            this.dgvParcelasSAC.AllowUserToResizeColumns = false;
            this.dgvParcelasSAC.AllowUserToResizeRows = false;
            this.dgvParcelasSAC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dgvParcelasSAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParcelasSAC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParcelasSAC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParcelasSAC.ColumnHeadersHeight = 30;
            this.dgvParcelasSAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nparcelajuros,
            this.dataGridViewTextBoxColumn2,
            this.jurosJuros,
            this.dataGridViewTextBoxColumn4,
            this.SaldoDevedorjuros,
            this.datavencimentojuros,
            this.DatadePagamentojuros,
            this.Situacaojuros});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelasSAC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParcelasSAC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvParcelasSAC.EnableHeadersVisualStyles = false;
            this.dgvParcelasSAC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dgvParcelasSAC.Location = new System.Drawing.Point(0, 149);
            this.dgvParcelasSAC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParcelasSAC.Name = "dgvParcelasSAC";
            this.dgvParcelasSAC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelasSAC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParcelasSAC.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvParcelasSAC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParcelasSAC.RowTemplate.Height = 24;
            this.dgvParcelasSAC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelasSAC.Size = new System.Drawing.Size(980, 289);
            this.dgvParcelasSAC.TabIndex = 47;
            this.dgvParcelasSAC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelasSAC_CellContentClick);
            // 
            // Nparcelajuros
            // 
            this.Nparcelajuros.Frozen = true;
            this.Nparcelajuros.HeaderText = "Nº da Parcela";
            this.Nparcelajuros.Name = "Nparcelajuros";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor da Prestação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // jurosJuros
            // 
            this.jurosJuros.Frozen = true;
            this.jurosJuros.HeaderText = "Juros";
            this.jurosJuros.Name = "jurosJuros";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amortizacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SaldoDevedorjuros
            // 
            this.SaldoDevedorjuros.Frozen = true;
            this.SaldoDevedorjuros.HeaderText = "Saldo Devedor";
            this.SaldoDevedorjuros.Name = "SaldoDevedorjuros";
            // 
            // datavencimentojuros
            // 
            this.datavencimentojuros.Frozen = true;
            this.datavencimentojuros.HeaderText = "Data do vencimento";
            this.datavencimentojuros.Name = "datavencimentojuros";
            this.datavencimentojuros.Width = 200;
            // 
            // DatadePagamentojuros
            // 
            this.DatadePagamentojuros.Frozen = true;
            this.DatadePagamentojuros.HeaderText = "Data de Pagamento";
            this.DatadePagamentojuros.Name = "DatadePagamentojuros";
            this.DatadePagamentojuros.Width = 150;
            // 
            // Situacaojuros
            // 
            this.Situacaojuros.HeaderText = "Situacao";
            this.Situacaojuros.Name = "Situacaojuros";
            // 
            // txtvalorImprestadoJUROS
            // 
            this.txtvalorImprestadoJUROS.BackColor = System.Drawing.Color.Moccasin;
            this.txtvalorImprestadoJUROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtvalorImprestadoJUROS.Location = new System.Drawing.Point(32, 35);
            this.txtvalorImprestadoJUROS.Name = "txtvalorImprestadoJUROS";
            this.txtvalorImprestadoJUROS.Size = new System.Drawing.Size(375, 29);
            this.txtvalorImprestadoJUROS.TabIndex = 37;
            this.txtvalorImprestadoJUROS.Text = "0,00";
            this.txtvalorImprestadoJUROS.TextChanged += new System.EventHandler(this.txtvalorImprestadoJUROS_TextChanged);
            // 
            // txtJurosPORCENTO
            // 
            this.txtJurosPORCENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtJurosPORCENTO.Location = new System.Drawing.Point(614, 35);
            this.txtJurosPORCENTO.Name = "txtJurosPORCENTO";
            this.txtJurosPORCENTO.Size = new System.Drawing.Size(193, 29);
            this.txtJurosPORCENTO.TabIndex = 45;
            this.txtJurosPORCENTO.Text = "0,00";
            this.txtJurosPORCENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJurosPORCENTO.TextChanged += new System.EventHandler(this.txtJurosPORCENTO_TextChanged);
            // 
            // TxtdiaBaseJuros
            // 
            this.TxtdiaBaseJuros.Enabled = false;
            this.TxtdiaBaseJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtdiaBaseJuros.Location = new System.Drawing.Point(416, 35);
            this.TxtdiaBaseJuros.Name = "TxtdiaBaseJuros";
            this.TxtdiaBaseJuros.Size = new System.Drawing.Size(192, 29);
            this.TxtdiaBaseJuros.TabIndex = 39;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(179, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Data de Inicio de Pagamento";
            // 
            // btnCriaParcelasJUROS
            // 
            this.btnCriaParcelasJUROS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriaParcelasJUROS.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCriaParcelasJUROS.FlatAppearance.BorderSize = 0;
            this.btnCriaParcelasJUROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriaParcelasJUROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCriaParcelasJUROS.ForeColor = System.Drawing.Color.White;
            this.btnCriaParcelasJUROS.Location = new System.Drawing.Point(812, 25);
            this.btnCriaParcelasJUROS.Name = "btnCriaParcelasJUROS";
            this.btnCriaParcelasJUROS.Size = new System.Drawing.Size(0, 37);
            this.btnCriaParcelasJUROS.TabIndex = 44;
            this.btnCriaParcelasJUROS.Text = "Parcelas de Juros";
            this.btnCriaParcelasJUROS.UseVisualStyleBackColor = false;
            this.btnCriaParcelasJUROS.Click += new System.EventHandler(this.btnCriaParcelasJUROS_Click);
            // 
            // dateTimeDataInicialJURSOS
            // 
            this.dateTimeDataInicialJURSOS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimeDataInicialJURSOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimeDataInicialJURSOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataInicialJURSOS.Location = new System.Drawing.Point(32, 89);
            this.dateTimeDataInicialJURSOS.Name = "dateTimeDataInicialJURSOS";
            this.dateTimeDataInicialJURSOS.Size = new System.Drawing.Size(375, 29);
            this.dateTimeDataInicialJURSOS.TabIndex = 40;
            // 
            // FrmCriarCodicoesPagamentoImprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.groupBoxPlanoContratos);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCriarCodicoesPagamentoImprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Codicoes Pagamento | Imprestimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCriarCodicoesPagamento_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.groupBoxPlanoContratos.ResumeLayout(false);
            this.groupBoxPlanoContratos.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metrolanoContratosPrice.ResumeLayout(false);
            this.metrolanoContratosPrice.PerformLayout();
            this.metrolanoContratoJUROS.ResumeLayout(false);
            this.metrolanoContratoJUROS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasSAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public MetroFramework.Controls.MetroLabel LBnomedoadm_modulo;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox iD_CLIENTETextBox;
        private System.Windows.Forms.TextBox vALOR_MESTextBox;
        private System.Windows.Forms.TextBox dIA_BASETextBox;
        public System.Windows.Forms.Button BtnSalvaradm_modulo;
        private System.Windows.Forms.DateTimePicker dtDataini;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbNParcela;
        private System.Windows.Forms.DataGridView dgvParcelas;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public System.Windows.Forms.Button BtnNovoContrato;
        public System.Windows.Forms.Button BtnCancelarContrato;
        public System.Windows.Forms.Button BtnCriarParcelas;
        public System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.GroupBox groupBoxPlanoContratos;
        private System.Windows.Forms.TextBox TxtPorcentagem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metrolanoContratosPrice;
        private MetroFramework.Controls.MetroTabPage metrolanoContratoJUROS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nparcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorprestacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amortizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDevedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadePagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridView dgvParcelasSAC;
        private System.Windows.Forms.TextBox txtvalorImprestadoJUROS;
        private System.Windows.Forms.TextBox txtJurosPORCENTO;
        private System.Windows.Forms.TextBox TxtdiaBaseJuros;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.Button btnCriaParcelasJUROS;
        private System.Windows.Forms.DateTimePicker dateTimeDataInicialJURSOS;
        private System.Windows.Forms.TextBox txtJurosPlano2;
        public System.Windows.Forms.Button BtnSalvarParcelaJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nparcelajuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDevedorjuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimentojuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadePagamentojuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacaojuros;
    }
}