﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPOO.Controllers;
using ProjetoPOO.Models;
using ProjetoPOO.Services;

namespace ProjetoPOO.Views
{
    public partial class frmClienteSelecaoView : Form
    {
        //Atributo público necessário para retornar
        //o cliente selecionado quando o usuário clicar
        //no botão "Selecionar".
        public Cliente clienteSelecao;

        //O parâmetro "ExibirBotaoSelecionar" é necessário
        //para sabermos se o botão "Selecionar" deve ser
        //exibido ou não. O valor padrão dele é "false",
        //portanto, se quem chamar o construtor não passar
        //o valor "true", o botão não será exibido.
        public frmClienteSelecaoView(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            //Essa linha é necessária para que o DataGridView não
            //crie as colunas de forma automática, exibindo todas
            //as propriedades do objeto. A intenção é nós definirmos
            //somente algumas colunas para serem exibidas.
            //Para adicionar as colunas, clique no DataGridView e clique
            //na setinha preta que aparece no canto superior direito dele.
            //Clique em Edit Column e adicione as colunas que desejar.
            //Após adicionar as colunas (e ainda na tela de edição de coluna)
            //selecione uma coluna e na propriedade "DataPropertyName" coloque
            //o nome da propriedade que você quer exibir naquela coluna (Nome, Telefone...).
            //O nome da propriedade precisa ser igual ao que existe na camada Models.
            dgvRegistros.AutoGenerateColumns = false;
            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        //Método privado para pesquisa de registro
        //Se estiver vazio retorna todos os registro
        //Se possui apenas numeros
        //o filtro será pelo código do Cliente
        //Se possuir qualquer texto 
        //o filtro será pelo Nome do Cliente

        private void Pesquisar()
        {
            int id = 0;

            ClienteController clienteController = new ClienteController();

            //O DataGrid somente exibe listas, portanto,
            //Não é possivel passar apenas um objeto do tipo
            //"Cliente" para ele. É nescessario que seum "ClineteCollection"
            //Lembrando que o "ClienteCollection" herda de "TList<>"
            ClienteCollection clienteCollection = new ClienteCollection();

            //"DataSource" é a propriedade do DataGrid que
            //que faz uma referencia o objeto que possui os dados
            //que serão exibidos. No caso ele´irá possuir, uma referencia
            //para o "ClienteCollection" 
            //Ou seja o "ClienteColletion" será a fonte de dados 
            //para o DataSource do DataGrid
            //Sempre é preciso limpar a grade ao realizar uma nova pesquisa

            dgvRegistros.DataSource = null;

            //Validar se o valor informado para pesquisa é do tipo Int
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                //Uma consulta por ID pode retornar no maximo 1 registro
                //ou nenhum registro, sendo nescessario validar se o registro
                //está nullo, se o registro não for nullo o adiconamos
                //a "ClienteCollection"
                Cliente cliente = clienteController.ConsultarPorId(id);
                if (cliente != null)
                    clienteCollection.Add(cliente);
            }
            else
                clienteCollection =
                    clienteController.ConsultarPorNome(txtPesquisa.Text);

            //Após popular a "clienteColletion" eu atribuo ao DataSource
            //da grade
            dgvRegistros.DataSource = clienteCollection;

            //Executemos os comando abaixo para atualizar a DataGrid
            dgvRegistros.Update(); //Atualizar fonte de dados
            dgvRegistros.Refresh(); //Atulizar os dados exibidos
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Excluir()
        {
            //Para excluir um registro
            //Eu preciso primeiro selecionar um dos registro
            //np DataGrid
            //Ou seja precisamo verificar se possui algum registro
            //selecionado na Grade
            //Sempre confirmar a exclusão do registro
            //Nunca excluir diretamente

            //A rotina Excluir espera o ID do registro
            //como parametro, ou seja
            //Para executar a exclusão do registro, é 
            //preciso identificar o ID do registro selecionado
            Cliente clienteSelecionado = RecuperarCliente();

            if (clienteSelecionado != null)
            {
                if(MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    

                    ClienteController clienteController = new ClienteController();

                    if (clienteController.Apagar(clienteSelecionado.IdCliente) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.",
                            "Informação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o regsitro.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
        }

        private Cliente RecuperarCliente()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return null;
            }
            else
            {
                //Este método recupera o objeto da linha 
                //selecionada na Grade
                return dgvRegistros.SelectedRows[0].DataBoundItem
                as Cliente;
            }
        }


        private void frmClienteSelecaoView_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Inserir, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Alterar, RecuperarCliente());
        }

        private void ChamarTelaCadastro(
            AcaoNaTela acaoTela, Cliente cliente)
        {
            frmClienteCadastroView frm = 
                new frmClienteCadastroView(acaoTela, cliente);
            frm.ShowDialog();

            //Ignorar quando a ação for Visualizar
            //Qualquer ação diferente de Visualizar
            //A grade será atualizada
            if (acaoTela != AcaoNaTela.Visualizar)
                Pesquisar();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro(AcaoNaTela.Visualizar, RecuperarCliente());
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            clienteSelecao = RecuperarCliente();
            if (clienteSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
