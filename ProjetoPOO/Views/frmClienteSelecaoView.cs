using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPOO.Controllers;
using ProjetoPOO.Models;

namespace ProjetoPOO.Views
{
    public partial class frmClienteSelecaoView : Form
    {
        public frmClienteSelecaoView()
        {
            InitializeComponent();

            //Desativar a criação automatica de colunas
            dgvRegistros.AutoGenerateColumns = false;
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

            if(dgvRegistros.SelectedRows.Count == 0)
                MessageBox.Show("Nenhum registro selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                if(MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //A rotina Excluir espera o ID do registro
                    //como parametro, ou seja
                    //Para executar a exclusão do registro, é 
                    //preciso identificar o ID do registro selecionado
                    Cliente clienteSelecionado =
                        (dgvRegistros.SelectedRows[0].DataBoundItem as Cliente);

                    ClienteController clienteController = new ClienteController();

                    if(clienteController.Apagar(clienteSelecionado.IdCliente) > 0)
                        MessageBox.Show("Registro excluído com sucesso.",
                            "Informação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Não foi possível excluir o regsitro.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }


        }
    }
}
