using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProjetoPOO.Views
{
    public partial class frmPrincipalView : Form
    {
        public frmPrincipalView()
        {
            InitializeComponent();
            AtualizaDataHora();
        }

        public void AtualizaDataHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaDataHora();
        }

        private void tstSite_Click(object sender, EventArgs e)
        {
            //Comando para abrir outro programa ou site
            //No caso do site será aberto no navegador padrão
            //precisa importar a biblioteca
            //using System.Diagnostics;
            Process.Start("https://www.unifafibe.com.br");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método close executa ao clicar no X do Form
        private void frmPrincipalView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Método executado de forma automatica quando o Form recebe um comando para ser fechado
        //Neste método é possivel cancelar o fechamento do Form
        private void frmPrincipalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?",
               "Atenção",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2
               ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Método executado ao carregar a tela Principal
        //De 2 clique no Form para criar este evento
        private void frmPrincipalView_Load(object sender, EventArgs e)
        {
            //Comando para recuparar o nome da maquina onde o programa está sendo executado
            tstHost.Text = Environment.MachineName.ToUpper();
            //Altetrar o titulo do Form
            //Adicionando a versão atual do Programa
            //A versão é difinida nas propriedades do projeto
            //Projeto > Propriedades de NomeProjeto > Informações do Assembly
            this.Text = "ProjetoPOO - Versão: " + Application.ProductVersion.ToString();
        }

        private void emitirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVenda.PerformClick();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClienteSelecaoView frm = new frmClienteSelecaoView();
            frm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobreView frm = new frmSobreView();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando para executar o evento Click de outro botão
            btnSair.PerformClick();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProdutoSelecaoView frm = new frmProdutoSelecaoView();
            frm.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmPedidoView frm = new frmPedidoView();
            frm.Show();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            frmPedidoSelecaoView frm = new frmPedidoSelecaoView();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCliente.PerformClick();
        }

        private void produtosF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnProduto.PerformClick();
        }

        private void manutençãoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOrcamento.PerformClick();
        }
    }
}
