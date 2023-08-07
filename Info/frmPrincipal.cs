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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
            {
                MeusFormularios.FormCategoria = new frmCategoria();
            }
            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
;        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
            {
                MeusFormularios.FormProduto = new frmProduto();
            }
            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void produtoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutosPorCategoria == null)
            {
                MeusFormularios.FormProdutosPorCategoria = new frmProdutosPorCategoria();
            }
            MeusFormularios.FormProdutosPorCategoria.Show();
            MeusFormularios.FormProdutosPorCategoria.Focus();
        }

        private void pessoasFísicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPessoaFisica == null)
            {
                MeusFormularios.FormPessoaFisica = new frmPessoaFisica();
            }
            MeusFormularios.FormPessoaFisica.Show();
            MeusFormularios.FormPessoaFisica.Focus();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
            {
                MeusFormularios.FormVenda = new frmVenda();
            }
            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutos == null)
            {
                MeusFormularios.FormRelatorioProdutos = new frmRelatorioProdutos();
            }
            MeusFormularios.FormRelatorioProdutos.Show();
            MeusFormularios.FormRelatorioProdutos.Focus();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLogin login = new frmLogin();
            //login.Show();
            //this.Hide();
        }

        private void produtosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutosPorCategoria == null)
            {
                MeusFormularios.FormRelatorioProdutosPorCategoria = new frmRelatorioProdutosPorCategoria();
            }
            MeusFormularios.FormRelatorioProdutosPorCategoria.Show();
            MeusFormularios.FormRelatorioProdutosPorCategoria.Focus();
        }
    }
}
