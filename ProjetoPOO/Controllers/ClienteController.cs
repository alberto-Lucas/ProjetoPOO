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
        DataBaseSqlServer dataBase 
            = new DataBaseSqlServer();
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
            dataBase.ExececutarManipulacao(CommandType.Text, queryInserir);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT @@IDENTITY
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion

    }
}
