using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.DAL;

namespace Info
{
    public partial class frmPessoaFisica : Form
    {
        public frmPessoaFisica()
        {
            InitializeComponent();
        }

        private void frmPessoaFisica_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormPessoaFisica = null;
        }

        private void frmPessoaFisica_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.PessoaFisicas.Select(x => x.Pessoa);
        }

        public Pessoa PessoaCorrente
        {
            get
            {
                return (Pessoa)this.pessoaBindingSource.Current;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.AddNew();
            this.PessoaCorrente.tbl_Pessoa_Fisica = new PessoaFisica();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            dtvPessoa.Refresh();
            MessageBox.Show("Pessoa Física armazenada com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.pessoaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Pessoa Física removida com sucesso!");
            }      
        }

        private void dtvPessoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {
                e.Value = ((PessoaFisica)e.Value).CPF;
            }
            if (e.Value != null && e.ColumnIndex == 5)
            {
                e.Value = ((PessoaFisica)e.Value).RG;
            }
        }
    }
}
