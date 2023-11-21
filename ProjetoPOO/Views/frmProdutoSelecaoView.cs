using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ProjetoPOO.Controllers;
using ProjetoPOO.Models;
using ProjetoPOO.Services;
using ProjetoPOO.Views;

namespace ProjetoPOO.Views
{
    public partial class frmProdutoSelecaoView : Form
    {
        public Produto produtoSelecao;
        public frmProdutoSelecaoView(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        #region Eventos
        private void frmProdutoSelecaoView_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Inserir, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Alterar, RecuperarRegistro());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Visualizar, RecuperarRegistro());
        }

        #endregion

        #region Métodos

        private Produto RecuperarRegistro()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Informação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                return dgvRegistros.SelectedRows[0].DataBoundItem as Produto;
            }
        }

        private void Pesquisar()
        {
            int id = 0;

            ProdutoController produtoController = new ProdutoController();
            ProdutoCollection podutoCollection = new ProdutoCollection();
            dgvRegistros.DataSource = null;

            if (int.TryParse(txtPesquisa.Text, out id))
            {
                Produto produto = produtoController.ConsultarPorId(id);
                if (produto != null)
                    podutoCollection.Add(produto);
            }
            else
                podutoCollection = produtoController.ConsultarPorDescricao(txtPesquisa.Text.Trim());

            dgvRegistros.DataSource = podutoCollection;
            dgvRegistros.Update();
            dgvRegistros.Refresh();
        }

        private void Excluir()
        {
            Produto produtoSelecionado = RecuperarRegistro();

            if (produtoSelecionado != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o registro?", "Confirmação", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 
                    ClienteController clienteController = new ClienteController();

                    if (clienteController.Apagar(produtoSelecionado.IdProduto) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.", "Informação", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o regsitro.", "Atenção", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ChamarTelaCadastro(AcaoNaTela acaoTela, Produto produto)
        {
            frmProdutoCadastroView frm = new frmProdutoCadastroView(acaoTela, produto);
            frm.ShowDialog();

            if (acaoTela != AcaoNaTela.Visualizar)
                Pesquisar();
        }

        private void Selecionar()
        {
            produtoSelecao = RecuperarRegistro();
            if(produtoSelecao != null)
                this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
