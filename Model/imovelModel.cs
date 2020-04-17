using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class imovelModel
    {
        public int ID { get; set; }
        public int ID_CATEGORIA { get; set; }
        public string NOME { get; set; }
        public string SITUACAO { get; set; }
        public string TIPO { get; set; }
        public string OCUPACAO { get; set; }
        public int ID_CORRETOR { get; set; }
        public String CIDADE { get; set; }
        public String BAIRRO { get; set; }
        public String NUMERO { get; set; }
        public String ESTADO { get; set; }
        public String COMPLEMENTO  { get; set; }
        public String PROPRIETARIO { get; set; }
        public String LOCALCHAVE { get; set; }
        public String ULTIMAATUALIZACAO { get; set; }
        public int QUARTOS { get; set; }
        public int SUITES { get; set; }
        public int PAVIMENTO { get; set; }
        public int GARAGEM { get; set; }
        public int SALA { get; set; }
        public int BANHEIRO { get; set; }
        public int ANDAR { get; set; }
        public int AREATERRENO { get; set; }
        public int AREACONSTRUIDA { get; set; }
        public int IDADEIMOVEL { get; set; }
        public int PRAZOENTREGA { get; set; }
        public String EDIFICIO { get; set; }
        public String CONSTRUTORA { get; set; }
        public String DESCRICAO { get; set; }
        public decimal VALORIPTU { get; set; }
        public decimal VALORCODOMINIO { get; set; }
        public decimal VALORPRECO { get; set; }
        public Byte[] IMAGEM1 { get; set; }
        public Byte[] IMAGEM2 { get; set; }
        public Byte[] IMAGEM3 { get; set; }
        public decimal VALORALUGUEL { get; set; }

        public void CarregaImagem1(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.IMAGEM1 = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.IMAGEM1, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public void CarregaImagem2(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.IMAGEM2 = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.IMAGEM2, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public void CarregaImagem3(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.IMAGEM3 = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.IMAGEM3, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
       
        public System.Drawing.Image BuscarImagem1(byte[] FOTO1)
        {
            System.Drawing.Image imagem = null;
            try
            {
                if (FOTO1 != null)
                    imagem = (Bitmap)((new ImageConverter()).ConvertFrom(FOTO1));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return imagem;
        }
        public System.Drawing.Image BuscarImagem2(byte[] FOTO2)
        {
            System.Drawing.Image imagem = null;
            try
            {
                if (FOTO2 != null)
                    imagem = (Bitmap)((new ImageConverter()).ConvertFrom(FOTO2));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return imagem;
        }
        public System.Drawing.Image BuscarImagem3(byte[] FOTO3)
        {
            System.Drawing.Image imagem = null;
            try
            {
                if (FOTO3 != null)
                    imagem = (Bitmap)((new ImageConverter()).ConvertFrom(FOTO3));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return imagem;
        }

        public FornecedorModel fornecedores { get; set; }
    }
}
