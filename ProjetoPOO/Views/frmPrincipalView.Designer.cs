﻿
namespace ProjetoPOO.Views
{
    partial class frmPrincipalView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrcamento = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EspacaoInicial = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ImagemUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstUser = new System.Windows.Forms.ToolStripLabel();
            this.EspacaoMeio = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImagemHst = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstHost = new System.Windows.Forms.ToolStripLabel();
            this.EspacaoMeio2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ImagemDB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tstDb = new System.Windows.Forms.ToolStripLabel();
            this.EspacoFinal = new System.Windows.Forms.ToolStripLabel();
            this.tstSite = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirVendaToolStripMenuItem,
            this.manutençãoDeVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Pedidos";
            // 
            // emitirVendaToolStripMenuItem
            // 
            this.emitirVendaToolStripMenuItem.Name = "emitirVendaToolStripMenuItem";
            this.emitirVendaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.emitirVendaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.emitirVendaToolStripMenuItem.Text = "Emitir Pedido";
            this.emitirVendaToolStripMenuItem.Click += new System.EventHandler(this.emitirVendaToolStripMenuItem_Click);
            // 
            // manutençãoDeVendasToolStripMenuItem
            // 
            this.manutençãoDeVendasToolStripMenuItem.Name = "manutençãoDeVendasToolStripMenuItem";
            this.manutençãoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.manutençãoDeVendasToolStripMenuItem.Text = "Manutenção de Pedidos";
            this.manutençãoDeVendasToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeVendasToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosF2ToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosF2ToolStripMenuItem
            // 
            this.produtosF2ToolStripMenuItem.Name = "produtosF2ToolStripMenuItem";
            this.produtosF2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.produtosF2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosF2ToolStripMenuItem.Text = "Produtos";
            this.produtosF2ToolStripMenuItem.Click += new System.EventHandler(this.produtosF2ToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnOrcamento);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.BackgroundImage = global::ProjetoPOO.Properties.Resources.icons8_Purchase_Order_30px_1;
            this.btnOrcamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrcamento.FlatAppearance.BorderSize = 0;
            this.btnOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrcamento.Location = new System.Drawing.Point(48, 10);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(30, 30);
            this.btnOrcamento.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnOrcamento, "Manutenção de Pedidos.");
            this.btnOrcamento.UseVisualStyleBackColor = true;
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(165, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 36);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(86, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 36);
            this.panel2.TabIndex = 11;
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImage = global::ProjetoPOO.Properties.Resources.icons8_Buying_30px_1;
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Location = new System.Drawing.Point(12, 10);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(30, 30);
            this.btnVenda.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnVenda, "Emitir Pedido.");
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::ProjetoPOO.Properties.Resources.icons8_Exit_30px_1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(172, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSair, "Sair do Sistema.");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackgroundImage = global::ProjetoPOO.Properties.Resources.icons8_Product_30px_21;
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Location = new System.Drawing.Point(129, 10);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(30, 30);
            this.btnProduto.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnProduto, "Cadastro de Produtos.");
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::ProjetoPOO.Properties.Resources.icons8_User_30px_3;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(93, 10);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(30, 30);
            this.btnCliente.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCliente, "Cadastro de Clientes.");
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(467, 31);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblData.Size = new System.Drawing.Size(298, 21);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(649, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(120, 31);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00:00";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EspacaoInicial,
            this.toolStripSeparator4,
            this.ImagemUser,
            this.toolStripLabel1,
            this.tstUser,
            this.EspacaoMeio,
            this.toolStripSeparator1,
            this.ImagemHst,
            this.toolStripLabel2,
            this.tstHost,
            this.EspacaoMeio2,
            this.toolStripSeparator2,
            this.ImagemDB,
            this.toolStripLabel3,
            this.tstDb,
            this.EspacoFinal,
            this.tstSite,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 330);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EspacaoInicial
            // 
            this.EspacaoInicial.Name = "EspacaoInicial";
            this.EspacaoInicial.Size = new System.Drawing.Size(13, 22);
            this.EspacaoInicial.Text = "  ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ImagemUser
            // 
            this.ImagemUser.Name = "ImagemUser";
            this.ImagemUser.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::ProjetoPOO.Properties.Resources.icons8_User_20px_3;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            // 
            // tstUser
            // 
            this.tstUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tstUser.Name = "tstUser";
            this.tstUser.Size = new System.Drawing.Size(37, 22);
            this.tstUser.Text = "User";
            // 
            // EspacaoMeio
            // 
            this.EspacaoMeio.Name = "EspacaoMeio";
            this.EspacaoMeio.Size = new System.Drawing.Size(22, 22);
            this.EspacaoMeio.Text = "     ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ImagemHst
            // 
            this.ImagemHst.Name = "ImagemHst";
            this.ImagemHst.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::ProjetoPOO.Properties.Resources.icons8_Workstation_20px_3;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(16, 22);
            // 
            // tstHost
            // 
            this.tstHost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tstHost.Name = "tstHost";
            this.tstHost.Size = new System.Drawing.Size(66, 22);
            this.tstHost.Text = "127.0.0.1";
            // 
            // EspacaoMeio2
            // 
            this.EspacaoMeio2.Name = "EspacaoMeio2";
            this.EspacaoMeio2.Size = new System.Drawing.Size(22, 22);
            this.EspacaoMeio2.Text = "     ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ImagemDB
            // 
            this.ImagemDB.Name = "ImagemDB";
            this.ImagemDB.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::ProjetoPOO.Properties.Resources.icons8_Database_20px_3;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(16, 22);
            // 
            // tstDb
            // 
            this.tstDb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tstDb.Name = "tstDb";
            this.tstDb.Size = new System.Drawing.Size(89, 22);
            this.tstDb.Text = "pooCamadas";
            // 
            // EspacoFinal
            // 
            this.EspacoFinal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.EspacoFinal.Name = "EspacoFinal";
            this.EspacoFinal.Size = new System.Drawing.Size(13, 22);
            this.EspacoFinal.Text = "  ";
            // 
            // tstSite
            // 
            this.tstSite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tstSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.tstSite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.tstSite.Name = "tstSite";
            this.tstSite.Size = new System.Drawing.Size(139, 22);
            this.tstSite.Text = "www.unifafibe.com.br";
            this.tstSite.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.tstSite.Click += new System.EventHandler(this.tstSite_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 254);
            this.label1.TabIndex = 21;
            this.label1.Text = "Projeto POO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjetoPOO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipalView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipalView_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipalView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrcamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel EspacaoInicial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel ImagemUser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tstUser;
        private System.Windows.Forms.ToolStripLabel EspacaoMeio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ImagemHst;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel tstHost;
        private System.Windows.Forms.ToolStripLabel EspacaoMeio2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ImagemDB;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel tstDb;
        private System.Windows.Forms.ToolStripLabel EspacoFinal;
        private System.Windows.Forms.ToolStripLabel tstSite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}