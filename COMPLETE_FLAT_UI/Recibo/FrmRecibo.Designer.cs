namespace SoftwareGerenciador.Recibo
{
    partial class FrmRecibo
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGerarRecibo = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtImportacia = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtReferente = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(685, 38);
            this.BarraTitulo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "RECIBO";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(647, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGerarRecibo
            // 
            this.BtnGerarRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnGerarRecibo.FlatAppearance.BorderSize = 0;
            this.BtnGerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnGerarRecibo.ForeColor = System.Drawing.Color.White;
            this.BtnGerarRecibo.Location = new System.Drawing.Point(537, 299);
            this.BtnGerarRecibo.Name = "BtnGerarRecibo";
            this.BtnGerarRecibo.Size = new System.Drawing.Size(121, 46);
            this.BtnGerarRecibo.TabIndex = 14;
            this.BtnGerarRecibo.Text = "Gerar Recibo";
            this.BtnGerarRecibo.UseVisualStyleBackColor = false;
            this.BtnGerarRecibo.Click += new System.EventHandler(this.BtnGerarRecibo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Recebi (emos) de";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtnome.Location = new System.Drawing.Point(24, 73);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(597, 23);
            this.txtnome.TabIndex = 15;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtendereco.Location = new System.Drawing.Point(24, 121);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(597, 23);
            this.txtendereco.TabIndex = 17;
            // 
            // txtImportacia
            // 
            this.txtImportacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImportacia.Location = new System.Drawing.Point(27, 169);
            this.txtImportacia.Name = "txtImportacia";
            this.txtImportacia.Size = new System.Drawing.Size(196, 23);
            this.txtImportacia.TabIndex = 19;
            this.txtImportacia.TextChanged += new System.EventHandler(this.txtImportacia_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 195);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Referente";
            // 
            // txtReferente
            // 
            this.txtReferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReferente.Location = new System.Drawing.Point(27, 217);
            this.txtReferente.Multiline = true;
            this.txtReferente.Name = "txtReferente";
            this.txtReferente.Size = new System.Drawing.Size(597, 56);
            this.txtReferente.TabIndex = 21;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Valor";
            // 
            // FrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 363);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtReferente);
            this.Controls.Add(this.txtImportacia);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.BtnGerarRecibo);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRecibo";
            this.Text = "FrmRecibo";
            this.Load += new System.EventHandler(this.FrmRecibo_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button BtnGerarRecibo;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtnome;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtImportacia;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtReferente;
        public MetroFramework.Controls.MetroLabel metroLabel5;
    }
}