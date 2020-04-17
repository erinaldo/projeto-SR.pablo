namespace SoftwareGerenciador.Mensalidade
{
    partial class FrmCancelamentoContrato
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
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.txtvalordaparcela = new System.Windows.Forms.TextBox();
            this.txtvalorparcelasvencidas = new System.Windows.Forms.TextBox();
            this.TxtPorcentagem = new System.Windows.Forms.TextBox();
            this.BtnFinalizarCancelamento = new System.Windows.Forms.Button();
            this.txtdescricaoreceita = new System.Windows.Forms.TextBox();
            this.combocategoriareceita = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQTDparcelasvencidas = new System.Windows.Forms.TextBox();
            this.TxtValorTotalAPagar = new System.Windows.Forms.TextBox();
            this.txtvalorreceita = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbNomeClienteTelaCancelamento = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iD_CLIENTELabel.Location = new System.Drawing.Point(20, 56);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(115, 17);
            iD_CLIENTELabel.TabIndex = 8;
            iD_CLIENTELabel.Text = "MOME CLIENTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label1.Location = new System.Drawing.Point(25, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(190, 29);
            label1.TabIndex = 13;
            label1.Text = "Valor da Parcela";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label2.Location = new System.Drawing.Point(27, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(363, 29);
            label2.TabIndex = 15;
            label2.Text = "Valor total de Parcelas Pedentes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label8.Location = new System.Drawing.Point(25, 234);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(168, 29);
            label8.TabIndex = 35;
            label8.Text = "Acrescentar %";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            label11.Location = new System.Drawing.Point(6, 26);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(360, 25);
            label11.TabIndex = 39;
            label11.Text = "Descrição para receita de cancelamento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            label12.Location = new System.Drawing.Point(6, 266);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(268, 25);
            label12.TabIndex = 40;
            label12.Text = "Categoria para cancelamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label3.Location = new System.Drawing.Point(18, 384);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(188, 29);
            label3.TabIndex = 17;
            label3.Text = "Total á ser pago";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(6, 325);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(458, 24);
            label14.TabIndex = 43;
            label14.Text = "R$ Da receita de cancelamento (Entrada no finaceiro)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label4.Location = new System.Drawing.Point(25, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(274, 29);
            label4.TabIndex = 38;
            label4.Text = "QTD Parcelas Pedentes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label5.Location = new System.Drawing.Point(27, 309);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 29);
            label5.TabIndex = 40;
            label5.Text = "Desconto %";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(988, 38);
            this.BarraTitulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cancelamento de contrato";
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
            // txtvalordaparcela
            // 
            this.txtvalordaparcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtvalordaparcela.Location = new System.Drawing.Point(21, 53);
            this.txtvalordaparcela.Name = "txtvalordaparcela";
            this.txtvalordaparcela.ReadOnly = true;
            this.txtvalordaparcela.Size = new System.Drawing.Size(371, 35);
            this.txtvalordaparcela.TabIndex = 12;
            // 
            // txtvalorparcelasvencidas
            // 
            this.txtvalorparcelasvencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtvalorparcelasvencidas.Location = new System.Drawing.Point(24, 122);
            this.txtvalorparcelasvencidas.Name = "txtvalorparcelasvencidas";
            this.txtvalorparcelasvencidas.ReadOnly = true;
            this.txtvalorparcelasvencidas.Size = new System.Drawing.Size(371, 35);
            this.txtvalorparcelasvencidas.TabIndex = 14;
            // 
            // TxtPorcentagem
            // 
            this.TxtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtPorcentagem.Location = new System.Drawing.Point(21, 268);
            this.TxtPorcentagem.Name = "TxtPorcentagem";
            this.TxtPorcentagem.Size = new System.Drawing.Size(371, 35);
            this.TxtPorcentagem.TabIndex = 34;
            this.TxtPorcentagem.Text = "0";
            this.TxtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPorcentagem.TextChanged += new System.EventHandler(this.TxtPorcentagem_TextChanged);
            // 
            // BtnFinalizarCancelamento
            // 
            this.BtnFinalizarCancelamento.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnFinalizarCancelamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnFinalizarCancelamento.FlatAppearance.BorderSize = 0;
            this.BtnFinalizarCancelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizarCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnFinalizarCancelamento.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizarCancelamento.Location = new System.Drawing.Point(0, 554);
            this.BtnFinalizarCancelamento.Name = "BtnFinalizarCancelamento";
            this.BtnFinalizarCancelamento.Size = new System.Drawing.Size(988, 46);
            this.BtnFinalizarCancelamento.TabIndex = 37;
            this.BtnFinalizarCancelamento.Text = "Confirmação de Cancelamento e Entrada em contas\r\n(receita)";
            this.BtnFinalizarCancelamento.UseVisualStyleBackColor = false;
            this.BtnFinalizarCancelamento.Click += new System.EventHandler(this.BtnFinalizarCancelamento_Click);
            // 
            // txtdescricaoreceita
            // 
            this.txtdescricaoreceita.Location = new System.Drawing.Point(9, 54);
            this.txtdescricaoreceita.Multiline = true;
            this.txtdescricaoreceita.Name = "txtdescricaoreceita";
            this.txtdescricaoreceita.Size = new System.Drawing.Size(440, 207);
            this.txtdescricaoreceita.TabIndex = 38;
            // 
            // combocategoriareceita
            // 
            this.combocategoriareceita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combocategoriareceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combocategoriareceita.FormattingEnabled = true;
            this.combocategoriareceita.Location = new System.Drawing.Point(11, 294);
            this.combocategoriareceita.Name = "combocategoriareceita";
            this.combocategoriareceita.Size = new System.Drawing.Size(440, 28);
            this.combocategoriareceita.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtQTDparcelasvencidas);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.TxtValorTotalAPagar);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtvalordaparcela);
            this.groupBox1.Controls.Add(this.txtvalorparcelasvencidas);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.TxtPorcentagem);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(55, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 464);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo do contrato";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDesconto.Location = new System.Drawing.Point(21, 343);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(371, 35);
            this.txtDesconto.TabIndex = 39;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // txtQTDparcelasvencidas
            // 
            this.txtQTDparcelasvencidas.BackColor = System.Drawing.Color.LightCoral;
            this.txtQTDparcelasvencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtQTDparcelasvencidas.Location = new System.Drawing.Point(21, 195);
            this.txtQTDparcelasvencidas.Name = "txtQTDparcelasvencidas";
            this.txtQTDparcelasvencidas.ReadOnly = true;
            this.txtQTDparcelasvencidas.Size = new System.Drawing.Size(371, 35);
            this.txtQTDparcelasvencidas.TabIndex = 37;
            // 
            // TxtValorTotalAPagar
            // 
            this.TxtValorTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtValorTotalAPagar.Location = new System.Drawing.Point(12, 418);
            this.TxtValorTotalAPagar.Name = "TxtValorTotalAPagar";
            this.TxtValorTotalAPagar.ReadOnly = true;
            this.TxtValorTotalAPagar.Size = new System.Drawing.Size(371, 35);
            this.TxtValorTotalAPagar.TabIndex = 16;
            // 
            // txtvalorreceita
            // 
            this.txtvalorreceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtvalorreceita.Location = new System.Drawing.Point(11, 353);
            this.txtvalorreceita.Name = "txtvalorreceita";
            this.txtvalorreceita.Size = new System.Drawing.Size(438, 23);
            this.txtvalorreceita.TabIndex = 44;
            this.txtvalorreceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label11);
            this.groupBox2.Controls.Add(this.txtvalorreceita);
            this.groupBox2.Controls.Add(label14);
            this.groupBox2.Controls.Add(this.txtdescricaoreceita);
            this.groupBox2.Controls.Add(label12);
            this.groupBox2.Controls.Add(this.combocategoriareceita);
            this.groupBox2.Location = new System.Drawing.Point(486, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 451);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Da entrada em contas do mês atual";
            // 
            // LbNomeClienteTelaCancelamento
            // 
            this.LbNomeClienteTelaCancelamento.AutoSize = true;
            this.LbNomeClienteTelaCancelamento.BackColor = System.Drawing.Color.YellowGreen;
            this.LbNomeClienteTelaCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbNomeClienteTelaCancelamento.Location = new System.Drawing.Point(141, 56);
            this.LbNomeClienteTelaCancelamento.Name = "LbNomeClienteTelaCancelamento";
            this.LbNomeClienteTelaCancelamento.Size = new System.Drawing.Size(64, 25);
            this.LbNomeClienteTelaCancelamento.TabIndex = 46;
            this.LbNomeClienteTelaCancelamento.Text = "label7";
            // 
            // FrmCancelamentoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 600);
            this.Controls.Add(this.LbNomeClienteTelaCancelamento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnFinalizarCancelamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(iD_CLIENTELabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCancelamentoContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCancelamento";
            this.Load += new System.EventHandler(this.FrmCancelamento_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtPorcentagem;
        public System.Windows.Forms.Button BtnFinalizarCancelamento;
        private System.Windows.Forms.TextBox txtdescricaoreceita;
        private System.Windows.Forms.ComboBox combocategoriareceita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtValorTotalAPagar;
        private System.Windows.Forms.TextBox txtvalorreceita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.TextBox txtvalorparcelasvencidas;
        public System.Windows.Forms.TextBox txtQTDparcelasvencidas;
        public System.Windows.Forms.TextBox txtvalordaparcela;
        public System.Windows.Forms.Label LbNomeClienteTelaCancelamento;
    }
}