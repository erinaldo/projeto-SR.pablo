namespace SoftwareGerenciador.ContasApagar
{
    partial class frmcontaApagar
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label12;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnSalvarContasPagar = new System.Windows.Forms.Button();
            this.Combocategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.txtvalorDocumento = new System.Windows.Forms.TextBox();
            this.dataEmissao = new System.Windows.Forms.DateTimePicker();
            this.comboFornecedor = new System.Windows.Forms.ComboBox();
            this.dataAlerta = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkAtivaDesativa = new System.Windows.Forms.CheckBox();
            this.panelPagamento = new System.Windows.Forms.Panel();
            this.BtnBaixaPagamento = new System.Windows.Forms.Button();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.BtnAlterar = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(398, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 17);
            label4.TabIndex = 32;
            label4.Text = "Descrição *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(294, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 17);
            label3.TabIndex = 30;
            label3.Text = "Categoria da conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(12, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 17);
            label1.TabIndex = 29;
            label1.Text = "Data de vencimento *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(12, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(161, 17);
            label2.TabIndex = 19;
            label2.Text = "Numero do documento *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label7.Location = new System.Drawing.Point(12, 155);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 17);
            label7.TabIndex = 41;
            label7.Text = "Data do alerta *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label8.Location = new System.Drawing.Point(204, 155);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 17);
            label8.TabIndex = 42;
            label8.Text = "Valor ( R$ )";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(12, 58);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(140, 17);
            label9.TabIndex = 115;
            label9.Text = "Fornecedor da conta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label10.Location = new System.Drawing.Point(207, 109);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(124, 17);
            label10.TabIndex = 118;
            label10.Text = "Data de Emissão *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label11.Location = new System.Drawing.Point(575, 58);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(57, 17);
            label11.TabIndex = 119;
            label11.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.Location = new System.Drawing.Point(31, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(134, 17);
            label5.TabIndex = 43;
            label5.Text = "Data do Pagamento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label12.Location = new System.Drawing.Point(223, 28);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(117, 17);
            label12.TabIndex = 44;
            label12.Text = "Valor pago ( R$ )";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.txtID);
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(870, 38);
            this.BarraTitulo.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(318, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 23);
            this.txtID.TabIndex = 44;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gerar Contas á Pagar";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(832, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnSalvarContasPagar
            // 
            this.BtnSalvarContasPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvarContasPagar.FlatAppearance.BorderSize = 0;
            this.BtnSalvarContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnSalvarContasPagar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarContasPagar.Location = new System.Drawing.Point(686, 204);
            this.BtnSalvarContasPagar.Name = "BtnSalvarContasPagar";
            this.BtnSalvarContasPagar.Size = new System.Drawing.Size(155, 52);
            this.BtnSalvarContasPagar.TabIndex = 15;
            this.BtnSalvarContasPagar.Text = "Salvar conta";
            this.BtnSalvarContasPagar.UseVisualStyleBackColor = false;
            this.BtnSalvarContasPagar.Click += new System.EventHandler(this.BtnSalvarContasPagar_Click);
            // 
            // Combocategoria
            // 
            this.Combocategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Combocategoria.FormattingEnabled = true;
            this.Combocategoria.Location = new System.Drawing.Point(297, 78);
            this.Combocategoria.Name = "Combocategoria";
            this.Combocategoria.Size = new System.Drawing.Size(277, 28);
            this.Combocategoria.TabIndex = 37;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(401, 129);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(454, 69);
            this.txtDescricao.TabIndex = 31;
            // 
            // dataVencimento
            // 
            this.dataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVencimento.Location = new System.Drawing.Point(12, 129);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(190, 23);
            this.dataVencimento.TabIndex = 28;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(15, 32);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(190, 23);
            this.txtNumeroDocumento.TabIndex = 20;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelDados
            // 
            this.panelDados.BackColor = System.Drawing.Color.White;
            this.panelDados.Controls.Add(this.BtnAlterar);
            this.panelDados.Controls.Add(label11);
            this.panelDados.Controls.Add(this.BtnSalvarContasPagar);
            this.panelDados.Controls.Add(label8);
            this.panelDados.Controls.Add(this.comboUsuario);
            this.panelDados.Controls.Add(this.txtvalorDocumento);
            this.panelDados.Controls.Add(label4);
            this.panelDados.Controls.Add(label10);
            this.panelDados.Controls.Add(this.dataEmissao);
            this.panelDados.Controls.Add(this.txtDescricao);
            this.panelDados.Controls.Add(this.comboFornecedor);
            this.panelDados.Controls.Add(label9);
            this.panelDados.Controls.Add(label3);
            this.panelDados.Controls.Add(this.Combocategoria);
            this.panelDados.Controls.Add(label2);
            this.panelDados.Controls.Add(this.txtNumeroDocumento);
            this.panelDados.Controls.Add(label1);
            this.panelDados.Controls.Add(this.dataVencimento);
            this.panelDados.Controls.Add(label7);
            this.panelDados.Controls.Add(this.dataAlerta);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDados.Location = new System.Drawing.Point(0, 38);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(870, 355);
            this.panelDados.TabIndex = 38;
            // 
            // comboUsuario
            // 
            this.comboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(578, 78);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(277, 28);
            this.comboUsuario.TabIndex = 120;
            // 
            // txtvalorDocumento
            // 
            this.txtvalorDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtvalorDocumento.Location = new System.Drawing.Point(207, 175);
            this.txtvalorDocumento.Name = "txtvalorDocumento";
            this.txtvalorDocumento.Size = new System.Drawing.Size(190, 23);
            this.txtvalorDocumento.TabIndex = 43;
            this.txtvalorDocumento.Text = "0,00";
            this.txtvalorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvalorDocumento.TextChanged += new System.EventHandler(this.txtvalorDocumento_TextChanged);
            // 
            // dataEmissao
            // 
            this.dataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEmissao.Location = new System.Drawing.Point(207, 129);
            this.dataEmissao.Name = "dataEmissao";
            this.dataEmissao.Size = new System.Drawing.Size(190, 23);
            this.dataEmissao.TabIndex = 117;
            // 
            // comboFornecedor
            // 
            this.comboFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboFornecedor.FormattingEnabled = true;
            this.comboFornecedor.Location = new System.Drawing.Point(15, 78);
            this.comboFornecedor.Name = "comboFornecedor";
            this.comboFornecedor.Size = new System.Drawing.Size(277, 28);
            this.comboFornecedor.TabIndex = 116;
            // 
            // dataAlerta
            // 
            this.dataAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataAlerta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAlerta.Location = new System.Drawing.Point(12, 175);
            this.dataAlerta.Name = "dataAlerta";
            this.dataAlerta.Size = new System.Drawing.Size(190, 23);
            this.dataAlerta.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkAtivaDesativa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 33);
            this.panel2.TabIndex = 41;
            // 
            // checkAtivaDesativa
            // 
            this.checkAtivaDesativa.AutoSize = true;
            this.checkAtivaDesativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkAtivaDesativa.Location = new System.Drawing.Point(27, 6);
            this.checkAtivaDesativa.Name = "checkAtivaDesativa";
            this.checkAtivaDesativa.Size = new System.Drawing.Size(165, 22);
            this.checkAtivaDesativa.TabIndex = 0;
            this.checkAtivaDesativa.Text = "Ativar ( Pagar conta )";
            this.checkAtivaDesativa.UseVisualStyleBackColor = true;
            this.checkAtivaDesativa.CheckedChanged += new System.EventHandler(this.checkAtivaDesativa_CheckedChanged);
            // 
            // panelPagamento
            // 
            this.panelPagamento.BackColor = System.Drawing.Color.White;
            this.panelPagamento.Controls.Add(this.BtnBaixaPagamento);
            this.panelPagamento.Controls.Add(label12);
            this.panelPagamento.Controls.Add(this.txtValorPagamento);
            this.panelPagamento.Controls.Add(label5);
            this.panelPagamento.Controls.Add(this.dataPagamento);
            this.panelPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPagamento.Location = new System.Drawing.Point(0, 426);
            this.panelPagamento.Name = "panelPagamento";
            this.panelPagamento.Size = new System.Drawing.Size(870, 150);
            this.panelPagamento.TabIndex = 42;
            // 
            // BtnBaixaPagamento
            // 
            this.BtnBaixaPagamento.BackColor = System.Drawing.Color.Green;
            this.BtnBaixaPagamento.FlatAppearance.BorderSize = 0;
            this.BtnBaixaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaixaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnBaixaPagamento.ForeColor = System.Drawing.Color.White;
            this.BtnBaixaPagamento.Location = new System.Drawing.Point(686, 73);
            this.BtnBaixaPagamento.Name = "BtnBaixaPagamento";
            this.BtnBaixaPagamento.Size = new System.Drawing.Size(155, 52);
            this.BtnBaixaPagamento.TabIndex = 46;
            this.BtnBaixaPagamento.Text = "Da baixa no financeiro";
            this.BtnBaixaPagamento.UseVisualStyleBackColor = false;
            this.BtnBaixaPagamento.Click += new System.EventHandler(this.BtnBaixaPagamento_Click);
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValorPagamento.Location = new System.Drawing.Point(226, 48);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(190, 23);
            this.txtValorPagamento.TabIndex = 45;
            this.txtValorPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPagamento.TextChanged += new System.EventHandler(this.txtValorPagamento_TextChanged);
            // 
            // dataPagamento
            // 
            this.dataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPagamento.Location = new System.Drawing.Point(31, 48);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(190, 23);
            this.dataPagamento.TabIndex = 42;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnAlterar.ForeColor = System.Drawing.Color.White;
            this.BtnAlterar.Location = new System.Drawing.Point(686, 262);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(155, 52);
            this.BtnAlterar.TabIndex = 121;
            this.BtnAlterar.Text = "Alterar conta";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // frmcontaApagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 576);
            this.Controls.Add(this.panelPagamento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.BarraTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcontaApagar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta á pagar";
            this.Load += new System.EventHandler(this.frmcontaApagar_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPagamento.ResumeLayout(false);
            this.panelPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button BtnSalvarContasPagar;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkAtivaDesativa;
        private System.Windows.Forms.Panel panelPagamento;
        public System.Windows.Forms.Button BtnBaixaPagamento;
        public System.Windows.Forms.ComboBox Combocategoria;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.DateTimePicker dataVencimento;
        public System.Windows.Forms.TextBox txtNumeroDocumento;
        public System.Windows.Forms.TextBox txtvalorDocumento;
        public System.Windows.Forms.DateTimePicker dataAlerta;
        public System.Windows.Forms.ComboBox comboFornecedor;
        public System.Windows.Forms.ComboBox comboUsuario;
        public System.Windows.Forms.DateTimePicker dataEmissao;
        public System.Windows.Forms.TextBox txtValorPagamento;
        public System.Windows.Forms.DateTimePicker dataPagamento;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button BtnAlterar;
    }
}