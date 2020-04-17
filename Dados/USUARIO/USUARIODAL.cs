using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.USUARIO
{
    public class USUARIODAL
    {
        DlConexao conexao;
        //INSERIR
        //ALTERA
        //EXCLUIR
        public LoginUsuario CONSULTAlOGIN(LoginUsuario login)
        {
            conexao = new DlConexao();
            LoginUsuario RETORNO = new LoginUsuario();
            try
            {
                conexao.limparParametros();

                conexao.AdicionarParametros("@LOGIN", login.LOGIN);
                conexao.AdicionarParametros("@SENHA", login.SENHA);

                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM usuario WHERE LOGIN = @LOGIN AND SENHA = @SENHA LIMIT 1");
                if(DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<LoginUsuario>(DATA,0);
                }
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public LoginUsuario CONSULTAlOGINweb(string login,string senha)
        {
            conexao = new DlConexao();
            LoginUsuario RETORNO = new LoginUsuario();
            try
            {
                conexao.limparParametros();

                conexao.AdicionarParametros("@LOGIN", login);
                conexao.AdicionarParametros("@SENHA", senha);

                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM usuario WHERE LOGIN = @LOGIN AND SENHA = @SENHA LIMIT 1");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<LoginUsuario>(DATA, 0);
                }
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return RETORNO;
        }

        public void Inserir(LoginUsuario dadostela)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@NOME", dadostela.NOME);
                conexao.AdicionarParametros("@LOGIN", dadostela.LOGIN);
                conexao.AdicionarParametros("@SENHA", dadostela.SENHA);
                conexao.AdicionarParametros("@CARGO", dadostela.CARGO);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO usuario(NOME, LOGIN, SENHA, CARGO) VALUES (@NOME,@LOGIN,@SENHA,@CARGO)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Alterar(LoginUsuario dadostela)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", dadostela.ID);
                conexao.AdicionarParametros("@NOME", dadostela.NOME);
                conexao.AdicionarParametros("@LOGIN", dadostela.LOGIN);
                conexao.AdicionarParametros("@SENHA", dadostela.SENHA);
                conexao.AdicionarParametros("@CARGO", dadostela.CARGO);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE usuario SET NOME=@NOME,LOGIN=@LOGIN,SENHA=@SENHA,CARGO=@CARGO WHERE ID=@ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<LoginUsuario> CONSULTA(LoginUsuario loginUsuario)
        {
            conexao = new DlConexao();
            List<LoginUsuario> retorno = new List<LoginUsuario>();
            try
            {
                conexao.limparParametros();
                var dados = conexao.ExecutaConsultas(CommandType.Text, "select * from usuario");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var usuarios = Genericos.Popular<LoginUsuario>(dados, i);
                    retorno.Add(usuarios);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
    }
}
