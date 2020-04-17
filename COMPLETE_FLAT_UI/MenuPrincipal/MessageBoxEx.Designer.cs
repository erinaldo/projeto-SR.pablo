namespace SoftwareGerenciador
{
    partial class MessageBoxEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxEx));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.imageIcon = new System.Windows.Forms.ImageList(this.components);
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBarra = new System.Windows.Forms.TableLayoutPanel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.tlpForm.SuspendLayout();
            this.tlpBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.AutoSize = true;
            this.pnlBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.pnlBody, 2);
            this.pnlBody.Controls.Add(this.pbImagem);
            this.pnlBody.Controls.Add(this.lblMessageText);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 30);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.MaximumSize = new System.Drawing.Size(480, 440);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(180, 94);
            this.pnlBody.TabIndex = 0;
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(15, 22);
            this.pbImagem.Margin = new System.Windows.Forms.Padding(15, 25, 0, 30);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(40, 42);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 7;
            this.pbImagem.TabStop = false;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.Location = new System.Drawing.Point(63, 27);
            this.lblMessageText.Margin = new System.Windows.Forms.Padding(10, 30, 30, 30);
            this.lblMessageText.MaximumSize = new System.Drawing.Size(390, 420);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(41, 15);
            this.lblMessageText.TabIndex = 8;
            this.lblMessageText.Text = "label1";
            this.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageIcon
            // 
            this.imageIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcon.ImageStream")));
            this.imageIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcon.Images.SetKeyName(0, "Error");
            this.imageIcon.Images.SetKeyName(1, "Warning");
            this.imageIcon.Images.SetKeyName(2, "Question");
            this.imageIcon.Images.SetKeyName(3, "Information");
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.pnlBody, 0, 1);
            this.tlpForm.Controls.Add(this.tlpBarra, 0, 0);
            this.tlpForm.Controls.Add(this.pnlFooter, 0, 2);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(1, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpForm.MinimumSize = new System.Drawing.Size(180, 170);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(180, 170);
            this.tlpForm.TabIndex = 12;
            // 
            // tlpBarra
            // 
            this.tlpBarra.ColumnCount = 3;
            this.tlpForm.SetColumnSpan(this.tlpBarra, 2);
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpBarra.Controls.Add(this.pbIcon, 0, 0);
            this.tlpBarra.Controls.Add(this.btnClose, 2, 0);
            this.tlpBarra.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBarra.Location = new System.Drawing.Point(0, 0);
            this.tlpBarra.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBarra.Name = "tlpBarra";
            this.tlpBarra.RowCount = 1;
            this.tlpBarra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarra.Size = new System.Drawing.Size(180, 30);
            this.tlpBarra.TabIndex = 10;
            this.tlpBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpBarra_MouseDown);
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(1, 1);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(1);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(38, 28);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(149, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 28);
            this.btnClose.TabIndex = 227;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Silver;
            this.lblTitulo.Location = new System.Drawing.Point(43, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 30);
            this.lblTitulo.TabIndex = 228;
            this.lblTitulo.Text = "Vetri -";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // pnlFooter
            // 
            this.tlpForm.SetColumnSpan(this.pnlFooter, 2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooter.Location = new System.Drawing.Point(0, 124);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(180, 45);
            this.pnlFooter.TabIndex = 9;
            // 
            // MessageBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(180, 170);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(180, 170);
            this.Name = "MessageBoxEx";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageBoxEx_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.tlpBarra.ResumeLayout(false);
            this.tlpBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpBarra;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.ImageList imageIcon;
    }
}