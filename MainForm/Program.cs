using FastReport;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestConnect;

namespace MainForm
{
     class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.DesignerSettings.ShowInTaskbar = true;
            Config.SplashScreenEnabled = true;
            
            using (Report report = new Report())
            {
                new MeGonnaBeRandomAssemblyInitializer();
                report.Design();
                
            }
        }
    }
}
