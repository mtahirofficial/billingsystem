using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Billing_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process mobj_pro = Process.GetCurrentProcess();
            Process[] mobj_proList = Process.GetProcessesByName(mobj_pro.ProcessName);
            if (mobj_proList.Length > 1)
            {
                MessageBox.Show("Can not open another one ", "Alert", MessageBoxButtons.OK);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
