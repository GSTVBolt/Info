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
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;

namespace Info
{
    public partial class frmListaCategorias : Form
    {
        public frmListaCategorias()
        {
            InitializeComponent();
        }

        private void frmListaCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormListaCategorias = null;
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutosPorCategoria == null)
            {
                MeusFormularios.FormRelatorioProdutosPorCategoria = new frmRelatorioProdutosPorCategoria();
            }
            MeusFormularios.FormRelatorioProdutosPorCategoria.CodigoCategoria = (int)cbxCategoria.SelectedValue;
            MeusFormularios.FormRelatorioProdutosPorCategoria.Show();
            MeusFormularios.FormRelatorioProdutosPorCategoria.Focus();
        }
    }
}
