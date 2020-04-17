namespace SoftwareGerenciador.ContasApagar
{
    partial class frmListaContasApagar
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButtonContratosCANCELADO = new System.Windows.Forms.RadioButton();
            this.radioButtonContratosATIVO = new System.Windows.Forms.RadioButton();
            this.btnNovoContaApagar = new System.Windows.Forms.Button();
            this.DGVDADOS = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DataInicial = new System.Windows.Forms.DateTimePicker();
            this.DataFinal = new System.Windows.Forms.DateTimePicker();
            this.Tarefas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorEditaConta = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.Tarefas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(391, 7);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(258, 24);
            label7.TabIndex = 43;
            label7.Text = "Consulta por data de emissão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(508, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 24);
            label1.TabIndex = 45;
            label1.Text = "A";
            // 
            // radioButtonContratosCANCELADO
            // 
            this.radioButtonContratosCANCELADO.AutoSize = true;
            this.radioButtonContratosCANCELADO.Checked = true;
            this.radioButtonContratosCANCELADO.ForeColor = System.Drawing.Color.White;
            this.radioButtonContratosCANCELADO.Location = new System.Drawing.Point(690, 51);
            this.radioButtonContratosCANCELADO.Name = "radioButtonContratosCANCELADO";
            this.radioButtonContratosCANCELADO.Size = new System.Drawing.Size(109, 17);
            this.radioButtonContratosCANCELADO.TabIndex = 40;
            this.radioButtonContratosCANCELADO.TabStop = true;
            this.radioButtonContratosCANCELADO.Text = "Contas não pagar";
            this.radioButtonContratosCANCELADO.UseVisualStyleBackColor = true;
            // 
            // radioButtonContratosATIVO
            // 
            this.radioButtonContratosATIVO.AutoSize = true;
            this.radioButtonContratosATIVO.ForeColor = System.Drawing.Color.White;
            this.radioButtonContratosATIVO.Location = new System.Drawing.Point(690, 33);
            this.radioButtonContratosATIVO.Name = "radioButtonContratosATIVO";
            this.radioButtonContratosATIVO.Size = new System.Drawing.Size(91, 17);
            this.radioButtonContratosATIVO.TabIndex = 39;
            this.radioButtonContratosATIVO.Text = "Contas Pagas";
            this.radioButtonContratosATIVO.UseVisualStyleBackColor = true;
            this.radioButtonContratosATIVO.CheckedChanged += new System.EventHandler(this.radioButtonContratosATIVO_CheckedChanged);
            // 
            // btnNovoContaApagar
            // 
            this.btnNovoContaApagar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNovoContaApagar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovoContaApagar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNovoContaApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnNovoContaApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNovoContaApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoContaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoContaApagar.ForeColor = System.Drawing.Color.Silver;
            this.btnNovoContaApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoContaApagar.Location = new System.Drawing.Point(111, 19);
            this.btnNovoContaApagar.Name = "btnNovoContaApagar";
            this.btnNovoContaApagar.Size = new System.Drawing.Size(238, 42);
            this.btnNovoContaApagar.TabIndex = 36;
            this.btnNovoContaApagar.Text = "Nova conta á pagar";
            this.btnNovoContaApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoContaApagar.UseVisualStyleBackColor = false;
            this.btnNovoContaApagar.Click += new System.EventHandler(this.btnNovoContaApagar_Click);
            // 
            // DGVDADOS
            // 
            this.DGVDADOS.AllowUserToAddRows = false;
            this.DGVDADOS.AllowUserToDeleteRows = false;
            this.DGVDADOS.AllowUserToResizeColumns = false;
            this.DGVDADOS.AllowUserToResizeRows = false;
            this.DGVDADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.DGVDADOS.Location = new System.Drawing.Point(0, 80);
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
            this.DGVDADOS.Size = new System.Drawing.Size(870, 377);
            this.DGVDADOS.TabIndex = 34;
            this.DGVDADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellContentClick);
            this.DGVDADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDADOS_CellFormatting);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(12, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 35;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DataInicial
            // 
            this.DataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicial.Location = new System.Drawing.Point(359, 38);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(147, 29);
            this.DataInicial.TabIndex = 42;
            this.DataInicial.ValueChanged += new System.EventHandler(this.DataInicial_ValueChanged);
            // 
            // DataFinal
            // 
            this.DataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFinal.Location = new System.Drawing.Point(537, 38);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(147, 29);
            this.DataFinal.TabIndex = 44;
            this.DataFinal.ValueChanged += new System.EventHandler(this.DataFinal_ValueChanged);
            // 
            // Tarefas
            // 
            this.Tarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Tarefas.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Tarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparatorEditaConta});
            this.Tarefas.Name = "Tarefas";
            this.Tarefas.Size = new System.Drawing.Size(223, 40);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 30);
            this.toolStripMenuItem1.Text = "Editar Conta";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparatorEditaConta
            // 
            this.toolStripSeparatorEditaConta.Name = "toolStripSeparatorEditaConta";
            this.toolStripSeparatorEditaConta.Size = new System.Drawing.Size(219, 6);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNovoContaApagar);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.radioButtonContratosATIVO);
            this.panel1.Controls.Add(this.DataFinal);
            this.panel1.Controls.Add(this.radioButtonContratosCANCELADO);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.DataInicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 80);
            this.panel1.TabIndex = 47;
            // 
            // frmListaContasApagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.DGVDADOS);
            this.Controls.Add(this.panel1);
            this.Name = "frmListaContasApagar";
            this.Text = "frmListaContasApagar";
            this.Load += new System.EventHandler(this.frmListaContasApagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.Tarefas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonContratosCANCELADO;
        private System.Windows.Forms.RadioButton radioButtonContratosATIVO;
        private System.Windows.Forms.Button btnNovoContaApagar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DGVDADOS;
        private System.Windows.Forms.DateTimePicker DataInicial;
        private System.Windows.Forms.DateTimePicker DataFinal;
        private System.Windows.Forms.ContextMenuStrip Tarefas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEditaConta;
    }
}