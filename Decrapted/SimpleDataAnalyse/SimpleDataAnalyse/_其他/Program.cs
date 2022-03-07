using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataAnalyse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmlogin = new FrmLogin();//登录表单

            frmlogin.ShowDialog();

            if (frmlogin.DialogResult == DialogResult.OK)
            {
                frmlogin.Dispose();
                Application.Run(new MainForm());
            }
            else if (frmlogin.DialogResult == DialogResult.Cancel)
            {
                frmlogin.Dispose();
                return;
            }

            //Application.Run(new Form1());

        }
    }
}
