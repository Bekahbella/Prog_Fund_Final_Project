using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //calling application base class telling it to enable styles
            Application.SetCompatibleTextRenderingDefault(false); //default is false because we changed it
            Application.Run(new Ordering());
        }
    }
}
