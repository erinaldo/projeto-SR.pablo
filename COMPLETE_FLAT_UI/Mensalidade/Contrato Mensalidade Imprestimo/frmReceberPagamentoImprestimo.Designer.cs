﻿namespace SoftwareGerenciador.adm_modulo
{
    partial class frmReceberPagamentoImprestimo
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.iD_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.LBnomedoadm_modulo = new MetroFramework.Controls.MetroLabel();
            this.BtnSalvaradm_modulo = new System.Windows.Forms.Button();
            this.txtvalorMensalidade = new System.Windows.Forms.TextBox();
            this.datapagamento = new System.Windows.Forms.DateTimePicker();
            this.DGVDADOS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvalormensal = new System.Windows.Forms.TextBox();
            this.txtquantidademeses = new System.Windows.Forms.TextBox();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.ComboSituacao = new MetroFramework.Controls.MetroComboBox();
            this.comboPagamento = new MetroFramework.Controls.MetroComboBox();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.txtvalorMensalidadeJuros = new System.Windows.Forms.TextBox();
            this.BtnpagamentoJuros = new System.Windows.Forms.Button();
            this.txtvalorFracionado = new System.Windows.Forms.TextBox();
            this.BtnpagamentoFracionado = new System.Windows.Forms.Button();
            this.LbValorPrestacao = new System.Windows.Forms.Label();
            this.LbValorFracionado = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.Location = new System.Drawing.Point(386, 11);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ID:";
            iDLabel.Visible = false;
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iD_CLIENTELabel.Location = new System.Drawing.Point(15, 49);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(114, 17);
            iD_CLIENTELabel.TabIndex = 11;
            iD_CLIENTELabel.Text = "NOME CLIENTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(601, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 17);
            label1.TabIndex = 15;
            label1.Text = "DATA PAGAMENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(15, 141);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(187, 17);
            label4.TabIndex = 20;
            label4.Text = "VALOR TOTAL À RECEBER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.Location = new System.Drawing.Point(15, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(172, 17);
            label5.TabIndex = 22;
            label5.Text = "QUANTIDADE DE MESES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label7.Location = new System.Drawing.Point(15, 32);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(115, 17);
            label7.TabIndex = 24;
            label7.Text = "VALOR MENSAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label9.Location = new System.Drawing.Point(349, 102);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 17);
            label9.TabIndex = 25;
            label9.Text = "SITUAÇÃO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(349, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 17);
            label3.TabIndex = 27;
            label3.Text = "FORMA PAGAMENTO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label10.Location = new System.Drawing.Point(0, 251);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(245, 17);
            label10.TabIndex = 35;
            label10.Text = "Selecione a parcela para pagamento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label11.Location = new System.Drawing.Point(44, 82);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(80, 17);
            label11.TabIndex = 44;
            label11.Text = "Valor Juros";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Controls.Add(this.iD_CLIENTETextBox);
            this.BarraTitulo.Controls.Add(this.iDTextBox);
            this.BarraTitulo.Controls.Add(iDLabel);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1035, 38);
            this.BarraTitulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Receber Pagamento do cliente";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(997, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // iD_CLIENTETextBox
            // 
            this.iD_CLIENTETextBox.Enabled = false;
            this.iD_CLIENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iD_CLIENTETextBox.Location = new System.Drawing.Point(454, 8);
            this.iD_CLIENTETextBox.Name = "iD_CLIENTETextBox";
            this.iD_CLIENTETextBox.Size = new System.Drawing.Size(50, 23);
            this.iD_CLIENTETextBox.TabIndex = 12;
            this.iD_CLIENTETextBox.Visible = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(430, 8);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(18, 23);
            this.iDTextBox.TabIndex = 10;
            this.iDTextBox.Visible = false;
            // 
            // LBnomedoadm_modulo
            // 
            this.LBnomedoadm_modulo.AutoSize = true;
            this.LBnomedoadm_modulo.Location = new System.Drawing.Point(128, 50);
            this.LBnomedoadm_modulo.Name = "LBnomedoadm_modulo";
            this.LBnomedoadm_modulo.Size = new System.Drawing.Size(107, 19);
            this.LBnomedoadm_modulo.TabIndex = 8;
            this.LBnomedoadm_modulo.Text = "Nome do cliente";
            // 
            // BtnSalvaradm_modulo
            // 
            this.BtnSalvaradm_modulo.BackColor = System.Drawing.Color.Green;
            this.BtnSalvaradm_modulo.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnSalvaradm_modulo.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_modulo.Location = new System.Drawing.Point(165, 151);
            this.BtnSalvaradm_modulo.Name = "BtnSalvaradm_modulo";
            this.BtnSalvaradm_modulo.Size = new System.Drawing.Size(175, 27);
            this.BtnSalvaradm_modulo.TabIndex = 13;
            this.BtnSalvaradm_modulo.Text = "Pagamento Integral";
            this.BtnSalvaradm_modulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvaradm_modulo.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_modulo.Click += new System.EventHandler(this.BtnSalvaradm_modulo_Click);
            // 
            // txtvalorMensalidade
            // 
            this.txtvalorMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvalorMensalidade.Location = new System.Drawing.Point(43, 151);
            this.txtvalorMensalidade.Name = "txtvalorMensalidade";
            this.txtvalorMensalidade.Size = new System.Drawing.Size(115, 26);
            this.txtvalorMensalidade.TabIndex = 16;
            this.txtvalorMensalidade.Text = "0";
            this.txtvalorMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvalorMensalidade.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            this.txtvalorMensalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // datapagamento
            // 
            this.datapagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datapagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datapagamento.Location = new System.Drawing.Point(604, 72);
            this.datapagamento.Name = "datapagamento";
            this.datapagamento.Size = new System.Drawing.Size(161, 23);
            this.datapagamento.TabIndex = 17;
            // 
            // DGVDADOS
            // 
            this.DGVDADOS.AllowUserToAddRows = false;
            this.DGVDADOS.AllowUserToDeleteRows = false;
            this.DGVDADOS.AllowUserToResizeColumns = false;
            this.DGVDADOS.AllowUserToResizeRows = false;
            this.DGVDADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDADOS.BackgroundColor = System.Drawing.Color.White;
            this.DGVDADOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDADOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDADOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDADOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDADOS.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDADOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDADOS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVDADOS.EnableHeadersVisualStyles = false;
            this.DGVDADOS.GridColor = System.Drawing.Color.White;
            this.DGVDADOS.Location = new System.Drawing.Point(0, 268);
            this.DGVDADOS.Name = "DGVDADOS";
            this.DGVDADOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDADOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDADOS.RowHeadersVisible = false;
            this.DGVDADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDADOS.Size = new System.Drawing.Size(1035, 370);
            this.DGVDADOS.TabIndex = 21;
            this.DGVDADOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellDoubleClick);
            this.DGVDADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDADOS_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.txtvalormensal);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.txtquantidademeses);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.txtvalortotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(771, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 199);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total parcial de pagamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtvalormensal
            // 
            this.txtvalormensal.BackColor = System.Drawing.Color.DimGray;
            this.txtvalormensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtvalormensal.ForeColor = System.Drawing.Color.White;
            this.txtvalormensal.Location = new System.Drawing.Point(18, 52);
            this.txtvalormensal.Name = "txtvalormensal";
            this.txtvalormensal.ReadOnly = true;
            this.txtvalormensal.Size = new System.Drawing.Size(190, 23);
            this.txtvalormensal.TabIndex = 23;
            // 
            // txtquantidademeses
            // 
            this.txtquantidademeses.BackColor = System.Drawing.Color.DimGray;
            this.txtquantidademeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtquantidademeses.ForeColor = System.Drawing.Color.White;
            this.txtquantidademeses.Location = new System.Drawing.Point(18, 103);
            this.txtquantidademeses.Name = "txtquantidademeses";
            this.txtquantidademeses.ReadOnly = true;
            this.txtquantidademeses.Size = new System.Drawing.Size(190, 23);
            this.txtquantidademeses.TabIndex = 21;
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.BackColor = System.Drawing.Color.DimGray;
            this.txtvalortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtvalortotal.ForeColor = System.Drawing.Color.White;
            this.txtvalortotal.Location = new System.Drawing.Point(18, 161);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.ReadOnly = true;
            this.txtvalortotal.Size = new System.Drawing.Size(190, 23);
            this.txtvalortotal.TabIndex = 19;
            // 
            // ComboSituacao
            // 
            this.ComboSituacao.FormattingEnabled = true;
            this.ComboSituacao.ItemHeight = 23;
            this.ComboSituacao.Items.AddRange(new object[] {
            "PAGO",
            "NAO PAGO",
            "CANCELADO",
            "GRATIS (BONUS)",
            "FRACIONADO"});
            this.ComboSituacao.Location = new System.Drawing.Point(352, 122);
            this.ComboSituacao.Name = "ComboSituacao";
            this.ComboSituacao.Size = new System.Drawing.Size(413, 29);
            this.ComboSituacao.TabIndex = 26;
            // 
            // comboPagamento
            // 
            this.comboPagamento.FormattingEnabled = true;
            this.comboPagamento.ItemHeight = 23;
            this.comboPagamento.Items.AddRange(new object[] {
            "GRATIS (BONUS)",
            "DEBITO",
            "CREDITO",
            "VALE_COMPRA",
            "DINHEIRO",
            "Transferência bancária;",
            "Depósito em espécie;",
            "Depósito em envelope;",
            "Loja (Dinheiro);",
            "Loja (Cartão)",
            "BOLETO"});
            this.comboPagamento.Location = new System.Drawing.Point(352, 176);
            this.comboPagamento.Name = "comboPagamento";
            this.comboPagamento.Size = new System.Drawing.Size(413, 29);
            this.comboPagamento.TabIndex = 28;
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(549, 244);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(55, 13);
            this.Link.TabIndex = 31;
            this.Link.TabStop = true;
            this.Link.Text = "linkLabel1";
            this.Link.Visible = false;
            // 
            // txtvalorMensalidadeJuros
            // 
            this.txtvalorMensalidadeJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvalorMensalidadeJuros.Location = new System.Drawing.Point(43, 102);
            this.txtvalorMensalidadeJuros.Name = "txtvalorMensalidadeJuros";
            this.txtvalorMensalidadeJuros.Size = new System.Drawing.Size(116, 26);
            this.txtvalorMensalidadeJuros.TabIndex = 36;
            this.txtvalorMensalidadeJuros.Text = "0";
            this.txtvalorMensalidadeJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnpagamentoJuros
            // 
            this.BtnpagamentoJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnpagamentoJuros.FlatAppearance.BorderSize = 0;
            this.BtnpagamentoJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnpagamentoJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnpagamentoJuros.ForeColor = System.Drawing.Color.White;
            this.BtnpagamentoJuros.Location = new System.Drawing.Point(165, 102);
            this.BtnpagamentoJuros.Name = "BtnpagamentoJuros";
            this.BtnpagamentoJuros.Size = new System.Drawing.Size(175, 27);
            this.BtnpagamentoJuros.TabIndex = 38;
            this.BtnpagamentoJuros.Text = "Pagamento Juros";
            this.BtnpagamentoJuros.UseVisualStyleBackColor = false;
            this.BtnpagamentoJuros.Click += new System.EventHandler(this.BtnpagamentoJuros_Click);
            // 
            // txtvalorFracionado
            // 
            this.txtvalorFracionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvalorFracionado.Location = new System.Drawing.Point(43, 207);
            this.txtvalorFracionado.Name = "txtvalorFracionado";
            this.txtvalorFracionado.Size = new System.Drawing.Size(115, 26);
            this.txtvalorFracionado.TabIndex = 42;
            this.txtvalorFracionado.Text = "0";
            this.txtvalorFracionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvalorFracionado.TextChanged += new System.EventHandler(this.txtvalorFracionado_TextChanged);
            // 
            // BtnpagamentoFracionado
            // 
            this.BtnpagamentoFracionado.BackColor = System.Drawing.Color.Green;
            this.BtnpagamentoFracionado.FlatAppearance.BorderSize = 0;
            this.BtnpagamentoFracionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnpagamentoFracionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnpagamentoFracionado.ForeColor = System.Drawing.Color.White;
            this.BtnpagamentoFracionado.Location = new System.Drawing.Point(165, 207);
            this.BtnpagamentoFracionado.Name = "BtnpagamentoFracionado";
            this.BtnpagamentoFracionado.Size = new System.Drawing.Size(175, 27);
            this.BtnpagamentoFracionado.TabIndex = 41;
            this.BtnpagamentoFracionado.Text = "Pagamento Fracionado";
            this.BtnpagamentoFracionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnpagamentoFracionado.UseVisualStyleBackColor = false;
            this.BtnpagamentoFracionado.Click += new System.EventHandler(this.BtnpagamentoFracionado_Click);
            // 
            // LbValorPrestacao
            // 
            this.LbValorPrestacao.AutoSize = true;
            this.LbValorPrestacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LbValorPrestacao.Location = new System.Drawing.Point(44, 134);
            this.LbValorPrestacao.Name = "LbValorPrestacao";
            this.LbValorPrestacao.Size = new System.Drawing.Size(109, 17);
            this.LbValorPrestacao.TabIndex = 45;
            this.LbValorPrestacao.Text = "Valor Prestação";
            // 
            // LbValorFracionado
            // 
            this.LbValorFracionado.AutoSize = true;
            this.LbValorFracionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LbValorFracionado.Location = new System.Drawing.Point(44, 187);
            this.LbValorFracionado.Name = "LbValorFracionado";
            this.LbValorFracionado.Size = new System.Drawing.Size(146, 17);
            this.LbValorFracionado.TabIndex = 46;
            this.LbValorFracionado.Text = "Valor Fracionado ( ? )";
            // 
            // frmReceberPagamentoImprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 638);
            this.Controls.Add(this.LbValorFracionado);
            this.Controls.Add(this.LbValorPrestacao);
            this.Controls.Add(label11);
            this.Controls.Add(this.txtvalorFracionado);
            this.Controls.Add(this.BtnpagamentoFracionado);
            this.Controls.Add(this.BtnpagamentoJuros);
            this.Controls.Add(this.txtvalorMensalidadeJuros);
            this.Controls.Add(label10);
            this.Controls.Add(this.txtvalorMensalidade);
            this.Controls.Add(this.ComboSituacao);
            this.Controls.Add(label9);
            this.Controls.Add(this.datapagamento);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(this.comboPagamento);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVDADOS);
            this.Controls.Add(this.BtnSalvaradm_modulo);
            this.Controls.Add(this.LBnomedoadm_modulo);
            this.Controls.Add(iD_CLIENTELabel);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReceberPagamentoImprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber Pagamento de Imprestimo | Juros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReceberPagamento_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        public System.Windows.Forms.Button BtnSalvaradm_modulo;
        private System.Windows.Forms.TextBox txtvalorMensalidade;
        private System.Windows.Forms.DateTimePicker datapagamento;
        private System.Windows.Forms.DataGridView DGVDADOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtvalormensal;
        private System.Windows.Forms.TextBox txtquantidademeses;
        private System.Windows.Forms.TextBox txtvalortotal;
        private MetroFramework.Controls.MetroComboBox ComboSituacao;
        private MetroFramework.Controls.MetroComboBox comboPagamento;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.TextBox txtvalorMensalidadeJuros;
        public System.Windows.Forms.Button BtnpagamentoJuros;
        private System.Windows.Forms.TextBox txtvalorFracionado;
        public System.Windows.Forms.Button BtnpagamentoFracionado;
        private System.Windows.Forms.Label LbValorPrestacao;
        private System.Windows.Forms.Label LbValorFracionado;
    }
}