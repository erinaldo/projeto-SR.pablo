namespace SoftwareGerenciador.Faturamento
{
    partial class frmconsultadepagamento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVDADOS = new System.Windows.Forms.DataGridView();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.BtnPesquisarData = new System.Windows.Forms.Button();
            this.dataPesquisar = new System.Windows.Forms.DateTimePicker();
            this.ComboNomeCliente = new System.Windows.Forms.ComboBox();
            this.btnLocalizarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tarefas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FAZERPAGAMENTO = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemWatsappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerPagamentoImprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.DGVDADOSIMPRESTIMO = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnlocalPelaDataImprestimo = new System.Windows.Forms.Button();
            this.dataPesquisarImprestimo = new System.Windows.Forms.DateTimePicker();
            this.ComboNomeClienteiMPRESTIMO = new System.Windows.Forms.ComboBox();
            this.btnLocalizarClienteIMPRESTIMO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.Tarefas.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOSIMPRESTIMO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDADOS
            // 
            this.DGVDADOS.AllowUserToAddRows = false;
            this.DGVDADOS.AllowUserToDeleteRows = false;
            this.DGVDADOS.AllowUserToResizeColumns = false;
            this.DGVDADOS.AllowUserToResizeRows = false;
            this.DGVDADOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDADOS.BackgroundColor = System.Drawing.Color.White;
            this.DGVDADOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDADOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDADOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDADOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDADOS.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDADOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDADOS.EnableHeadersVisualStyles = false;
            this.DGVDADOS.GridColor = System.Drawing.Color.White;
            this.DGVDADOS.Location = new System.Drawing.Point(0, 71);
            this.DGVDADOS.Name = "DGVDADOS";
            this.DGVDADOS.ReadOnly = true;
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
            this.DGVDADOS.Size = new System.Drawing.Size(942, 427);
            this.DGVDADOS.TabIndex = 3;
            this.DGVDADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellContentClick);
            this.DGVDADOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellDoubleClick);
            this.DGVDADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDADOS_CellFormatting);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BarraTitulo.Controls.Add(this.label4);
            this.BarraTitulo.Controls.Add(this.label3);
            this.BarraTitulo.Controls.Add(this.Link);
            this.BarraTitulo.Controls.Add(this.BtnPesquisarData);
            this.BarraTitulo.Controls.Add(this.dataPesquisar);
            this.BarraTitulo.Controls.Add(this.ComboNomeCliente);
            this.BarraTitulo.Controls.Add(this.btnLocalizarCliente);
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Location = new System.Drawing.Point(-1, 3);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(942, 62);
            this.BarraTitulo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(583, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Consultas pelo Nome do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Consultas por Data";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(482, 36);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(55, 13);
            this.Link.TabIndex = 20;
            this.Link.TabStop = true;
            this.Link.Text = "linkLabel1";
            this.Link.Visible = false;
            // 
            // BtnPesquisarData
            // 
            this.BtnPesquisarData.BackColor = System.Drawing.Color.White;
            this.BtnPesquisarData.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.if_miscellaneous_04_809403;
            this.BtnPesquisarData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisarData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnPesquisarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarData.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisarData.Location = new System.Drawing.Point(435, 23);
            this.BtnPesquisarData.Name = "BtnPesquisarData";
            this.BtnPesquisarData.Size = new System.Drawing.Size(41, 26);
            this.BtnPesquisarData.TabIndex = 19;
            this.BtnPesquisarData.UseVisualStyleBackColor = false;
            this.BtnPesquisarData.Click += new System.EventHandler(this.BtnPesquisarData_Click);
            // 
            // dataPesquisar
            // 
            this.dataPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataPesquisar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPesquisar.Location = new System.Drawing.Point(237, 23);
            this.dataPesquisar.Name = "dataPesquisar";
            this.dataPesquisar.Size = new System.Drawing.Size(192, 26);
            this.dataPesquisar.TabIndex = 18;
            // 
            // ComboNomeCliente
            // 
            this.ComboNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComboNomeCliente.FormattingEnabled = true;
            this.ComboNomeCliente.Location = new System.Drawing.Point(587, 23);
            this.ComboNomeCliente.Name = "ComboNomeCliente";
            this.ComboNomeCliente.Size = new System.Drawing.Size(235, 28);
            this.ComboNomeCliente.TabIndex = 6;
            this.ComboNomeCliente.SelectedIndexChanged += new System.EventHandler(this.ComboNomeCliente_SelectedIndexChanged);
            this.ComboNomeCliente.TextChanged += new System.EventHandler(this.ComboNomeCliente_TextChanged);
            // 
            // btnLocalizarCliente
            // 
            this.btnLocalizarCliente.BackColor = System.Drawing.Color.White;
            this.btnLocalizarCliente.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.if_miscellaneous_04_809403;
            this.btnLocalizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLocalizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCliente.Location = new System.Drawing.Point(828, 23);
            this.btnLocalizarCliente.Name = "btnLocalizarCliente";
            this.btnLocalizarCliente.Size = new System.Drawing.Size(41, 26);
            this.btnLocalizarCliente.TabIndex = 17;
            this.btnLocalizarCliente.UseVisualStyleBackColor = false;
            this.btnLocalizarCliente.Click += new System.EventHandler(this.btnLocalizarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Situação de Clientes\r\nContrato";
            // 
            // Tarefas
            // 
            this.Tarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Tarefas.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Tarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FAZERPAGAMENTO,
            this.mensagemWatsappToolStripMenuItem,
            this.fazerPagamentoImprestimoToolStripMenuItem});
            this.Tarefas.Name = "Tarefas";
            this.Tarefas.Size = new System.Drawing.Size(418, 94);
            // 
            // FAZERPAGAMENTO
            // 
            this.FAZERPAGAMENTO.ForeColor = System.Drawing.Color.White;
            this.FAZERPAGAMENTO.Name = "FAZERPAGAMENTO";
            this.FAZERPAGAMENTO.Size = new System.Drawing.Size(417, 30);
            this.FAZERPAGAMENTO.Text = "Fazer Pagamento Aluguel";
            this.FAZERPAGAMENTO.Click += new System.EventHandler(this.FAZERPAGAMENTO_Click);
            // 
            // mensagemWatsappToolStripMenuItem
            // 
            this.mensagemWatsappToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mensagemWatsappToolStripMenuItem.Name = "mensagemWatsappToolStripMenuItem";
            this.mensagemWatsappToolStripMenuItem.Size = new System.Drawing.Size(417, 30);
            this.mensagemWatsappToolStripMenuItem.Text = "whatsapp web (Cobrança)";
            this.mensagemWatsappToolStripMenuItem.Click += new System.EventHandler(this.mensagemWatsappToolStripMenuItem_Click);
            // 
            // fazerPagamentoImprestimoToolStripMenuItem
            // 
            this.fazerPagamentoImprestimoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fazerPagamentoImprestimoToolStripMenuItem.Name = "fazerPagamentoImprestimoToolStripMenuItem";
            this.fazerPagamentoImprestimoToolStripMenuItem.Size = new System.Drawing.Size(417, 30);
            this.fazerPagamentoImprestimoToolStripMenuItem.Text = "Fazer Pagamento Imprestimo";
            this.fazerPagamentoImprestimoToolStripMenuItem.Click += new System.EventHandler(this.fazerPagamentoImprestimoToolStripMenuItem_Click);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(950, 537);
            this.metroTabControl1.TabIndex = 6;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.DGVDADOS);
            this.metroTabPage1.Controls.Add(this.BarraTitulo);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(942, 498);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Situação de Recebimento de Contratos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.DGVDADOSIMPRESTIMO);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(942, 498);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Situação de Recebimento Imprestimo";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // DGVDADOSIMPRESTIMO
            // 
            this.DGVDADOSIMPRESTIMO.AllowUserToAddRows = false;
            this.DGVDADOSIMPRESTIMO.AllowUserToDeleteRows = false;
            this.DGVDADOSIMPRESTIMO.AllowUserToResizeColumns = false;
            this.DGVDADOSIMPRESTIMO.AllowUserToResizeRows = false;
            this.DGVDADOSIMPRESTIMO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDADOSIMPRESTIMO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDADOSIMPRESTIMO.BackgroundColor = System.Drawing.Color.White;
            this.DGVDADOSIMPRESTIMO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDADOSIMPRESTIMO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDADOSIMPRESTIMO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDADOSIMPRESTIMO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDADOSIMPRESTIMO.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDADOSIMPRESTIMO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVDADOSIMPRESTIMO.EnableHeadersVisualStyles = false;
            this.DGVDADOSIMPRESTIMO.GridColor = System.Drawing.Color.White;
            this.DGVDADOSIMPRESTIMO.Location = new System.Drawing.Point(3, 71);
            this.DGVDADOSIMPRESTIMO.Name = "DGVDADOSIMPRESTIMO";
            this.DGVDADOSIMPRESTIMO.ReadOnly = true;
            this.DGVDADOSIMPRESTIMO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDADOSIMPRESTIMO.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDADOSIMPRESTIMO.RowHeadersVisible = false;
            this.DGVDADOSIMPRESTIMO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDADOSIMPRESTIMO.Size = new System.Drawing.Size(936, 419);
            this.DGVDADOSIMPRESTIMO.TabIndex = 7;
            this.DGVDADOSIMPRESTIMO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOSIMPRESTIMO_CellContentClick);
            this.DGVDADOSIMPRESTIMO.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDADOSIMPRESTIMO_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.BtnlocalPelaDataImprestimo);
            this.panel1.Controls.Add(this.dataPesquisarImprestimo);
            this.panel1.Controls.Add(this.ComboNomeClienteiMPRESTIMO);
            this.panel1.Controls.Add(this.btnLocalizarClienteIMPRESTIMO);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 62);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(588, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consultas pelo Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Consultas por Data";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            // 
            // BtnlocalPelaDataImprestimo
            // 
            this.BtnlocalPelaDataImprestimo.BackColor = System.Drawing.Color.White;
            this.BtnlocalPelaDataImprestimo.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.if_miscellaneous_04_809403;
            this.BtnlocalPelaDataImprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnlocalPelaDataImprestimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnlocalPelaDataImprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnlocalPelaDataImprestimo.ForeColor = System.Drawing.Color.White;
            this.BtnlocalPelaDataImprestimo.Location = new System.Drawing.Point(434, 23);
            this.BtnlocalPelaDataImprestimo.Name = "BtnlocalPelaDataImprestimo";
            this.BtnlocalPelaDataImprestimo.Size = new System.Drawing.Size(41, 26);
            this.BtnlocalPelaDataImprestimo.TabIndex = 19;
            this.BtnlocalPelaDataImprestimo.UseVisualStyleBackColor = false;
            this.BtnlocalPelaDataImprestimo.Click += new System.EventHandler(this.BtnlocalPelaDataImprestimo_Click);
            // 
            // dataPesquisarImprestimo
            // 
            this.dataPesquisarImprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataPesquisarImprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPesquisarImprestimo.Location = new System.Drawing.Point(236, 23);
            this.dataPesquisarImprestimo.Name = "dataPesquisarImprestimo";
            this.dataPesquisarImprestimo.Size = new System.Drawing.Size(192, 26);
            this.dataPesquisarImprestimo.TabIndex = 18;
            // 
            // ComboNomeClienteiMPRESTIMO
            // 
            this.ComboNomeClienteiMPRESTIMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComboNomeClienteiMPRESTIMO.FormattingEnabled = true;
            this.ComboNomeClienteiMPRESTIMO.Location = new System.Drawing.Point(592, 21);
            this.ComboNomeClienteiMPRESTIMO.Name = "ComboNomeClienteiMPRESTIMO";
            this.ComboNomeClienteiMPRESTIMO.Size = new System.Drawing.Size(235, 28);
            this.ComboNomeClienteiMPRESTIMO.TabIndex = 6;
            // 
            // btnLocalizarClienteIMPRESTIMO
            // 
            this.btnLocalizarClienteIMPRESTIMO.BackColor = System.Drawing.Color.White;
            this.btnLocalizarClienteIMPRESTIMO.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.if_miscellaneous_04_809403;
            this.btnLocalizarClienteIMPRESTIMO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarClienteIMPRESTIMO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLocalizarClienteIMPRESTIMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarClienteIMPRESTIMO.Location = new System.Drawing.Point(833, 21);
            this.btnLocalizarClienteIMPRESTIMO.Name = "btnLocalizarClienteIMPRESTIMO";
            this.btnLocalizarClienteIMPRESTIMO.Size = new System.Drawing.Size(41, 26);
            this.btnLocalizarClienteIMPRESTIMO.TabIndex = 17;
            this.btnLocalizarClienteIMPRESTIMO.UseVisualStyleBackColor = false;
            this.btnLocalizarClienteIMPRESTIMO.Click += new System.EventHandler(this.btnLocalizarClienteIMPRESTIMO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Situação de Clientes\r\nImprestimo";
            // 
            // frmconsultadepagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 537);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmconsultadepagamento";
            this.Text = "frmconsultadepagamento";
            this.Load += new System.EventHandler(this.frmconsultadepagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.Tarefas.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOSIMPRESTIMO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDADOS;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip Tarefas;
        private System.Windows.Forms.ToolStripMenuItem FAZERPAGAMENTO;
        private System.Windows.Forms.Button btnLocalizarCliente;
        private System.Windows.Forms.ComboBox ComboNomeCliente;
        private System.Windows.Forms.Button BtnPesquisarData;
        private System.Windows.Forms.DateTimePicker dataPesquisar;
        private System.Windows.Forms.ToolStripMenuItem mensagemWatsappToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtnlocalPelaDataImprestimo;
        private System.Windows.Forms.DateTimePicker dataPesquisarImprestimo;
        private System.Windows.Forms.ComboBox ComboNomeClienteiMPRESTIMO;
        private System.Windows.Forms.Button btnLocalizarClienteIMPRESTIMO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVDADOSIMPRESTIMO;
        private System.Windows.Forms.ToolStripMenuItem fazerPagamentoImprestimoToolStripMenuItem;
    }
}