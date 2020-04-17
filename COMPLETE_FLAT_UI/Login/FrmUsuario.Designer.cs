namespace SoftwareGerenciador.Login
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label vALOR_MESLabel;
            System.Windows.Forms.Label dIA_BASELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnSalvaradm_modulo = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.DGVDADOS = new System.Windows.Forms.DataGridView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            iDLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            vALOR_MESLabel = new System.Windows.Forms.Label();
            dIA_BASELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(43, 19);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "ID:";
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iD_CLIENTELabel.ForeColor = System.Drawing.Color.White;
            iD_CLIENTELabel.Location = new System.Drawing.Point(15, 57);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(53, 17);
            iD_CLIENTELabel.TabIndex = 14;
            iD_CLIENTELabel.Text = "NOME:";
            // 
            // vALOR_MESLabel
            // 
            vALOR_MESLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            vALOR_MESLabel.AutoSize = true;
            vALOR_MESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            vALOR_MESLabel.ForeColor = System.Drawing.Color.White;
            vALOR_MESLabel.Location = new System.Drawing.Point(18, 95);
            vALOR_MESLabel.Name = "vALOR_MESLabel";
            vALOR_MESLabel.Size = new System.Drawing.Size(50, 17);
            vALOR_MESLabel.TabIndex = 16;
            vALOR_MESLabel.Text = "lOGIN:";
            // 
            // dIA_BASELabel
            // 
            dIA_BASELabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dIA_BASELabel.AutoSize = true;
            dIA_BASELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dIA_BASELabel.ForeColor = System.Drawing.Color.White;
            dIA_BASELabel.Location = new System.Drawing.Point(9, 133);
            dIA_BASELabel.Name = "dIA_BASELabel";
            dIA_BASELabel.Size = new System.Drawing.Size(59, 17);
            dIA_BASELabel.TabIndex = 18;
            dIA_BASELabel.Text = "SENHA:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(9, 171);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 17);
            label1.TabIndex = 22;
            label1.Text = "CARGO:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(87, 16);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(560, 23);
            this.iDTextBox.TabIndex = 13;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtnome.Location = new System.Drawing.Point(87, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(560, 23);
            this.txtnome.TabIndex = 15;
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtlogin.Location = new System.Drawing.Point(87, 92);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(560, 23);
            this.txtlogin.TabIndex = 17;
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsenha.Location = new System.Drawing.Point(87, 130);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(560, 23);
            this.txtsenha.TabIndex = 19;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(912, 46);
            this.BarraTitulo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cadastro de usuario";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(874, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnSalvaradm_modulo
            // 
            this.BtnSalvaradm_modulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvaradm_modulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvaradm_modulo.FlatAppearance.BorderSize = 0;
            this.BtnSalvaradm_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvaradm_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvaradm_modulo.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaradm_modulo.Location = new System.Drawing.Point(668, 46);
            this.BtnSalvaradm_modulo.Name = "BtnSalvaradm_modulo";
            this.BtnSalvaradm_modulo.Size = new System.Drawing.Size(192, 68);
            this.BtnSalvaradm_modulo.TabIndex = 21;
            this.BtnSalvaradm_modulo.Text = "Salvar";
            this.BtnSalvaradm_modulo.UseVisualStyleBackColor = false;
            this.BtnSalvaradm_modulo.Click += new System.EventHandler(this.BtnSalvaradm_modulo_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCargo.Location = new System.Drawing.Point(87, 168);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(560, 23);
            this.txtCargo.TabIndex = 23;
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
            this.DGVDADOS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVDADOS.EnableHeadersVisualStyles = false;
            this.DGVDADOS.GridColor = System.Drawing.Color.White;
            this.DGVDADOS.Location = new System.Drawing.Point(0, 189);
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
            this.DGVDADOS.Size = new System.Drawing.Size(880, 181);
            this.DGVDADOS.TabIndex = 24;
            this.DGVDADOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDADOS_CellClick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(888, 409);
            this.metroTabControl1.TabIndex = 25;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.metroTabPage1.Controls.Add(label1);
            this.metroTabPage1.Controls.Add(this.DGVDADOS);
            this.metroTabPage1.Controls.Add(this.txtCargo);
            this.metroTabPage1.Controls.Add(this.BtnSalvaradm_modulo);
            this.metroTabPage1.Controls.Add(iDLabel);
            this.metroTabPage1.Controls.Add(this.iDTextBox);
            this.metroTabPage1.Controls.Add(this.txtsenha);
            this.metroTabPage1.Controls.Add(iD_CLIENTELabel);
            this.metroTabPage1.Controls.Add(dIA_BASELabel);
            this.metroTabPage1.Controls.Add(this.txtnome);
            this.metroTabPage1.Controls.Add(this.txtlogin);
            this.metroTabPage1.Controls.Add(vALOR_MESLabel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(880, 370);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cadastro Usuario";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(880, 378);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Permisoes de Usuário";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDADOS)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button BtnSalvaradm_modulo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.DataGridView DGVDADOS;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}