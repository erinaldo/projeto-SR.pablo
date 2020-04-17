using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dados.Agenda
{
    public class AgendamentoDAL
    {
        DlConexao conexao;
        public void Inserir(Agendamento agendamento)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@NOME", agendamento.NOME);
                conexao.AdicionarParametros("@ID_PRODUTO", agendamento.ID_PRODUTO);
                conexao.AdicionarParametros("@EMAIL", agendamento.EMAIL);
                conexao.AdicionarParametros("@TELEFONE", agendamento.TELEFONE);
                conexao.AdicionarParametros("@DATA_AGENDAMENTO", agendamento.DATA_AGENDAMENTO);
                conexao.AdicionarParametros("@DESCRICAO", agendamento.DESCRICAO);
                conexao.AdicionarParametros("@STATUS", agendamento.STATUS);
                conexao.ExecutarManipulacao(CommandType.Text, "INSERT INTO agendamento(NOME, DATA_AGENDAMENTO, EMAIL, TELEFONE, ID_PRODUTO ,DESCRICAO, STATUS) VALUES (@NOME, @DATA_AGENDAMENTO, @EMAIL, @TELEFONE, @ID_PRODUTO ,@DESCRICAO, @STATUS)");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Alterar(Agendamento agendamento)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", agendamento.ID);
                conexao.AdicionarParametros("@NOME", agendamento.NOME);
                conexao.AdicionarParametros("@ID_PRODUTO", agendamento.ID_PRODUTO);
                conexao.AdicionarParametros("@EMAIL", agendamento.EMAIL);
                conexao.AdicionarParametros("@TELEFONE", agendamento.TELEFONE);
                conexao.AdicionarParametros("@DATA_AGENDAMENTO", agendamento.DATA_AGENDAMENTO);
                conexao.AdicionarParametros("@DESCRICAO", agendamento.DESCRICAO);
               

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE agendamento SET NOME=@NOME,DATA_AGENDAMENTO= @DATA_AGENDAMENTO,EMAIL=@EMAIL,TELEFONE=@TELEFONE,ID_PRODUTO = @ID_PRODUTO, DESCRICAO = @DESCRICAO WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Agendamento> ListaAgendamento()
        {
            conexao = new DlConexao();
            var retorno = new List<Agendamento>();
            try
            {
                conexao.limparParametros();
               
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM agendamento where STATUS = 'AGENDADO' ORDER by DATA_AGENDAMENTO DESC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var objeto = Genericos.Popular<Agendamento>(dados, i);
                    retorno.Add(objeto);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public List<Agendamento> ListaAgendamento(DateTime dataInicial)
        {
            conexao = new DlConexao();
            var retorno = new List<Agendamento>();
            try
            {
                conexao.limparParametros();
                var dia = dataInicial.Day;
                var mes = dataInicial.Month;
                var ano = dataInicial.Year;
                string novadataInicial = ano + "-" + mes + "-" + dia;
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM agendamento where DATA_AGENDAMENTO = '" + novadataInicial + "' AND STATUS = 'AGENDADO' ORDER by DATA_AGENDAMENTO ASC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    var objeto = Genericos.Popular<Agendamento>(dados, i);
                    retorno.Add(objeto);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public Agendamento Agendamento(int ID)
        {
            conexao = new DlConexao();
            var retorno = new Agendamento();
            try
            {
                conexao.limparParametros();
                var dados = conexao.ExecutaConsultas(CommandType.Text, "SELECT * FROM agendamento where ID = " + ID + " ORDER by DATA_AGENDAMENTO DESC");
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    retorno = Genericos.Popular<Agendamento>(dados, i);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public void AlterarAgedamento(Agendamento agendamento)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", agendamento.ID);
                conexao.AdicionarParametros("@STATUS", agendamento.STATUS);
                //conexao.AdicionarParametros("@TIPO", agendamento.TIPO);

                conexao.ExecutarManipulacao(CommandType.Text, "UPDATE agendamento SET STATUS=@STATUS,TIPO=@TIPO WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void eXCLUIR(int ID)
        {
            conexao = new DlConexao();
            try
            {
                conexao.limparParametros();
                conexao.AdicionarParametros("@ID", ID);
                

                conexao.ExecutarManipulacao(CommandType.Text, "DELETE FROM agendamento WHERE ID = @ID");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
