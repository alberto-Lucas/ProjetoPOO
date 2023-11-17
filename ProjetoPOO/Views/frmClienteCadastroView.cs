using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPOO.Models;
using ProjetoPOO.Controllers;
using ProjetoPOO.Services;

namespace ProjetoPOO.Views
{
    public partial class frmClienteCadastroView : Form
    {
        AcaoNaTela acaoSelecionada;
        Cliente clienteSelecionado;
        public frmClienteCadastroView(
            AcaoNaTela acaoTela, Cliente cliente)
        {
            InitializeComponent();
            acaoSelecionada = acaoTela;
            clienteSelecionado = cliente;

            if (acaoSelecionada == AcaoNaTela.Inserir)
                this.Text = "Cadastrar";
            else
            {
                CarregarDados();

                if (acaoSelecionada == AcaoNaTela.Alterar)
                    this.Text = "Alterar";
                else
                {
                    this.Text = "Visualizar";
                    DesabilitarCampos();
                }
            }
        }

        private void CarregarDados()
        {
            txtId.Text = clienteSelecionado.IdCliente.ToString();
            txtNome.Text = clienteSelecionado.Nome;
            txtRG.Text = clienteSelecionado.RG;
            mskCPF.Text = clienteSelecionado.CPF;
            dtpDtNascimento.Value = clienteSelecionado.DtNascimento;
            txtTelefone.Text = clienteSelecionado.Telefone;
        }

        private void DesabilitarCampos()
        {
            txtNome.ReadOnly = true;
            txtRG.ReadOnly = true;
            mskCPF.ReadOnly = true;
            dtpDtNascimento.Enabled = false;
            txtTelefone.ReadOnly = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            //A validação vem aqui primeiro

            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                //Para salvar o cliente, é precisa instanciar
                //o objeto Cliente, e preecnher com as informações
                //que o usuário informou na tela
                //Após é nescessario utilizar a camada Controller
                //para salvar o registro no banco de dados
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.RG = txtRG.Text;

                //o CPF utiliza um campo do tipo MASK
                //por tanto a pontução é informada de forma
                //automatica, antes de gravar no banco
                //é preciso remover as pontuações
                //utilizando o Replace

                cliente.CPF = mskCPF.Text.Replace(".", "");
                cliente.CPF = cliente.CPF.Replace(",", "");
                cliente.CPF = cliente.CPF.Replace("-", "");

                cliente.DtNascimento = dtpDtNascimento.Value;
                cliente.Telefone = txtTelefone.Text;

                ClienteController clienteController = 
                    new ClienteController();


                int idCadastro = 0;

                if (acaoSelecionada == AcaoNaTela.Inserir)
                    idCadastro = clienteController.Inserir(cliente);
                else
                {
                    cliente.IdCliente = int.Parse(txtId.Text);
                    idCadastro = clienteController.Alterar(cliente);
                }

                if (idCadastro > 0)
                {
                    //o txtID sempre estara vazio quando for 
                    //um cadastro novo
                    //caso seja uma alteração o campo irá apresenta
                    //o ID do registro
                    //por tanto se o campo ja esta preenchido
                    //não preciso atribuir o valor retornado
                    //do banco de dados
                    //Porém se for um cadastro novo
                    //é preciso apresentar o ID do novo cadastro
                    //no txtID
                    if(string.IsNullOrEmpty(txtId.Text))
                        txtId.Text = idCadastro.ToString();

                    MessageBox.Show("Registro salvo com sucesso!",
                        "Informação", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Falha ao salvar registro",
                       "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Preencha os campos corretamente", 
                    "Atenção", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning); 
        }
    }
}
