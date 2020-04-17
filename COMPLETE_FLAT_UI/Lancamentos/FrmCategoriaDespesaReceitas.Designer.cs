namespace SoftwareGerenciador.Lancamentos
{
    partial class FrmCategoriaDespesaReceitas
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
            System.Windows.Forms.Label label2;
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtIDcategoria = new System.Windows.Forms.TextBox();
            this.BtnSalvarCategoria = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dgvdadosCategorias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdadosCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(16, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 17);
            label2.TabIndex = 21;
            label2.Text = "Nome da categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCategoria.Location = new System.Drawing.Point(16, 55);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(378, 23);
            this.txtNomeCategoria.TabIndex = 22;
            this.txtNomeCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIDcategoria
            // 
            this.txtIDcategoria.Enabled = false;
            this.txtIDcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIDcategoria.Location = new System.Drawing.Point(19, 3);
            this.txtIDcategoria.Name = "txtIDcategoria";
            this.txtIDcategoria.Size = new System.Drawing.Size(125, 23);
            this.txtIDcategoria.TabIndex = 23;
            this.txtIDcategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSalvarCategoria
            // 
            this.BtnSalvarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnSalvarCategoria.FlatAppearance.BorderSize = 0;
            this.BtnSalvarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnSalvarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarCategoria.Location = new System.Drawing.Point(441, 6);
            this.BtnSalvarCategoria.Name = "BtnSalvarCategoria";
            this.BtnSalvarCategoria.Size = new System.Drawing.Size(155, 46);
            this.BtnSalvarCategoria.TabIndex = 25;
            this.BtnSalvarCategoria.Text = "Salvar";
            this.BtnSalvarCategoria.UseVisualStyleBackColor = false;
            this.BtnSalvarCategoria.Click += new System.EventHandler(this.BtnSalvarCategoria_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(619, 64);
            this.BarraTitulo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Criar Grupo Categoria Gerais";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SoftwareGerenciador.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(12, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvdadosCategorias
            // 
            this.dgvdadosCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdadosCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvdadosCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdadosCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdadosCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdadosCategorias.GridColor = System.Drawing.Color.White;
            this.dgvdadosCategorias.Location = new System.Drawing.Point(0, 184);
            this.dgvdadosCategorias.Name = "dgvdadosCategorias";
            this.dgvdadosCategorias.RowHeadersVisible = false;
            this.dgvdadosCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdadosCategorias.Size = new System.Drawing.Size(619, 118);
            this.dgvdadosCategorias.TabIndex = 27;
            this.dgvdadosCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdadosCategorias_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.txtIDcategoria);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtNomeCategoria);
            this.panel1.Controls.Add(this.BtnSalvarCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 120);
            this.panel1.TabIndex = 28;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(441, 58);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(155, 46);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // FrmCategoriaDespesaReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(619, 302);
            this.Controls.Add(this.dgvdadosCategorias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCategoriaDespesaReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoriaDespesaReceitas";
            this.Load += new System.EventHandler(this.FrmCategoriaDespesaReceitas_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdadosCategorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtIDcategoria;
        public System.Windows.Forms.Button BtnSalvarCategoria;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView dgvdadosCategorias;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnExcluir;
    }
}