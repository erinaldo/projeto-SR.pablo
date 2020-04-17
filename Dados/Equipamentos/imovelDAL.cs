using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.imovels
{
    public class imovelDAL
    {
        DlConexao conexao;

        public void Inserir(imovelModel imovel)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao.AdicionarParametros("@NOME", imovel.NOME);
                conexao.AdicionarParametros("@SITUACAO", imovel.SITUACAO);
                conexao.AdicionarParametros("@TIPO", imovel.TIPO);
                conexao.AdicionarParametros("@OCUPACAO", imovel.OCUPACAO);
                conexao.AdicionarParametros("@ID_CORRETOR", imovel.ID_CORRETOR);
                conexao.AdicionarParametros("@ID_CATEGORIA", imovel.ID_CATEGORIA);
                conexao.AdicionarParametros("@CIDADE", imovel.CIDADE);
                conexao.AdicionarParametros("@BAIRRO", imovel.BAIRRO);
                conexao.AdicionarParametros("@NUMERO", imovel.NUMERO);
                conexao.AdicionarParametros("@ESTADO", imovel.ESTADO);
                conexao.AdicionarParametros("@COMPLEMENTO", imovel.COMPLEMENTO);
                conexao.AdicionarParametros("@PROPRIETARIO", imovel.PROPRIETARIO);
                conexao.AdicionarParametros("@LOCALCHAVE", imovel.LOCALCHAVE);
                conexao.AdicionarParametros("@ULTIMAATUALIZACAO", imovel.ULTIMAATUALIZACAO);
                conexao.AdicionarParametros("@QUARTOS", imovel.QUARTOS);
                conexao.AdicionarParametros("@SUITES", imovel.SUITES);
                conexao.AdicionarParametros("@PAVIMENTO", imovel.PAVIMENTO);
                conexao.AdicionarParametros("@GARAGEM", imovel.GARAGEM);
                conexao.AdicionarParametros("@SALA", imovel.SALA);
                conexao.AdicionarParametros("@BANHEIRO", imovel.BANHEIRO);
                conexao.AdicionarParametros("@ANDAR", imovel.ANDAR);
                conexao.AdicionarParametros("@AREATERRENO", imovel.AREATERRENO);
                conexao.AdicionarParametros("@AREACONSTRUIDA", imovel.AREACONSTRUIDA);
                conexao.AdicionarParametros("@IDADEIMOVEL", imovel.IDADEIMOVEL);
                conexao.AdicionarParametros("@PRAZOENTREGA", imovel.PRAZOENTREGA);
                conexao.AdicionarParametros("@EDIFICIO", imovel.EDIFICIO);
                conexao.AdicionarParametros("@CONSTRUTORA", imovel.CONSTRUTORA);
                conexao.AdicionarParametros("@DESCRICAO", imovel.DESCRICAO);
                conexao.AdicionarParametros("@VALORIPTU", imovel.VALORIPTU);
                conexao.AdicionarParametros("@VALORCODOMINIO", imovel.VALORCODOMINIO);
                conexao.AdicionarParametros("@VALORPRECO", imovel.VALORPRECO);
                conexao.AdicionarParametros("@IMAGEM1", imovel.IMAGEM1);
                conexao.AdicionarParametros("@IMAGEM2", imovel.IMAGEM2);
                conexao.AdicionarParametros("@IMAGEM3", imovel.IMAGEM3);
                conexao.AdicionarParametros("@VALORALUGUEL", imovel.VALORALUGUEL);

                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO imovel(ID_CATEGORIA,NOME, SITUACAO, TIPO, OCUPACAO, ID_CORRETOR, CIDADE, BAIRRO, NUMERO, ESTADO, COMPLEMENTO, PROPRIETARIO, LOCALCHAVE, ULTIMAATUALIZACAO, QUARTOS, SUITES, PAVIMENTO, GARAGEM, SALA, BANHEIRO, ANDAR, AREATERRENO, AREACONSTRUIDA, IDADEIMOVEL, PRAZOENTREGA, EDIFICIO, CONSTRUTORA, DESCRICAO, VALORIPTU, VALORCODOMINIO, VALORPRECO, IMAGEM1, IMAGEM2, IMAGEM3,VALORALUGUEL) " +
                    "VALUES" +
                    "(@ID_CATEGORIA,@NOME, @SITUACAO, @TIPO, @OCUPACAO, @ID_CORRETOR, @CIDADE, @BAIRRO, @NUMERO, @ESTADO, @COMPLEMENTO, @PROPRIETARIO, @LOCALCHAVE, @ULTIMAATUALIZACAO, @QUARTOS, @SUITES, @PAVIMENTO, @GARAGEM, @SALA, @BANHEIRO, @ANDAR, @AREATERRENO, @AREACONSTRUIDA, @IDADEIMOVEL, @PRAZOENTREGA, @EDIFICIO, @CONSTRUTORA, @DESCRICAO, @VALORIPTU, @VALORCODOMINIO, @VALORPRECO, @IMAGEM1, @IMAGEM2, @IMAGEM3, @VALORALUGUEL)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarSituacaoImovel(int ID,string Plano)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
               
                conexao.AdicionarParametros("@SITUACAO", Plano);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE imovel SET SITUACAO = @SITUACAO  WHERE ID =" + ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Alterar(imovelModel imovel)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao.AdicionarParametros("@ID", imovel.ID);
                conexao.AdicionarParametros("@NOME", imovel.NOME);
                conexao.AdicionarParametros("@SITUACAO", imovel.SITUACAO);
                conexao.AdicionarParametros("@TIPO", imovel.TIPO);
                conexao.AdicionarParametros("@OCUPACAO", imovel.OCUPACAO);
                conexao.AdicionarParametros("@ID_CORRETOR", imovel.ID_CORRETOR);
                conexao.AdicionarParametros("@ID_CATEGORIA", imovel.ID_CATEGORIA);
                conexao.AdicionarParametros("@CIDADE", imovel.CIDADE);
                conexao.AdicionarParametros("@BAIRRO", imovel.BAIRRO);
                conexao.AdicionarParametros("@NUMERO", imovel.NUMERO);
                conexao.AdicionarParametros("@ESTADO", imovel.ESTADO);
                conexao.AdicionarParametros("@COMPLEMENTO", imovel.COMPLEMENTO);
                conexao.AdicionarParametros("@PROPRIETARIO", imovel.PROPRIETARIO);
                conexao.AdicionarParametros("@LOCALCHAVE", imovel.LOCALCHAVE);
                conexao.AdicionarParametros("@ULTIMAATUALIZACAO", imovel.ULTIMAATUALIZACAO);
                conexao.AdicionarParametros("@QUARTOS", imovel.QUARTOS);
                conexao.AdicionarParametros("@SUITES", imovel.SUITES);
                conexao.AdicionarParametros("@PAVIMENTO", imovel.PAVIMENTO);
                conexao.AdicionarParametros("@GARAGEM", imovel.GARAGEM);
                conexao.AdicionarParametros("@SALA", imovel.SALA);
                conexao.AdicionarParametros("@BANHEIRO", imovel.BANHEIRO);
                conexao.AdicionarParametros("@ANDAR", imovel.ANDAR);
                conexao.AdicionarParametros("@AREATERRENO", imovel.AREATERRENO);
                conexao.AdicionarParametros("@AREACONSTRUIDA", imovel.AREACONSTRUIDA);
                conexao.AdicionarParametros("@IDADEIMOVEL", imovel.IDADEIMOVEL);
                conexao.AdicionarParametros("@PRAZOENTREGA", imovel.PRAZOENTREGA);
                conexao.AdicionarParametros("@EDIFICIO", imovel.EDIFICIO);
                conexao.AdicionarParametros("@CONSTRUTORA", imovel.CONSTRUTORA);
                conexao.AdicionarParametros("@DESCRICAO", imovel.DESCRICAO);
                conexao.AdicionarParametros("@VALORIPTU", imovel.VALORIPTU);
                conexao.AdicionarParametros("@VALORCODOMINIO", imovel.VALORCODOMINIO);
                conexao.AdicionarParametros("@VALORPRECO", imovel.VALORPRECO);
                conexao.AdicionarParametros("@IMAGEM1", imovel.IMAGEM1);
                conexao.AdicionarParametros("@IMAGEM2", imovel.IMAGEM2);
                conexao.AdicionarParametros("@IMAGEM3", imovel.IMAGEM3);
                conexao.AdicionarParametros("@VALORALUGUEL", imovel.VALORALUGUEL);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE imovel SET ID_CATEGORIA= @ID_CATEGORIA,NOME=@NOME," +
                    "SITUACAO=@SITUACAO,TIPO=@TIPO,OCUPACAO=@OCUPACAO,ID_CORRETOR=@ID_CORRETOR,CIDADE=@CIDADE,BAIRRO=@BAIRRO," +
                    "NUMERO=@NUMERO,ESTADO=@ESTADO,COMPLEMENTO=@COMPLEMENTO,PROPRIETARIO=@PROPRIETARIO,LOCALCHAVE=@LOCALCHAVE," +
                    "ULTIMAATUALIZACAO=@ULTIMAATUALIZACAO,QUARTOS=@QUARTOS,SUITES=@SUITES,PAVIMENTO=@PAVIMENTO,GARAGEM=@GARAGEM," +
                    "SALA=@SALA,BANHEIRO=@BANHEIRO,ANDAR=@ANDAR,AREATERRENO=@AREATERRENO,AREACONSTRUIDA=@AREACONSTRUIDA," +
                    "IDADEIMOVEL=@IDADEIMOVEL,PRAZOENTREGA=@PRAZOENTREGA,EDIFICIO=@EDIFICIO,CONSTRUTORA=@CONSTRUTORA,DESCRICAO=@DESCRICAO," +
                    "VALORIPTU=@VALORIPTU,VALORCODOMINIO=@VALORCODOMINIO,VALORPRECO=@VALORPRECO,IMAGEM1=@IMAGEM1,IMAGEM2=@IMAGEM2," +
                    "IMAGEM3=@IMAGEM3, VALORALUGUEL = @VALORALUGUEL WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(int imovel)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                conexao.ExecutaConsultas(System.Data.CommandType.Text, "DELETE FROM imovel WHERE ID =" + imovel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Listaimovel(imovelModel imovel)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                var retorno = new List<imovelModel>();
                DataTable dados = new DataTable();
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM imovel INNER JOIN forncedor f on imovel.ID_FORNECEDOR = f.ID ");
                //for (int i = 0; i < dados.Rows.Count; i++)
                //{
                //    var tela = Genericos.Popular<imovelModel>(dados, i);
                //    retorno.Add(tela);
                //}

                return dados;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<imovelModel> imovel(imovelModel imovel)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                var retorno = new List<imovelModel>();
                DataTable dados = new DataTable();
                dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM imovel  ORDER BY NOME ASC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var tela = Genericos.Popular<imovelModel>(dados, i);
                    retorno.Add(tela);
                }

                return retorno;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public imovelModel CONSULTATODOSPELOID(int Codigo)
        {
            var RETORNO = new imovelModel();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM imovel WHERE ID =" + Codigo + " ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<imovelModel>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }
        public imovelModel ConsultaimovelNome(string Nome)
        {
            var RETORNO = new imovelModel();
            try
            {
                conexao = new DlConexao();
                conexao.limparParametros();
                var DATA = conexao.ExecutaConsultas(System.Data.CommandType.Text, "SELECT * FROM imovel WHERE NOME ='" + Nome + "' ORDER BY NOME ASC");
                if (DATA.Rows.Count > 0)
                {
                    RETORNO = Genericos.Popular<imovelModel>(DATA, 0);
                }

            }
            catch (Exception EX)
            {

                ExceptionErro.ExibirMenssagemException(EX);
            }
            return RETORNO;
        }

        public List<imovelModel> ListaImovelSituacao(string situacao)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new List<imovelModel>();
            try
            {
                conexao.AdicionarParametros("@SITUACAO", situacao);
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM imovel where SITUACAO = @SITUACAO  ORDER BY NOME ASC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novosdados = Genericos.Popular<imovelModel>(dados, i);
                    retorno.Add(novosdados);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public List<imovelModel> imovelSituacao(int ID, string situacao)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new List<imovelModel>();
            try
            {
                conexao.AdicionarParametros("@SITUACAO", situacao);
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM imovel where  ID =" + ID + " SITUACAO = @SITUACAO ORDER BY NOME ASC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novosdados = Genericos.Popular<imovelModel>(dados, i);
                    retorno.Add(novosdados);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public imovelModel ListaimovelID(imovelModel fornecedor)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new imovelModel();
            try
            {
                conexao.AdicionarParametros("@ID", fornecedor.ID);
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM imovel where ID = @ID");
                if (dados.Rows.Count > 0)
                    retorno = Genericos.Popular<imovelModel>(dados, 0);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }


    }
}
