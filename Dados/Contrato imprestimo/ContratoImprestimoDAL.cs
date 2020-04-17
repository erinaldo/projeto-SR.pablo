using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Contrato_imprestimo
{
    public class ContratoImprestimoDAL
    {
        DlConexao conexao;
        public void ReceberPagamento(ContratoImprestimoParcela contrato)
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
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoimprestimoparcela SET " +
                    "DATA_PAGAMENTO=@DATA_PAGAMENTO, " +
                    "FORMA_PAGAMENTO=@FORMA_PAGAMENTO," +
                    "VALORFRACIONADO = 0 ," +
                     "VALOR_PAGO=@VALOR_PAGO," +
                    "SITUACAO=@SITUACAO " +
                    "WHERE ID_CONTRATO = @ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ReceberPagamentoFracionado(ContratoImprestimoParcela contrato)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", contrato.ID_CONTRATO);
                conexao.AdicionarParametros("@VALORFRACIONADO", contrato.VALORFRACIONADO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", contrato.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@FORMA_PAGAMENTO", contrato.FORMA_PAGAMENTO);
                conexao.AdicionarParametros("@SITUACAO", contrato.SITUACAO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", contrato.DATA_VENCIMENTO);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoimprestimoparcela SET " +
                    "DATA_PAGAMENTO=@DATA_PAGAMENTO," +
                    "FORMA_PAGAMENTO=@FORMA_PAGAMENTO," +
                    "VALORFRACIONADO=@VALORFRACIONADO," +
                    "SITUACAO=@SITUACAO " +
                    "WHERE ID_CONTRATO = @ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AlterarParcelas(ContratoImprestimoParcela dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", dados.ID_CONTRATO);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", dados.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@N_MENSALIDADE", dados.N_MENSALIDADE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoimprestimoparcela SET SITUACAO = @SITUACAO, DATA_PAGAMENTO = @DATA_PAGAMENTO WHERE ID_CONTRATO=@ID_CONTRATO AND N_MENSALIDADE = @N_MENSALIDADE ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ContratoImprestimo> ConsultaContratos(ContratoImprestimo contrato)
        {
            List<ContratoImprestimo> RETORNO = new List<ContratoImprestimo>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", contrato.ID_CLIENTE);
                //conexao.AdicionarParametros("@ID", contrato.ID);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimo.ID,cliente.NOME,contratoimprestimo.VALOR_IMPRESTADO,contratoimprestimo.JUROS,contratoimprestimo.VALOR_JUROS,contratoimprestimo.DIA_BASE,contratoimprestimo.SITUACAO " +
                    "FROM contratoimprestimo INNER join cliente on cliente.ID = contratoimprestimo.ID_CLIENTE " +
                    "WHERE contratoimprestimo.ID_CLIENTE = @id_cliente");
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    var dados = new ContratoImprestimo();
                    dados.ClienteContrato = new cliente();

                    dados.ID = Convert.ToInt32(DATA.Rows[i].ItemArray[0].ToString());
                    dados.ClienteContrato.NOME = Convert.ToString(DATA.Rows[i].ItemArray[1].ToString());
                    dados.VALOR_IMPRESTADO = Convert.ToDecimal(DATA.Rows[i].ItemArray[2].ToString());
                    dados.JUROS = Convert.ToString(DATA.Rows[i].ItemArray[3].ToString());
                    dados.VALOR_JUROS = Convert.ToDecimal(DATA.Rows[i].ItemArray[4].ToString());
                    dados.DIA_BASE = Convert.ToInt32(DATA.Rows[i].ItemArray[5].ToString());
                    dados.SITUACAO = Convert.ToString(DATA.Rows[i].ItemArray[6].ToString());
                    RETORNO.Add(dados);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public void UpdateSituacao(ContratoModel dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", dados.ID);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoimprestimo SET SITUACAO = @SITUACAO WHERE ID=@ID ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //public void Update(ContratoImprestimo dados)
        //{
        //    conexao = new DlConexao();
        //    try
        //    {
        //        conexao.limparParametros();
        //        conexao.AdicionarParametros("@ID", dados.ID);
        //        conexao.AdicionarParametros("@ID_CLIENTE", dados.ID_CLIENTE);
        //        conexao.AdicionarParametros("@VALOR_MES", dados.VALOR_MES);
        //        conexao.AdicionarParametros("@DIA_BASE", dados.DIA_BASE);
        //        conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contrato SET ID_CLIENTE = @ID_CLIENTE, VALOR_MES = @VALOR_MES ,DIA_BASE = @DIA_BASE WHERE ID=@ID ");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        public void AlterarParcelasAtradadas(ContratoImprestimoParcela dados)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", dados.ID_CONTRATO);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", dados.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@N_MENSALIDADE", dados.N_MENSALIDADE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contratoimprestimoparcela SET SITUACAO = @SITUACAO, N_MENSALIDADE = @N_MENSALIDADE  WHERE ID_CONTRATO=@ID_CONTRATO AND DATA_VENCIMENTO = @DATA_VENCIMENTO ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID_CONTRATO ,cliente.NOME, contratoimprestimoparcela.PLANO, contratoimprestimoparcela.DATA_VENCIMENTO, contratoimprestimoparcela.VALOR_PRESTACAO, contratoimprestimoparcela.VALOR_JUROS,contratoimprestimoparcela.N_MENSALIDADE, contratoimprestimoparcela.SITUACAO FROM contratoimprestimoparcela INNER JOIN contratoimprestimo on contratoimprestimo.ID = contratoimprestimoparcela.ID_CONTRATO INNER JOIN cliente on cliente.ID = contratoimprestimo.ID_CLIENTE  " +
                    "WHERE contratoimprestimoparcela.DATA_VENCIMENTO BETWEEN date('" + novadataFinal + "')  AND date('" + novadataInicial + "') AND contratoimprestimoparcela.SITUACAO = '" + situacao + "'  AND contratoimprestimoparcela.SITUACAO <> 'PAGO' AND contratoimprestimoparcela.SITUACAO <> 'CANCELADO' AND contratoimprestimoparcela.SITUACAO <> 'GRATIS (BONUS)' AND contratoimprestimoparcela.SITUACAO <> 'JUROS' AND contratoimprestimoparcela.SITUACAO <> 'FRACIONADO' ");

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }
        public ContratoImprestimo ConsultacontratoAtivo(int ID_CLIENTE, string Situacao)
        {
            ContratoImprestimo RETORNO = new ContratoImprestimo();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", ID_CLIENTE);
                conexao.AdicionarParametros("@Situacao", Situacao);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimo WHERE ID_CLIENTE = @id_cliente AND SITUACAO = @Situacao");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoImprestimo>(DATA, 0);
                }

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

                var dia = dataInicial.Day.ToString("00");
                var mes = dataInicial.Month.ToString("00");
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID_CONTRATO ,cliente.NOME, contratoimprestimoparcela.PLANO, contratoimprestimoparcela.DATA_VENCIMENTO, contratoimprestimoparcela.VALOR_PRESTACAO, contratoimprestimoparcela.VALOR_JUROS ,contratoimprestimoparcela.N_MENSALIDADE, contratoimprestimoparcela.SITUACAO FROM contratoimprestimoparcela INNER JOIN contratoimprestimo on contratoimprestimo.ID = contratoimprestimoparcela.ID_CONTRATO INNER JOIN cliente on cliente.ID = contratoimprestimo.ID_CLIENTE  " +
                    "WHERE contratoimprestimoparcela.DATA_VENCIMENTO = '" + novadataInicial + "' AND contratoimprestimoparcela.SITUACAO = 'NAO PAGO' AND contratoimprestimoparcela.SITUACAO <> 'CANCELADO' AND contratoimprestimoparcela.SITUACAO <> 'JUROS' ORDER BY contratoimprestimoparcela.DATA_VENCIMENTO ASC");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public int Salvar(ContratoImprestimo dados)
        {
            int retorno = 0;
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CLIENTE", dados.ID_CLIENTE);
                conexao.AdicionarParametros("@VALOR_IMPRESTADO", dados.VALOR_IMPRESTADO);
                conexao.AdicionarParametros("@JUROS", dados.JUROS);
                conexao.AdicionarParametros("@VALOR_JUROS", dados.VALOR_JUROS);
                conexao.AdicionarParametros("@DIA_BASE", dados.DIA_BASE);
                conexao.AdicionarParametros("@SITUACAO", dados.SITUACAO);
                conexao.AdicionarParametros("@DATA", DateTime.Now.Date);

                retorno = Convert.ToInt32(conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO contratoimprestimo(ID_CLIENTE, VALOR_IMPRESTADO,JUROS,VALOR_JUROS, DIA_BASE,SITUACAO, DATA) " +
                    "VALUES (@ID_CLIENTE,@VALOR_IMPRESTADO,@JUROS,@VALOR_JUROS, @DIA_BASE,@SITUACAO,@DATA); SELECT LAST_INSERT_ID();"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public ContratoImprestimo Consulta(ContratoImprestimo contrato)
        {
            ContratoImprestimo RETORNO = new ContratoImprestimo();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@id_cliente", contrato.ID_CLIENTE);
                conexao.AdicionarParametros("@ID", contrato.ID);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimo WHERE ID_CLIENTE = @id_cliente AND ID = @ID");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoImprestimo>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public void InserirParcelas(ContratoImprestimoParcela contrato)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", contrato.ID_CONTRATO);
                conexao.AdicionarParametros("@VALOR_PRESTACAO", contrato.VALOR_PRESTACAO);
                conexao.AdicionarParametros("@VALOR_JUROS", contrato.VALOR_JUROS);
                conexao.AdicionarParametros("@N_MENSALIDADE", contrato.N_MENSALIDADE);
                conexao.AdicionarParametros("@PLANO", contrato.PLANO);
                conexao.AdicionarParametros("@DATA_VENCIMENTO", contrato.DATA_VENCIMENTO);
                conexao.AdicionarParametros("@DATA_PAGAMENTO", contrato.DATA_PAGAMENTO);
                conexao.AdicionarParametros("@SITUACAO", contrato.SITUACAO);
                conexao.AdicionarParametros("@AMORTIZACAO", contrato.AMORTIZACAO);
                conexao.AdicionarParametros("@SALDODEVEDOR", contrato.SALDODEVEDOR);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO contratoimprestimoparcela(ID_CONTRATO,PLANO, N_MENSALIDADE, DATA_PAGAMENTO, DATA_VENCIMENTO, VALOR_PRESTACAO, VALOR_JUROS,AMORTIZACAO,SALDODEVEDOR, SITUACAO) " +
                    "VALUES (@ID_CONTRATO, @PLANO,@N_MENSALIDADE, @DATA_PAGAMENTO, @DATA_VENCIMENTO, @VALOR_PRESTACAO, @VALOR_JUROS, @AMORTIZACAO, @SALDODEVEDOR, @SITUACAO)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ContratoImprestimoParcela> ConsultaParcelas(int ID_CONTRATO)
        {
            List<ContratoImprestimoParcela> RETORNO = new List<ContratoImprestimoParcela>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CONTRATO", ID_CONTRATO);
                var dados = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimoparcela WHERE ID_CONTRATO = @ID_CONTRATO");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<ContratoImprestimoParcela>(dados, i);
                    RETORNO.Add(novos);
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }
        //busca parcelas de contratos ativos e parcelas pagas ou fracionada
        public List<ContratoImprestimoParcela> ConsultaParcelasPagasFinanceiroNORMAL(int iD_Contrato)
        {
            List<ContratoImprestimoParcela> RETORNO = new List<ContratoImprestimoParcela>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var dados = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimoparcela " +
                    "WHERE ID_CONTRATO =" + iD_Contrato + " AND SITUACAO ='PAGO' ");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<ContratoImprestimoParcela>(dados, i);
                    RETORNO.Add(novos);
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }
        public List<ContratoImprestimoParcela> ConsultaParcelasPagasFinanceiroFRACIONADO(int iD_Contrato)
        {
            List<ContratoImprestimoParcela> RETORNO = new List<ContratoImprestimoParcela>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var dados = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimoparcela " +
                    "WHERE ID_CONTRATO = "+ iD_Contrato + " AND SITUACAO ='FRACIONADO' ");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<ContratoImprestimoParcela>(dados, i);
                    RETORNO.Add(novos);
                }

            }
            catch (Exception EX)
            {

                throw EX;
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

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID ,contratoimprestimoparcela.ID_CONTRATO ,cliente.NOME, contratoimprestimoparcela.PLANO, contratoimprestimoparcela.DATA_VENCIMENTO, contratoimprestimoparcela.VALOR_PRESTACAO,contratoimprestimoparcela.VALOR_JUROS,contratoimprestimoparcela.N_MENSALIDADE, contratoimprestimoparcela.SITUACAO,contratoimprestimoparcela.VALORFRACIONADO FROM contratoimprestimoparcela INNER JOIN contratoimprestimo on contratoimprestimo.ID = contratoimprestimoparcela.ID_CONTRATO INNER JOIN cliente on cliente.ID = contratoimprestimo.ID_CLIENTE  " +
                    "WHERE contratoimprestimoparcela.DATA_VENCIMENTO BETWEEN date('" + novadataInicial + "') AND date('" + novadataFinal + "') AND contratoimprestimoparcela.SITUACAO = 'NAO PAGO' OR contratoimprestimoparcela.SITUACAO = 'ATRASADO' OR contratoimprestimoparcela.SITUACAO = 'FRACIONADO' AND contratoimprestimoparcela.SITUACAO <> 'CANCELADO' and contratoimprestimoparcela.SITUACAO <> 'JUROS' ORDER BY contratoimprestimoparcela.DATA_VENCIMENTO ASC");

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

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID,contratoimprestimoparcela.ID_CONTRATO ,cliente.NOME, contratoimprestimoparcela.PLANO, contratoimprestimoparcela.DATA_VENCIMENTO, contratoimprestimoparcela.VALOR_PRESTACAO ,contratoimprestimoparcela.VALOR_JUROS, contratoimprestimoparcela.N_MENSALIDADE, contratoimprestimoparcela.SITUACAO,contratoimprestimoparcela.VALORFRACIONADO " +
                    "FROM contratoimprestimoparcela INNER JOIN contratoimprestimo on contratoimprestimo.ID = contratoimprestimoparcela.ID_CONTRATO INNER JOIN cliente on cliente.ID = contratoimprestimo.ID_CLIENTE  " +
                    "WHERE  contratoimprestimoparcela.ID_CONTRATO = " + contrato + "");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public List<ContratoImprestimo> ListapelasituacaoContrato (string situacao)
        {
            var RETORNO = new List<ContratoImprestimo>();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@situacao", situacao);
                var dados = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimo WHERE SITUACAO = @situacao");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<ContratoImprestimo>(dados, i);
                    RETORNO.Add(novos);
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public DataTable ResumoRecebimentoMesGrafico(DateTime Mes)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                string dia = Mes.Day.ToString("00");
                string mes = Mes.Month.ToString("00");
                var ano = Mes.Year;
                string novadataInicial = ano + "-" + mes;
                //SELECT contratoparcelamento.ID,contratoparcelamento.ID_CONTRATO,contratoparcelamento.PLANO,contratoparcelamento.N_MENSALIDADE,contratoparcelamento.DATA_PAGAMENTO,contratoparcelamento.DATA_VENCIMENTO,contratoparcelamento.VALOR,contratoparcelamento.FORMA_PAGAMENTO,contratoparcelamento.VALOR_PAGO, contratoparcelamento.SITUACAO,c.ID,cli.NOME FROM contratoparcelamento inner JOIN contrato c on contratoparcelamento.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID WHERE MONTH(DATA_PAGAMENTO) = '" + mes + "' AND YEAR(DATA_PAGAMENTO) = '" + ano + "' AND SITUACAO = 'PAGO'
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID,contratoimprestimoparcela.ID_CONTRATO,contratoimprestimoparcela.PLANO,contratoimprestimoparcela.N_MENSALIDADE,contratoimprestimoparcela.DATA_PAGAMENTO,contratoimprestimoparcela.DATA_VENCIMENTO,contratoimprestimoparcela.VALOR_PRESTACAO,contratoimprestimoparcela.VALOR_JUROS ,contratoimprestimoparcela.AMORTIZACAO ,contratoimprestimoparcela.SALDODEVEDOR,contratoimprestimoparcela.FORMA_PAGAMENTO,contratoimprestimoparcela.VALOR_PAGO,contratoimprestimoparcela.VALORFRACIONADO, contratoimprestimoparcela.SITUACAO,c.ID,cli.NOME " +
                    "FROM contratoimprestimoparcela inner JOIN contratoimprestimo c on contratoimprestimoparcela.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID " +
                    "WHERE MONTH(contratoimprestimoparcela.DATA_PAGAMENTO) = '" + mes + "' AND YEAR(contratoimprestimoparcela.DATA_PAGAMENTO) = '" + ano + "' AND contratoimprestimoparcela.SITUACAO = 'PAGO' or contratoimprestimoparcela.SITUACAO = 'JUROS' or contratoimprestimoparcela.SITUACAO = 'FRACIONADO'");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public DataTable ResumoRecebimentoMesFuturo(DateTime Mes)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                string dia = Mes.Day.ToString("00");
                string mes = Mes.Month.ToString("00");
                var ano = Mes.Year;
                string novadataInicial = ano + "-" + mes;
                
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT contratoimprestimoparcela.ID,contratoimprestimoparcela.ID_CONTRATO,contratoimprestimoparcela.PLANO,contratoimprestimoparcela.N_MENSALIDADE,contratoimprestimoparcela.DATA_PAGAMENTO,contratoimprestimoparcela.DATA_VENCIMENTO,contratoimprestimoparcela.VALOR_PRESTACAO,contratoimprestimoparcela.VALOR_JUROS ,contratoimprestimoparcela.AMORTIZACAO ,contratoimprestimoparcela.SALDODEVEDOR,contratoimprestimoparcela.FORMA_PAGAMENTO,contratoimprestimoparcela.VALOR_PAGO,contratoimprestimoparcela.VALORFRACIONADO, contratoimprestimoparcela.SITUACAO,c.ID,cli.NOME " +
                    "FROM contratoimprestimoparcela inner JOIN contratoimprestimo c on contratoimprestimoparcela.ID_CONTRATO = c.ID inner JOIN cliente cli on c.ID_CLIENTE = cli.ID " +
                    "WHERE MONTH(contratoimprestimoparcela.DATA_VENCIMENTO) = '" + mes + "' AND YEAR(contratoimprestimoparcela.DATA_VENCIMENTO) = '" + ano + "' AND contratoimprestimoparcela.SITUACAO = 'NAO PAGO'");
            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public ContratoImprestimo ConsultaContratoID(int contrato)
        {
            ContratoImprestimo RETORNO = new ContratoImprestimo();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                conexao.AdicionarParametros("@ID", contrato);
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contratoimprestimo WHERE ID = @ID");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<ContratoImprestimo>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
    }
}
