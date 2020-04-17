using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class MessageBoxEx : Form
    {
        public MessageBoxEx()
        {
            //site #356789
            InitializeComponent();
            pnlBody.BackColor = Color.White;
            tlpBarra.BackColor = pnlBody.BackColor;
            pnlFooter.BackColor = Color.FromArgb(64, 69, 76);//0; 119; 190 cor azul
            
        }

        private void MessageBoxEx_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #region Variaveis

        public string DetailMessage { get; set; } = string.Empty;

        public float ButtonFontSize { get; set; } = 10.0f;

        public float MessageFontSize { get; set; } = 8.5f;

        public float DetailFonteSize { get; set; } = 9.0f;

        public FontFamily ButtonFontFamily { get; set; } = new FontFamily("Microsoft Sans Serif");

        public FontFamily DetailFontFamily { get; set; } = new FontFamily("Microsoft Sans Serif");

        public FontFamily MessageFontFamily { get; set; } = new FontFamily("Microsoft Sans Serif");

        public Color ButtonForeColor { get; set; } = Color.Black;

        public Color MessageDetailForeColor { get; set; } = Color.Black;

        public Color MessageForeColor { get; set; } = Color.Black;

        //public Color TitleForeColor
        //{
        //    get { return _titleForeColor; }
        //    set { _titleForeColor = value; }
        //}
        //public Color PnlbodyBackColor { get; set; } = Color.FromArgb(40, 40, 40); // cor meio

        //public Color PnlFooterBackColor { get; set; } = Color.FromArgb(90, 192, 157); // cor baixo FromArgb(60, 60, 60)

        //public Color TitleBarBackColor { get; set; } = Color.FromArgb(40, 40, 40); // cima

        public Color MessageDetailBackColor { get; set; } = Color.White; //cor detalhes

        #endregion

        /// <summary> setMessage é um metodo para exibir a mensagem no Messagebox 
        /// redimensionando o form dinamicammente de acordo com o tamanho da mensagem </summary>
        /// <param name="messageText">Mensagem fornecida pelo usuário.</param>
        private void SetMessage(string messageText)
        {
            //int number = Math.Abs(messageText.Length / 30);
            //if (number != 0) this.lblMessageText.Height = number * 25;
            lblMessageText.Text = messageText;

            //verifica o altura e largura do texto baseado no tipo, tamanho da Font e na largura definida pelo usuario
            // MessageFontFamily e messageFonteSize são definidos pelo usuario
            Size size = TextRenderer.MeasureText(messageText, new Font(MessageFontFamily, MessageFontSize), new Size(390, 0), TextFormatFlags.WordBreak);
            int messageWidth = 400; // determina largura inicial do form para exibição da mensagem
            int area = Screen.PrimaryScreen.WorkingArea.Width; // verifica a largura da tela 

            do
            {
                // verifica se a largura do messageBox não é maior que a largura da tela, se for maior a mensagem sera 
                // transferida para o campo detalhes logo abaixo dos dados ja inseridos nele
                if (messageWidth < (area - 200))
                {
                    pnlBody.MaximumSize = new Size(messageWidth + 100, 450); //determina novo tamanho do Messagebox
                    lblMessageText.MaximumSize = new Size(messageWidth, 400); // determina novo tamanho para area que o texto ocupara no Messagebox

                    size = TextRenderer.MeasureText(messageText, new Font(MessageFontFamily, MessageFontSize), new Size(messageWidth, 0), TextFormatFlags.WordBreak);
                    messageWidth += 200; // aumenta a largura do form Messagebox e do label message em 200px
                }
                else
                {
                    //exibe nova mensagem  informando que o texo foi movido para a area Detalhes
                    lblMessageText.Text = "A mensagem é muito grande para ser exibida! \nPara visualizá-la clique em detalhes e procure por: \n\n    <<<<<<   Mensagem Movida  >>>>>>";

                    pnlBody.MaximumSize = new Size(580, 440);
                    lblMessageText.MaximumSize = new Size(490, 420);

                    string linha;

                    // verifica se o campo detalhes ja contém algum texo para pode inserir o texo transferido logo abaixo dele.
                    if (DetailMessage != string.Empty)
                    {
                        linha = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                        DetailMessage = DetailMessage + linha + "<<<<<<   Mensagem Movida  >>>>>> " + linha + messageText;
                    }
                    else
                    {
                        linha = Environment.NewLine + Environment.NewLine + Environment.NewLine;
                        DetailMessage = "<<<<<<   Mensagem Movida  >>>>>> " + linha + messageText;
                    }

                    // permine que o loop seja encerrado
                    size.Height = 0;
                }
            } while (size.Height > 400);  // realiza o loop até texto caber na altura de 400px          
        }

        private void BtnAdd(DialogResult dr, int x, int y, int btnWidth, int btnHeigth)
        {
            var btn = new Button(); // cria novo botão

            switch (dr)
            {
                case DialogResult.OK:
                    btn.Text = "&OK";
                    break;
                case DialogResult.Yes:
                    btn.Text = "&Sim";
                    break;
                case DialogResult.No:
                    btn.Text = "&Não";
                    break;
                case DialogResult.Cancel:
                    btn.Text = "&Cancel";
                    break;
                case DialogResult.Ignore:
                    btn.Text = "&Ignore";
                    break;
                case DialogResult.Retry:
                    btn.Text = "&Repetir";
                    break;
                case DialogResult.Abort:
                    btn.Text = "&Abortar";
                    break;
                case DialogResult.None:
                    btn.Click += BtnDetail_Click;
                    btn.Text = "&Detalhes";
                    break;
            }


            // btn.Text = "&OK"; // texto exibido no botão
            btn.DialogResult = dr; // resultado ao clicar no botão --> fecha o MessageBox
            btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn.FlatStyle = FlatStyle.Popup; // determina o estilo do botão
            btn.FlatAppearance.BorderSize = 0; // determina o tamanho da borda do botão
            btn.SetBounds(x, y, btnWidth, btnHeigth);
            btn.ForeColor = Color.White; // determina a cor da fonte do texto exibido no botão, a váriavel fonteColor é definida pelo usuário
            btn.Font = new Font(ButtonFontFamily, ButtonFontSize); // determina a letra e o tamanho da letra do texto inserido no botão, as variaveis, buttonFontFamily e buttonFontSize são definidas pelo usuário
            pnlFooter.Controls.Add(btn);
        }

        private void DetailAdd(int x, int y, int btnW, int btnH)
        {
            var txt = new TextBox(); // cria um novo textbox
            txt.BorderStyle = BorderStyle.FixedSingle; // determina o tipo de borda
            txt.Multiline = true; // permite que o texto inseriro seja exibido em mais de uma linha
            txt.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right; // faz com que o textBox preencha todo o formulario, ancodando ele em Os lados.
            txt.SetBounds(x, y, btnW, btnH); // determina o tamanho do textbox e a posição em que ele deve ser inserido
            txt.ScrollBars = ScrollBars.Vertical;  // cria barra de rolagem vergical caso o texto inserido exceda o tamanho pré determinado do textbox
            txt.BackColor = MessageDetailBackColor; // determina a cor do fundo do textBox, a váriavel textBackColor é definida pelo usuário
            txt.ForeColor = MessageDetailForeColor; // determina a cor da fonte do texto exibido no textBox, a váriavel fonteColor é definida pelo usuário
            txt.Font = new Font(DetailFontFamily, DetailFonteSize);  // determina a letra e o tamanho da letra do texto inserido no textBox, as variaveis, detailFontFamily e detailFontSize são definidas pelo usuário
            txt.Text = DetailMessage; // atribui o texto da variável DetailMessage fornecido pelo usuário. 

            pnlFooter.Controls.Add(txt);
        }

        private static Size MsgBoxSize(MessageButton messageButton)
        {
            switch (messageButton)
            {
                case MessageButton.OkCancel:
                case MessageButton.OkDetail:
                case MessageButton.YesNo:
                case MessageButton.RetryCancel:
                    return new Size(202, 151);
                case MessageButton.OkCancelDetail:
                case MessageButton.YesNoCancel:
                case MessageButton.YesNoDetail:
                case MessageButton.AbortRetryIgnore:
                case MessageButton.RetryCancelDetail:
                    return new Size(297, 151);
                case MessageButton.YesNoCancelDetail:
                case MessageButton.AbortRetryIgnoreDetail:
                    return new Size(393, 151);
            }
            return new Size(180, 170);
        }

        private static MessageButton SelectButton(MessageButton messageButton, string detail)
        {
            if (detail != string.Empty)
            {
                switch (messageButton)
                {
                    case MessageButton.OK: return MessageButton.OkDetail;
                    case MessageButton.OkCancel: return MessageButton.OkCancelDetail;
                    case MessageButton.YesNo: return MessageButton.YesNoDetail;
                    case MessageButton.YesNoCancel: return MessageButton.YesNoCancelDetail;
                    case MessageButton.RetryCancel: return MessageButton.RetryCancelDetail;
                    case MessageButton.AbortRetryIgnore: return MessageButton.AbortRetryIgnoreDetail;
                }
            }

            switch (messageButton)
            {
                case MessageButton.OkDetail: return MessageButton.OK;
                case MessageButton.OkCancelDetail: return MessageButton.OkCancel;
                case MessageButton.YesNoDetail: return MessageButton.YesNo;
                case MessageButton.YesNoCancelDetail: return MessageButton.YesNoCancel;
                case MessageButton.RetryCancelDetail: return MessageButton.RetryCancel;
                case MessageButton.AbortRetryIgnore: return MessageButton.AbortRetryIgnoreDetail;
            }

            return messageButton;
        }

        /// <summary> Método para adicionar botões dinamicamente e a caixa de texto Detalhes ao MessageBox</summary>
        /// <param name="messageButton">Tipo de Button a ser exibido no MessageBox</param>
        private void AddButton(MessageButton messageButton)
        {
            int footerSize = pnlFooter.ClientSize.Width;
            int w = 85;
            int h = 25;
            int x1 = footerSize - (w + 10);
            int x2 = footerSize - (w * 2 + 20);
            int x3 = footerSize - (w * 3 + 30);
            int x4 = footerSize - (w * 4 + 40);

            switch (messageButton)
            {
                case MessageButton.OK:
                    {
                        BtnAdd(DialogResult.OK, x1, 10, w, h);
                    }
                    break;
                case MessageButton.OkDetail:
                    BtnAdd(DialogResult.OK, x1, 10, w, h);
                    BtnAdd(DialogResult.None, x2, 10, w, h);
                    DetailAdd(10, h + 20, footerSize - 20, 100);
                    break;
                case MessageButton.OkCancel:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.OK, x2, 10, w, h);
                    }
                    break;
                case MessageButton.OkCancelDetail:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.OK, x2, 10, w, h);
                        BtnAdd(DialogResult.None, x3, 10, w, h);
                        DetailAdd(10, h + 20, footerSize - 20, 100);
                    }
                    break;
                case MessageButton.YesNo:
                    {
                        BtnAdd(DialogResult.No, x1, 10, w, h);
                        BtnAdd(DialogResult.Yes, x2, 10, w, h);
                    }
                    break;
                case MessageButton.YesNoDetail:
                    {
                        BtnAdd(DialogResult.No, x1, 10, w, h);
                        BtnAdd(DialogResult.Yes, x2, 10, w, h);
                        BtnAdd(DialogResult.None, x3, 10, w, h);
                        DetailAdd(10, h + 20, footerSize - 20, 100);
                    }
                    break;
                case MessageButton.YesNoCancel:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.No, x2, 10, w, h);
                        BtnAdd(DialogResult.Yes, x3, 10, w, h);
                    }
                    break;
                case MessageButton.YesNoCancelDetail:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.No, x2, 10, w, h);
                        BtnAdd(DialogResult.Yes, x3, 10, w, h);
                        BtnAdd(DialogResult.None, x4, 10, w, h);
                        DetailAdd(10, h + 20, footerSize - 20, 100);
                    }
                    break;
                case MessageButton.RetryCancel:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.Retry, x2, 10, w, h);
                    }
                    break;
                case MessageButton.RetryCancelDetail:
                    {
                        BtnAdd(DialogResult.Cancel, x1, 10, w, h);
                        BtnAdd(DialogResult.Retry, x2, 10, w, h);
                        BtnAdd(DialogResult.None, x3, 10, w, h);
                        DetailAdd(10, h + 20, footerSize - 20, 100);
                    }
                    break;
                case MessageButton.AbortRetryIgnore:
                    {
                        BtnAdd(DialogResult.Ignore, x1, 10, w, h);
                        BtnAdd(DialogResult.Retry, x2, 10, w, h);
                        BtnAdd(DialogResult.Abort, x3, 10, w, h);
                    }
                    break;
                case MessageButton.AbortRetryIgnoreDetail:
                    {
                        BtnAdd(DialogResult.Ignore, x1, 10, w, h);
                        BtnAdd(DialogResult.Retry, x2, 10, w, h);
                        BtnAdd(DialogResult.Abort, x3, 10, w, h);
                        BtnAdd(DialogResult.None, x4, 10, w, h);
                        DetailAdd(10, h + 20, footerSize - 20, 100);
                    }
                    break;
            }
        }

        /// <summary> Método para adicionar icones dinamicamente ao MessageBox</summary>
        /// <param name="messageIcon">Tipo de icone a ser exibido no MessageBox.</param>
        /// <remarks>Para maior qualidade da imagem foi utilizado imagens do resource</remarks>
        private void AddIconImage(MessageIcon messageIcon)
        {
            switch (messageIcon)
            {
                case MessageIcon.Error:
                    pbImagem.Image = SystemIcons.Error.ToBitmap();// IMG.Properties.Resources._Error;
                    break;
                case MessageIcon.Information:
                    pbImagem.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageIcon.Question:
                    pbImagem.Image = SystemIcons.Question.ToBitmap();
                    break;
                case MessageIcon.Warning:
                    pbImagem.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageIcon.Exclamation:
                    pbImagem.Image = SystemIcons.Exclamation.ToBitmap();
                    break;
                case MessageIcon.Retry:
                    pbImagem.Image = SystemIcons.Asterisk.ToBitmap();
                    break;
                case MessageIcon.Success:
                    pbImagem.Image = SystemIcons.Shield.ToBitmap();
                    break;
            }
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        internal static DialogResult Show(string messageText)
        {
            SystemSounds.Exclamation.Play();
            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = "Atenção";
            messageBoxEx.AddIconImage(MessageIcon.Information);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do messagebox</param>
        internal static DialogResult Show(string messageText, string messageTitle)
        {
            SystemSounds.Exclamation.Play();
            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.Text = messageTitle;
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.AddIconImage(MessageIcon.Information);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        internal static DialogResult Show(string messageText, MessageIcon messageIcon)
        {
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = "AVISO";
            messageBoxEx.AddIconImage(messageIcon);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>        
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        /// <param name="messageButton">Botões que compoem o MessageBox.</param>
        internal static DialogResult Show(string messageText, MessageIcon messageIcon, MessageButton messageButton)
        {
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = "AVISO";
            messageBoxEx.AddIconImage(messageIcon);

            messageButton = SelectButton(messageButton, messageBoxEx.DetailMessage.Trim());

            messageBoxEx.MinimumSize = MsgBoxSize(messageButton);
            messageBoxEx.AddButton(messageButton);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do messagebox</param>
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        internal static DialogResult Show(string messageText, string messageTitle, MessageIcon messageIcon)
        {
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = messageTitle;
            messageBoxEx.AddIconImage(messageIcon);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do messagebox</param>
        /// <param name="messageDetail">Detakhes adicionais da mensagem, exibida ao clicar no botão detalhe.s</param>
        internal static DialogResult Show(string messageText, string messageTitle, string messageDetail)
        {
            SystemSounds.Exclamation.Play();
            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.Text = messageTitle;
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.DetailMessage = messageDetail;
            messageBoxEx.AddIconImage(MessageIcon.Information);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;

        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do MessageBox.</param>
        /// <param name="messageDetail">Detakhes adicionais da mensagem, exibida ao clicar no botão detalhes</param>
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        internal static DialogResult Show(string messageText, string messageTitle, string messageDetail, MessageIcon messageIcon)
        {
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.DetailMessage = messageDetail;
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = messageTitle;
            messageBoxEx.AddIconImage(messageIcon);
            messageBoxEx.AddButton(messageBoxEx.DetailMessage.Trim() != string.Empty ? MessageButton.OkDetail : MessageButton.OK);
            messageBoxEx.MinimumSize = new Size(202, 151);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do MessageBox.</param>
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        /// <param name="messageButton">Botões que compoem o MessageBox.</param>
        internal static DialogResult Show(string messageText, string messageTitle, MessageIcon messageIcon, MessageButton messageButton)
        {
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = messageTitle;
            messageBoxEx.AddIconImage(messageIcon);

            messageButton = SelectButton(messageButton, messageBoxEx.DetailMessage.Trim());

            messageBoxEx.MinimumSize = MsgBoxSize(messageButton);
            messageBoxEx.AddButton(messageButton);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        /// <summary> Métodos para exibir a mensagens no MessageBox.</summary>
        /// <param name="messageText">Mensagem a ser exibida.</param>
        /// <param name="messageTitle">Titulo do MessageBox.</param>
        /// <param name="messageDetail">Detakhes adicionais da mensagem, exibida ao clicar no botão detalhes</param>
        /// <param name="messageIcon">Icone exibido juntamente com a mensagem.</param>
        /// <param name="messageButton">Botões que compoem o MessageBox.</param>
        internal static DialogResult Show(string messageText, string messageTitle, string messageDetail, MessageIcon messageIcon, MessageButton messageButton)
        {
            //Executa um som de acordo com a opçao de icone desejada
            if (messageIcon == MessageIcon.Error) SystemSounds.Hand.Play();
            else SystemSounds.Exclamation.Play();

            var messageBoxEx = new MessageBoxEx();
            messageBoxEx.DetailMessage = messageDetail;
            messageBoxEx.SetMessage(messageText);
            messageBoxEx.Text = messageTitle;
            messageBoxEx.AddIconImage(messageIcon);

            messageButton = SelectButton(messageButton, messageBoxEx.DetailMessage.Trim());

            messageBoxEx.MinimumSize = MsgBoxSize(messageButton);
            messageBoxEx.AddButton(messageButton);
            messageBoxEx.ShowDialog();
            return messageBoxEx.DialogResult;
        }

        #region permite mover o form clicando com o botão direito do mouse
        //evendo mouse down do form       

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        /// <summary>Evento criado dinamicamente juntamente com o botão detalhes </summary>
        private bool _open = false;
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            if (!_open)
            {
                pnlFooter.Height += 110;
                _open = true;
            }
            else
            {
                pnlFooter.Height -= 110;
                _open = false;
            }
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
        }

        private void tlpBarra_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

       
    }

    internal enum MessageIcon
    {
        Error,
        Exclamation,
        Information,
        Question,
        Success,
        Warning,
        Retry
    }

    internal enum MessageButton
    {
        OK,
        OkDetail,
        OkCancel,
        OkCancelDetail,
        YesNo,
        YesNoDetail,
        YesNoCancel,
        YesNoCancelDetail,
        RetryCancel,
        RetryCancelDetail,
        AbortRetryIgnore,
        AbortRetryIgnoreDetail
    }
}
