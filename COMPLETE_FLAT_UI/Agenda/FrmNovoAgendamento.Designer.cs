namespace SoftwareGerenciador.Agenda
{
    partial class FrmNovoAgendamento
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnSalvaradm_modulo = new System.Windows.Forms.Button();
            this.EMAILtextBox = new System.Windows.Forms.TextBox();
            this.TELEFONEtextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.comboImovel = new System.Windows.Forms.ComboBox();
            this.DataInstalacao = new System.Windows.Forms.DateTimePicker();
            this.TxtDescrcao = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(102, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 17);
            label1.TabIndex = 89;
            label1.Text = "E-MAIL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(74, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 17);
            label2.TabIndex = 91;
            label2.Text = "TELEFONE:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.White;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.Location = new System.Drawing.Point(38, 50);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(104, 17);
            iDLabel.TabIndex = 77;
            iDLabel.Text = "CÓD AGENDA:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.BackColor = System.Drawing.Color.White;
            nOMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nOMELabel.Location = new System.Drawing.Point(106, 79);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(53, 17);
            nOMELabel.TabIndex = 79;
            nOMELabel.Text = "NOME:";
            nOMELabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.BackColor = System.Drawing.Color.White;
            cIDADELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cIDADELabel.Location = new System.Drawing.Point(96, 105);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(63, 17);
            cIDADELabel.TabIndex = 87;
            cIDADELabel.Text = "IMÓVEL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(1, 195);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 17);
            label3.TabIndex = 97;
            label3.Text = "DATA PARA AGENDAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.Location = new System.Drawing.Point(177, 229);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(175, 17);
            label5.TabIndex = 100;
            label5.Text = "Detalhes do agendamento";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(784, 38);
            this.BarraTitulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(92, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Novos Agendamentos";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(746, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnSalvaradm_modulo
            // 
            this.BtnSalvaradm_modulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvaradm_modulo.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvaradm_modulo.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_modulo.Location = new System.Drawing.Point(583, 249);
            this.BtnSalvaradm_modulo.Name = "BtnSalvaradm_modulo";
            this.BtnSalvaradm_modulo.Size = new System.Drawing.Size(192, 66);
            this.BtnSalvaradm_modulo.TabIndex = 93;
            this.BtnSalvaradm_modulo.Text = "Salvar";
            this.BtnSalvaradm_modulo.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_modulo.Click += new System.EventHandler(this.BtnSalvaradm_modulo_Click);
            // 
            // EMAILtextBox
            // 
            this.EMAILtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EMAILtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EMAILtextBox.Location = new System.Drawing.Point(170, 132);
            this.EMAILtextBox.Name = "EMAILtextBox";
            this.EMAILtextBox.Size = new System.Drawing.Size(599, 23);
            this.EMAILtextBox.TabIndex = 90;
            // 
            // TELEFONEtextBox
            // 
            this.TELEFONEtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TELEFONEtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TELEFONEtextBox.Location = new System.Drawing.Point(170, 161);
            this.TELEFONEtextBox.Name = "TELEFONEtextBox";
            this.TELEFONEtextBox.Size = new System.Drawing.Size(599, 23);
            this.TELEFONEtextBox.TabIndex = 92;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(153, 44);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(174, 23);
            this.iDTextBox.TabIndex = 78;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nOMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nOMETextBox.Location = new System.Drawing.Point(170, 73);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(599, 23);
            this.nOMETextBox.TabIndex = 80;
            // 
            // comboImovel
            // 
            this.comboImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboImovel.FormattingEnabled = true;
            this.comboImovel.Location = new System.Drawing.Point(170, 102);
            this.comboImovel.Name = "comboImovel";
            this.comboImovel.Size = new System.Drawing.Size(599, 24);
            this.comboImovel.TabIndex = 94;
            this.comboImovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboTIPO_KeyPress);
            // 
            // DataInstalacao
            // 
            this.DataInstalacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataInstalacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInstalacao.Location = new System.Drawing.Point(170, 190);
            this.DataInstalacao.Name = "DataInstalacao";
            this.DataInstalacao.Size = new System.Drawing.Size(200, 23);
            this.DataInstalacao.TabIndex = 96;
            // 
            // TxtDescrcao
            // 
            this.TxtDescrcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescrcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtDescrcao.Location = new System.Drawing.Point(153, 249);
            this.TxtDescrcao.Multiline = true;
            this.TxtDescrcao.Name = "TxtDescrcao";
            this.TxtDescrcao.Size = new System.Drawing.Size(424, 79);
            this.TxtDescrcao.TabIndex = 101;
            // 
            // FrmNovoAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 344);
            this.Controls.Add(this.TxtDescrcao);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(this.DataInstalacao);
            this.Controls.Add(this.comboImovel);
            this.Controls.Add(this.BtnSalvaradm_modulo);
            this.Controls.Add(this.EMAILtextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.TELEFONEtextBox);
            this.Controls.Add(label2);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNovoAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNovoAgendamento";
            this.Load += new System.EventHandler(this.FrmNovoAgendamento_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button BtnSalvaradm_modulo;
        public System.Windows.Forms.TextBox EMAILtextBox;
        public System.Windows.Forms.TextBox TELEFONEtextBox;
        public System.Windows.Forms.TextBox iDTextBox;
        public System.Windows.Forms.TextBox nOMETextBox;
        public System.Windows.Forms.ComboBox comboImovel;
        public System.Windows.Forms.DateTimePicker DataInstalacao;
        public System.Windows.Forms.TextBox TxtDescrcao;
    }
}