using Dados;
using Dados.CLIENTE;
using Dados.Fornecedor;
using Model;
using SoftwareGerenciador.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    public partial class FormNovoadm_modulo : Form
    {
        public FormNovoadm_modulo()
        {
            InitializeComponent();
        }
        public string foto = "";
        public string foto1 = "";
        public string foto2 = "";
        public string foto3 = "";
        public imovelModel dadosEquipamento;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNovoadm_modulo_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvaradm_modulo_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(dIAVENCIMENTOTextBox.Text))
                {
                    MessageBoxEx.Show("Coloque o dia de vencimento");
                    return;
                }
                if (string.IsNullOrWhiteSpace(eNDERECOTextBox.Text))
                {
                    MessageBoxEx.Show("Coloque o endereço para mensagens futuras.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(bAIRROTextBox.Text))
                {
                    MessageBoxEx.Show("Coloque o seu bairro para mensagens futuras.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cIDADETextBox.Text))
                {
                    MessageBoxEx.Show("Coloque sua cidade para mensagens futuras.");
                    return;
                }
                if (tELEFONE1TextBox.Text == "(  )       -")
                {
                    MessageBoxEx.Show("E necessario de um telefone principal, que tenha watsap para mensagens futuras.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(iDTextBox.Text))//se o campo id e vazio e pra salvar os dados
                {
                    new CLIENTEDAL().Salvar(Objetoadm_modulo());

                    MessageBoxEx.Show("Inserido com sucesso");
                    Close();
                }
                else //se o campo estiver uma numeração e pra alterar os dados
                {
                    new CLIENTEDAL().Update(Objetoadm_modulo());

                    MessageBoxEx.Show("Alterado com sucesso");
                    Close();
                }
            }
            catch (Exception EX)
            {

                MessageBoxEx.Show(EX.ToString());
            }

        }
        private cliente Objetoadm_modulo()
        {
            cliente retorno = new cliente()
            {
                //ID = Convert.ToInt32(iDTextBox.Text),
                NOME = nOMETextBox.Text.Trim(),
                OBS = oBSTextBox.Text.Trim(),
                DATA = DateTime.Now.Date,
                DIAVENCIMENTO = dIAVENCIMENTOTextBox.Text.Trim(),
                EMAILPARTICULAR = eMAILPARTICULARTextBox.Text.Trim(),
                CPFCNPJ = cPFCNPJTextBox.Text.Trim(),
                TELEFONE1 = tELEFONE1TextBox.Text.Trim().Replace("(","").Replace(")", "").Replace("-", "").Replace(" ", ""),
                TELEFONE2 = tELEFONE2TextBox.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                ENDERECO = eNDERECOTextBox.Text.Trim(),
                BAIRRO = bAIRROTextBox.Text.Trim(),
                CIDADE = cIDADETextBox.Text.Trim(),
                CEP = cEPTextBox.Text.Trim(),
                NUMEROINDETIDADE = nUMEROINDETIDADETextBox.Text.Trim()
            };

            if (this.foto == "Foto Original")
            {
                var mt = new CLIENTEDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.FOTO = mt.FOTO;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto))
                    retorno.CarregaImagem(this.foto);
            }

            if (this.foto1 == "Foto Original")
            {
                var mt = new CLIENTEDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM1 = mt.IMAGEM1;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto1))
                    retorno.CarregaImagem1(this.foto1);
            }
            if (this.foto2 == "Foto Original")
            {
                var mt = new CLIENTEDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM2 = mt.IMAGEM2;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto2))
                    retorno.CarregaImagem2(this.foto2);
            }
            if (this.foto3 == "Foto Original")
            {
                var mt = new CLIENTEDAL().CONSULTATODOSPELOID(Convert.ToInt32(iDTextBox.Text));
                retorno.IMAGEM3 = mt.IMAGEM3;
            }
            else
            {
                if (!string.IsNullOrEmpty(foto3))
                    retorno.CarregaImagem3(this.foto3);
            }



            if (string.IsNullOrWhiteSpace(iDTextBox.Text)) { retorno.ID = 0; } else { retorno.ID = Convert.ToInt32(iDTextBox.Text.Trim()); }
            return retorno;
        }

        private void cPFCNPJTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, cPFCNPJTextBox);
            }
            //codigo para permiti apenas numeros no texbox
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }
        public static bool ValidaEmail(string email)
        {
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            //return System.Text.RegularExpressions.Regex.IsMatch(email, strRegex);
            Regex re = new Regex(strRegex);
            return re.IsMatch(email);
        }
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        private void eMAILPARTICULARTextBox_Leave(object sender, EventArgs e)
        {
            if (ValidaEmail(eMAILPARTICULARTextBox.Text) == false)
            {
                LbMensagenEmail.Visible = true;
                eMAILPARTICULARTextBox.Clear();
            }
            else
            {
                LbMensagenEmail.Visible = false;
            }
        }

        private void cEPTextBox_Leave(object sender, EventArgs e)
        {
            //if (ValidaCep(cEPTextBox.Text) == false)
            //{
            //    lbCEP.Visible = true;
            //    lbCEP.Text = "O CEP é inválido";
            //}
            //else
            //{
            //    if (BuscaEndereco.verificaCEP(cEPTextBox.Text) == true)
            //    {
            //        bAIRROTextBox.Text = BuscaEndereco.bairro;
            //        eNDERECOTextBox.Text = BuscaEndereco.endereco;
            //        cIDADETextBox.Text = BuscaEndereco.cidade;
            //        lbCEP.Visible = false;
            //    }
            //}
        }
        public static bool ValidaCep(string cep)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnLinpaImagem_Click(object sender, EventArgs e)
        {
            imagemadm_modulo.Image = null;
        }

        private void btnSalvarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                imagemadm_modulo.Load(this.foto);
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void oBSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLinpaImagem1_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM1.Image = null;
        }

        private void btnLinpaImagem2_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM2.Image = null;
        }

        private void btnLinpaImagem3_Click(object sender, EventArgs e)
        {
            pictureBoxIMAGEM3.Image = null;
        }

        private void btnSalvarImagem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto1 = od.FileName;
                pictureBoxIMAGEM1.Load(this.foto1);
            }
        }

        private void btnSalvarImagem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto2 = od.FileName;
                pictureBoxIMAGEM2.Load(this.foto2);
            }
        }

        private void btnSalvarImagem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto3 = od.FileName;
                pictureBoxIMAGEM3.Load(this.foto3);
            }
        }

        private void comboOPERADORA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboStatusManutencao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void radioProprio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nOMETextBox_TextChanged(object sender, EventArgs e)
        {
            //consulta cliente se existi
            try
            {
                if (!string.IsNullOrWhiteSpace(nOMETextBox.Text))
                {
                    var adm_moduloRetorno = new CLIENTEDAL().CONSULTATODOSPELONOMEcomlikeUMcliente(nOMETextBox.Text.Trim());
                    if (adm_moduloRetorno.ID > 0)
                    {
                        iDTextBox.Text = adm_moduloRetorno.ID.ToString();
                        //nOMETextBox.Text = adm_moduloRetorno.NOME.ToString();
                        if (adm_moduloRetorno.OBS != null)
                            oBSTextBox.Text = adm_moduloRetorno.OBS.ToString();

                        if (adm_moduloRetorno.DIAVENCIMENTO != null)
                            dIAVENCIMENTOTextBox.Text = adm_moduloRetorno.DIAVENCIMENTO.ToString();

                        if (adm_moduloRetorno.EMAILPARTICULAR != null)
                            eMAILPARTICULARTextBox.Text = adm_moduloRetorno.EMAILPARTICULAR.ToString();

                        if (adm_moduloRetorno.TELEFONE2 != null)
                            tELEFONE2TextBox.Text = adm_moduloRetorno.TELEFONE2.ToString();
                        if (adm_moduloRetorno.CPFCNPJ != null)
                            cPFCNPJTextBox.Text = adm_moduloRetorno.CPFCNPJ.ToString();
                        if (adm_moduloRetorno.TELEFONE1 != null)
                            tELEFONE1TextBox.Text = adm_moduloRetorno.TELEFONE1.ToString();

                        if (adm_moduloRetorno.ENDERECO != null)
                            eNDERECOTextBox.Text = adm_moduloRetorno.ENDERECO.ToString();
                        if (adm_moduloRetorno.BAIRRO != null)
                            bAIRROTextBox.Text = adm_moduloRetorno.BAIRRO.ToString();
                        if (adm_moduloRetorno.CIDADE != null)
                            cIDADETextBox.Text = adm_moduloRetorno.CIDADE.ToString();
                        if (adm_moduloRetorno.CEP != null)
                            cEPTextBox.Text = adm_moduloRetorno.CEP.ToString();

                        if (adm_moduloRetorno.NUMEROINDETIDADE != null)
                            nUMEROINDETIDADETextBox.Text = adm_moduloRetorno.NUMEROINDETIDADE.ToString();

                        if (adm_moduloRetorno.FOTO != null)
                        {
                            //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));

                            imagemadm_modulo.Image = new cliente().BuscarImagem(adm_moduloRetorno.FOTO);
                            foto = "Foto Original";
                        }
                        if (adm_moduloRetorno.IMAGEM1 != null)
                        {
                            //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                            try
                            {
                                pictureBoxIMAGEM1.Image = new cliente().BuscarImagem1(adm_moduloRetorno.IMAGEM1);
                                foto1 = "Foto Original";
                            }
                            catch { }
                        }
                        if (adm_moduloRetorno.IMAGEM2 != null)
                        {
                            //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                            try
                            {
                                pictureBoxIMAGEM2.Image = new cliente().BuscarImagem2(adm_moduloRetorno.IMAGEM2);
                                foto2 = "Foto Original";
                            }
                            catch { }

                        }
                        if (adm_moduloRetorno.IMAGEM3 != null)
                        {
                            //MemoryStream ms = new MemoryStream(Convert.ToByte(DGVDADOS.CurrentRow.Cells[26].Value));
                            try
                            {
                                pictureBoxIMAGEM3.Image = new cliente().BuscarImagem3(adm_moduloRetorno.IMAGEM3);
                                foto3 = "Foto Original";
                            }
                            catch { }

                        }
                        //muda o nome do botão pra altera
                        BtnSalvaradm_modulo.Text = "Alterar";

                    }
                    else
                    {
                        iDTextBox.Clear();
                        //nOMETextBox.Clear();
                        oBSTextBox.Clear();
                        dIAVENCIMENTOTextBox.Clear();
                        eMAILPARTICULARTextBox.Clear();
                        tELEFONE2TextBox.Clear();
                        cPFCNPJTextBox.Clear();
                        tELEFONE1TextBox.Clear();
                        eNDERECOTextBox.Clear();
                        bAIRROTextBox.Clear();
                        cIDADETextBox.Clear();
                        cEPTextBox.Clear();
                        nUMEROINDETIDADETextBox.Clear();
                        imagemadm_modulo.Image = null;
                        pictureBoxIMAGEM1.Image = null;
                        pictureBoxIMAGEM2.Image = null;
                        pictureBoxIMAGEM3.Image = null;
                        foto = "";
                        foto1 = "";
                        foto2 = "";
                        foto3 = "";
                        //muda o nome do botão pra altera
                        BtnSalvaradm_modulo.Text = "Salvar";
                    }
                }
                else
                {
                    iDTextBox.Clear();
                    //nOMETextBox.Clear();
                    oBSTextBox.Clear();
                    dIAVENCIMENTOTextBox.Clear();
                    eMAILPARTICULARTextBox.Clear();
                    tELEFONE2TextBox.Clear();
                    cPFCNPJTextBox.Clear();
                    tELEFONE1TextBox.Clear();
                    eNDERECOTextBox.Clear();
                    bAIRROTextBox.Clear();
                    cIDADETextBox.Clear();
                    cEPTextBox.Clear();
                    nUMEROINDETIDADETextBox.Clear();
                    imagemadm_modulo.Image = null;
                    pictureBoxIMAGEM1.Image = null;
                    pictureBoxIMAGEM2.Image = null;
                    pictureBoxIMAGEM3.Image = null;
                    foto = "";
                    foto1 = "";
                    foto2 = "";
                    foto3 = "";
                    //muda o nome do botão pra altera
                    BtnSalvaradm_modulo.Text = "Salvar";
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Erro: " + ex.Message + ex.StackTrace);
            }
        }
    }
}
