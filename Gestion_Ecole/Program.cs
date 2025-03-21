using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
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
            ///Application.Run(new login());
             Application.Run(new Dashboard());
           /// Application.Run(new Registration());
           /// Application.Run(new FormClasse());
           /// Application.Run(new FormCours());
           /// Application.Run(new FormMatiere());

        }
    }
}
