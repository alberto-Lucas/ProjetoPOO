using ProjetoPOO.Models;
using ProjetoPOO.Services;
using System;
using System.Data;


namespace ProjetoPOO.Controllers
{
    public class ProdutoController
    {
        //DataBaseSqlServer dataBase = new DataBaseSqlServer();
        DataBaseMySQL dataBase = new DataBaseMySQL();

        public int Inserir(Produto produto)
        {
            string queryInserir = "INSERT INTO produto (descricao, codigo_barras, unidade, preco_venda, estoque_atual) " +
                "VALUES (@Descricao, @CodigoBarras, @Unidade, @PrecoVenda, @EstoqueAtual);";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Descricao", produto.Descricao);
            dataBase.AdicionarParametros("@CodigoBarras", produto.CodBarras);
            dataBase.AdicionarParametros("@Unidade", produto.Unidade);
            dataBase.AdicionarParametros("@PrecoVenda", produto.PrecoVenda);
            dataBase.AdicionarParametros("@EstoqueAtual", produto.EstoqueAtual);

            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(CommandType.Text, "SELECT MAX(id_produto) FROM produto"));
        }

        public int Alterar(Produto produto)
        {
            string queryInserir = "UPDATE produto SET descricao = @Descricao, codigo_barras = @CodigoBarras, " +
                "unidade = @Unidade, preco_venda = @PrecoVenda, estoque_atual = @EstoqueAtual WHERE id_produto = @IdProduto";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdProduto", produto.IdProduto);
            dataBase.AdicionarParametros("@Descricao", produto.Descricao);
            dataBase.AdicionarParametros("@CodigoBarras", produto.CodBarras);
            dataBase.AdicionarParametros("@Unidade", produto.Unidade);
            dataBase.AdicionarParametros("@PrecoVenda", produto.PrecoVenda);
            dataBase.AdicionarParametros("@EstoqueAtual", produto.EstoqueAtual);

            return dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
        }

        public int Apagar(int IdProduto)
        {
            string queryInserir = "DELETE FROM produto WHERE id_produto = @IdProduto";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdProduto", IdProduto);

            return dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
        }

        public ProdutoCollection ConsultarTodos()
        {
            ProdutoCollection produtoColecao = new ProdutoCollection();
            string queryConsulta = "SELECT * FROM produto ORDER BY descricao";

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, queryConsulta);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(dataRow["id_produto"]);
                produto.Descricao = Convert.ToString(dataRow["descricao"]);
                produto.CodBarras = Convert.ToString(dataRow["codigo_barras"]);
                produto.Unidade = Convert.ToString(dataRow["unidade"]);
                produto.PrecoVenda = Convert.ToDecimal(dataRow["preco_venda"]);
                produto.EstoqueAtual = Convert.ToInt32(dataRow["estoque_atual"]);

                produtoColecao.Add(produto);
            }
            return produtoColecao;
        }

        public Produto ConsultarPorId(int IdProduto)
        {
            string queryConsulta = "SELECT * FROM produto WHERE id_produto = @IdProduto";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdProduto", IdProduto);

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, queryConsulta);

            Produto produto = new Produto();
            produto.IdProduto = Convert.ToInt32(dataTable.Rows[0]["id_produto"]);
            produto.Descricao = Convert.ToString(dataTable.Rows[0]["descricao"]);
            produto.CodBarras = Convert.ToString(dataTable.Rows[0]["codigo_barras"]);
            produto.Unidade = Convert.ToString(dataTable.Rows[0]["unidade"]);
            produto.PrecoVenda = Convert.ToDecimal(dataTable.Rows[0]["preco_venda"]);
            produto.EstoqueAtual = Convert.ToInt32(dataTable.Rows[0]["estoque_atual"]);

            return produto;
        }

        public ProdutoCollection ConsultarPorDescricao(string Descricao)
        {
            ProdutoCollection produtoColecao = new ProdutoCollection();
            string queryConsulta = "SELECT * FROM produto WHERE descricao LIKE '%' + @Descricao + '%' ORDER BY descricao";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Descricao", Descricao);

            DataTable dataTable = dataBase.ExecutarConsulta(CommandType.Text, queryConsulta);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(dataRow["id_produto"]);
                produto.Descricao = Convert.ToString(dataRow["descricao"]);
                produto.CodBarras = Convert.ToString(dataRow["codigo_barras"]);
                produto.Unidade = Convert.ToString(dataRow["unidade"]);
                produto.PrecoVenda = Convert.ToDecimal(dataRow["preco_venda"]);
                produto.EstoqueAtual = Convert.ToInt32(dataRow["estoque_atual"]);

                produtoColecao.Add(produto);
            }
            return produtoColecao;
        }
    }
}
