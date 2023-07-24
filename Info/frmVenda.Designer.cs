namespace Info
{
    partial class frmVenda
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
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label lblValor;
            System.Windows.Forms.Label lblDesconto;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxPessoa = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.gpbNovaVenda = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFV = new System.Windows.Forms.Button();
            this.btnFPD = new System.Windows.Forms.Button();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.dtvItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
            lblDesconto = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.gpbNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPessoaLabel.Location = new System.Drawing.Point(168, 17);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(66, 20);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente: ";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            codigoVendaLabel.Location = new System.Drawing.Point(120, 28);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(114, 20);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            codigoProdutoLabel.Location = new System.Drawing.Point(165, 63);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(69, 20);
            codigoProdutoLabel.TabIndex = 2;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            quantidadeLabel.Location = new System.Drawing.Point(138, 99);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(96, 20);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valorLabel.Location = new System.Drawing.Point(184, 131);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(50, 20);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            lblValor.Location = new System.Drawing.Point(184, 361);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(50, 20);
            lblValor.TabIndex = 10;
            lblValor.Text = "Valor:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            lblDesconto.Location = new System.Drawing.Point(152, 400);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new System.Drawing.Size(82, 20);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valorPagoLabel.Location = new System.Drawing.Point(143, 434);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(91, 20);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // cbxPessoa
            // 
            this.cbxPessoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.cbxPessoa.DataSource = this.pessoaBindingSource;
            this.cbxPessoa.DisplayMember = "Nome";
            this.cbxPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPessoa.FormattingEnabled = true;
            this.cbxPessoa.Location = new System.Drawing.Point(240, 14);
            this.cbxPessoa.Name = "cbxPessoa";
            this.cbxPessoa.Size = new System.Drawing.Size(328, 28);
            this.cbxPessoa.TabIndex = 2;
            this.cbxPessoa.ValueMember = "CodigoPessoa";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Info.DAL.Venda);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Info.DAL.Pessoa);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(574, 11);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(124, 35);
            this.btnNovaVenda.TabIndex = 6;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // gpbNovaVenda
            // 
            this.gpbNovaVenda.Controls.Add(this.btnImprimir);
            this.gpbNovaVenda.Controls.Add(this.btnFV);
            this.gpbNovaVenda.Controls.Add(this.btnFPD);
            this.gpbNovaVenda.Controls.Add(valorPagoLabel);
            this.gpbNovaVenda.Controls.Add(this.txtValorPago);
            this.gpbNovaVenda.Controls.Add(lblDesconto);
            this.gpbNovaVenda.Controls.Add(this.txtDesconto);
            this.gpbNovaVenda.Controls.Add(lblValor);
            this.gpbNovaVenda.Controls.Add(this.txtValor2);
            this.gpbNovaVenda.Controls.Add(this.btnNovoItem);
            this.gpbNovaVenda.Controls.Add(this.dtvItens);
            this.gpbNovaVenda.Controls.Add(valorLabel);
            this.gpbNovaVenda.Controls.Add(this.txtValor);
            this.gpbNovaVenda.Controls.Add(quantidadeLabel);
            this.gpbNovaVenda.Controls.Add(this.txtQuantidade);
            this.gpbNovaVenda.Controls.Add(codigoProdutoLabel);
            this.gpbNovaVenda.Controls.Add(this.cbxProduto);
            this.gpbNovaVenda.Controls.Add(codigoVendaLabel);
            this.gpbNovaVenda.Controls.Add(this.txtCodigoVenda);
            this.gpbNovaVenda.Location = new System.Drawing.Point(0, 50);
            this.gpbNovaVenda.Name = "gpbNovaVenda";
            this.gpbNovaVenda.Size = new System.Drawing.Size(815, 546);
            this.gpbNovaVenda.TabIndex = 7;
            this.gpbNovaVenda.TabStop = false;
            this.gpbNovaVenda.Text = "Nova Venda";
            this.gpbNovaVenda.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(13, 431);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 35);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnFV
            // 
            this.btnFV.Enabled = false;
            this.btnFV.Location = new System.Drawing.Point(12, 393);
            this.btnFV.Name = "btnFV";
            this.btnFV.Size = new System.Drawing.Size(124, 35);
            this.btnFV.TabIndex = 16;
            this.btnFV.Text = "Finalizar Venda";
            this.btnFV.UseVisualStyleBackColor = true;
            this.btnFV.Click += new System.EventHandler(this.btnFV_Click);
            // 
            // btnFPD
            // 
            this.btnFPD.Location = new System.Drawing.Point(12, 352);
            this.btnFPD.Name = "btnFPD";
            this.btnFPD.Size = new System.Drawing.Size(124, 35);
            this.btnFPD.TabIndex = 16;
            this.btnFPD.Text = "Finalizar Pedido";
            this.btnFPD.UseVisualStyleBackColor = true;
            this.btnFPD.Click += new System.EventHandler(this.btnFPD_Click);
            // 
            // txtValorPago
            // 
            this.txtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorPago.Location = new System.Drawing.Point(240, 434);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.Size = new System.Drawing.Size(165, 26);
            this.txtValorPago.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(240, 398);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(165, 26);
            this.txtDesconto.TabIndex = 13;
            // 
            // txtValor2
            // 
            this.txtValor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValor2.Location = new System.Drawing.Point(240, 361);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.ReadOnly = true;
            this.txtValor2.Size = new System.Drawing.Size(165, 26);
            this.txtValor2.TabIndex = 11;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(574, 122);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(124, 35);
            this.btnNovoItem.TabIndex = 8;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // dtvItens
            // 
            this.dtvItens.AllowUserToAddRows = false;
            this.dtvItens.AutoGenerateColumns = false;
            this.dtvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.dtvItens.DataSource = this.itemVendaBindingSource;
            this.dtvItens.Location = new System.Drawing.Point(6, 163);
            this.dtvItens.Name = "dtvItens";
            this.dtvItens.Size = new System.Drawing.Size(789, 177);
            this.dtvItens.TabIndex = 8;
            this.dtvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtvItens_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 185;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(Info.DAL.ItemVenda);
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Valor", true));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValor.Location = new System.Drawing.Point(240, 131);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(165, 26);
            this.txtValor.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Quantidade", true));
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(240, 96);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(165, 26);
            this.txtQuantidade.TabIndex = 5;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "CodigoProduto", true));
            this.cbxProduto.DataSource = this.produtoBindingSource;
            this.cbxProduto.DisplayMember = "Descricao";
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(240, 60);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(267, 28);
            this.cbxProduto.TabIndex = 3;
            this.cbxProduto.ValueMember = "Codigo";
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.codigoProdutoComboBox_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAL.Produto);
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txtCodigoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoVenda.Location = new System.Drawing.Point(240, 25);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.ReadOnly = true;
            this.txtCodigoVenda.Size = new System.Drawing.Size(165, 26);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 546);
            this.Controls.Add(this.gpbNovaVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.cbxPessoa);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Vendas .::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenda_FormClosed);
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.gpbNovaVenda.ResumeLayout(false);
            this.gpbNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox cbxPessoa;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.GroupBox gpbNovaVenda;
        private System.Windows.Forms.DataGridView dtvItens;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFV;
        private System.Windows.Forms.Button btnFPD;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}