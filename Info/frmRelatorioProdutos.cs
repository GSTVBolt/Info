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
    public partial class frmRelatorioProdutos : Form
    {
        public frmRelatorioProdutos()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_info;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        private void frmRelatorioProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorioProdutos = null;
        }

        private void frmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vw_RelatorioProdutos ORDER BY ds_Produto ASC";

            cmd.CommandText = sql;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Info", dt);
            reportViewer1.LocalReport.ReportPath = "RelatorioProdutos.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
