using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.CLIENTE
{
    public class CLIENTEDAL
    {
        DlConexao Conexao;
        public void Salvar(cliente cliente)
        {
            Conexao = new DlConexao();
            try
            {
                Conexao.limparParametros();
                //Conexao.AdicionarParametros("@ID", cliente.ID);
                Conexao.AdicionarParametros("@NOME", cliente.NOME);
                Conexao.AdicionarParametros("@OBS", cliente.OBS);
                Conexao.AdicionarParametros("@DIAVENCIMENTO", cliente.DIAVENCIMENTO);
                Conexao.AdicionarParametros("@DATA", cliente.DATA);
                Conexao.AdicionarParametros("@CPFCNPJ", cliente.CPFCNPJ);
                Conexao.AdicionarParametros("@TELEFONE1", cliente.TELEFONE1);
                Conexao.AdicionarParametros("@TELEFONE2", cliente.TELEFONE2);
                Conexao.AdicionarParametros("@ENDERECO", cliente.ENDERECO);
                Conexao.AdicionarParametros("@BAIRRO", cliente.BAIRRO);
                Conexao.AdicionarParametros("@CIDADE", cliente.CIDADE);
                Conexao.AdicionarParametros("@CEP", cliente.CEP);
                Conexao.AdicionarParametros("@NUMEROINDETIDADE", cliente.NUMEROINDETIDADE);
                Conexao.AdicionarParametros("@FOTO", cliente.FOTO);
                Conexao.AdicionarParametros("@EMAILPARTICULAR", cliente.EMAILPARTICULAR);
                Conexao.AdicionarParametros("@IMAGEM1", cliente.IMAGEM1);
                Conexao.AdicionarParametros("@IMAGEM2", cliente.IMAGEM2);
                Conexao.AdicionarParametros("@IMAGEM3", cliente.IMAGEM3);
                Conexao.AdicionarParametros("@STATUS", "ATIVO");
             

                Conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO cliente(NOME, OBS, DATA, DIAVENCIMENTO, EMAILPARTICULAR, CPFCNPJ, TELEFONE1, TELEFONE2, ENDERECO, BAIRRO, CIDADE, CEP, NUMEROINDETIDADE, FOTO, IMAGEM1, IMAGEM2, IMAGEM3,STATUS) " +
                                                                          "VALUES (@NOME, @OBS, @DATA, @DIAVENCIMENTO, @EMAILPARTICULAR, @CPFCNPJ, @TELEFONE1, @TELEFONE2, @ENDERECO, @BAIRRO, @CIDADE, @CEP, @NUMEROINDETIDADE, @FOTO, @IMAGEM1, @IMAGEM2, @IMAGEM3,@STATUS)");

            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        public cliente CONSULTATODOSPELOID(int Codigo)
        {
            cliente RETORNO = new cliente();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente WHERE ID =" + Codigo + " ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<cliente>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public cliente CONSULTATODOSPELONOME(string NOME)
        {
            cliente RETORNO = new cliente();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                Conexao.AdicionarParametros("@NOME", NOME);
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente WHERE NOME = @NOME ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<cliente>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<cliente> CONSULTATODOSPELONOMEcomlike(string NOME)
        {
            var RETORNO = new List<cliente>();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                //Conexao.AdicionarParametros("@NOME", NOME);
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente WHERE NOME LIKE '" + NOME + "%' ORDER BY NOME ASC");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var clienteConsulta = Genericos.Popular<cliente>(DATA, i);

                    RETORNO.Add(clienteConsulta);
                } 

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public cliente CONSULTATODOSPELONOMEcomlikeUMcliente(string NOME)
        {
            var RETORNO = new cliente();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                //Conexao.AdicionarParametros("@NOME", NOME);
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente WHERE NOME LIKE '" + NOME + "%' ORDER BY NOME ASC");
               if(DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<cliente>(DATA, 0);
                }
            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public void UpdateClienteCancelamento(int IDCliente, string tipoStatus)
        {
            Conexao = new DlConexao();
            try
            {
                Conexao.limparParametros();
                Conexao.AdicionarParametros("@ID", IDCliente);
                Conexao.AdicionarParametros("@STATUS", tipoStatus);
                //Conexao.AdicionarParametros("@SITUACAO", TipoContrato);
                Conexao.ExecutarManipulacao(CommandType.Text, "UPDATE cliente SET STATUS=@STATUS WHERE ID = @ID");
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }
        public void Update(cliente cliente)
        {
            Conexao = new DlConexao();
            try
            {
                Conexao.limparParametros();
                Conexao.AdicionarParametros("@ID", cliente.ID);
                Conexao.AdicionarParametros("@NOME", cliente.NOME);
                Conexao.AdicionarParametros("@OBS", cliente.OBS);
                Conexao.AdicionarParametros("@DIAVENCIMENTO", cliente.DIAVENCIMENTO);
                Conexao.AdicionarParametros("@DATA", cliente.DATA);
                Conexao.AdicionarParametros("@CPFCNPJ", cliente.CPFCNPJ);
                Conexao.AdicionarParametros("@TELEFONE1", cliente.TELEFONE1);
                Conexao.AdicionarParametros("@TELEFONE2", cliente.TELEFONE2);
                Conexao.AdicionarParametros("@ENDERECO", cliente.ENDERECO);
                Conexao.AdicionarParametros("@BAIRRO", cliente.BAIRRO);
                Conexao.AdicionarParametros("@CIDADE", cliente.CIDADE);
                Conexao.AdicionarParametros("@CEP", cliente.CEP);
                Conexao.AdicionarParametros("@NUMEROINDETIDADE", cliente.NUMEROINDETIDADE);
                Conexao.AdicionarParametros("@FOTO", cliente.FOTO);
                Conexao.AdicionarParametros("@EMAILPARTICULAR", cliente.EMAILPARTICULAR);
                Conexao.AdicionarParametros("@IMAGEM1", cliente.IMAGEM1);
                Conexao.AdicionarParametros("@IMAGEM2", cliente.IMAGEM2);
                Conexao.AdicionarParametros("@IMAGEM3", cliente.IMAGEM3);


                Conexao.ExecutarManipulacao(CommandType.Text, "UPDATE cliente SET NOME=@NOME,OBS=@OBS, " +
                    "DATA=@DATA,DIAVENCIMENTO=@DIAVENCIMENTO,EMAILPARTICULAR=@EMAILPARTICULAR,CPFCNPJ=@CPFCNPJ,TELEFONE1=@TELEFONE1,TELEFONE2=@TELEFONE2,ENDERECO=@ENDERECO,BAIRRO=@BAIRRO,CIDADE=@CIDADE,CEP=@CEP,NUMEROINDETIDADE=@NUMEROINDETIDADE, FOTO=@FOTO, " +
                    "IMAGEM1=@IMAGEM1, IMAGEM2=@IMAGEM2, IMAGEM3=@IMAGEM3  WHERE ID = @ID");
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }
        public List<cliente> CONSULTATODOSContratosATIVOS(string Status)
        {
            List<cliente> RETORNO = new List<cliente>();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente WHERE STATUS = '" + Status + "' ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    for (int i = 0; i < DATA.Rows.Count; i++)
                    {
                        cliente novos = new cliente();
                        novos = Genericos.Popular<cliente>(DATA, i);
                        RETORNO.Add(novos);
                    }
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<cliente> CONSULTATODOS()
        {
            List<cliente> RETORNO = new List<cliente>();
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                var DATA = Conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM cliente ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    for (int i = 0; i < DATA.Rows.Count; i++)
                    {
                        cliente novos = new cliente();
                        novos = Genericos.Popular<cliente>(DATA, i);
                        RETORNO.Add(novos);
                    }
                }
                    
            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public void Excluir(int id)
        {
           
            try
            {
                Conexao = new DlConexao();
                Conexao.limparParametros();
                Conexao.ExecutaConsultas(System.Data.CommandType.Text, "DELETE FROM cliente WHERE ID =" + id);
               
            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
          
        }
    }
}
