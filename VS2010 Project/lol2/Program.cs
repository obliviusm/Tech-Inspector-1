using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lol2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GeneralContentManager.LoadGlobalSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            GeneralContentManager.ClearTempFolder();
            GeneralContentManager.SaveGlobalSettings();
        }
    }
}
