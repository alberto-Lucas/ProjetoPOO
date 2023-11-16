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

namespace ProjetoPOO.Views
{
    public partial class frmClienteCadastroView : Form
    {
        public frmClienteCadastroView()
        {
            InitializeComponent();
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

                int idCadastro = clienteController.Inserir(cliente);
                if (idCadastro > 0)
                {
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
