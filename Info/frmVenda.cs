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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormVenda = null;
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItemVenda ItemCorrente
        {
            get
            {
                return (ItemVenda)this.itemVendaBindingSource.Current;
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;

            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Vendas;

            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;

            this.vendaBindingSource.AddNew();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            cbxPessoa.Enabled = false;
            gpbNovaVenda.Visible = true;
            btnNovaVenda.Enabled = false;

            this.itemVendaBindingSource.DataSource = DataContextFactory.DataContext.ItemVendas
                .Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);

            NovoItem();
        }

        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itemVendaBindingSource.EndEdit();
            dtvItens.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            mostraSomaValores();
            NovoItem();
        }

        private void dtvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((Produto)e.Value).Descricao;
            }
        }

        private void codigoProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProduto.SelectedItem != null)
            {
                var pro = (Produto)cbxProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void mostraSomaValores()
        {
            decimal total = 0;

            foreach (DataGridViewRow dg in dtvItens.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subTotal = v1 * v2;
                dg.Cells[4].Value = subTotal;
                total += subTotal;
            }
            this.VendaCorrente.Valor = total;
        }

        private void btnFPD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar essa venda?\nNão será possível adicionar um novo item.",
                                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoItem.Enabled = false;
                cbxProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor2.Enabled = false;
                txtCodigoVenda.Enabled = false;
                txtDesconto.ReadOnly = false;
                txtDesconto.Focus();
                btnFPD.Enabled = false;
                btnFV.Enabled = true;
            }
        }

        private void btnFV_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txtDesconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txtDesconto.Enabled = false;
            btnFV.Enabled = false;
            btnImprimir.Enabled = true;
        }
    }
}
