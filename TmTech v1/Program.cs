using System;
using System.Windows.Forms;

namespace TmTech_v1
{
    static class Program
    {
 //       private static readonly ILog Log = LogManager.GetLogger(
 //MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //log4net.Config.XmlConfigurator.Configure();

            //Log.Debug("mgjoa0");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
