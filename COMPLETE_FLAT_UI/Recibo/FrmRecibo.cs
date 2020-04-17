using Dados;
using SoftwareGerenciador.Mensalidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador.Recibo
{
    public partial class FrmRecibo : Form
    {
        public FrmRecibo()
        {
            InitializeComponent();
        }

        private void BtnGerarRecibo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtImportacia.Text))
            {
                CriarPDF.CriarPDFRecibo(txtnome.Text, txtendereco.Text, txtImportacia.Text, txtReferente.Text);
                this.Alert("Recibo gerado com sucesso!", "", Form_Alert.enmType.Success);
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //Trocar o caminho da imagem
                startInfo.FileName = Application.StartupPath + @"\ReciboGErado.pdf";
                System.Diagnostics.Process.Start(startInfo);
            }
            else
                MessageBoxEx.Show("Coloque o valor da importancia?");
           
        }
        public void Alert(string msg1, string msg2, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg1, msg2, type);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception erro)
            {
                MessageBoxEx.Show(erro.Message);
            }
        }

        private void txtImportacia_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtImportacia);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void FrmRecibo_Load(object sender, EventArgs e)
        {

        }
    }
}
