using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsKeyBinder
{
    static class Program
    {
        public static MainForm Form;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new MainForm();
            Application.EnableVisualStyles();

            Application.Run(Form);
        }
    }
}
