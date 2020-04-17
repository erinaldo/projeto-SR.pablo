using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class cliente
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string OBS { get; set; }
        public DateTime DATA { get; set; }
        public string DIAVENCIMENTO { get; set; }
       
        public string EMAILPARTICULAR { get; set; }
      
        public string CPFCNPJ { get; set; }
        public string TELEFONE1 { get; set; }
        public string TELEFONE2 { get; set; }
        
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string CEP { get; set; }
        public string NUMEROINDETIDADE { get; set; }
        public byte[] FOTO { get; set; }
        public byte[] IMAGEM1 { get; set; }
        public byte[] IMAGEM2 { get; set; }
        public byte[] IMAGEM3 { get; set; }
        public string STATUS { get; set; }
       

        public void CarregaImagem(String imgCaminho)
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
                this.FOTO = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.FOTO, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
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
        public System.Drawing.Image BuscarImagem(byte[] FOTO)
        {
            System.Drawing.Image imagem = null;
            try
            {
                if (FOTO != null)
                    imagem = (Bitmap)((new ImageConverter()).ConvertFrom(FOTO));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return imagem;
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
    }
}
