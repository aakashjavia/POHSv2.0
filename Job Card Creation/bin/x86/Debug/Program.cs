using Job_Card_Creation.pages;
using System;
using System.Windows.Forms;

namespace Job_Card_Creation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            { 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new SplashStartup());
                Application.Run(new LogInPage());
            }

            catch (Exception e)
             
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}