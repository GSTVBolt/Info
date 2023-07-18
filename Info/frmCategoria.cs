using Info.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria armazenada com sucesso!");
            }
        }

        private bool Valida()
        {
            if (txtCateg.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatório!");
                txtCateg.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.CategoriaCorrente))
                {
                    MessageBox.Show("Você não pode excluir uma categoria que possui produtos!");
                }
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
            }
        }

        public Categoria CategoriaCorrente
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo);
            if (produtos.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
