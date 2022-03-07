using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            MakeDelegate();
        }

        private void MakeDelegate()
        {
            //取消登录 退出
            btn_cancel.Click += (sender, eve) => { this.Close(); };
            //登录确认
            btn_checkLogin.Click += (sender, eve) => { };
            //标题栏 移动
            panel_titleBar.MouseDown += On_TitleBar_MouseDown;
            panel_titleBar.MouseMove += On_TitleBar_MouseMove;

        }

        /// <summary>
        /// 使页面可以拖动
        /// </summary>
        private Point downPoint;
        private void On_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }
        private void On_TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }
    }
}
