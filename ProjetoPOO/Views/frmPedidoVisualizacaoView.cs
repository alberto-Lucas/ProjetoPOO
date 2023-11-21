using ProjetoPOO.Models;
using ProjetoPOO.Controllers;
using System;
using System.Windows.Forms;
using System.Reflection;

namespace ProjetoPOO.Views
{
    public partial class frmPedidoVisualizacaoView : Form
    {
        Pedido pedidoSelecionado;
        PedidoItemController pedidoItemController = new PedidoItemController();
        public frmPedidoVisualizacaoView(Pedido pedido)
        {
            InitializeComponent();
            dgvPedidoItens.AutoGenerateColumns = false;

            pedidoSelecionado = pedido;
        }

        #region Eventos
        private void frmPedidoVisualizacaoView_Load(object sender, EventArgs e)
        {
            CarregarPropriedades();
            CarregarProdutos();
        }

        private void dgvPedidoItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgvPedidoItens.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dgvPedidoItens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgvPedidoItens.Rows[e.RowIndex].DataBoundItem,
                        dgvPedidoItens.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Métodos
        #region CarregarPropriedade
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = CarregarPropriedade(propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1));
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Type typeProperty;
                    PropertyInfo propertyInfo;

                    if (propriedade != null)
                    {
                        typeProperty = propriedade.GetType();
                        propertyInfo = typeProperty.GetProperty(nomeDaPropriedade);
                        retorno = propertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        private void CarregarPropriedades()
        {
            txtIdCliente.Text   = pedidoSelecionado.Cliente.IdCliente.ToString();
            txtNomeCliente.Text = pedidoSelecionado.Cliente.Nome;
            txtIdPedido.Text    = pedidoSelecionado.IdPedido.ToString();
            txtDataHora.Text    = pedidoSelecionado.DtHora.ToShortDateString();
            lblValorTotal.Text  = "Valor total: R$ " + string.Format("{0:N2}", pedidoSelecionado.ValorTotal);
        }

        private void CarregarProdutos()
        {
            dgvPedidoItens.DataSource = null;
            dgvPedidoItens.DataSource = pedidoItemController.ConsultarTodosItensDoPedido(pedidoSelecionado.IdPedido);
            dgvPedidoItens.Update();
            dgvPedidoItens.Refresh();
        }
        #endregion
    }
}
