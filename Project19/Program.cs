using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             using (Frm_Login loginForm = new Frm_Login())
    {
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            // If login successful, run application with main menu
            Application.Run(new Frm_Main_Menu());
        }
    }
        }
    }
}
