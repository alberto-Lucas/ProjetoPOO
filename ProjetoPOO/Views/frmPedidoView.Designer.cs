
namespace ProjetoPOO.Views
{
    partial class frmPedidoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoView));
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeItem = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.grbItensPedido = new System.Windows.Forms.GroupBox();
            this.dgvPedidoItens = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grbDadosPedido = new System.Windows.Forms.GroupBox();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.grbItensPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).BeginInit();
            this.grbDadosPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(538, 688);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(170, 35);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Pedido";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(712, 49);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(100, 29);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // txtQuantidadeItem
            // 
            this.txtQuantidadeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeItem.Location = new System.Drawing.Point(615, 51);
            this.txtQuantidadeItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidadeItem.MaxLength = 2;
            this.txtQuantidadeItem.Name = "txtQuantidadeItem";
            this.txtQuantidadeItem.Size = new System.Drawing.Size(86, 26);
            this.txtQuantidadeItem.TabIndex = 5;
            this.txtQuantidadeItem.Text = "1";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(9, 51);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(56, 26);
            this.txtIdProduto.TabIndex = 1;
            this.txtIdProduto.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarProduto.Location = new System.Drawing.Point(566, 49);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarProduto.TabIndex = 3;
            this.btnPesquisarProduto.Text = "...";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produto";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(76, 51);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(481, 26);
            this.txtDescricaoProduto.TabIndex = 2;
            this.txtDescricaoProduto.TabStop = false;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharTela.Location = new System.Drawing.Point(717, 688);
            this.btnFecharTela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(123, 35);
            this.btnFecharTela.TabIndex = 8;
            this.btnFecharTela.Text = "Fechar tela";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverItem.Location = new System.Drawing.Point(699, 432);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(112, 35);
            this.btnRemoverItem.TabIndex = 10;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(339, 388);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(474, 29);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor total: R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grbItensPedido
            // 
            this.grbItensPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbItensPedido.Controls.Add(this.btnRemoverItem);
            this.grbItensPedido.Controls.Add(this.lblValorTotal);
            this.grbItensPedido.Controls.Add(this.dgvPedidoItens);
            this.grbItensPedido.Controls.Add(this.btnAdicionarItem);
            this.grbItensPedido.Controls.Add(this.label5);
            this.grbItensPedido.Controls.Add(this.txtQuantidadeItem);
            this.grbItensPedido.Controls.Add(this.txtIdProduto);
            this.grbItensPedido.Controls.Add(this.btnPesquisarProduto);
            this.grbItensPedido.Controls.Add(this.label4);
            this.grbItensPedido.Controls.Add(this.txtDescricaoProduto);
            this.grbItensPedido.Location = new System.Drawing.Point(18, 198);
            this.grbItensPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbItensPedido.Name = "grbItensPedido";
            this.grbItensPedido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbItensPedido.Size = new System.Drawing.Size(822, 480);
            this.grbItensPedido.TabIndex = 6;
            this.grbItensPedido.TabStop = false;
            this.grbItensPedido.Text = "Itens do pedido";
            // 
            // dgvPedidoItens
            // 
            this.dgvPedidoItens.AllowUserToAddRows = false;
            this.dgvPedidoItens.AllowUserToDeleteRows = false;
            this.dgvPedidoItens.AllowUserToOrderColumns = true;
            this.dgvPedidoItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.DescricaoProduto,
            this.ValorUnitario,
            this.Quantidade,
            this.ValorTotal});
            this.dgvPedidoItens.Location = new System.Drawing.Point(9, 91);
            this.dgvPedidoItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPedidoItens.MultiSelect = false;
            this.dgvPedidoItens.Name = "dgvPedidoItens";
            this.dgvPedidoItens.RowHeadersVisible = false;
            this.dgvPedidoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoItens.Size = new System.Drawing.Size(804, 294);
            this.dgvPedidoItens.TabIndex = 7;
            this.dgvPedidoItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidoItens_CellFormatting);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Produto.IdProduto";
            this.IdProduto.HeaderText = "Código";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 80;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescricaoProduto.DataPropertyName = "Produto.Descricao";
            this.DescricaoProduto.HeaderText = "Descrição";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorUnitario.HeaderText = "Preço";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Width = 70;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 70;
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(117, 125);
            this.txtDataHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(176, 26);
            this.txtDataHora.TabIndex = 7;
            this.txtDataHora.TabStop = false;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(14, 125);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(92, 26);
            this.txtIdPedido.TabIndex = 5;
            this.txtIdPedido.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data/Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Pedido";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(14, 48);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(52, 26);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TabStop = false;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(768, 48);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarCliente.TabIndex = 3;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 48);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(684, 26);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TabStop = false;
            // 
            // grbDadosPedido
            // 
            this.grbDadosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosPedido.Controls.Add(this.txtDataHora);
            this.grbDadosPedido.Controls.Add(this.txtIdPedido);
            this.grbDadosPedido.Controls.Add(this.label3);
            this.grbDadosPedido.Controls.Add(this.label2);
            this.grbDadosPedido.Controls.Add(this.txtIdCliente);
            this.grbDadosPedido.Controls.Add(this.btnPesquisarCliente);
            this.grbDadosPedido.Controls.Add(this.label1);
            this.grbDadosPedido.Controls.Add(this.txtNomeCliente);
            this.grbDadosPedido.Location = new System.Drawing.Point(18, 18);
            this.grbDadosPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDadosPedido.Name = "grbDadosPedido";
            this.grbDadosPedido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDadosPedido.Size = new System.Drawing.Size(822, 171);
            this.grbDadosPedido.TabIndex = 5;
            this.grbDadosPedido.TabStop = false;
            this.grbDadosPedido.Text = "Dados do pedido";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(18, 688);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(170, 35);
            this.btnCancelarVenda.TabIndex = 9;
            this.btnCancelarVenda.Text = "Cancelar Pedido";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // frmPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 742);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.grbItensPedido);
            this.Controls.Add(this.grbDadosPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Venda";
            this.grbItensPedido.ResumeLayout(false);
            this.grbItensPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).EndInit();
            this.grbDadosPedido.ResumeLayout(false);
            this.grbDadosPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeItem;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.GroupBox grbItensPedido;
        private System.Windows.Forms.DataGridView dgvPedidoItens;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox grbDadosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnCancelarVenda;
    }
}