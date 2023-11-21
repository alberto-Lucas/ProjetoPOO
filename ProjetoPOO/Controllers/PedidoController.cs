using System;
using System.Linq;
using ProjetoPOO.Services;
using ProjetoPOO.Models;
using System.Data;

namespace ProjetoPOO.Controllers
{
    public class PedidoController
    {
        DataBaseMySQL dataBase = new DataBaseMySQL();

        public int Inserir(Pedido pedido)
        {
            string query = "INSERT INTO pedido (data_hora, id_cliente, status) " +
                "VALUES (@DataHora, @IdCliente, @Status)";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@DataHora", pedido.DtHora);
            dataBase.AdicionarParametros("@IdCliente", pedido.Cliente.IdCliente);
            dataBase.AdicionarParametros("@Status", pedido.Status);

            dataBase.ExecutarManipulacao(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(id_pedido) FROM pedido"));
        }

        public int Alterar(Pedido pedido)
        {
            string query = "UPDATE pedido SET +" +
                            "data_hora = @DataHora, " +
                            "id_cliente = @IdCliente, " +
                            "status = @Status " +
                            "WHERE id_pedido = @IdPedido";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido",   pedido.IdPedido);
            dataBase.AdicionarParametros("@DataHora",   pedido.DtHora);
            dataBase.AdicionarParametros("@Status",     pedido.Status);
            dataBase.AdicionarParametros("@IdCliente",  pedido.Cliente.IdCliente);

            return dataBase.ExecutarManipulacao(CommandType.Text, query);
        }

        public int AlterarStatus(int idPedido, char status)
        {
            string query = "UPDATE pedido SET " +
                            "status = @Status " +
                            "WHERE id_pedido = @IdPedido";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", idPedido);
            dataBase.AdicionarParametros("@Status", status);

            return dataBase.ExecutarManipulacao(CommandType.Text, query);
        }

        public int Apagar(int idPedido)
        {
            string query = "DELETE FROM pedido WHERE id_pedido = @IdPedido";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", idPedido);

            return dataBase.ExecutarManipulacao(CommandType.Text, query);
        }

        public PedidoCollection ConsultarTodos()
        {
            PedidoCollection pedidoCollection = new PedidoCollection();
            ClienteController clienteController = new ClienteController();
            PedidoItemController pedidoItemController = new PedidoItemController();

            string query = "SELECT * FROM pedido";

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(dataRow["id_pedido"]);
                pedido.DtHora = Convert.ToDateTime(dataRow["data_hora"]);
                pedido.Cliente = clienteController.ConsultarPorId(Convert.ToInt32(dataRow["id_cliente"]));
                pedido.Status = Convert.ToChar(dataRow["status"]);
                pedido.ValorTotal = pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido);


                pedidoCollection.Add(pedido);
            }
            return pedidoCollection;
        }

        public PedidoCollection ConsultarPorPeriodo(DateTime dtInicial, DateTime dtFinal)
        {
            PedidoCollection pedidoCollection = new PedidoCollection();
            ClienteController clienteController = new ClienteController();
            PedidoItemController pedidoItemController = new PedidoItemController();

            string query = "SELECT * FROM pedido " +
                            "WHERE data_hora BETWEEN @DtInicial AND @DtFinal";

            //É preciso ajustar o horario para a Consulta
            //Ao pegar o valor direto do DateTimePicker irá retornar a hora atual da seleção dos valores
            //Por é precisa ajustar somente os valores de horas para a consulta
            //Pois para consultar os registros de um dia completo é preciso
            //que a hora inicial seja 00:00:00
            //e a hora final seja 23:59:59
            //Caso contrario o banco de dados poderá não retornar todos os dados daquela data selecionada

            DateTime dtInicialZeroHoras = dtInicial.Date;
            DateTime dtFinalUltimaHora = new DateTime(dtFinal.Year, dtFinal.Month, dtFinal.Day, 23, 59, 59);

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@DtInicial",  dtInicialZeroHoras);
            dataBase.AdicionarParametros("@DtFinal",    dtFinalUltimaHora);

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(dataRow["id_pedido"]);
                pedido.DtHora = Convert.ToDateTime(dataRow["data_hora"]);
                pedido.Cliente = clienteController.ConsultarPorId(Convert.ToInt32(dataRow["id_cliente"]));
                pedido.Status = Convert.ToChar(dataRow["status"]);
                pedido.ValorTotal = pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido);

                pedidoCollection.Add(pedido);
            }
            return pedidoCollection;
        }

        public Pedido ConsultarPorId(int IdPedido)
        {
            ClienteController clienteController = new ClienteController();
            PedidoItemController pedidoItemController = new PedidoItemController();

            string query = "SELECT * FROM pedido WHERE id_pedido = @IdPedido";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPedido", IdPedido);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(dataTable.Rows[0]["id_pedido"]);
                pedido.DtHora = Convert.ToDateTime(dataTable.Rows[0]["data_hora"]);
                pedido.Cliente = clienteController.ConsultarPorId(Convert.ToInt32(dataTable.Rows[0]["id_cliente"]));
                pedido.Status = Convert.ToChar(dataTable.Rows[0]["status"]);
                pedido.ValorTotal = pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido);

                return pedido;
            }
            else
            {
                return null;
            }
        }

        public PedidoCollection ConsultarPorCampo(string campo, string valor)
        {
            PedidoCollection pedidoCollection = new PedidoCollection();
            ClienteController clienteController = new ClienteController();
            PedidoItemController pedidoItemController = new PedidoItemController();

            string query = "SELECT * FROM pedido " +
                            "WHERE " + campo + " = @Valor";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Valor", valor);

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(dataRow["id_pedido"]);
                pedido.DtHora = Convert.ToDateTime(dataRow["data_hora"]);
                pedido.Cliente = clienteController.ConsultarPorId(Convert.ToInt32(dataRow["id_cliente"]));
                pedido.Status = Convert.ToChar(dataRow["status"]);
                pedido.ValorTotal = pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido);

                pedidoCollection.Add(pedido);
            }
            return pedidoCollection;
        }
    }
}
