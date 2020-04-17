namespace SoftwareGerenciador.Agenda
{
    partial class FrmAgendamentoVeicular
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
            this.DGVDADOS = new System.Windows.Forms.DataGridView();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataPesquisar = new System.Windows.Forms.DateTimePicker();
            this.BtnPesquisarData = new System.Windows.Forms.Button();
            this.radioINSTALCAO = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TarefasAgendados = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarAgendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAZERPAGAMENTO = new System.Windows.Forms.ToolStripMenuItem();
            this.cONCLUIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemWatsappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instalaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TarefasManutencao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemGerarAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsappWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TarefasAgendados.SuspendLayout();
            this.TarefasManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDADOS
            // 
            this.DGVDADOS.AllowUserToAddRows = false;
            this.DGVDADOS.AllowUserToDeleteRows = false;
            this.DGVDADOS.AllowUserToResizeColumns = false;
            this.DGVDADOS.AllowUserToResizeRows = false;
            this.DGVDADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDADOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDADOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDADOS.EnableHeadersVisualStyles = false;
            this.DGVDADOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.DGVDADOS.Location = new System.Drawing.Point(0, 91);
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
            this.DGVDADOS.Size = new System.Drawing.Size(871, 385);
            this.DGVDADOS.TabIndex = 4;
            this.DGVDADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellContentClick);
            this.DGVDADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDADOS_CellFormatting);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BarraTitulo.Controls.Add(this.groupBox1);
            this.BarraTitulo.Controls.Add(this.radioINSTALCAO);
            this.BarraTitulo.Controls.Add(this.btnNuevo);
            this.BarraTitulo.Controls.Add(this.Link);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(871, 91);
            this.BarraTitulo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataPesquisar);
            this.groupBox1.Controls.Add(this.BtnPesquisarData);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(297, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agedamento";
            // 
            // dataPesquisar
            // 
            this.dataPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataPesquisar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPesquisar.Location = new System.Drawing.Point(18, 25);
            this.dataPesquisar.Name = "dataPesquisar";
            this.dataPesquisar.Size = new System.Drawing.Size(129, 26);
            this.dataPesquisar.TabIndex = 26;
            // 
            // BtnPesquisarData
            // 
            this.BtnPesquisarData.BackColor = System.Drawing.Color.White;
            this.BtnPesquisarData.BackgroundImage = global::SoftwareGerenciador.Properties.Resources.if_miscellaneous_04_809403;
            this.BtnPesquisarData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisarData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnPesquisarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarData.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisarData.Location = new System.Drawing.Point(153, 25);
            this.BtnPesquisarData.Name = "BtnPesquisarData";
            this.BtnPesquisarData.Size = new System.Drawing.Size(41, 26);
            this.BtnPesquisarData.TabIndex = 27;
            this.BtnPesquisarData.UseVisualStyleBackColor = false;
            this.BtnPesquisarData.Click += new System.EventHandler(this.BtnPesquisarData_Click);
            // 
            // radioINSTALCAO
            // 
            this.radioINSTALCAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioINSTALCAO.AutoSize = true;
            this.radioINSTALCAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioINSTALCAO.ForeColor = System.Drawing.Color.White;
            this.radioINSTALCAO.Location = new System.Drawing.Point(527, 33);
            this.radioINSTALCAO.Name = "radioINSTALCAO";
            this.radioINSTALCAO.Size = new System.Drawing.Size(109, 24);
            this.radioINSTALCAO.TabIndex = 25;
            this.radioINSTALCAO.TabStop = true;
            this.radioINSTALCAO.Text = "Agendados";
            this.radioINSTALCAO.UseVisualStyleBackColor = true;
            this.radioINSTALCAO.CheckedChanged += new System.EventHandler(this.radioINSTALCAO_CheckedChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(73, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(218, 42);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Novo Agendamento";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(12, 40);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(55, 13);
            this.Link.TabIndex = 20;
            this.Link.TabStop = true;
            this.Link.Text = "linkLabel1";
            this.Link.Visible = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(9, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TarefasAgendados
            // 
            this.TarefasAgendados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.TarefasAgendados.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TarefasAgendados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarAgendamentoToolStripMenuItem,
            this.FAZERPAGAMENTO,
            this.criarPagamentoToolStripMenuItem,
            this.mensagemWatsappToolStripMenuItem});
            this.TarefasAgendados.Name = "Tarefas";
            this.TarefasAgendados.Size = new System.Drawing.Size(314, 124);
            this.TarefasAgendados.Opening += new System.ComponentModel.CancelEventHandler(this.TarefasAgendados_Opening);
            // 
            // editarAgendamentoToolStripMenuItem
            // 
            this.editarAgendamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarAgendamentoToolStripMenuItem.Name = "editarAgendamentoToolStripMenuItem";
            this.editarAgendamentoToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.editarAgendamentoToolStripMenuItem.Text = "Editar Agendamento";
            this.editarAgendamentoToolStripMenuItem.Click += new System.EventHandler(this.editarAgendamentoToolStripMenuItem_Click);
            // 
            // FAZERPAGAMENTO
            // 
            this.FAZERPAGAMENTO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONCLUIDOToolStripMenuItem,
            this.cANCELADAToolStripMenuItem});
            this.FAZERPAGAMENTO.ForeColor = System.Drawing.Color.White;
            this.FAZERPAGAMENTO.Name = "FAZERPAGAMENTO";
            this.FAZERPAGAMENTO.Size = new System.Drawing.Size(313, 30);
            this.FAZERPAGAMENTO.Text = "Situação";
            // 
            // cONCLUIDOToolStripMenuItem
            // 
            this.cONCLUIDOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.cONCLUIDOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cONCLUIDOToolStripMenuItem.Name = "cONCLUIDOToolStripMenuItem";
            this.cONCLUIDOToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.cONCLUIDOToolStripMenuItem.Text = "CONCLUIDO";
            this.cONCLUIDOToolStripMenuItem.Click += new System.EventHandler(this.cONCLUIDOToolStripMenuItem_Click);
            // 
            // cANCELADAToolStripMenuItem
            // 
            this.cANCELADAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.cANCELADAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cANCELADAToolStripMenuItem.Name = "cANCELADAToolStripMenuItem";
            this.cANCELADAToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.cANCELADAToolStripMenuItem.Text = "CANCELADA";
            this.cANCELADAToolStripMenuItem.Click += new System.EventHandler(this.cANCELADAToolStripMenuItem_Click);
            // 
            // criarPagamentoToolStripMenuItem
            // 
            this.criarPagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.instalaçãoToolStripMenuItem});
            this.criarPagamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.criarPagamentoToolStripMenuItem.Name = "criarPagamentoToolStripMenuItem";
            this.criarPagamentoToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.criarPagamentoToolStripMenuItem.Text = "Envio E-mail";
            this.criarPagamentoToolStripMenuItem.Click += new System.EventHandler(this.criarPagamentoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.manutençãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.manutençãoToolStripMenuItem.Text = "Lenbrar Manutenção";
            this.manutençãoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // instalaçãoToolStripMenuItem
            // 
            this.instalaçãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.instalaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.instalaçãoToolStripMenuItem.Name = "instalaçãoToolStripMenuItem";
            this.instalaçãoToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.instalaçãoToolStripMenuItem.Text = "Lenbrar Instalação";
            this.instalaçãoToolStripMenuItem.Click += new System.EventHandler(this.instalaçãoToolStripMenuItem_Click);
            // 
            // mensagemWatsappToolStripMenuItem
            // 
            this.mensagemWatsappToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem1,
            this.instalaçãoToolStripMenuItem1});
            this.mensagemWatsappToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mensagemWatsappToolStripMenuItem.Name = "mensagemWatsappToolStripMenuItem";
            this.mensagemWatsappToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.mensagemWatsappToolStripMenuItem.Text = "whatsapp web";
            this.mensagemWatsappToolStripMenuItem.Click += new System.EventHandler(this.mensagemWatsappToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.manutençãoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(313, 30);
            this.manutençãoToolStripMenuItem1.Text = "Lenbrar Manutenção";
            this.manutençãoToolStripMenuItem1.Click += new System.EventHandler(this.manutençãoToolStripMenuItem1_Click);
            // 
            // instalaçãoToolStripMenuItem1
            // 
            this.instalaçãoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.instalaçãoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.instalaçãoToolStripMenuItem1.Name = "instalaçãoToolStripMenuItem1";
            this.instalaçãoToolStripMenuItem1.Size = new System.Drawing.Size(313, 30);
            this.instalaçãoToolStripMenuItem1.Text = "Lenbrar Instalação";
            this.instalaçãoToolStripMenuItem1.Click += new System.EventHandler(this.instalaçãoToolStripMenuItem1_Click);
            // 
            // TarefasManutencao
            // 
            this.TarefasManutencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.TarefasManutencao.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TarefasManutencao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGerarAgendamento,
            this.whatsappWebToolStripMenuItem});
            this.TarefasManutencao.Name = "Tarefas";
            this.TarefasManutencao.Size = new System.Drawing.Size(490, 64);
            // 
            // toolStripMenuItemGerarAgendamento
            // 
            this.toolStripMenuItemGerarAgendamento.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemGerarAgendamento.Name = "toolStripMenuItemGerarAgendamento";
            this.toolStripMenuItemGerarAgendamento.Size = new System.Drawing.Size(489, 30);
            this.toolStripMenuItemGerarAgendamento.Text = "Agendar solicitação";
            this.toolStripMenuItemGerarAgendamento.Click += new System.EventHandler(this.toolStripMenuItemGerarAgendamento_Click);
            // 
            // whatsappWebToolStripMenuItem
            // 
            this.whatsappWebToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.whatsappWebToolStripMenuItem.Name = "whatsappWebToolStripMenuItem";
            this.whatsappWebToolStripMenuItem.Size = new System.Drawing.Size(489, 30);
            this.whatsappWebToolStripMenuItem.Text = "whatsapp web solicitar manutenção";
            this.whatsappWebToolStripMenuItem.Click += new System.EventHandler(this.whatsappWebToolStripMenuItem_Click);
            // 
            // FrmAgendamentoVeicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(871, 476);
            this.Controls.Add(this.DGVDADOS);
            this.Controls.Add(this.BarraTitulo);
            this.Name = "FrmAgendamentoVeicular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmAgendamentoVeicular";
            this.Load += new System.EventHandler(this.FrmAgendamentoVeicular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TarefasAgendados.ResumeLayout(false);
            this.TarefasManutencao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDADOS;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ContextMenuStrip TarefasAgendados;
        private System.Windows.Forms.ToolStripMenuItem FAZERPAGAMENTO;
        private System.Windows.Forms.ToolStripMenuItem criarPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemWatsappToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.ToolStripMenuItem cONCLUIDOToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RadioButton radioINSTALCAO;
        private System.Windows.Forms.ToolStripMenuItem editarAgendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instalaçãoToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip TarefasManutencao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGerarAgendamento;
        private System.Windows.Forms.ToolStripMenuItem cANCELADAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsappWebToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dataPesquisar;
        private System.Windows.Forms.Button BtnPesquisarData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}