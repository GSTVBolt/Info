using Info.DAL;

namespace Info
{
    partial class frmPessoaFisica
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label nomePaiLabel;
            System.Windows.Forms.Label nomeMaeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cPFLabel;
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtvPessoa = new System.Windows.Forms.DataGridView();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomePaiTextBox = new System.Windows.Forms.TextBox();
            this.nomeMaeTextBox = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_Pessoa_Fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            nomePaiLabel = new System.Windows.Forms.Label();
            nomeMaeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeLabel.Location = new System.Drawing.Point(102, 12);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            emailLabel.Location = new System.Drawing.Point(107, 57);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 24);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            rGLabel.Location = new System.Drawing.Point(419, 154);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(42, 24);
            rGLabel.TabIndex = 7;
            rGLabel.Text = "RG:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataNascimentoLabel.Location = new System.Drawing.Point(12, 196);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(157, 24);
            dataNascimentoLabel.TabIndex = 9;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // nomePaiLabel
            // 
            nomePaiLabel.AutoSize = true;
            nomePaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomePaiLabel.Location = new System.Drawing.Point(71, 243);
            nomePaiLabel.Name = "nomePaiLabel";
            nomePaiLabel.Size = new System.Drawing.Size(98, 24);
            nomePaiLabel.TabIndex = 11;
            nomePaiLabel.Text = "Nome Pai:";
            // 
            // nomeMaeLabel
            // 
            nomeMaeLabel.AutoSize = true;
            nomeMaeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeMaeLabel.Location = new System.Drawing.Point(60, 290);
            nomeMaeLabel.Name = "nomeMaeLabel";
            nomeMaeLabel.Size = new System.Drawing.Size(109, 24);
            nomeMaeLabel.TabIndex = 13;
            nomeMaeLabel.Text = "Nome Mae:";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Pessoa);
            // 
            // dtvPessoa
            // 
            this.dtvPessoa.AutoGenerateColumns = false;
            this.dtvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.tbl_Pessoa_Fisica});
            this.dtvPessoa.DataSource = this.pessoaBindingSource;
            this.dtvPessoa.Location = new System.Drawing.Point(12, 371);
            this.dtvPessoa.Name = "dtvPessoa";
            this.dtvPessoa.Size = new System.Drawing.Size(784, 181);
            this.dtvPessoa.TabIndex = 13;
            this.dtvPessoa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtvPessoa_CellFormatting);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nomeTextBox.Location = new System.Drawing.Point(181, 12);
            this.nomeTextBox.Multiline = true;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(493, 29);
            this.nomeTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.emailTextBox.Location = new System.Drawing.Point(181, 57);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(278, 29);
            this.emailTextBox.TabIndex = 2;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource, "tbl_Pessoa_Fisica.DataNascimento", true));
            this.dataNascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(181, 196);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(371, 29);
            this.dataNascimentoDateTimePicker.TabIndex = 6;
            // 
            // nomePaiTextBox
            // 
            this.nomePaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "tbl_Pessoa_Fisica.NomePai", true));
            this.nomePaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nomePaiTextBox.Location = new System.Drawing.Point(181, 243);
            this.nomePaiTextBox.Multiline = true;
            this.nomePaiTextBox.Name = "nomePaiTextBox";
            this.nomePaiTextBox.Size = new System.Drawing.Size(493, 29);
            this.nomePaiTextBox.TabIndex = 7;
            // 
            // nomeMaeTextBox
            // 
            this.nomeMaeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "tbl_Pessoa_Fisica.NomeMae", true));
            this.nomeMaeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nomeMaeTextBox.Location = new System.Drawing.Point(181, 290);
            this.nomeMaeTextBox.Multiline = true;
            this.nomeMaeTextBox.Name = "nomeMaeTextBox";
            this.nomeMaeTextBox.Size = new System.Drawing.Size(493, 29);
            this.nomeMaeTextBox.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(558, 330);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(428, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(298, 330);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 35);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(168, 330);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 35);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            telefoneLabel.Location = new System.Drawing.Point(79, 102);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(90, 24);
            telefoneLabel.TabIndex = 19;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(181, 102);
            this.telefoneMaskedTextBox.Mask = "(00) 00000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(278, 29);
            this.telefoneMaskedTextBox.TabIndex = 3;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "tbl_Pessoa_Fisica.RG", true));
            this.rGMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rGMaskedTextBox.Location = new System.Drawing.Point(477, 149);
            this.rGMaskedTextBox.Mask = "00,000,000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(197, 29);
            this.rGMaskedTextBox.TabIndex = 5;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cPFLabel.Location = new System.Drawing.Point(117, 154);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(52, 24);
            cPFLabel.TabIndex = 19;
            cPFLabel.Text = "CPF:";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "tbl_Pessoa_Fisica.CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(181, 149);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(215, 29);
            this.cPFMaskedTextBox.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoPessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tbl_Pessoa_Fisica";
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // tbl_Pessoa_Fisica
            // 
            this.tbl_Pessoa_Fisica.DataPropertyName = "tbl_Pessoa_Fisica";
            this.tbl_Pessoa_Fisica.HeaderText = "RG";
            this.tbl_Pessoa_Fisica.Name = "tbl_Pessoa_Fisica";
            this.tbl_Pessoa_Fisica.Width = 140;
            // 
            // frmPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 572);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(this.rGMaskedTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(nomeMaeLabel);
            this.Controls.Add(this.nomeMaeTextBox);
            this.Controls.Add(nomePaiLabel);
            this.Controls.Add(this.nomePaiTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(rGLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.dtvPessoa);
            this.Name = "frmPessoaFisica";
            this.Text = "::.Cadastro de Pessoas Físicas.::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPessoaFisica_FormClosed);
            this.Load += new System.EventHandler(this.frmPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.DataGridView dtvPessoa;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomePaiTextBox;
        private System.Windows.Forms.TextBox nomeMaeTextBox;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_Pessoa_Fisica;
    }
}