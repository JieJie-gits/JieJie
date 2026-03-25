using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Frm;

namespace test
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalMode.ClassFrm.frmLogin = new FrmLogin();
            Application.Run(GlobalMode.ClassFrm.frmLogin);
            //Application.Run(new FrmHome());
        }
    }
}
