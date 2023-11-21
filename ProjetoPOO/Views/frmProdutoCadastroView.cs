using System.Windows.Forms;
using ProjetoPOO.Models;
using ProjetoPOO.Controllers;
using ProjetoPOO.Services;

namespace ProjetoPOO.Views
{
    public partial class frmProdutoCadastroView : Form
    {
        AcaoNaTela acaoSelecionada;
        Produto produtoSelecionado;
        public frmProdutoCadastroView(AcaoNaTela acaoTela, Produto produto)
        {
            InitializeComponent();
            acaoSelecionada = acaoTela;
            produtoSelecionado = produto;

            if (acaoSelecionada == AcaoNaTela.Inserir)
                this.Text = "Cadastrar Produto";
            else
            {
                CarregarDados();

                if (acaoSelecionada == AcaoNaTela.Alterar)
                    this.Text = "Alterar Produto";
                else
                {
                    this.Text = "Visualizar Produto";
                    DesabilitarCampos();
                }
            }
        }

        #region Eventos
        private void frmProdutoCadastroView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acaoSelecionada != AcaoNaTela.Visualizar)
                if (MessageBox.Show("Deseja realmente sair?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        private void CarregarDados()
        {
            txtId.Text          = produtoSelecionado.IdProduto.ToString();
            txtDescricao.Text   = produtoSelecionado.Descricao;
            txtBarras.Text      = produtoSelecionado.CodBarras;
            txtUnidade.Text     = produtoSelecionado.Unidade;
            txtPrecoVenda.Text  = string.Format("{0:N2}", produtoSelecionado.PrecoVenda);
            txtEstoque.Text     = produtoSelecionado.EstoqueAtual.ToString();
        }

        private void DesabilitarCampos()
        {
            txtDescricao.ReadOnly   = true;
            txtBarras.ReadOnly      = true;
            txtUnidade.ReadOnly     = true;
            txtPrecoVenda.ReadOnly  = true;
            txtEstoque.ReadOnly     = true;
            btnSalvar.Visible       = false;
            btnCancelar.Visible     = false;
        }

        private void Salvar()
        {
            if (!string.IsNullOrEmpty(txtDescricao.Text))
            {
                Produto produto = new Produto();

                produto.Descricao   = txtDescricao.Text;
                produto.CodBarras   = txtBarras.Text;
                produto.Unidade     = txtUnidade.Text;

                string precoVenda = txtPrecoVenda.Text.Replace(".", "");
                decimal preco = 0;
                if (decimal.TryParse(precoVenda, out preco))
                    produto.PrecoVenda = preco;
                else
                {
                    MessageBox.Show("Digite uma quantidade de estoque válida.", "Atenção...",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstoque.Focus();
                    return;
                }

                int estoque = 0;
                if (int.TryParse(txtEstoque.Text, out estoque))
                    produto.EstoqueAtual = estoque;
                else
                {
                    MessageBox.Show("Digite uma quantidade de estoque válida.", "Atenção...",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstoque.Focus();
                    return;
                }

                ProdutoController produtoController = new ProdutoController();
                int retonoSql = 0;

                if (acaoSelecionada == AcaoNaTela.Inserir)
                    retonoSql = produtoController.Inserir(produto);
                else
                {
                    produto.IdProduto = int.Parse(txtId.Text);
                    retonoSql = produtoController.Alterar(produto);
                }

                if (retonoSql > 0)
                {
                    if (acaoSelecionada == AcaoNaTela.Inserir)
                        txtId.Text = retonoSql.ToString();

                    MessageBox.Show("Registro salvo com sucesso!", "Informação", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Falha ao salvar registro", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Preencha os campos corretamente", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
