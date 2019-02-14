using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jumpcoin_install_win;
using Microsoft.VisualBasic;

namespace Jumpcoind_install
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // try
           // {
                Application.Run(new Form1());
                {
                }
            //}
            //catch
           // {

            //}
        }
    }
}
