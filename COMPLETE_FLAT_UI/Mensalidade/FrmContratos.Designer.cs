namespace SoftwareGerenciador.Mensalidade
{
    partial class FrmContratos
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
            this.radioButtonContratosCANCELADO = new System.Windows.Forms.RadioButton();
            this.radioButtonContratosATIVO = new System.Windows.Forms.RadioButton();
            this.NomeClientetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbNumeroDeContratos = new System.Windows.Forms.Label();
            this.Tarefas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.Tarefas.SuspendLayout();
            this.SuspendLayout();
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
            this.DGVDADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDADOS.EnableHeadersVisualStyles = false;
            this.DGVDADOS.GridColor = System.Drawing.Color.White;
            this.DGVDADOS.Location = new System.Drawing.Point(0, 81);
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
            this.DGVDADOS.Size = new System.Drawing.Size(870, 376);
            this.DGVDADOS.TabIndex = 3;
            this.DGVDADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellContentClick);
            // 
            // radioButtonContratosCANCELADO
            // 
            this.radioButtonContratosCANCELADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonContratosCANCELADO.AutoSize = true;
            this.radioButtonContratosCANCELADO.ForeColor = System.Drawing.Color.White;
            this.radioButtonContratosCANCELADO.Location = new System.Drawing.Point(673, 51);
            this.radioButtonContratosCANCELADO.Name = "radioButtonContratosCANCELADO";
            this.radioButtonContratosCANCELADO.Size = new System.Drawing.Size(166, 17);
            this.radioButtonContratosCANCELADO.TabIndex = 32;
            this.radioButtonContratosCANCELADO.TabStop = true;
            this.radioButtonContratosCANCELADO.Text = "Clientes  contrato Cancelados";
            this.radioButtonContratosCANCELADO.UseVisualStyleBackColor = true;
            this.radioButtonContratosCANCELADO.CheckedChanged += new System.EventHandler(this.radioButtonContratosCANCELADO_CheckedChanged);
            // 
            // radioButtonContratosATIVO
            // 
            this.radioButtonContratosATIVO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonContratosATIVO.AutoSize = true;
            this.radioButtonContratosATIVO.ForeColor = System.Drawing.Color.White;
            this.radioButtonContratosATIVO.Location = new System.Drawing.Point(673, 31);
            this.radioButtonContratosATIVO.Name = "radioButtonContratosATIVO";
            this.radioButtonContratosATIVO.Size = new System.Drawing.Size(136, 17);
            this.radioButtonContratosATIVO.TabIndex = 31;
            this.radioButtonContratosATIVO.TabStop = true;
            this.radioButtonContratosATIVO.Text = "Clientes contrato Ativos";
            this.radioButtonContratosATIVO.UseVisualStyleBackColor = true;
            this.radioButtonContratosATIVO.CheckedChanged += new System.EventHandler(this.radioButtonContratosATIVO_CheckedChanged);
            // 
            // NomeClientetextBox
            // 
            this.NomeClientetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeClientetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomeClientetextBox.Location = new System.Drawing.Point(434, 38);
            this.NomeClientetextBox.Name = "NomeClientetextBox";
            this.NomeClientetextBox.Size = new System.Drawing.Size(231, 26);
            this.NomeClientetextBox.TabIndex = 30;
            this.NomeClientetextBox.TextChanged += new System.EventHandler(this.NomeClientetextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Consultas pelo Nome do Cliente";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(7, 16);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 34;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lista de contratos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbNumeroDeContratos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.NomeClientetextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonContratosATIVO);
            this.panel1.Controls.Add(this.radioButtonContratosCANCELADO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 81);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Qtd de contratos:";
            // 
            // LbNumeroDeContratos
            // 
            this.LbNumeroDeContratos.AutoSize = true;
            this.LbNumeroDeContratos.BackColor = System.Drawing.Color.Transparent;
            this.LbNumeroDeContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbNumeroDeContratos.ForeColor = System.Drawing.Color.White;
            this.LbNumeroDeContratos.Location = new System.Drawing.Point(336, 28);
            this.LbNumeroDeContratos.Name = "LbNumeroDeContratos";
            this.LbNumeroDeContratos.Size = new System.Drawing.Size(51, 20);
            this.LbNumeroDeContratos.TabIndex = 35;
            this.LbNumeroDeContratos.Text = "label2";
            // 
            // Tarefas
            // 
            this.Tarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Tarefas.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Tarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editar,
            this.criarPagamentoToolStripMenuItem});
            this.Tarefas.Name = "Tarefas";
            this.Tarefas.Size = new System.Drawing.Size(378, 64);
            // 
            // Editar
            // 
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Image = global::SoftwareGerenciador.Properties.Resources.Planes;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(377, 30);
            this.Editar.Text = "Detalhamento de contrato";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // criarPagamentoToolStripMenuItem
            // 
            this.criarPagamentoToolStripMenuItem.Name = "criarPagamentoToolStripMenuItem";
            this.criarPagamentoToolStripMenuItem.Size = new System.Drawing.Size(377, 30);
            // 
            // FrmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.DGVDADOS);
            this.Controls.Add(this.panel1);
            this.Name = "FrmContratos";
            this.Text = "FrmContratos";
            this.Load += new System.EventHandler(this.FrmContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tarefas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDADOS;
        private System.Windows.Forms.RadioButton radioButtonContratosCANCELADO;
        private System.Windows.Forms.RadioButton radioButtonContratosATIVO;
        private System.Windows.Forms.TextBox NomeClientetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip Tarefas;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem criarPagamentoToolStripMenuItem;
        private System.Windows.Forms.Label LbNumeroDeContratos;
        private System.Windows.Forms.Label label2;
    }
}