namespace SoftwareGerenciador.adm_modulo
{
    partial class FrmCriarCodicoesPagamento
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LBnomedoadm_modulo = new MetroFramework.Controls.MetroLabel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iD_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.vALOR_MESTextBox = new System.Windows.Forms.TextBox();
            this.dIA_BASETextBox = new System.Windows.Forms.TextBox();
            this.BtnSalvaradm_modulo = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RadioAvulso = new MetroFramework.Controls.MetroRadioButton();
            this.RadioVenda = new MetroFramework.Controls.MetroRadioButton();
            this.dtDataini = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbNParcela = new MetroFramework.Controls.MetroComboBox();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadePagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFracionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnNovoContrato = new System.Windows.Forms.Button();
            this.BtnCancelarContrato = new System.Windows.Forms.Button();
            this.BtnCriarParcelas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxEditorImovel = new System.Windows.Forms.RichTextBox();
            this.groupBoxPlanoContratos = new System.Windows.Forms.GroupBox();
            this.comboImovel = new System.Windows.Forms.ComboBox();
            this.txtvalorEntrada = new System.Windows.Forms.TextBox();
            this.RadioAluguel = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnGerarContrato = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            vALOR_MESLabel = new System.Windows.Forms.Label();
            dIA_BASELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPlanoContratos.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.Location = new System.Drawing.Point(4, 47);
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
            iD_CLIENTELabel.Location = new System.Drawing.Point(17, 90);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(115, 17);
            iD_CLIENTELabel.TabIndex = 6;
            iD_CLIENTELabel.Text = "MOME CLIENTE:";
            // 
            // vALOR_MESLabel
            // 
            vALOR_MESLabel.AutoSize = true;
            vALOR_MESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            vALOR_MESLabel.Location = new System.Drawing.Point(7, 8);
            vALOR_MESLabel.Name = "vALOR_MESLabel";
            vALOR_MESLabel.Size = new System.Drawing.Size(92, 17);
            vALOR_MESLabel.TabIndex = 8;
            vALOR_MESLabel.Text = "VALOR MES:";
            // 
            // dIA_BASELabel
            // 
            dIA_BASELabel.AutoSize = true;
            dIA_BASELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dIA_BASELabel.Location = new System.Drawing.Point(206, 8);
            dIA_BASELabel.Name = "dIA_BASELabel";
            dIA_BASELabel.Size = new System.Drawing.Size(74, 17);
            dIA_BASELabel.TabIndex = 10;
            dIA_BASELabel.Text = "DIA BASE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(820, 539);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 17);
            label1.TabIndex = 23;
            label1.Text = "Total Parcial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(475, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 17);
            label3.TabIndex = 32;
            label3.Text = "Entrada (R$)";
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.BackColor = System.Drawing.Color.White;
            cIDADELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cIDADELabel.Location = new System.Drawing.Point(92, 28);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(63, 17);
            cIDADELabel.TabIndex = 95;
            cIDADELabel.Text = "IMÓVEL:";
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
            this.label6.Size = new System.Drawing.Size(119, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contrato";
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
            this.LBnomedoadm_modulo.Location = new System.Drawing.Point(138, 90);
            this.LBnomedoadm_modulo.Name = "LBnomedoadm_modulo";
            this.LBnomedoadm_modulo.Size = new System.Drawing.Size(107, 19);
            this.LBnomedoadm_modulo.TabIndex = 4;
            this.LBnomedoadm_modulo.Text = "Nome do cliente";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(48, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(123, 23);
            this.iDTextBox.TabIndex = 5;
            this.iDTextBox.Visible = false;
            // 
            // iD_CLIENTETextBox
            // 
            this.iD_CLIENTETextBox.Enabled = false;
            this.iD_CLIENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iD_CLIENTETextBox.Location = new System.Drawing.Point(48, 64);
            this.iD_CLIENTETextBox.Name = "iD_CLIENTETextBox";
            this.iD_CLIENTETextBox.Size = new System.Drawing.Size(123, 23);
            this.iD_CLIENTETextBox.TabIndex = 7;
            this.iD_CLIENTETextBox.Visible = false;
            // 
            // vALOR_MESTextBox
            // 
            this.vALOR_MESTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.vALOR_MESTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vALOR_MESTextBox.Location = new System.Drawing.Point(26, 165);
            this.vALOR_MESTextBox.Name = "vALOR_MESTextBox";
            this.vALOR_MESTextBox.Size = new System.Drawing.Size(186, 23);
            this.vALOR_MESTextBox.TabIndex = 9;
            this.vALOR_MESTextBox.Text = "0,00";
            this.vALOR_MESTextBox.TextChanged += new System.EventHandler(this.vALOR_MESTextBox_TextChanged);
            // 
            // dIA_BASETextBox
            // 
            this.dIA_BASETextBox.Enabled = false;
            this.dIA_BASETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dIA_BASETextBox.Location = new System.Drawing.Point(218, 165);
            this.dIA_BASETextBox.Name = "dIA_BASETextBox";
            this.dIA_BASETextBox.Size = new System.Drawing.Size(186, 23);
            this.dIA_BASETextBox.TabIndex = 11;
            // 
            // BtnSalvaradm_modulo
            // 
            this.BtnSalvaradm_modulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvaradm_modulo.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnSalvaradm_modulo.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_modulo.Location = new System.Drawing.Point(775, 466);
            this.BtnSalvaradm_modulo.Name = "BtnSalvaradm_modulo";
            this.BtnSalvaradm_modulo.Size = new System.Drawing.Size(192, 56);
            this.BtnSalvaradm_modulo.TabIndex = 12;
            this.BtnSalvaradm_modulo.Text = "Salvar\r\nContrato";
            this.BtnSalvaradm_modulo.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_modulo.Click += new System.EventHandler(this.BtnSalvaradm_modulo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(410, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Dia para Pagamento";
            // 
            // RadioAvulso
            // 
            this.RadioAvulso.AutoSize = true;
            this.RadioAvulso.Location = new System.Drawing.Point(22, 31);
            this.RadioAvulso.Name = "RadioAvulso";
            this.RadioAvulso.Size = new System.Drawing.Size(59, 15);
            this.RadioAvulso.TabIndex = 14;
            this.RadioAvulso.Text = "Avulso";
            this.RadioAvulso.UseVisualStyleBackColor = true;
            this.RadioAvulso.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // RadioVenda
            // 
            this.RadioVenda.AutoSize = true;
            this.RadioVenda.Location = new System.Drawing.Point(22, 52);
            this.RadioVenda.Name = "RadioVenda";
            this.RadioVenda.Size = new System.Drawing.Size(55, 15);
            this.RadioVenda.TabIndex = 15;
            this.RadioVenda.Text = "Venda";
            this.RadioVenda.UseVisualStyleBackColor = true;
            this.RadioVenda.CheckedChanged += new System.EventHandler(this.RadioVenda_CheckedChanged);
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(161, 88);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(180, 29);
            this.dtDataini.TabIndex = 16;
            this.dtDataini.ValueChanged += new System.EventHandler(this.dtDataini_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(161, 63);
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
            this.cbNParcela.Location = new System.Drawing.Point(347, 88);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(122, 29);
            this.cbNParcela.TabIndex = 18;
            this.cbNParcela.SelectedIndexChanged += new System.EventHandler(this.cbNParcela_SelectedIndexChanged);
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Enabled = false;
            this.txtTotalParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalParcial.ForeColor = System.Drawing.Color.Green;
            this.txtTotalParcial.Location = new System.Drawing.Point(777, 559);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(190, 29);
            this.txtTotalParcial.TabIndex = 24;
            this.txtTotalParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeColumns = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto,
            this.DatadePagamento,
            this.Situacao,
            this.ValorFracionado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvParcelas.Location = new System.Drawing.Point(20, 385);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParcelas.Name = "dgvParcelas";
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
            this.dgvParcelas.Size = new System.Drawing.Size(726, 204);
            this.dgvParcelas.TabIndex = 25;
            // 
            // pco_cod
            // 
            this.pco_cod.Frozen = true;
            this.pco_cod.HeaderText = "Nº da Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.Width = 70;
            // 
            // pco_valor
            // 
            this.pco_valor.Frozen = true;
            this.pco_valor.HeaderText = "Valor da Mensalidade";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.Width = 130;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.Frozen = true;
            this.pco_datavecto.HeaderText = "Data do vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.Width = 150;
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
            // ValorFracionado
            // 
            this.ValorFracionado.HeaderText = "ValorFracionado";
            this.ValorFracionado.Name = "ValorFracionado";
            this.ValorFracionado.Width = 120;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(347, 63);
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
            this.BtnNovoContrato.Location = new System.Drawing.Point(249, 44);
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
            this.BtnCancelarContrato.Location = new System.Drawing.Point(410, 44);
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
            this.BtnCriarParcelas.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCriarParcelas.FlatAppearance.BorderSize = 0;
            this.BtnCriarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCriarParcelas.ForeColor = System.Drawing.Color.White;
            this.BtnCriarParcelas.Location = new System.Drawing.Point(10, 123);
            this.BtnCriarParcelas.Name = "BtnCriarParcelas";
            this.BtnCriarParcelas.Size = new System.Drawing.Size(214, 37);
            this.BtnCriarParcelas.TabIndex = 29;
            this.BtnCriarParcelas.Text = "Criar Parcelas";
            this.BtnCriarParcelas.UseVisualStyleBackColor = false;
            this.BtnCriarParcelas.Click += new System.EventHandler(this.BtnCriarParcelas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(vALOR_MESLabel);
            this.panel1.Controls.Add(dIA_BASELabel);
            this.panel1.Location = new System.Drawing.Point(26, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 33);
            this.panel1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.richTextBoxEditorImovel);
            this.groupBox1.Location = new System.Drawing.Point(634, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 333);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Contrato (Descrição)";
            // 
            // richTextBoxEditorImovel
            // 
            this.richTextBoxEditorImovel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEditorImovel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBoxEditorImovel.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxEditorImovel.Name = "richTextBoxEditorImovel";
            this.richTextBoxEditorImovel.Size = new System.Drawing.Size(336, 314);
            this.richTextBoxEditorImovel.TabIndex = 34;
            this.richTextBoxEditorImovel.Text = "";
            // 
            // groupBoxPlanoContratos
            // 
            this.groupBoxPlanoContratos.BackColor = System.Drawing.Color.White;
            this.groupBoxPlanoContratos.Controls.Add(this.comboImovel);
            this.groupBoxPlanoContratos.Controls.Add(cIDADELabel);
            this.groupBoxPlanoContratos.Controls.Add(label3);
            this.groupBoxPlanoContratos.Controls.Add(this.txtvalorEntrada);
            this.groupBoxPlanoContratos.Controls.Add(this.RadioAluguel);
            this.groupBoxPlanoContratos.Controls.Add(this.RadioAvulso);
            this.groupBoxPlanoContratos.Controls.Add(this.RadioVenda);
            this.groupBoxPlanoContratos.Controls.Add(this.metroLabel2);
            this.groupBoxPlanoContratos.Controls.Add(this.BtnCriarParcelas);
            this.groupBoxPlanoContratos.Controls.Add(this.dtDataini);
            this.groupBoxPlanoContratos.Controls.Add(this.metroLabel3);
            this.groupBoxPlanoContratos.Controls.Add(this.cbNParcela);
            this.groupBoxPlanoContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlanoContratos.Location = new System.Drawing.Point(26, 194);
            this.groupBoxPlanoContratos.Name = "groupBoxPlanoContratos";
            this.groupBoxPlanoContratos.Size = new System.Drawing.Size(602, 183);
            this.groupBoxPlanoContratos.TabIndex = 32;
            this.groupBoxPlanoContratos.TabStop = false;
            this.groupBoxPlanoContratos.Text = "Planos do contrato";
            // 
            // comboImovel
            // 
            this.comboImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboImovel.FormattingEnabled = true;
            this.comboImovel.Location = new System.Drawing.Point(161, 25);
            this.comboImovel.Name = "comboImovel";
            this.comboImovel.Size = new System.Drawing.Size(429, 24);
            this.comboImovel.TabIndex = 96;
            this.comboImovel.SelectedIndexChanged += new System.EventHandler(this.comboImovel_SelectedIndexChanged);
            // 
            // txtvalorEntrada
            // 
            this.txtvalorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtvalorEntrada.Location = new System.Drawing.Point(476, 93);
            this.txtvalorEntrada.Name = "txtvalorEntrada";
            this.txtvalorEntrada.Size = new System.Drawing.Size(111, 23);
            this.txtvalorEntrada.TabIndex = 31;
            this.txtvalorEntrada.Text = "0,00";
            this.txtvalorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvalorEntrada.TextChanged += new System.EventHandler(this.txtvalorEntrada_TextChanged);
            // 
            // RadioAluguel
            // 
            this.RadioAluguel.AutoSize = true;
            this.RadioAluguel.Checked = true;
            this.RadioAluguel.Location = new System.Drawing.Point(22, 73);
            this.RadioAluguel.Name = "RadioAluguel";
            this.RadioAluguel.Size = new System.Drawing.Size(64, 15);
            this.RadioAluguel.TabIndex = 30;
            this.RadioAluguel.TabStop = true;
            this.RadioAluguel.Text = "Aluguel";
            this.RadioAluguel.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(775, 396);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(187, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Gerar contrato para assinatura";
            // 
            // BtnGerarContrato
            // 
            this.BtnGerarContrato.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGerarContrato.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.word;
            this.BtnGerarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGerarContrato.FlatAppearance.BorderSize = 0;
            this.BtnGerarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnGerarContrato.ForeColor = System.Drawing.Color.White;
            this.BtnGerarContrato.Location = new System.Drawing.Point(775, 418);
            this.BtnGerarContrato.Name = "BtnGerarContrato";
            this.BtnGerarContrato.Size = new System.Drawing.Size(39, 42);
            this.BtnGerarContrato.TabIndex = 97;
            this.BtnGerarContrato.UseVisualStyleBackColor = false;
            this.BtnGerarContrato.Click += new System.EventHandler(this.BtnGerarContrato_Click);
            // 
            // FrmCriarCodicoesPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 600);
            this.Controls.Add(this.BtnGerarContrato);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.groupBoxPlanoContratos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnNovoContrato);
            this.Controls.Add(this.BtnCancelarContrato);
            this.Controls.Add(this.dgvParcelas);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtTotalParcial);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LBnomedoadm_modulo);
            this.Controls.Add(this.BtnSalvaradm_modulo);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(iD_CLIENTELabel);
            this.Controls.Add(this.iD_CLIENTETextBox);
            this.Controls.Add(this.vALOR_MESTextBox);
            this.Controls.Add(this.dIA_BASETextBox);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCriarCodicoesPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Codicoes Pagamento | Aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCriarCodicoesPagamento_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPlanoContratos.ResumeLayout(false);
            this.groupBoxPlanoContratos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton RadioAvulso;
        private MetroFramework.Controls.MetroRadioButton RadioVenda;
        private System.Windows.Forms.DateTimePicker dtDataini;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbNParcela;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.DataGridView dgvParcelas;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public System.Windows.Forms.Button BtnNovoContrato;
        public System.Windows.Forms.Button BtnCancelarContrato;
        public System.Windows.Forms.Button BtnCriarParcelas;
        public System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPlanoContratos;
        private MetroFramework.Controls.MetroRadioButton RadioAluguel;
        private System.Windows.Forms.TextBox txtvalorEntrada;
        public System.Windows.Forms.ComboBox comboImovel;
        private System.Windows.Forms.RichTextBox richTextBoxEditorImovel;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public System.Windows.Forms.Button BtnGerarContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadePagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFracionado;
    }
}