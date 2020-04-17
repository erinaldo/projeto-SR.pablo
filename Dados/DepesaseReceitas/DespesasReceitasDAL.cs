using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.DepesaseReceitas
{
    public class DespesasReceitasDAL
    {
        DlConexao conexao;
        public void InserirDespesas(despesas despesas)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CATEGORIA", despesas.ID_CATEGORIA);
                conexao.AdicionarParametros("@DATA", despesas.DATA);
                conexao.AdicionarParametros("@DESCRICAO", despesas.DESCRICAO);
                conexao.AdicionarParametros("@VALOR", despesas.VALOR);
                conexao.AdicionarParametros("@ID_IMOVEL", despesas.ID_IMOVEL);
                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO despesa(DESCRICAO, ID_CATEGORIA, DATA, VALOR,ID_IMOVEL) VALUES (@DESCRICAO, @ID_CATEGORIA, @DATA, @VALOR,@ID_IMOVEL)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void InserirReceitas(receitas receitas)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CATEGORIA", receitas.ID_CATEGORIA);
                conexao.AdicionarParametros("@DATA", receitas.DATA);
                conexao.AdicionarParametros("@DESCRICAO", receitas.DESCRICAO);
                conexao.AdicionarParametros("@VALOR", receitas.VALOR);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO receita(DESCRICAO, ID_CATEGORIA, DATA, VALOR) VALUES (@DESCRICAO, @ID_CATEGORIA, @DATA, @VALOR)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AlterarDespesas(despesas despesas)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CATEGORIA", despesas.ID_CATEGORIA);
                conexao.AdicionarParametros("@DATA", despesas.DATA);
                conexao.AdicionarParametros("@DESCRICAO", despesas.DESCRICAO);
                conexao.AdicionarParametros("@VALOR", despesas.VALOR);
                conexao.AdicionarParametros("@ID", despesas.ID);
                conexao.AdicionarParametros("@ID_IMOVEL", despesas.ID_IMOVEL);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE despesa SET DESCRICAO=@DESCRICAO,ID_CATEGORIA= @ID_CATEGORIA,DATA= @DATA,VALOR= @VALOR ,ID_IMOVEL=@ID_IMOVEL WHERE ID= @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AlterarReceitas(receitas receitas)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID_CATEGORIA", receitas.ID_CATEGORIA);
                conexao.AdicionarParametros("@DATA", receitas.DATA);
                conexao.AdicionarParametros("@DESCRICAO", receitas.DESCRICAO);
                conexao.AdicionarParametros("@VALOR", receitas.VALOR);
                conexao.AdicionarParametros("@ID", receitas.ID);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE receita SET DESCRICAO=@DESCRICAO,ID_CATEGORIA= @ID_CATEGORIA,DATA= @DATA,VALOR= @VALOR WHERE ID= @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ExcluirDespesa(int ID)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.ExecutarManipulacao(CommandType.Text, "Delete from despesa where ID ="+ ID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirReceita(int ID)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.ExecutarManipulacao(CommandType.Text, "Delete from receita where ID =" + ID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<despesas> ListaDespesas(DateTime Mes)
        {
            try
            {
                var retorno = new List<despesas>();
                conexao = new DlConexao();
                var dados = new DataTable();
                conexao.limparParametros();
                var dia = Mes.Day;
                var mes = Mes.Month;
                var ano = Mes.Year;
                string novadataInicial = ano + "-" + mes;
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT despesa.ID,despesa.DESCRICAO,despesa.ID_CATEGORIA, " +
                    "despesa.VALOR,despesa.DATA,despesa.ID_IMOVEL,imovel.NOME FROM `despesa` INNER JOIN imovel on despesa.ID_IMOVEL = imovel.ID " +
                    "WHERE MONTH(DATA) = '" + mes + "' AND YEAR(DATA) = '" + ano + "'  ");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var d = new despesas();
                    d.ID = Convert.ToInt32(dados.Rows[i].ItemArray[0]);
                    d.DESCRICAO = Convert.ToString(dados.Rows[i].ItemArray[1]);
                    d.ID_CATEGORIA = Convert.ToInt32(dados.Rows[i].ItemArray[2]);
                    d.VALOR = Convert.ToDecimal(dados.Rows[i].ItemArray[3]);
                    d.DATA = Convert.ToDateTime(dados.Rows[i].ItemArray[4]);
                    if(dados.Rows[i].ItemArray[5] != null)
                    {
                        d.ID_IMOVEL = Convert.ToInt32(dados.Rows[i].ItemArray[5]);
                        d.imovel = new imovelModel();
                        d.imovel.NOME = Convert.ToString(dados.Rows[i].ItemArray[6]);
                    }
                    
                    retorno.Add(d);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<despesas> ListaDespesasPelaData(string date)
        {
            try
            {
                var retorno = new List<despesas>();
                conexao = new DlConexao();
                var dados = new DataTable();
                conexao.limparParametros();
                conexao.AdicionarParametros("@DATA", date);
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT despesa.ID,despesa.DESCRICAO,despesa.ID_CATEGORIA, " +
                    "despesa.VALOR,despesa.DATA,despesa.ID_IMOVEL,imovel.NOME FROM `despesa` INNER JOIN imovel on despesa.ID_IMOVEL = imovel.ID WHERE DATA ='" + date+"'");

                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var d = new despesas();
                    d.ID = Convert.ToInt32(dados.Rows[i].ItemArray[0]);
                    d.DESCRICAO = Convert.ToString(dados.Rows[i].ItemArray[1]);
                    d.ID_CATEGORIA = Convert.ToInt32(dados.Rows[i].ItemArray[2]);
                    d.VALOR = Convert.ToDecimal(dados.Rows[i].ItemArray[3]);
                    d.DATA = Convert.ToDateTime(dados.Rows[i].ItemArray[4]);
                    if (dados.Rows[i].ItemArray[5] != null)
                    {
                        d.ID_IMOVEL = Convert.ToInt32(dados.Rows[i].ItemArray[5]);
                        d.imovel = new imovelModel();
                        d.imovel.NOME = Convert.ToString(dados.Rows[i].ItemArray[6]);
                    }

                    retorno.Add(d);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<receitas> ListaReceita(DateTime Mes)
        {
            try
            {
                var retorno = new List<receitas>();
                conexao = new DlConexao();
                var dados = new DataTable();
                conexao.limparParametros();
                var dia = Mes.Day;
                var mes = Mes.Month;
                var ano = Mes.Year;
                string novadataInicial = ano + "-" + mes;
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM receita WHERE MONTH(DATA) = '" + mes + "' AND YEAR(DATA) = '" + ano + "' ");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var d = Genericos.Popular<receitas>(dados, i);
                    retorno.Add(d);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<receitas> ListaReceitaPelaData(string date)
        {
            try
            {
                var retorno = new List<receitas>();
                conexao = new DlConexao();
                var dados = new DataTable();
                conexao.limparParametros();
                conexao.AdicionarParametros("@DATA", date);
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM receita WHERE DATA = @DATA ");

                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var d = Genericos.Popular<receitas>(dados, i);
                    retorno.Add(d);
                }

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #region procedimentocategoria
        public List<despesasCategoria> ListaCategoria(despesasCategoria despesasCategoria)
        {
            try
            {
                var retorno = new List<despesasCategoria>();

                conexao = new DlConexao();
                conexao.limparParametros();
                var data = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM categoriadespesa ORDER BY NOME ASC");
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var novos = Genericos.Popular<despesasCategoria>(data, i);
                    retorno.Add(novos);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region procedimento de graficos de despesas e receitas
        public DataTable ResumoDepesaMesGrafico(DateTime Mes)
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

                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM despesa WHERE MONTH(DATA) = '"+mes +"' AND YEAR(DATA) = '"+ano +"' ");

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
        public DataTable ResumoDespesaMesCombo(DateTime Ano, int categoria)
        {
            DataTable RETORNO = new DataTable();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var mes = Ano.Month;
                var ano = Ano.Year;
                RETORNO = conexao.ExecutaConsultas(System.Data.CommandType.Text,"SELECT despesa.ID,despesa.DESCRICAO,despesa.ID_CATEGORIA, " +
                "despesa.VALOR,despesa.DATA,despesa.ID_IMOVEL,imovel.NOME FROM `despesa` INNER JOIN imovel on despesa.ID_IMOVEL = imovel.ID " +
                "WHERE MONTH(DATA) = '" + mes + "' AND YEAR(DATA) = '" + ano + "' AND despesa.ID_CATEGORIA = '" + categoria + "' ");
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
