using System;
using System.Reflection;
using System.Windows.Forms;
using ProjetoPOO.Controllers;
using ProjetoPOO.Models;

namespace ProjetoPOO.Views
{
    public partial class frmPedidoView : Form
    {
        //Os atributos abaixo irão armazenas os dados
        //selecionados pelo usuário.
        Cliente clientePedido;
        Produto produtoPedido;

        //Esse atributo irá armazenar os dados do pedido.
        Pedido pedido;

        //Intancias das classes de controle
        PedidoController pedidoController = new PedidoController();
        PedidoItemController pedidoItemController = new PedidoItemController();

        public frmPedidoView()
        {
            InitializeComponent();
            dgvPedidoItens.AutoGenerateColumns = false;
        }

        #region Eventos

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarPedido();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarPedido();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            if (pedido == null)
                Close();
            else
                CancelarPedido();
        }        

        private void dgvPedidoItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //Tratamento especial para exibir as propriedades que estão dentro de outras propriedades.
                //É esse evento que chama o método "CarregarPropriedade", mas somente se a propriedade
                //possuir o ponto final.
                if ((dgvPedidoItens.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dgvPedidoItens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgvPedidoItens.Rows[e.RowIndex].DataBoundItem,
                        dgvPedidoItens.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Métodos

        #region CarregarPropriedade
        //Esse método é necessário quando você precisar acessar
        //uma propriedade dentro de outra propriedade.
        //Por exemplo, para acessar a descrição do produto que 
        //está dentro do objeto de "pedidoItem", eu preciso
        //colocar "pedidoItem.Produto.Descricao". Nesses casos
        //é necessário fazer um tratamento especial para conseguir
        //chegar até a "Descricao".
        //É utilizada a classe de Reflection para recuperar
        //os dados da propriedade, e recursividade do método abaixo.
        //Preciso importar a biblioteca
        //using System.Reflection;
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                //Olha se no parâmetro "nomeDaPropriedade" existe um ponto final.
                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    //O "Substring" irá recuperar o texto que existe antes do ponto final.
                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        //Retorna todas as informações das propriedades
                        //que o parâmetro "propriedade" possui.
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        //Para cada informação retornada eu comparo se o nome
                        //da propriedade é igual ao que eu quero (que é o nome
                        //que está na variável "propriedadeAntesDoPonto").
                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                //Se for o nome que eu quero, eu carrego as propriedades
                                //do objeto que está depois do ponto final. Aqui é utilizada
                                //a recursividade para fazer esse trabalho.
                                retorno = CarregarPropriedade(propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1));
                                break;
                            }
                        }
                    }
                }
                else //Quando o parâmetro "nomeDaPropriedade" não tiver mais um ponto final,
                {    //então eu cheguei até o último nível (que é o que me interessa).
                    Type typeProperty;
                    PropertyInfo propertyInfo;

                    if (propriedade != null)
                    {
                        //Com o Reflection eu recupero o valor da propriedade que quero.
                        typeProperty = propriedade.GetType();
                        propertyInfo = typeProperty.GetProperty(nomeDaPropriedade);
                        retorno = propertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        private void PesquisarCliente()
        {
            frmClienteSelecaoView frm = new frmClienteSelecaoView(true);
            DialogResult dialogResult = frm.ShowDialog();
            //Se o resultado da tela de seleção for "OK"
            //então o usuário clicou no botão "Selecionar".
            if (dialogResult == DialogResult.OK)
            {
                //Acesso o atributo público "clienteSelecao" para recuperar o objeto
                clientePedido = frm.clienteSelecao;

                //Exibidos os dados do Cliente na tela pelo objeto retornado
                txtIdCliente.Text   = clientePedido.IdCliente.ToString();
                txtNomeCliente.Text = clientePedido.Nome; 
            }
        }

        private void PesquisarProduto()
        {
            frmProdutoSelecaoView frm = new frmProdutoSelecaoView(true);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                produtoPedido = frm.produtoSelecao;

                txtIdProduto.Text = produtoPedido.IdProduto.ToString();
                txtDescricaoProduto.Text = produtoPedido.Descricao;

                //Comando para colocar em campo em Foco
                //No caso após selecionar o Produto o campo Quantidade
                //irá receber o foco, para que o cliente informe a quantidade
                //sem precisar clicar no campo ou apertat TAB para chegar ao campo
                txtQuantidadeItem.Focus();
            }
        }

        private void AdicionarItem()
        {
            //Se nenhum cliente foi selecionado, dá uma mensagem,
            //coloca o foco no botão de pesquisa de cliente e
            //para o fluxo (utilizando o "return").
            if (clientePedido == null)
            {
                MessageBox.Show("É necessário selecionar o cliente.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisarCliente.Focus();
                return;
            }

            if (produtoPedido == null)
            {
                MessageBox.Show("É necessário selecionar o produto.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisarProduto.Focus();
                return;
            }

            int quantidade = 0;
            //Só permite quantidade maior que zero e menor que 99.
            if (int.TryParse(txtQuantidadeItem.Text, out quantidade) && (quantidade > 0) && (quantidade <= 99))
            {
                //Se esse for o primeiro produto inserido, então
                //eu ainda não terei um pedido gravado. Portanto,
                //Eu crio um novo pedido e insiro no banco de dados.
                if (pedido == null)
                {
                    pedido = new Pedido();
                    pedido.Cliente  = clientePedido;
                    pedido.DtHora   = DateTime.Now;

                    //Defino o status da venda como P de Pendente
                    pedido.Status   = 'P';

                    pedido.IdPedido = pedidoController.Inserir(pedido);

                    txtIdPedido.Text = pedido.IdPedido.ToString();
                    txtDataHora.Text = pedido.DtHora.ToString();
                }

                //Crio e populo um novo pedidoItem.
                PedidoItem pedidoItem = new PedidoItem();
                pedidoItem.Pedido = pedido;
                pedidoItem.Produto = produtoPedido;
                pedidoItem.Quantidade = quantidade;
                pedidoItem.ValorUnitario = produtoPedido.PrecoVenda;

                //Realizo o calculo para gravar o valor total do produto
                //Utilianzando o PrecoVenda do objeto produtoPedido
                //selecionado na tela de Seleção de Produtos
                pedidoItem.ValorTotal = (quantidade * produtoPedido.PrecoVenda);

                //Insiro no banco de dados.
                //E recupero o ID do Pedido criado pelo banco de dados
                pedidoItem.IdPedidoItem = pedidoItemController.Inserir(pedidoItem);

                //Limpo os produtos exibidos no DataGridView e
                //recupero todos os produtos do pedido.
                //É preciso sempre carregar os produtos do banco de dados
                //para garantir que os produtos apresentados em tela
                //foram realmente gravados do banco de dados.
                dgvPedidoItens.DataSource = null;
                dgvPedidoItens.DataSource = pedidoItemController.ConsultarTodosItensDoPedido(pedido.IdPedido);
                dgvPedidoItens.Update();
                dgvPedidoItens.Refresh();

                //Utilizo o método ValorTotalItensItensDoPedido da classe ClienteController
                //Para aparesentar o valor total da venda, novamente nescessario para que 
                //o valor exeibido esteja de acordo com o registro gravados no banco de dados
                //Busco o valor total do pedido, formatando o valor
                //como um número com duas casas decimais.
                lblValorTotal.Text = "Valor total: R$ " + string.Format("{0:N2}", pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido));

                //Limpo a variável do produto que eu havia selecionado
                //e limpo os campos da tela.
                produtoPedido = null;
                txtIdProduto.Clear();
                txtDescricaoProduto.Clear();
                txtQuantidadeItem.Text = "1";
            }
            else
            {
                MessageBox.Show("A quantidade deve ser um número inteiro, maior que 0 (zero) e menor ou igual a 99.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidadeItem.Focus();
            }
        }

        private void RemoverItem()
        {
            if (dgvPedidoItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente remover este produto?", "Confirmação...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Recupero o ID do item do pedido diretamente do objeto guardado
                    //no DataGridView e apago ele.
                    pedidoItemController.Apagar(pedido.IdPedido, (dgvPedidoItens.SelectedRows[0].DataBoundItem as PedidoItem).IdPedidoItem);
                    dgvPedidoItens.DataSource = null;
                    dgvPedidoItens.DataSource = pedidoItemController.ConsultarTodosItensDoPedido(pedido.IdPedido);
                    dgvPedidoItens.Update();
                    dgvPedidoItens.Refresh();


                    //Atualizo o valor total da venda
                    lblValorTotal.Text = "Valor total: R$ " + string.Format("{0:N2}", pedidoItemController.ValorTotalItensItensDoPedido(pedido.IdPedido));
                }
            }
        }

        private void FinalizarPedido()
        {
            if (pedido != null)
            {
                if (MessageBox.Show("Deseja realmente Finalizar este pedido?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Como todos os dados da Venda ja foram gravados no banco de dados
                    //Enquanto o pedido foi sendo montado.
                    //Eu apenos atualizo o status do pedido para F de Finalizado
                    if (pedidoController.AlterarStatus(pedido.IdPedido, 'F') > 0)
                    {
                        MessageBox.Show("Pedido finalizado com sucesso.", "Informação...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Após finalizado com sucesso limpo todos os objetos e campos da tela.
                        LimparTela();
                    }
                    else
                        MessageBox.Show("O Pedido não foi encontrado no banco de dados.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Nenhum Pedido criado para ser Finalizado.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CancelarPedido()
        {
            if (pedido != null)
            {
                if (MessageBox.Show("Deseja realmente Cancelar este pedido?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (pedidoController.AlterarStatus(pedido.IdPedido, 'C') > 0)
                    {
                        MessageBox.Show("Pedido cancelado com sucesso.", "Informação...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTela();
                    }
                    else
                        MessageBox.Show("O Pedido não foi encontrado no banco de dados.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Nenhum Pedido criado para ser Cancelado.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void LimparTela()
        {
            clientePedido = null;
            produtoPedido = null;
            pedido = null;

            txtIdCliente.Clear();
            txtNomeCliente.Clear();
            txtIdPedido.Clear();
            txtDataHora.Clear();
            txtIdProduto.Clear();
            txtDescricaoProduto.Clear();
            txtQuantidadeItem.Text = "1";
            dgvPedidoItens.DataSource = null;
            lblValorTotal.Text = "Valor total: R$ 0,00";
            btnPesquisarCliente.Focus();
        }
        #endregion
    }
}
