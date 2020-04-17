using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.ContaaPagar
{
    public class ContaPagarDAL
    {
        DlConexao conexao;
        public void Salvar(ContaPagarModel contaPagar)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_FORNECEDOR", contaPagar.ID_FORNECEDOR);
                conexao.AdicionarParametros("@ID_CATEGORIA", contaPagar.ID_CATEGORIA);
                conexao.AdicionarParametros("@ID_USUARIO", contaPagar.ID_USUARIO);
                conexao.AdicionarParametros("@DATAVENCIMENTO", contaPagar.DATAVENCIMENTO);
                conexao.AdicionarParametros("@DATAEMISSAO", contaPagar.DATAEMISSAO);
                conexao.AdicionarParametros("@DATAALERTA", contaPagar.DATAALERTA);
                conexao.AdicionarParametros("@DESCRICAO", contaPagar.DESCRICAO);
                conexao.AdicionarParametros("@DATAPAGAMENTO", contaPagar.DATAPAGAMENTO);
                conexao.AdicionarParametros("@VALORPAGO", contaPagar.VALORPAGO);
                conexao.AdicionarParametros("@SITUACAO", contaPagar.SITUACAO);
                conexao.AdicionarParametros("@NUMERODOCUMENTO", contaPagar.NUMERODOCUMENTO);
                conexao.AdicionarParametros("@VALORCONTA", contaPagar.VALORCONTA);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO contapagar(ID_FORNECEDOR, ID_CATEGORIA, ID_USUARIO, DATAVENCIMENTO, DATAEMISSAO, DATAALERTA, DESCRICAO, DATAPAGAMENTO, VALORPAGO, SITUACAO,NUMERODOCUMENTO, VALORCONTA) " +
                    "VALUES (@ID_FORNECEDOR, @ID_CATEGORIA, @ID_USUARIO, @DATAVENCIMENTO, @DATAEMISSAO, @DATAALERTA, @DESCRICAO, @DATAPAGAMENTO, @VALORPAGO, @SITUACAO,@NUMERODOCUMENTO, @VALORCONTA)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ContaPagarModel> ListaConta(DateTime? dataInicial, DateTime? dataFinal, DateTime? DataVencimentoHoje, string Situacao)
        {
            try
            {

                DataTable Dados = new DataTable();
                conexao = new DlConexao();
                conexao.limparParametros();
                var Retorno = new List<ContaPagarModel>();
                //consulta por intervalos de data
                if ((dataInicial != null) && (dataFinal != null) && (Situacao == string.Empty))
                {
                    //desmebrando a data
                    string ano = dataInicial.Value.Year.ToString("0000");
                    string mes = dataInicial.Value.Month.ToString("00");
                    string dia = dataInicial.Value.Day.ToString("00");
                    string dataInicialDesmebrada = ano + "-" + mes + "-" + dia;

                    string anoFinal = dataFinal.Value.Year.ToString("0000");
                    string mesFinal = dataFinal.Value.Month.ToString("00");
                    string diaFinal = dataFinal.Value.Day.ToString("00");
                    string dataFinalDesmebrada = anoFinal + "-" + mesFinal + "-" + diaFinal;

                    Dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT contapagar.ID,forncedor.NOME as 'Fornecedor'," +
                        "categoriadespesa.NOME as 'Categoria'" +
                        ",usuario.NOME as 'Usuario'" +
                        ", contapagar.ID_FORNECEDOR, contapagar.ID_CATEGORIA, contapagar.ID_USUARIO, contapagar.DATAVENCIMENTO, contapagar.DATAEMISSAO, " +
                        "contapagar.DATAALERTA, contapagar.DESCRICAO, contapagar.DATAPAGAMENTO, contapagar.VALORPAGO, contapagar.SITUACAO, " +
                        "contapagar.NUMERODOCUMENTO,contapagar.VALORCONTA FROM contapagar " +
                        "INNER JOIN forncedor on forncedor.ID = contapagar.ID_FORNECEDOR " +
                        "INNER JOIN categoriadespesa on categoriadespesa.ID = contapagar.ID_CATEGORIA " +
                        "INNER JOIN usuario on usuario.ID = contapagar.ID_USUARIO " +
                        "WHERE contapagar.DATAEMISSAO BETWEEN ('" + dataInicialDesmebrada + "') AND ('" + dataFinalDesmebrada + "')");
                    //" AND contapagar.SITUACAO = '" + Situacao + "'  ORDER BY DATAVENCIMENTO ASC");
                    for (int i = 0; i < Dados.Rows.Count; i++)
                    {
                        ContaPagarModel contaPagar = new ContaPagarModel();
                        contaPagar.ID = Convert.ToInt32(Dados.Rows[i].ItemArray[0]);
                        //tra os dados do iner join da consulta
                        contaPagar.fornecedor = new FornecedorModel();
                        contaPagar.fornecedor.NOME = Convert.ToString(Dados.Rows[i].ItemArray[1]);
                        contaPagar.categoria = new despesasCategoria();
                        contaPagar.categoria.NOME = Convert.ToString(Dados.Rows[i].ItemArray[2]);
                        contaPagar.usuario = new LoginUsuario();
                        contaPagar.usuario.NOME = Convert.ToString(Dados.Rows[i].ItemArray[3]);

                        contaPagar.ID_FORNECEDOR = Convert.ToInt32(Dados.Rows[i].ItemArray[4]);
                        contaPagar.ID_CATEGORIA = Convert.ToInt32(Dados.Rows[i].ItemArray[5]);
                        contaPagar.ID_USUARIO = Convert.ToInt32(Dados.Rows[i].ItemArray[6]);

                        contaPagar.DATAVENCIMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[7]);
                        contaPagar.DATAEMISSAO = Convert.ToDateTime(Dados.Rows[i].ItemArray[8]);
                        contaPagar.DATAALERTA = Convert.ToDateTime(Dados.Rows[i].ItemArray[9]);
                        contaPagar.DESCRICAO = Convert.ToString(Dados.Rows[i].ItemArray[10]);
                        if (Dados.Rows[i].ItemArray[11] != DBNull.Value)
                            contaPagar.DATAPAGAMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[11]);
                        contaPagar.VALORPAGO = Convert.ToDecimal(Dados.Rows[i].ItemArray[12]);
                        contaPagar.SITUACAO = Convert.ToString(Dados.Rows[i].ItemArray[13]);
                        contaPagar.NUMERODOCUMENTO = Convert.ToString(Dados.Rows[i].ItemArray[14]);
                        contaPagar.VALORCONTA = Convert.ToDecimal(Dados.Rows[i].ItemArray[15]);
                        Retorno.Add(contaPagar);
                    }
                }

                //consulta por intervalos de data
                else if ((dataInicial != null) && (dataFinal != null) && (Situacao != string.Empty))
                {
                    //desmebrando a data
                    string ano = dataInicial.Value.Year.ToString("0000");
                    string mes = dataInicial.Value.Month.ToString("00");
                    string dia = dataInicial.Value.Day.ToString("00");
                    string dataInicialDesmebrada = ano + "-" + mes + "-" + dia;

                    string anoFinal = dataFinal.Value.Year.ToString("0000");
                    string mesFinal = dataFinal.Value.Month.ToString("00");
                    string diaFinal = dataFinal.Value.Day.ToString("00");
                    string dataFinalDesmebrada = anoFinal + "-" + mesFinal + "-" + diaFinal;
                    if (Situacao == "PAGO")
                    {
                        Dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT contapagar.ID,forncedor.NOME as 'Fornecedor'," +
                       "categoriadespesa.NOME as 'Categoria'" +
                       ",usuario.NOME as 'Usuario'" +
                       ", contapagar.ID_FORNECEDOR, contapagar.ID_CATEGORIA, contapagar.ID_USUARIO, contapagar.DATAVENCIMENTO, contapagar.DATAEMISSAO, " +
                       "contapagar.DATAALERTA, contapagar.DESCRICAO, contapagar.DATAPAGAMENTO, contapagar.VALORPAGO, contapagar.SITUACAO, " +
                       "contapagar.NUMERODOCUMENTO, contapagar.VALORCONTA FROM contapagar " +
                       "INNER JOIN forncedor on forncedor.ID = contapagar.ID_FORNECEDOR " +
                       "INNER JOIN categoriadespesa on categoriadespesa.ID = contapagar.ID_CATEGORIA " +
                       "INNER JOIN usuario on usuario.ID = contapagar.ID_USUARIO " +
                       "WHERE contapagar.DATAPAGAMENTO BETWEEN ('" + dataInicialDesmebrada + "') AND ('" + dataFinalDesmebrada + "')" +
                   " AND contapagar.SITUACAO = '" + Situacao + "'  ORDER BY DATAVENCIMENTO ASC");
                    }
                    else if (Situacao == "NAO PAGO")
                    {
                        Dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT contapagar.ID,forncedor.NOME as 'Fornecedor'," +
                      "categoriadespesa.NOME as 'Categoria'" +
                      ",usuario.NOME as 'Usuario'" +
                      ", contapagar.ID_FORNECEDOR, contapagar.ID_CATEGORIA, contapagar.ID_USUARIO, contapagar.DATAVENCIMENTO, contapagar.DATAEMISSAO, " +
                      "contapagar.DATAALERTA, contapagar.DESCRICAO, contapagar.DATAPAGAMENTO, contapagar.VALORPAGO, contapagar.SITUACAO, " +
                      "contapagar.NUMERODOCUMENTO, contapagar.VALORCONTA FROM contapagar " +
                      "INNER JOIN forncedor on forncedor.ID = contapagar.ID_FORNECEDOR " +
                      "INNER JOIN categoriadespesa on categoriadespesa.ID = contapagar.ID_CATEGORIA " +
                      "INNER JOIN usuario on usuario.ID = contapagar.ID_USUARIO " +
                      "WHERE contapagar.DATAEMISSAO BETWEEN ('" + dataInicialDesmebrada + "') AND ('" + dataFinalDesmebrada + "')" +
                  " AND contapagar.SITUACAO = '" + Situacao + "'  ORDER BY DATAVENCIMENTO ASC");
                    }

                    for (int i = 0; i < Dados.Rows.Count; i++)
                    {
                        ContaPagarModel contaPagar = new ContaPagarModel();
                        contaPagar.ID = Convert.ToInt32(Dados.Rows[i].ItemArray[0]);
                        //tra os dados do iner join da consulta
                        contaPagar.fornecedor = new FornecedorModel();
                        contaPagar.fornecedor.NOME = Convert.ToString(Dados.Rows[i].ItemArray[1]);
                        contaPagar.categoria = new despesasCategoria();
                        contaPagar.categoria.NOME = Convert.ToString(Dados.Rows[i].ItemArray[2]);
                        contaPagar.usuario = new LoginUsuario();
                        contaPagar.usuario.NOME = Convert.ToString(Dados.Rows[i].ItemArray[3]);

                        contaPagar.ID_FORNECEDOR = Convert.ToInt32(Dados.Rows[i].ItemArray[4]);
                        contaPagar.ID_CATEGORIA = Convert.ToInt32(Dados.Rows[i].ItemArray[5]);
                        contaPagar.ID_USUARIO = Convert.ToInt32(Dados.Rows[i].ItemArray[6]);

                        contaPagar.DATAVENCIMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[7]);
                        contaPagar.DATAEMISSAO = Convert.ToDateTime(Dados.Rows[i].ItemArray[8]);
                        contaPagar.DATAALERTA = Convert.ToDateTime(Dados.Rows[i].ItemArray[9]);
                        contaPagar.DESCRICAO = Convert.ToString(Dados.Rows[i].ItemArray[10]);
                        if (Dados.Rows[i].ItemArray[11] != DBNull.Value)
                            contaPagar.DATAPAGAMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[11]);
                        contaPagar.VALORPAGO = Convert.ToDecimal(Dados.Rows[i].ItemArray[12]);
                        contaPagar.SITUACAO = Convert.ToString(Dados.Rows[i].ItemArray[13]);
                        contaPagar.NUMERODOCUMENTO = Convert.ToString(Dados.Rows[i].ItemArray[14]);
                        contaPagar.VALORCONTA = Convert.ToDecimal(Dados.Rows[i].ItemArray[15]);
                        Retorno.Add(contaPagar);
                    }
                }

                //Consulta por data do dia 
                else if ((DataVencimentoHoje != null) && (dataInicial == null) && (dataFinal == null) && (Situacao == string.Empty))
                {
                    //desmebrando a data
                    string ano = DataVencimentoHoje.Value.Year.ToString("0000");
                    string mes = DataVencimentoHoje.Value.Month.ToString("00");
                    string dia = DataVencimentoHoje.Value.Day.ToString("00");
                    string datadesmebrada = ano + "-" + mes + "-" + dia;
                    Dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT contapagar.ID,forncedor.NOME as 'Fornecedor'," +
                        "categoriadespesa.NOME as 'Categoria'" +
                        ",usuario.NOME as 'Usuario'" +
                        ", contapagar.ID_FORNECEDOR, contapagar.ID_CATEGORIA, contapagar.ID_USUARIO, contapagar.DATAVENCIMENTO, contapagar.DATAEMISSAO, " +
                        "contapagar.DATAALERTA, contapagar.DESCRICAO, contapagar.DATAPAGAMENTO, contapagar.VALORPAGO, contapagar.SITUACAO, " +
                        "contapagar.NUMERODOCUMENTO, contapagar.VALORCONTA FROM contapagar " +
                        "INNER JOIN forncedor on forncedor.ID = contapagar.ID_FORNECEDOR " +
                        "INNER JOIN categoriadespesa on categoriadespesa.ID = contapagar.ID_CATEGORIA " +
                        "INNER JOIN usuario on usuario.ID = contapagar.ID_USUARIO " +
                        "WHERE contapagar.DATAEMISSAO = '" + datadesmebrada + "' AND contapagar.SITUACAO = '" + Situacao + "'  ORDER BY DATAVENCIMENTO ASC");
                    for (int i = 0; i < Dados.Rows.Count; i++)
                    {
                        ContaPagarModel contaPagar = new ContaPagarModel();
                        contaPagar.ID = Convert.ToInt32(Dados.Rows[i].ItemArray[0]);
                        //tra os dados do iner join da consulta
                        contaPagar.fornecedor = new FornecedorModel();
                        contaPagar.fornecedor.NOME = Convert.ToString(Dados.Rows[i].ItemArray[1]);
                        contaPagar.categoria = new despesasCategoria();
                        contaPagar.categoria.NOME = Convert.ToString(Dados.Rows[i].ItemArray[2]);
                        contaPagar.usuario = new LoginUsuario();
                        contaPagar.usuario.NOME = Convert.ToString(Dados.Rows[i].ItemArray[3]);

                        contaPagar.ID_FORNECEDOR = Convert.ToInt32(Dados.Rows[i].ItemArray[4]);
                        contaPagar.ID_CATEGORIA = Convert.ToInt32(Dados.Rows[i].ItemArray[5]);
                        contaPagar.ID_USUARIO = Convert.ToInt32(Dados.Rows[i].ItemArray[6]);

                        contaPagar.DATAVENCIMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[7]);
                        contaPagar.DATAEMISSAO = Convert.ToDateTime(Dados.Rows[i].ItemArray[8]);
                        contaPagar.DATAALERTA = Convert.ToDateTime(Dados.Rows[i].ItemArray[9]);
                        contaPagar.DESCRICAO = Convert.ToString(Dados.Rows[i].ItemArray[10]);
                        if (Dados.Rows[i].ItemArray[11] != DBNull.Value)
                            contaPagar.DATAPAGAMENTO = Convert.ToDateTime(Dados.Rows[i].ItemArray[11]);
                        contaPagar.VALORPAGO = Convert.ToDecimal(Dados.Rows[i].ItemArray[12]);
                        contaPagar.SITUACAO = Convert.ToString(Dados.Rows[i].ItemArray[13]);
                        contaPagar.NUMERODOCUMENTO = Convert.ToString(Dados.Rows[i].ItemArray[14]);
                        contaPagar.VALORCONTA = Convert.ToDecimal(Dados.Rows[i].ItemArray[15]);
                        Retorno.Add(contaPagar);
                    }
                }

                return Retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(ContaPagarModel contaPagar)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("ID", contaPagar.ID);
                conexao.AdicionarParametros("ID_FORNECEDOR", contaPagar.ID_FORNECEDOR);
                conexao.AdicionarParametros("ID_CATEGORIA", contaPagar.ID_CATEGORIA);
                conexao.AdicionarParametros("ID_USUARIO", contaPagar.ID_USUARIO);
                conexao.AdicionarParametros("DATAVENCIMENTO", contaPagar.DATAVENCIMENTO);
                conexao.AdicionarParametros("DATAEMISSAO", contaPagar.DATAEMISSAO);
                conexao.AdicionarParametros("DATAALERTA", contaPagar.DATAALERTA);
                conexao.AdicionarParametros("DESCRICAO", contaPagar.DESCRICAO);
                //conexao.AdicionarParametros("@DATAPAGAMENTO", contaPagar.DATAPAGAMENTO);
                //conexao.AdicionarParametros("@VALORPAGO", contaPagar.VALORPAGO);
                //conexao.AdicionarParametros("@SITUACAO", contaPagar.SITUACAO);
                conexao.AdicionarParametros("@NUMERODOCUMENTO", contaPagar.NUMERODOCUMENTO);
                conexao.AdicionarParametros("@VALORCONTA", contaPagar.VALORCONTA);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contapagar SET ID_FORNECEDOR=@ID_FORNECEDOR,ID_CATEGORIA=@ID_CATEGORIA,ID_USUARIO=@ID_USUARIO," +
                    "DATAVENCIMENTO=@DATAVENCIMENTO,DATAEMISSAO=@DATAEMISSAO,DATAALERTA=@DATAALERTA,DESCRICAO=@DESCRICAO," +
                    "NUMERODOCUMENTO=@NUMERODOCUMENTO,VALORCONTA=@VALORCONTA WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ContasAlerta()
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contapagar WHERE DATAALERTA <= NOW() AND SITUACAO = 'NAO PAGO'");
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public void UpdateContaPaga(ContaPagarModel contaPagar)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("ID", contaPagar.ID);
                //conexao.AdicionarParametros("ID_FORNECEDOR", contaPagar.ID_FORNECEDOR);
                //conexao.AdicionarParametros("ID_CATEGORIA", contaPagar.ID_CATEGORIA);
                //conexao.AdicionarParametros("ID_USUARIO", contaPagar.ID_USUARIO);
                //conexao.AdicionarParametros("DATAVENCIMENTO", contaPagar.DATAVENCIMENTO);
                //conexao.AdicionarParametros("DATAEMISSAO", contaPagar.DATAEMISSAO);
                //conexao.AdicionarParametros("DATAALERTA", contaPagar.DATAALERTA);
                //conexao.AdicionarParametros("DESCRICAO", contaPagar.DESCRICAO);
                conexao.AdicionarParametros("@DATAPAGAMENTO", contaPagar.DATAPAGAMENTO);
                conexao.AdicionarParametros("@VALORPAGO", contaPagar.VALORPAGO);
                conexao.AdicionarParametros("@SITUACAO", contaPagar.SITUACAO);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE contapagar SET DATAPAGAMENTO=@DATAPAGAMENTO ,VALORPAGO=@VALORPAGO ,SITUACAO=@SITUACAO WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ContaPagarModel LocalizarConta(int codigo)
        {
            try
            {
                var retorno = new ContaPagarModel();
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", codigo);
                var Dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM contapagar WHERE ID = @ID");
                if (Dados.Rows.Count > 0)
                {
                    retorno.ID = Convert.ToInt32(Dados.Rows[0].ItemArray[0]);

                    retorno.ID_FORNECEDOR = Convert.ToInt32(Dados.Rows[0].ItemArray[1]);
                    retorno.ID_CATEGORIA = Convert.ToInt32(Dados.Rows[0].ItemArray[2]);
                    retorno.ID_USUARIO = Convert.ToInt32(Dados.Rows[0].ItemArray[3]);

                    retorno.DATAVENCIMENTO = Convert.ToDateTime(Dados.Rows[0].ItemArray[4]);
                    retorno.DATAEMISSAO = Convert.ToDateTime(Dados.Rows[0].ItemArray[5]);
                    retorno.DATAALERTA = Convert.ToDateTime(Dados.Rows[0].ItemArray[6]);
                    retorno.DESCRICAO = Convert.ToString(Dados.Rows[0].ItemArray[7]);
                    if (Dados.Rows[0].ItemArray[8] != DBNull.Value)
                        retorno.DATAPAGAMENTO = Convert.ToDateTime(Dados.Rows[0].ItemArray[8]);
                    retorno.VALORPAGO = Convert.ToDecimal(Dados.Rows[0].ItemArray[9]);
                    retorno.SITUACAO = Convert.ToString(Dados.Rows[0].ItemArray[10]);
                    retorno.NUMERODOCUMENTO = Convert.ToString(Dados.Rows[0].ItemArray[11]);
                    retorno.VALORCONTA = Convert.ToDecimal(Dados.Rows[0].ItemArray[12]);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ResumoContaPagasMesGrafico(DateTime? Mes, DateTime? Mesnaopago)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                if (Mes != null)
                {
                    var dia = Mes.Value.Day;
                    var mes = Mes.Value.Month;
                    var ano = Mes.Value.Year;
                    string novadataInicial = ano + "-" + mes;
                    RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contapagar WHERE MONTH(DATAPAGAMENTO) = '" + mes + "' AND YEAR(DATAPAGAMENTO) = '" + ano + "' AND SITUACAO = 'PAGO'");
                }
                else if (Mesnaopago != null)
                {
                    var dia = Mesnaopago.Value.Day;
                    var mes = Mesnaopago.Value.Month;
                    var ano = Mesnaopago.Value.Year;
                    string novadataInicial = ano + "-" + mes;
                    RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contapagar WHERE MONTH(DATAVENCIMENTO) = '" + mes + "' AND YEAR(DATAVENCIMENTO) = '" + ano + "' AND SITUACAO = 'NAO PAGO'");
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public DataTable ResumoInstacaodia(DateTime dia, int categoria)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                string dias = dia.Day.ToString("00");
                string mes = dia.Month.ToString("00");
                string ano = dia.Year.ToString();
                string novadataInicial = ano + "-" + mes + "-" + dias;
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM contapagar WHERE DATAPAGAMENTO ='" + novadataInicial + "' AND ID_CATEGORIA = '" + categoria + "' ");

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
    }
}
