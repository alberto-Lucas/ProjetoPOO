using ProjetoPOO.Models;
using ProjetoPOO.Services;
using System;
using System.Data;

namespace ProjetoPOO.Controllers
{
    public class PedidoItemController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(PedidoItem pedidoItem)
        {
            string queryInserir = "INSERT INTO pedido_item (id_pedido, id_produto, quantidade, valor_unitario, valor_total) " +
                "VALUES (@IdPedido, @IdProduto, @Quantidade, @ValorUnitario, @ValorTotal);";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", pedidoItem.Pedido.IdPedido);
            dataBase.AdicionarParametros("@IdProduto", pedidoItem.Produto.IdProduto);
            dataBase.AdicionarParametros("@Quantidade", pedidoItem.Quantidade);
            dataBase.AdicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
            dataBase.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);

            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);

            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(CommandType.Text, "SELECT MAX(id_pedido_item) FROM pedido_item"));
        }

        public int Alterar(PedidoItem pedidoItem)
        {
            string queryAlterar = "UPDATE pedido_item SET id_produto = @IdProduto, quantidade = @Quantidade, " +
                "valor_unitario = @ValorUnitario, valor_total = @ValorTotal WHERE id_pedido = @IdPedido AND id_pedido_item = @IdPedidoItem";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", pedidoItem.Pedido.IdPedido);
            dataBase.AdicionarParametros("@IdPedidoItem", pedidoItem.IdPedidoItem);
            dataBase.AdicionarParametros("@IdProduto", pedidoItem.Produto.IdProduto);
            dataBase.AdicionarParametros("@Quantidade", pedidoItem.Quantidade);
            dataBase.AdicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
            dataBase.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);

            return dataBase.ExecutarManipulacao(CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdPedido, int IdPedidoItem)
        {
            string queryApagar = "DELETE FROM pedido_item WHERE id_pedido = @IdPedido AND id_pedido_item = @IdPedidoItem";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", IdPedido);
            dataBase.AdicionarParametros("@IdPedidoItem", IdPedidoItem);

            return dataBase.ExecutarManipulacao(CommandType.Text, queryApagar);
        }

        public PedidoItemCollection ConsultarTodosItensDoPedido(int IdPedido)
        {
            PedidoItemCollection pedidoItemCollection = new PedidoItemCollection();
            ProdutoController produtoController = new ProdutoController();
            PedidoController pedidoController = new PedidoController();

            string queryConsulta = "SELECT * FROM pedido_item WHERE id_pedido = @IdPedido ORDER BY id_pedido_item";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", IdPedido);

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, queryConsulta);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                PedidoItem pedidoItem = new PedidoItem();
                pedidoItem.Pedido = pedidoController.ConsultarPorId(Convert.ToInt32(dataRow["id_pedido"]));
                pedidoItem.Produto = produtoController.ConsultarPorId(Convert.ToInt32(dataRow["id_produto"]));
                pedidoItem.IdPedidoItem = Convert.ToInt32(dataRow["id_pedido_item"]);
                pedidoItem.Quantidade = Convert.ToInt32(dataRow["quantidade"]);
                pedidoItem.ValorUnitario = Convert.ToDecimal(dataRow["valor_unitario"]);
                pedidoItem.ValorTotal = Convert.ToDecimal(dataRow["valor_total"]);

                pedidoItemCollection.Add(pedidoItem);
            }
            return pedidoItemCollection;
        }

        public decimal ValorTotalItensItensDoPedido(int IdPedido)
        {
            string query = "SELECT SUM(valor_total) FROM pedido_item WHERE id_pedido = @IdPedido";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", IdPedido);

            //Armazeno o retorno da consulta para validar o valor retornado
            var retorno = dataBase.ExecutarConsultaScalar(CommandType.Text, query);

            //Verifico se o valor retornado não é Null
            //No caso de ser um retorno de banco de dados é um valor DBNull
            //Devido a conversão do valor para decimal, se o valor for Null
            //a conversão ira gerar um erro.
            //Utilizo um if ternario para realizara a validação
            //Se o valor for null ou no caso DBNull
            //retorno o valor zero se não retorno o proprio valor
            //Se fosse um if normal seria:
            //      if (retorno is DBNull)
            //          return 0;
            //      else
            //          return Convert.ToDecimal(retorno);
            //Nesse caso o uso de if ternario se torna mais elegante
            //e de simples visualização
            return Convert.ToDecimal(retorno is DBNull ?  0 : retorno);
        }
    }
}
