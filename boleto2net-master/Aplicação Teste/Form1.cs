using Boleto2Net;
using Boleto2Net.Testes;
using System;
using System.Windows.Forms;

namespace Aplicação_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            IBanco _banco;
            try
            {
               
                var contaBancaria = new ContaBancaria
                {
                    Agencia = "1234",
                    DigitoAgencia = "",
                    Conta = "56789",
                    DigitoConta = "0",
                    CarteiraPadrao = "109",
                    TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples,
                    TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro,
                    TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
                };
                _banco = Banco.Instancia(Bancos.Itau);
                _banco.Cedente = Utils.GerarCedente("", "", "", contaBancaria);

                _banco.FormataCedente();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro da tela" + ex.Message + ex.StackTrace);
            }
        }
    }
}
