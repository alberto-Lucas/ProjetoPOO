using ProjetoPOO.Models;
using ProjetoPOO.Services;
using System;
using System.Data;

namespace ProjetoPOO.Controllers
{
    public class ClienteController
    {
        #region Variaveis Locais
        //Variavel local e privada que faz o acesso ao 
        //banco de dados e executa os comandos.
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #endregion

        #region Inserir
        //Método puliboc que insere na tabela de clientes
        //um novo registro. Os dados que serão inseridos
        //são passados no parametro atraves de um objeto
        //do tipo Cliente. Os dados foram preenchidos pelo
        //usuário na tela de cadastro de clientes.

        public int Inserir(Cliente cliente)
        {
            //Variavel local que armazena o comando que será
            //executado no banco de dados
            //O "@" indica para o SQL a utilização de 
            //parametros
            string queryInserir =
                "INSERT INTO cliente (nome, rg, cpf, " +
                "data_nascimento, telefone) VALUES (@Nome, " +
                "@RG, @CPF, @DataNascimento, @Telefone)";

            //Limpar qualquer sujeiro do objeto que armezana
            //os parametros
            dataBase.LimparParametros();

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AdicionarParametros("@Nome", cliente.Nome);
            dataBase.AdicionarParametros("@RG", cliente.RG);
            dataBase.AdicionarParametros("@CPF", cliente.CPF);
            dataBase.AdicionarParametros("@DataNascimento", cliente.DtNascimento);
            dataBase.AdicionarParametros("@Telefone", cliente.Telefone);

            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT MAX(id_cliente) FROM cliente
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(id_cliente) FROM cliente"));
        }
        #endregion

        #region Alterar
        //Método public alterar
        public int Alterar(Cliente cliente)
        {
            string queryAlterar =
                "UPDATE cliente SET " +
                "nome = @Nome, " +
                "rg = @RG, " +
                "cpf = @CPF, " +
                "data_nascimento = @DataNascimento, " +
                "telefone = @telefone " +
                "WHERE id_cliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", cliente.Nome);
            dataBase.AdicionarParametros("@RG", cliente.RG);
            dataBase.AdicionarParametros("@CPF", cliente.CPF);
            dataBase.AdicionarParametros("@DataNascimento", cliente.DtNascimento);
            dataBase.AdicionarParametros("@Telefone", cliente.Telefone);
            dataBase.AdicionarParametros("@IdCliente", cliente.IdCliente);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdCliente)
        {
            string queryApagar =
                "DELETE FROM cliente " +
                "WHERE id_cliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }
        #endregion

        #region ConsultarPorNome
        public ClienteCollection ConsultarPorNome(string nome)
        {
            ClienteCollection clienteColecao = new ClienteCollection();
            string query =
                "SELECT * FROM cliente " +
                "WHERE nome LIKE '%' + @Nome + '%'";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);
            //Neste momento o SELECT foi executado 
            //E o banco retornou um DataTable
            //Agora precisamos converter esse DataTable
            //para ClienteCollection

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.IdCliente = Convert.ToInt32(dataRow["id_cliente"]);
                cliente.Nome = Convert.ToString(dataRow["nome"]);
                cliente.RG = Convert.ToString(dataRow["rg"]);
                cliente.CPF = Convert.ToString(dataRow["cpf"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if(!(dataRow["data_nascimento"] is DBNull))
                    cliente.DtNascimento = 
                        Convert.ToDateTime(dataRow["data_nascimento"]);
                cliente.Telefone = Convert.ToString(dataRow["telefone"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                clienteColecao.Add(cliente);
            }
            return clienteColecao;
        }
        #endregion

        #region ConsultarPorId
        public Cliente ConsultarPorId(int IdCliente)
        {
            string query =
                "SELECT * FROM cliente " +
                "WHERE id_cliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Cliente cliente = new Cliente();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.IdCliente = Convert.ToInt32(dataTable.Rows[0]["id_cliente"]);
                cliente.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
                cliente.RG = Convert.ToString(dataTable.Rows[0]["rg"]);
                cliente.CPF = Convert.ToString(dataTable.Rows[0]["cpf"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if (!(dataTable.Rows[0]["data_nascimento"] is DBNull))
                    cliente.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["data_nascimento"]);
                cliente.Telefone = Convert.ToString(dataTable.Rows[0]["telefone"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                return cliente;
            }
            else
                return null;
        }
        #endregion
    }
}
