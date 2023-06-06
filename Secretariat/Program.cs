using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat
{
    static class Program
    {
        internal static SqlConnection databaseConnection;
        internal static Form1 forma;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            forma = new Form1();
            Application.Run(forma);
        }
    }
}
