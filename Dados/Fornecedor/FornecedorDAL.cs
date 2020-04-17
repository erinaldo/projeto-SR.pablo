using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Fornecedor
{
    public class FornecedorDAL
    {
        DlConexao conexao;

        #region Cadastro de fornecdores
        public void inserir(FornecedorModel fornecedor)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao.AdicionarParametros("@NOME", fornecedor.NOME);
                conexao.AdicionarParametros("@RASAOSOCIAL", fornecedor.RASAOSOCIAL);
                conexao.AdicionarParametros("@IE", fornecedor.IE);
                conexao.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                conexao.AdicionarParametros("@ENDERECO", fornecedor.ENDERECO);
                conexao.AdicionarParametros("@EMAIL", fornecedor.EMAIL);
                conexao.AdicionarParametros("@TELEFONE", fornecedor.TELEFONE);
                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO forncedor(NOME, RASAOSOCIAL, IE, CNPJ, ENDERECO, EMAIL, TELEFONE) VALUES (@NOME, @RASAOSOCIAL, @IE, @CNPJ, @ENDERECO, @EMAIL, @TELEFONE)");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void alterar(FornecedorModel fornecedor)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao.AdicionarParametros("@ID", fornecedor.ID);
                conexao.AdicionarParametros("@NOME", fornecedor.NOME);
                conexao.AdicionarParametros("@RASAOSOCIAL", fornecedor.RASAOSOCIAL);
                conexao.AdicionarParametros("@IE", fornecedor.IE);
                conexao.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                conexao.AdicionarParametros("@ENDERECO", fornecedor.ENDERECO);
                conexao.AdicionarParametros("@EMAIL", fornecedor.EMAIL);
                conexao.AdicionarParametros("@TELEFONE", fornecedor.TELEFONE);
                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE forncedor SET NOME=@NOME,RASAOSOCIAL=@RASAOSOCIAL,IE=@IE,CNPJ=@CNPJ,ENDERECO=@ENDERECO,EMAIL=@EMAIL,TELEFONE=@TELEFONE WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(int fornecedor)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            try
            {
                conexao.ExecutarManipulacao(CommandType.Text, "DELETE FROM forncedor WHERE ID =" + fornecedor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public FornecedorModel consulta()
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new FornecedorModel();
            try
            {
                var dados = conexao.ExecutaConsultas(CommandType.Text, "");


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public FornecedorModel consultaid(int id)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new FornecedorModel();
            try
            {
                conexao.AdicionarParametros("@ID", id);
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM forncedor WHERE ID =@ID");
                if (dados.Rows.Count > 0)
                    retorno = Genericos.Popular<FornecedorModel>(dados, 0);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public List<FornecedorModel> ListaFornecedor(FornecedorModel fornecedor)
        {
            conexao = new DlConexao();
            conexao.limparParametros();
            var retorno = new List<FornecedorModel>();
            try
            {
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM forncedor");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var novosdados = Genericos.Popular<FornecedorModel>(dados, i);
                    retorno.Add(novosdados);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        #endregion


    }
}
