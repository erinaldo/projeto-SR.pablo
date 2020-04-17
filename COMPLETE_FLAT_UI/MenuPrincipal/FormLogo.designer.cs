namespace SoftwareGerenciador
{
    partial class FormLogo
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
            this.panelAgendamento = new System.Windows.Forms.Panel();
            this.LbMes = new System.Windows.Forms.Label();
            this.LbQuantidadeAgedamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPagamento = new System.Windows.Forms.Panel();
            this.LbquantidadeClienteMensalidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbQuantidadeClientes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbFornecedores = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAgendamento.SuspendLayout();
            this.panelPagamento.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgendamento
            // 
            this.panelAgendamento.BackColor = System.Drawing.Color.OliveDrab;
            this.panelAgendamento.Controls.Add(this.LbMes);
            this.panelAgendamento.Controls.Add(this.LbQuantidadeAgedamento);
            this.panelAgendamento.Controls.Add(this.label2);
            this.panelAgendamento.Controls.Add(this.label1);
            this.panelAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelAgendamento.Location = new System.Drawing.Point(524, 174);
            this.panelAgendamento.Name = "panelAgendamento";
            this.panelAgendamento.Size = new System.Drawing.Size(253, 129);
            this.panelAgendamento.TabIndex = 1;
            this.panelAgendamento.Click += new System.EventHandler(this.panelAgendamento_Click);
            // 
            // LbMes
            // 
            this.LbMes.AutoSize = true;
            this.LbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMes.ForeColor = System.Drawing.Color.Red;
            this.LbMes.Location = new System.Drawing.Point(62, 20);
            this.LbMes.Name = "LbMes";
            this.LbMes.Size = new System.Drawing.Size(120, 37);
            this.LbMes.TabIndex = 5;
            this.LbMes.Text = "janeiro";
            // 
            // LbQuantidadeAgedamento
            // 
            this.LbQuantidadeAgedamento.AutoSize = true;
            this.LbQuantidadeAgedamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbQuantidadeAgedamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbQuantidadeAgedamento.ForeColor = System.Drawing.Color.Crimson;
            this.LbQuantidadeAgedamento.Location = new System.Drawing.Point(0, 104);
            this.LbQuantidadeAgedamento.Name = "LbQuantidadeAgedamento";
            this.LbQuantidadeAgedamento.Size = new System.Drawing.Size(125, 25);
            this.LbQuantidadeAgedamento.TabIndex = 4;
            this.LbQuantidadeAgedamento.Text = "08 : Veiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mês:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agendamentos";
            // 
            // panelPagamento
            // 
            this.panelPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPagamento.BackColor = System.Drawing.Color.ForestGreen;
            this.panelPagamento.Controls.Add(this.LbquantidadeClienteMensalidade);
            this.panelPagamento.Controls.Add(this.label5);
            this.panelPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelPagamento.Location = new System.Drawing.Point(619, 12);
            this.panelPagamento.Name = "panelPagamento";
            this.panelPagamento.Size = new System.Drawing.Size(253, 129);
            this.panelPagamento.TabIndex = 2;
            this.panelPagamento.Click += new System.EventHandler(this.panelPagamento_Click);
            // 
            // LbquantidadeClienteMensalidade
            // 
            this.LbquantidadeClienteMensalidade.AutoSize = true;
            this.LbquantidadeClienteMensalidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbquantidadeClienteMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbquantidadeClienteMensalidade.ForeColor = System.Drawing.Color.Crimson;
            this.LbquantidadeClienteMensalidade.Location = new System.Drawing.Point(0, 104);
            this.LbquantidadeClienteMensalidade.Name = "LbquantidadeClienteMensalidade";
            this.LbquantidadeClienteMensalidade.Size = new System.Drawing.Size(121, 25);
            this.LbquantidadeClienteMensalidade.TabIndex = 4;
            this.LbquantidadeClienteMensalidade.Text = "05 : Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mensalidades para  \r\npagamentos no dia de hoje";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.Controls.Add(this.LbQuantidadeClientes);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel3.Location = new System.Drawing.Point(6, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 129);
            this.panel3.TabIndex = 6;
            // 
            // LbQuantidadeClientes
            // 
            this.LbQuantidadeClientes.AutoSize = true;
            this.LbQuantidadeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbQuantidadeClientes.ForeColor = System.Drawing.Color.White;
            this.LbQuantidadeClientes.Location = new System.Drawing.Point(0, 72);
            this.LbQuantidadeClientes.Name = "LbQuantidadeClientes";
            this.LbQuantidadeClientes.Size = new System.Drawing.Size(121, 25);
            this.LbQuantidadeClientes.TabIndex = 4;
            this.LbQuantidadeClientes.Text = "05 : Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total de Clientes";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.LbFornecedores);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel4.Location = new System.Drawing.Point(265, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 129);
            this.panel4.TabIndex = 8;
            // 
            // LbFornecedores
            // 
            this.LbFornecedores.AutoSize = true;
            this.LbFornecedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbFornecedores.ForeColor = System.Drawing.Color.White;
            this.LbFornecedores.Location = new System.Drawing.Point(0, 104);
            this.LbFornecedores.Name = "LbFornecedores";
            this.LbFornecedores.Size = new System.Drawing.Size(171, 25);
            this.LbFornecedores.TabIndex = 4;
            this.LbFornecedores.Text = "05 : Fornecedores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total de Fornecedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Location = new System.Drawing.Point(6, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 29);
            this.panel1.TabIndex = 10;
            // 
            // FormLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelPagamento);
            this.Controls.Add(this.panelAgendamento);
            this.Name = "FormLogo";
            this.Text = "FormLogo";
            this.Load += new System.EventHandler(this.FormLogo_Load);
            this.panelAgendamento.ResumeLayout(false);
            this.panelAgendamento.PerformLayout();
            this.panelPagamento.ResumeLayout(false);
            this.panelPagamento.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAgendamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbQuantidadeAgedamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPagamento;
        private System.Windows.Forms.Label LbquantidadeClienteMensalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbQuantidadeClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbFornecedores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbMes;
        private System.Windows.Forms.Panel panel1;
    }
}