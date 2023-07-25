using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmLogin FormLogin = new frmLogin();
            FormLogin.ShowDialog();

            if (FormLogin.logado == true)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
