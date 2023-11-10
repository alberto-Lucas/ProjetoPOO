//É preciso importar as bibliotecas do SQLSERVER
using System;
using System.Data;
using System.Data.SqlClient;


namespace ProjetoPOO.Services
{
    public class DataBaseSqlServer
    {
        //Métodos privado que cria nova conexão com o banco
        private SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString =
                "Data Source=127.0.0.1;" +
                "Initial Catalog=pooCamadas;" +
                "Integrated Security=SSPI;";

            conexao.Open();
            return conexao;
        }

        //Variaveil privade que armazena os parametros
        //que serao utilizados no comando SQL
        private
            SqlParameterCollection sqlParameterCollection =
                new SqlCommand().Parameters;

        //Método Puilco que limpa todos os parametros
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        //Método publico para adicionar
        //os novos parametros
        public void 
            AdicionarParametros(string nomeParametro,
                                object valorParametro)
        {
            sqlParameterCollection.Add(
                new SqlParameter(nomeParametro,
                                 valorParametro));
        }

        //Método pulico que executa comandos
        //INSERT, UPDATE e DELETE
        //Retorna a quantidade de linhas afetadas
        public int ExececutarManipulacao(
            CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach(SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                //Executa o comando SQL e retorna quantas linhas afetadas
                return sqlCommand.ExecuteNonQuery();
            }
            //Adicionar a biblioteca using System;
            catch(Exception ex)
            {
                //Retorno o erro a onde o Método foi chamado
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n"+
                    "Mensagem original: " + ex.Message);
            }
        }

        //Método pulibo que executa comando SQL 
        //Retorna todas as linhas e colunas da consulta
        public DataTable ExecutarConsulta(
            CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                //O C# precisa que o retorno do banco de dados serja 
                //convertido para um objeto. Para isso ele utiliza
                //o SqlDataAdapter, que irá "adaptar" p retorno
                //da consulta para um objeto do tipo DataTabel.
                //É o DataTable que será utlizado dentro do C#
                //Ou seja eu converto a tabela de dados sql
                //em tabale de dados C#
                SqlDataAdapter sqlDataAdapter = 
                    new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                //Nesse ponto o comando SQL é executado
                //e o resultado é "adaptado" (convertido)
                //para o objeto dataTabela
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch(Exception ex)
            {
                //Retorno o erro a onde o Método foi chamado
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        }

        //Método publico que executa comando SELECT no banco de dados
        //Retorna apenas a primeira coluna da primeira linha do banco
        public object ExecutarConsultaScalar(CommandType commandType,
            string nomeStoredProcedureOuTextpSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextpSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        new SqlParameter(sqlParameter.ParameterName,
                                            sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Retorno o erro a onde o Método foi chamado
                throw new Exception("Houve uma falha ao execuar o " +
                    "comando no banco de dados.\r\n" +
                    "Mensagem original: " + ex.Message);
            }
        }

    }
}
