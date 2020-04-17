using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Dados
{
    public class DlConexao : IDisposable
    {
        private MySqlConnection conectarBanco()
        {

            //return new SqlConnection(dal.PainelPrincipal.stringConexao);
            return new MySqlConnection(new DadosDaConexao().getWebConfig("MySql"));

        }
        private MySqlParameterCollection sqlParameterCollection = new MySqlCommand().Parameters;

        public void limparParametros()
        {
            sqlParameterCollection.Clear();
        }

        internal void ExecutarManipulacao(object commandType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método para Adicionar parametros na procedure
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <param name="valorParametro"></param>
        public void AdicionarParametros(string nomeParametro, Object valorParametro)
        {
            sqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametro));
        }

        /// <summary>
        /// metodo para inserir, alterar, excluir
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="nomeStoreProcedureOuTextoSql"></param>
        /// <returns></returns>
        public object ExecutarManipulacao(System.Data.CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            var sqlcommand = new MySqlCommand();
            var sqlConnection = new MySqlConnection();

            try
            {
                sqlConnection = conectarBanco();
                sqlConnection.Open();

                //Criar comando que ira levar a informação ao BD
                sqlcommand = sqlConnection.CreateCommand();

                //Insere os dados no comando
                sqlcommand.CommandText = nomeStoreProcedureOuTextoSql;

                //tipo
                //sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandTimeout = 7200; //em segundos para derrubar conexao == 2hrs

                //adcionaos parametros do comando
                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //ExecuteScalar() retorna somente primeira coluna da primeira linha

                return sqlcommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + Environment.NewLine + ex.Message + (ex.InnerException != null ? ex.InnerException.ToString() : String.Empty));
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlcommand.Dispose();

            }
        }

        /// <summary>
        /// Select no Banco
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="nomeStoreProcedureOuTextoSql"></param>
        /// <returns></returns>
        public DataTable ExecutaConsultas(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            MySqlConnection sqlConnection = new MySqlConnection();
            MySqlCommand sqlcommand = new MySqlCommand();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();

            try
            {
                // CommandType.StoredProcedure
                sqlConnection = conectarBanco();
                sqlConnection.Open();

                //Criar comando que ria levar a informação ao BD
                sqlcommand = sqlConnection.CreateCommand();

                //Insere os dados no comando
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoreProcedureOuTextoSql;
                //sqlcommand.CommandType = commandType;
                //sqlcommand.CommandType = CommandType.Text;
                sqlcommand.CommandTimeout = 7200; //em segundos para derrubar conexao == 2hrs

                //adcionaos parametros do comando
                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //cria uma adaptador
                sqlDataAdapter = new MySqlDataAdapter(sqlcommand);

                //transforma os dados do BD para C#
                sqlDataAdapter.Fill(dataTable);

                //ExecuteScalar() retorna somente primeira coluna da primeira linh
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + Environment.NewLine + ex.Message + (ex.InnerException != null ? ex.InnerException.ToString() : String.Empty));
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlcommand.Dispose();
            }
        }
        public void Dispose()
        {
            this.Dispose();
        }

    }
}
