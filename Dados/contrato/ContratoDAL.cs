using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dados.contrato
{
    public class ContratoDAL
    {
        DlConexao conexao;
        public void Update(ContratoModel dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", dados.ID);
                conexao.AdicionarParametros("@ID_CLIENTE", dados.ID_CLIENTE);
                conexao.AdicionarParametros("@VALOR_MES", dados.VALOR_MES);
                conexao.AdicionarParametros("@DIA_BASE", dados.DIA_BASE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contrato SET ID_CLIENTE = @ID_CLIENTE, VALOR_MES = @VALOR_MES ,DIA_BASE = @DIA_BASE WHERE ID=@ID ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateSituacao(ContratoModel dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", dados.ID);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contrato SET SITUACAO = @SITUACAO WHERE ID=@ID ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarParcelas(contratoParcelamento dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", dados.ID_CONTRATO);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", dados.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@N_MENSALIDADE", dados.N_MENSALIDADE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoparcelamento SET SITUACAO = @SITUACAO, DATA_PAGAMENTO = @DATA_PAGAMENTO WHERE ID_CONTRATO=@ID_CONTRATO AND N_MENSALIDADE = @N_MENSALIDADE ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AlterarParcelasAtradadas(contratoParcelamento dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", dados.ID_CONTRATO);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", dados.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@N_MENSALIDADE", dados.N_MENSALIDADE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoparcelamento SET SITUACAO = @SITUACAO, N_MENSALIDADE = @N_MENSALIDADE  WHERE ID_CONTRATO=@ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ReceberPagamento(contratoParcelamento contrato)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", contrato.ID_CONTRATO);
                conexao.AdicionarParametros("@VALOR_PAGO", contrato.VALOR_PAGO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", contrato.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@FORMA_PAGAMENTO", contrato.FORMA_PAGAMENTO);
                conexao.AdicionarParametros("@SITUACAO", contrato.SITUACAO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", contrato.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@VALORFRACIONADO", contrato.VALORFRACIONADO);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoparcelamento SET " +
                    "DATA_PAGAMENTO=@DATA_PAGAMENTO," +
                    "FORMA_PAGAMENTO=@FORMA_PAGAMENTO," +
                    "VALOR_PAGO=@VALOR_PAGO," +
                    "SITUACAO=@SITUACAO, " +
                    "VALORFRACIONADO = @VALORFRACIONADO " +
                    "WHERE ID_CONTRATO = @ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ReceberPagamentoFracionado(contratoParcelamento contrato)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", contrato.ID_CONTRATO);
                conexao.AdicionarParametros("@VALORFRACIONADO", contrato.VALORFRACIONADO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", contrato.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@FORMA_PAGAMENTO", contrato.FORMA_PAGAMENTO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", contrato.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@SITUACAO", contrato.SITUACAO);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoparcelamento SET " +
                    "DATA_PAGAMENTO=@DATA_PAGAMENTO," +
                    "FORMA_PAGAMENTO=@FORMA_PAGAMENTO," +
                    "VALORFRACIONADO=@VALORFRACIONADO, " +
                     "SITUACAO = @SITUACAO " +
                    "WHERE ID_CONTRATO = @ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Salvar(ContratoModel dados)
        {
            int retorno = 0;
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CLIENTE", dados.ID_CLIENTE);
                conexao.AdicionarParametros("@VALOR_MES", dados.VALOR_MES);
                conexao.AdicionarParametros("@DIA_BASE", dados.DIA_BASE);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@ID_IMOVEL", dados.ID_IMOVEL);
                conexao.AdicionarParametros("@DOCUMENTO", dados.Documento);
                retorno = Convert.ToInt32(conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO contrato(ID_CLIENTE, VALOR_MES, DIA_BASE,SITUACAO,ID_IMOVEL,DOCUMENTO) VALUES (@ID_CLIENTE,@VALOR_MES, @DIA_BASE,@SITUACAO, @ID_IMOVEL, @DOCUMENTO); SELECT LAST_INSERT_ID();"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public List<contratoParcelamento> ConsultaParcelas(int iD)
        {
            List<contratoParcelamento> RETORNO = new List<contratoParcelamento>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@iD", iD);
                var dados = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoparcelamento WHERE ID_CONTRATO = @iD");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<contratoParcelamento>(dados, i);
                    RETORNO.Add(novos);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public void InserirParcelas(contratoParcelamento contrato)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", contrato.ID_CONTRATO);
                conexao.AdicionarParametros("@VALOR", contrato.VALOR);
                conexao.AdicionarParametros("@N_MENSALIDADE", contrato.N_MENSALIDADE);
                conexao.AdicionarParametros("@PLANO", contrato.PLANO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", contrato.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", contrato.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@SITUACAO", contrato.SITUACAO);
               
                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO contratoparcelamento(ID_CONTRATO, PLANO, N_MENSALIDADE,DATA_PAGAMENTO, DATA_VENCIMENTO,SITUACAO, VALOR) VALUES " +
                                                                                                "(@ID_CONTRATO, @PLANO, @N_MENSALIDADE,@DATA_PAGAMENTO, @DATA_VENCIMENTO,@SITUACAO, @VALOR) ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ExcluirParcelas(int id)
        {

            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id", id);
                conexao.ExecutaConsultas(System.Data.CommandType.Text, "DELETE FROM contratoparcelamento WHERE ID_CONTRATO = @id");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }

        }
        public ContratoModel Consulta(ContratoModel contrato)
        {
            ContratoModel RETORNO = new ContratoModel();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", contrato.ID_CLIENTE);
                conexao.AdicionarParametros("@ID", contrato.ID);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contrato WHERE ID_CLIENTE = @id_cliente AND ID = @ID");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoModel>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public ContratoModel ConsultaContratoID(int contrato)
        {
            ContratoModel RETORNO = new ContratoModel();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                conexao.AdicionarParametros("@ID", contrato);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contrato WHERE ID = @ID");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoModel>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public ContratoModel ConsultacontratoAtivo(int ID_CLIENTE, string Situacao)
        {
            ContratoModel RETORNO = new ContratoModel();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", ID_CLIENTE);
                conexao.AdicionarParametros("@Situacao", Situacao);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contrato WHERE ID_CLIENTE = @id_cliente AND SITUACAO = @Situacao");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoModel>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<ContratoModel> ConsultaContratos(ContratoModel contrato)
        {
            List<ContratoModel> RETORNO = new List<ContratoModel>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", contrato.ID_CLIENTE);
                //conexao.AdicionarParametros("@ID", contrato.ID);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contrato.ID,cliente.NOME,contrato.VALOR_MES,contrato.DIA_BASE,contrato.SITUACAO FROM contrato " +
                    "INNER join cliente on cliente.ID = contrato.ID_CLIENTE " +
                    "WHERE ID_CLIENTE = @id_cliente");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var dados = new ContratoModel();
                    dados.ClienteContrato = new cliente();

                    dados.ID = Convert.ToInt32(DATA.Rows[i].ItemArray[0].ToString());
                    dados.ClienteContrato.NOME = Convert.ToString(DATA.Rows[i].ItemArray[1].ToString());
                    dados.VALOR_MES = Convert.ToDecimal(DATA.Rows[i].ItemArray[2].ToString());
                    dados.DIA_BASE = Convert.ToInt32(DATA.Rows[i].ItemArray[3].ToString());
                    dados.SITUACAO = Convert.ToString(DATA.Rows[i].ItemArray[4].ToString());
                    RETORNO.Add(dados);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<ContratoModel> ConsultaTodosContratos()
        {
            List<ContratoModel> RETORNO = new List<ContratoModel>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contrato.ID,cliente.NOME,contrato.VALOR_MES,contrato.DIA_BASE,contrato.SITUACAO FROM contrato " +
                    "INNER join cliente on cliente.ID = contrato.ID_CLIENTE");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var dados = new ContratoModel();
                    dados.ClienteContrato = new cliente();

                    dados.ID = Convert.ToInt32(DATA.Rows[i].ItemArray[0].ToString());
                    dados.ClienteContrato.NOME = Convert.ToString(DATA.Rows[i].ItemArray[1].ToString());
                    dados.VALOR_MES = Convert.ToDecimal(DATA.Rows[i].ItemArray[2].ToString());
                    dados.DIA_BASE = Convert.ToInt32(DATA.Rows[i].ItemArray[3].ToString());
                    dados.SITUACAO = Convert.ToString(DATA.Rows[i].ItemArray[4].ToString());
                    RETORNO.Add(dados);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public DataTable ConsultaSituacaoPagamento(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                //conexao.AdicionarParametros("@Inicial", dataInicial);
                //conexao.AdicionarParametros("@Final", dataFinal);
                var dia = dataInicial.Day;
                var mes = dataInicial.Month;
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;

                var diaFinal = dataFinal.Day;
                var mesFinal = dataFinal.Month;
                var anoFinal = dataFinal.Year;
                string novadataFinal = anoFinal + "-" + mesFinal + "-" + diaFinal;
                conexao.limparParametros();

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoparcelamento.ID_CONTRATO ,cliente.NOME, contratoparcelamento.PLANO, contratoparcelamento.DATA_VENCIMENTO, contratoparcelamento.VALOR,contratoparcelamento.N_MENSALIDADE, contratoparcelamento.SITUACAO, contratoparcelamento.VALORFRACIONADO FROM contratoparcelamento INNER JOIN contrato on contrato.ID = contratoparcelamento.ID_CONTRATO INNER JOIN cliente on cliente.ID = contrato.ID_CLIENTE  " +
                    "WHERE contratoparcelamento.DATA_VENCIMENTO BETWEEN date('" + novadataInicial + "') AND date('" + novadataFinal + "') AND contratoparcelamento.SITUACAO = 'NAO PAGO' OR contratoparcelamento.SITUACAO = 'ATRASADO' OR contratoparcelamento.SITUACAO = 'FRACIONADO' AND contratoparcelamento.SITUACAO <> 'CANCELADO' AND contratoparcelamento.SITUACAO <> 'PAGO' ORDER BY contratoparcelamento.DATA_VENCIMENTO ASC");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public DataTable ConsultaData(DateTime dataInicial)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                var dia = dataInicial.Day;
                var mes = dataInicial.Month;
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes.ToString("00") + "-" + dia.ToString("00");

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoparcelamento.ID_CONTRATO ,cliente.NOME, contratoparcelamento.PLANO, contratoparcelamento.DATA_VENCIMENTO, contratoparcelamento.VALOR,contratoparcelamento.N_MENSALIDADE, contratoparcelamento.SITUACAO FROM contratoparcelamento INNER JOIN contrato on contrato.ID = contratoparcelamento.ID_CONTRATO INNER JOIN cliente on cliente.ID = contrato.ID_CLIENTE  " +
                    "WHERE contratoparcelamento.DATA_VENCIMENTO = '" + novadataInicial + "' AND contratoparcelamento.SITUACAO = 'NAO PAGO' AND contratoparcelamento.SITUACAO <> 'CANCELADO' AND contratoparcelamento.SITUACAO <> 'JUROS' ORDER BY contratoparcelamento.DATA_VENCIMENTO ASC");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public DataTable ConsultaData(DateTime dataInicial, DateTime dataFinal, string situacao)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                //conexao.AdicionarParametros("@Inicial", dataInicial);
                //conexao.AdicionarParametros("@Final", dataFinal);
                var dia = dataInicial.Day;
                var mes = dataInicial.Month;
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;
                var diaFinal = dataFinal.Day;
                var mesFinal = dataFinal.Month;
                var anoFinal = dataFinal.Year;
                string novadataFinal = anoFinal + "-" + mesFinal + "-" + diaFinal;

                conexao.limparParametros();

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoparcelamento.ID_CONTRATO ,cliente.NOME, contratoparcelamento.PLANO, contratoparcelamento.DATA_VENCIMENTO, contratoparcelamento.VALOR,contratoparcelamento.N_MENSALIDADE, contratoparcelamento.SITUACAO, contratoparcelamento.VALORFRACIONADO FROM contratoparcelamento INNER JOIN contrato on contrato.ID = contratoparcelamento.ID_CONTRATO INNER JOIN cliente on cliente.ID = contrato.ID_CLIENTE " +
                    "WHERE contratoparcelamento.DATA_VENCIMENTO BETWEEN date('" + novadataFinal + "')  AND date('" + novadataInicial + "') AND contratoparcelamento.SITUACAO = '" + situacao + "' AND contratoparcelamento.SITUACAO <> 'PAGO' AND contratoparcelamento.SITUACAO <> 'CANCELADO' AND contratoparcelamento.SITUACAO <> 'GRATIS (BONUS)'  AND contratoparcelamento.SITUACAO <> 'FRACIONADO'");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public DataTable ConsultaSituacaoPagamento(DateTime dataInicial, DateTime dataFinal, int contrato)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                //conexao.AdicionarParametros("@Inicial", dataInicial);
                //conexao.AdicionarParametros("@Final", dataFinal);
                var dia = dataInicial.Day;
                var mes = dataInicial.Month;
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;

                var diaFinal = dataFinal.Day;
                var mesFinal = dataFinal.Month;
                var anoFinal = dataFinal.Year;
                string novadataFinal = anoFinal + "-" + mesFinal + "-" + diaFinal;
                conexao.limparParametros();

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoparcelamento.ID_CONTRATO ,cliente.NOME, contratoparcelamento.PLANO, contratoparcelamento.DATA_VENCIMENTO, contratoparcelamento.VALOR,contratoparcelamento.N_MENSALIDADE, contratoparcelamento.SITUACAO, contratoparcelamento.VALORFRACIONADO FROM contratoparcelamento INNER JOIN contrato on contrato.ID = contratoparcelamento.ID_CONTRATO INNER JOIN cliente on cliente.ID = contrato.ID_CLIENTE  " +
                    "WHERE  contratoparcelamento.ID_CONTRATO = '" + contrato + "'");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<ContratoModel> CONSULTATODOSPELONOMEcomlike(string NOME)
        {
            var RETORNO = new List<ContratoModel>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                //Conexao.AdicionarParametros("@NOME", NOME);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contrato.ID,cliente.NOME,contrato.VALOR_MES,contrato.DIA_BASE,contrato.SITUACAO FROM contrato " +
                    "INNER join cliente on cliente.ID = contrato.ID_CLIENTE WHERE cliente.NOME LIKE '%" + NOME + "%' ORDER BY cliente.NOME ASC");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var dados = new ContratoModel();
                    dados.ClienteContrato = new cliente();

                    dados.ID = Convert.ToInt32(DATA.Rows[i].ItemArray[0].ToString());
                    dados.ClienteContrato.NOME = Convert.ToString(DATA.Rows[i].ItemArray[1].ToString());
                    dados.VALOR_MES = Convert.ToDecimal(DATA.Rows[i].ItemArray[2].ToString());
                    dados.DIA_BASE = Convert.ToInt32(DATA.Rows[i].ItemArray[3].ToString());
                    dados.SITUACAO = Convert.ToString(DATA.Rows[i].ItemArray[4].ToString());
                    RETORNO.Add(dados);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public List<ContratoModel> CONSULTATODOSPELOSITUACAO(string NOME)
        {
            var RETORNO = new List<ContratoModel>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                //Conexao.AdicionarParametros("@NOME", NOME);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contrato.ID,cliente.NOME,contrato.VALOR_MES,contrato.DIA_BASE,contrato.SITUACAO FROM contrato " +
                    "INNER join cliente on cliente.ID = contrato.ID_CLIENTE WHERE contrato.SITUACAO = '"+ NOME + "' ORDER BY cliente.NOME ASC");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var dados = new ContratoModel();
                    dados.ClienteContrato = new cliente();

                    dados.ID = Convert.ToInt32(DATA.Rows[i].ItemArray[0].ToString());
                    dados.ClienteContrato.NOME = Convert.ToString(DATA.Rows[i].ItemArray[1].ToString());
                    dados.VALOR_MES = Convert.ToDecimal(DATA.Rows[i].ItemArray[2].ToString());
                    dados.DIA_BASE = Convert.ToInt32(DATA.Rows[i].ItemArray[3].ToString());
                    dados.SITUACAO = Convert.ToString(DATA.Rows[i].ItemArray[4].ToString());
                    RETORNO.Add(dados);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        #region procedimento de graficos de Recebimento


        public DataTable ResumoRecebimentoMesGrafico(DateTime Mes)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                var dia = Mes.Day;
                var mes = Mes.Month;
                var ano = Mes.Year;
                string novadataInicial = ano + "-" + mes;
                //SELECT contratoparcelamento.ID,contratoparcelamento.ID_CONTRATO,contratoparcelamento.PLANO,contratoparcelamento.N_MENSALIDADE,contratoparcelamento.DATA_PAGAMENTO,contratoparcelamento.DATA_VENCIMENTO,contratoparcelamento.VALOR,contratoparcelamento.FORMA_PAGAMENTO,contratoparcelamento.VALOR_PAGO, contratoparcelamento.SITUACAO,c.ID,cli.NOME FROM contratoparcelamento inner JOIN contrato c on contratoparcelamento.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID WHERE MONTH(DATA_PAGAMENTO) = '" + mes + "' AND YEAR(DATA_PAGAMENTO) = '" + ano + "' AND SITUACAO = 'PAGO'
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoparcelamento.ID,contratoparcelamento.ID_CONTRATO,contratoparcelamento.PLANO,contratoparcelamento.N_MENSALIDADE,contratoparcelamento.DATA_PAGAMENTO,contratoparcelamento.DATA_VENCIMENTO,contratoparcelamento.VALOR,contratoparcelamento.FORMA_PAGAMENTO,contratoparcelamento.VALOR_PAGO, contratoparcelamento.SITUACAO,contratoparcelamento.VALORFRACIONADO,c.ID,cli.NOME " +
                    "FROM contratoparcelamento " +
                    "inner JOIN contrato c on contratoparcelamento.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID " +
                    "WHERE MONTH(contratoparcelamento.DATA_PAGAMENTO) = '" + mes + "' AND YEAR(contratoparcelamento.DATA_PAGAMENTO) = '" + ano + "' AND contratoparcelamento.SITUACAO = 'PAGO'  OR contratoparcelamento.VALORFRACIONADO > 0");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public DataTable ResumoreceitaMesGrafico(DateTime Ano)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var mes = Ano.Month;
                var ano = Ano.Year;
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM receita WHERE MONTH(DATA) = '" + mes + "' AND YEAR(DATA) = '" + ano + "' ");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        #endregion

        #region consulta portotal de faturamento por dia pra declaração de imposto
        public DataTable FaturamentoDiarioReceitasConsulta(DateTime Data)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                var dia = Data.Day;
                var mes = Data.Month;
                var ano = Data.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;
                //SELECT contratoparcelamento.ID,contratoparcelamento.ID_CONTRATO,contratoparcelamento.PLANO,contratoparcelamento.N_MENSALIDADE,contratoparcelamento.DATA_PAGAMENTO,contratoparcelamento.DATA_VENCIMENTO,contratoparcelamento.VALOR,contratoparcelamento.FORMA_PAGAMENTO,contratoparcelamento.VALOR_PAGO, contratoparcelamento.SITUACAO,c.ID,cli.NOME FROM contratoparcelamento inner JOIN contrato c on contratoparcelamento.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID WHERE MONTH(DATA_PAGAMENTO) = '" + mes + "' AND YEAR(DATA_PAGAMENTO) = '" + ano + "' AND SITUACAO = 'PAGO'
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text,
                    "SELECT contratoparcelamento.ID, contratoparcelamento.ID_CONTRATO, contratoparcelamento.PLANO, contratoparcelamento.N_MENSALIDADE, contratoparcelamento.DATA_PAGAMENTO, contratoparcelamento.DATA_VENCIMENTO, contratoparcelamento.VALOR, contratoparcelamento.FORMA_PAGAMENTO, contratoparcelamento.VALOR_PAGO, contratoparcelamento.SITUACAO, contratoparcelamento.VALORFRACIONADO, c.ID, cli.NOME " +
                    "FROM contratoparcelamento " +
                    "inner JOIN contrato c on contratoparcelamento.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID " +
                    "WHERE contratoparcelamento.DATA_PAGAMENTO = '" + novadataInicial + "' AND contratoparcelamento.SITUACAO = 'PAGO' OR contratoparcelamento.SITUACAO = 'FRACIONADO' AND contratoparcelamento.SITUACAO = 'PAGO'  OR contratoparcelamento.VALORFRACIONADO > 0");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        #endregion
    }
}
