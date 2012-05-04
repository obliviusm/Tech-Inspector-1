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
            if (GeneralContentManager.defaultIcon != null)
                typeof(Form).GetField("defaultIcon",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).SetValue(
                    null, GeneralContentManager.defaultIcon);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            GeneralContentManager.ClearTempFolder();
            GeneralContentManager.SaveGlobalSettings();
        }
    }
}
