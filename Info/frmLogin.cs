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
    public partial class frmLogin : Form
    {
        public bool logado = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void efetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.NomeUsuario == txtUsuario.Text && x.Senha == txtSenha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            efetuarLogin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                efetuarLogin();
            }
        }
    }
}
