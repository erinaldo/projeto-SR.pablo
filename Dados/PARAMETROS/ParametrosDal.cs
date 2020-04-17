using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.PARAMETROS
{
    public class ParametrosDal
    {
        DlConexao conexao;
        public void Inserir(Model.Parametros parametros)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@NOMEEMPRESA", parametros.NOMEEMPRESA);
                conexao.AdicionarParametros("@EMAIL", parametros.EMAIL);
                conexao.AdicionarParametros("@SENHA", parametros.SENHA);
                conexao.AdicionarParametros("@Porta", parametros.Porta);
                conexao.AdicionarParametros("@smtp", parametros.smtp);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO parametros(NOMEEMPRESA, EMAIL, SENHA, porta, smtp) VALUES (@NOMEEMPRESA, @EMAIL, @SENHA, @porta, @smtp)");

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Alterar(Model.Parametros parametros)
        {
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", parametros.ID);
                conexao.AdicionarParametros("@NOMEEMPRESA", parametros.NOMEEMPRESA);
                conexao.AdicionarParametros("@EMAIL", parametros.EMAIL);
                conexao.AdicionarParametros("@SENHA", parametros.SENHA);
                conexao.AdicionarParametros("@Porta", parametros.Porta);
                conexao.AdicionarParametros("@smtp", parametros.smtp);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE parametros SET NOMEEMPRESA=@NOMEEMPRESA,EMAIL=@EMAIL,SENHA=@SENHA,porta=@porta, smtp = @smtp WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Parametros Todos(Model.Parametros parametros)
        {
            var Retorno = new Model.Parametros();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM parametros");

                if (dados.Rows.Count > 0)
                    Retorno = Genericos.Popular<Model.Parametros>(dados, 0);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Retorno;
        }
        public List<Model.Parametros> TodosLista(Model.Parametros parametros)
        {
            var Retorno = new List<Model.Parametros>();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Retorno;
        }
    }
}
