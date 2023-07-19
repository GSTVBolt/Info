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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            dtvProdutos.Refresh();
            MessageBox.Show("Produto armazenada com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Produto removido com sucesso!");
        }

        private void produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {
                e.Value = ((Categoria)e.Value).Descricao;
            }
        }
    }
}
