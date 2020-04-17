using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region iniciar o xamp com a aplicação
            //var processo = 
            // Define um array 
            Process[] macProcessos;
            macProcessos = Process.GetProcessesByName("xampp-control");
            if (macProcessos.Length == 0)
            {
                //não tem esse processo em execução
                //executo o processo
                System.Diagnostics.Process.Start(@"C:\xampp\xampp-control.exe");
            }
            else if (macProcessos.Length == 1)
            {
                //processo estar sendo executado

            }
            #endregion

            #region Ferificar Banco de dados e criar as tabelas

            #endregion

            using (FormLogin frmlogin = new FormLogin())
            {

                var retorno = frmlogin.ShowDialog();

                if (retorno != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

            }

            Application.Run(new FormMenuPrincipal());
            //Application.Run(new FormLogin());
        }
    }
}

