using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            Login login = new Login();
            //  DialogResult result = login.ShowDialog();
            /*if  (result == DialogResult.OK)
             {*/
            login.Close();

            Application.Run(mainForm: new Login());
        }
    }
}
