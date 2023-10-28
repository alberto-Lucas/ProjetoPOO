using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoPOO.Services;

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

        #endregion

    }
}
