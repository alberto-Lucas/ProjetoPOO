using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPOO.Views
{
    public partial class frmSobreView : Form
    {
        public frmSobreView()
        {
            InitializeComponent();
        }

        private void frmSobreView_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "Versão: " + Application.ProductVersion.ToString();
        }

        #region Mover o Form

        //Variaveis e Dll responsaveis por movimentar o form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Evento MouseDown do Panel(Barra laranja) ao clicar e deixar clicado é possivel mover o Form
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para trocar o icone de Fechar ao retirar o Mouse do botão
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //Comando para carregar a imagem salva na pasta Resources do projeto
            pictureBox1.Image = global::ProjetoPOO.Properties.Resources.icons8_Close_Window_24px_3;
        }


        //Evento para trocar o icone de Fechar ao deixar o Mouse sobre o botão
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Comando para carregar a imagem salva na pasta Resources do projeto
            pictureBox1.Image = global::ProjetoPOO.Properties.Resources.icons8_Close_Window_24px_2;
        }
    }
}
