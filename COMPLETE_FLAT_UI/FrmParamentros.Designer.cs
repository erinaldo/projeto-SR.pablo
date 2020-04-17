namespace SoftwareGerenciador
{
    partial class FrmParamentros
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
            System.Windows.Forms.Label eMAILPARTICULARLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.txtEmailRemetente = new System.Windows.Forms.TextBox();
            this.TxtSenhaRementente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnSalvaradm_Parametros = new System.Windows.Forms.Button();
            this.TxtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnTesteDeConexaoEmail = new System.Windows.Forms.Button();
            this.txtSMPT = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            eMAILPARTICULARLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMAILPARTICULARLabel
            // 
            eMAILPARTICULARLabel.AutoSize = true;
            eMAILPARTICULARLabel.BackColor = System.Drawing.Color.White;
            eMAILPARTICULARLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            eMAILPARTICULARLabel.Location = new System.Drawing.Point(15, 102);
            eMAILPARTICULARLabel.Name = "eMAILPARTICULARLabel";
            eMAILPARTICULARLabel.Size = new System.Drawing.Size(52, 17);
            eMAILPARTICULARLabel.TabIndex = 36;
            eMAILPARTICULARLabel.Text = "EMAIL:";
            eMAILPARTICULARLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(8, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 17);
            label1.TabIndex = 38;
            label1.Text = "SENHA:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(37, 310);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 17);
            label2.TabIndex = 44;
            label2.Text = "NOME EMPRESA";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailRemetente
            // 
            this.txtEmailRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmailRemetente.Location = new System.Drawing.Point(74, 96);
            this.txtEmailRemetente.Name = "txtEmailRemetente";
            this.txtEmailRemetente.Size = new System.Drawing.Size(403, 23);
            this.txtEmailRemetente.TabIndex = 37;
            // 
            // TxtSenhaRementente
            // 
            this.TxtSenhaRementente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSenhaRementente.Location = new System.Drawing.Point(74, 125);
            this.TxtSenhaRementente.Name = "TxtSenhaRementente";
            this.TxtSenhaRementente.Size = new System.Drawing.Size(403, 23);
            this.TxtSenhaRementente.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.txtSMPT);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.BtnTesteDeConexaoEmail);
            this.groupBox1.Controls.Add(this.txtEmailRemetente);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(eMAILPARTICULARLabel);
            this.groupBox1.Controls.Add(this.TxtSenhaRementente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(36, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 170);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros de Envio de E-mail para o cliente";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(640, 38);
            this.BarraTitulo.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parâmetros";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(602, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnSalvaradm_Parametros
            // 
            this.BtnSalvaradm_Parametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvaradm_Parametros.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_Parametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_Parametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvaradm_Parametros.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_Parametros.Location = new System.Drawing.Point(436, 357);
            this.BtnSalvaradm_Parametros.Name = "BtnSalvaradm_Parametros";
            this.BtnSalvaradm_Parametros.Size = new System.Drawing.Size(192, 38);
            this.BtnSalvaradm_Parametros.TabIndex = 40;
            this.BtnSalvaradm_Parametros.Text = "Salvar";
            this.BtnSalvaradm_Parametros.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_Parametros.Visible = false;
            this.BtnSalvaradm_Parametros.Click += new System.EventHandler(this.BtnSalvaradm_Parametros_Click);
            // 
            // TxtNomeEmpresa
            // 
            this.TxtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtNomeEmpresa.Location = new System.Drawing.Point(162, 310);
            this.TxtNomeEmpresa.Name = "TxtNomeEmpresa";
            this.TxtNomeEmpresa.Size = new System.Drawing.Size(327, 23);
            this.TxtNomeEmpresa.TabIndex = 43;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtID.Location = new System.Drawing.Point(564, 44);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(76, 23);
            this.TxtID.TabIndex = 45;
            this.TxtID.Visible = false;
            // 
            // BtnTesteDeConexaoEmail
            // 
            this.BtnTesteDeConexaoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnTesteDeConexaoEmail.FlatAppearance.BorderSize = 0;
            this.BtnTesteDeConexaoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTesteDeConexaoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnTesteDeConexaoEmail.ForeColor = System.Drawing.Color.White;
            this.BtnTesteDeConexaoEmail.Location = new System.Drawing.Point(417, 22);
            this.BtnTesteDeConexaoEmail.Name = "BtnTesteDeConexaoEmail";
            this.BtnTesteDeConexaoEmail.Size = new System.Drawing.Size(119, 68);
            this.BtnTesteDeConexaoEmail.TabIndex = 41;
            this.BtnTesteDeConexaoEmail.Text = "Testar Permição";
            this.BtnTesteDeConexaoEmail.UseVisualStyleBackColor = false;
            this.BtnTesteDeConexaoEmail.Click += new System.EventHandler(this.BtnTesteDeConexaoEmail_Click);
            // 
            // txtSMPT
            // 
            this.txtSMPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSMPT.Location = new System.Drawing.Point(77, 31);
            this.txtSMPT.Name = "txtSMPT";
            this.txtSMPT.Size = new System.Drawing.Size(233, 23);
            this.txtSMPT.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(19, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 17);
            label4.TabIndex = 42;
            label4.Text = "SMTP:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPorta.Location = new System.Drawing.Point(74, 61);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(236, 23);
            this.txtPorta.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.Location = new System.Drawing.Point(10, 64);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 17);
            label5.TabIndex = 44;
            label5.Text = "PORTA:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmParamentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(label2);
            this.Controls.Add(this.TxtNomeEmpresa);
            this.Controls.Add(this.BtnSalvaradm_Parametros);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParamentros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParamentros";
            this.Load += new System.EventHandler(this.FrmParamentros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEmailRemetente;
        public System.Windows.Forms.TextBox TxtSenhaRementente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button BtnSalvaradm_Parametros;
        private System.Windows.Forms.TextBox TxtNomeEmpresa;
        private System.Windows.Forms.TextBox TxtID;
        public System.Windows.Forms.Button BtnTesteDeConexaoEmail;
        public System.Windows.Forms.TextBox txtSMPT;
        public System.Windows.Forms.TextBox txtPorta;
    }
}