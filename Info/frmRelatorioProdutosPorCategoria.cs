using Info.DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Info
{
    public partial class frmRelatorioProdutosPorCategoria : Form
    {
        public int CodigoCategoria { get; set; }
        public frmRelatorioProdutosPorCategoria()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_info;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        private void frmRelatorioProdutosPorCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorioProdutosPorCategoria = null;
        }

        private void frmRelatorioProdutosPorCategoria_Load(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();

            string sql = "SELECT * FROM vw_RelatorioProdutos WHERE id_Categoria = (" + CodigoCategoria + ") ORDER BY ds_Produto ASC";

            cmd.CommandText = sql;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Info2", dt);
            reportViewer1.LocalReport.ReportPath = "RelatorioProdutosPorCategoria.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
