using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.DataBase
{
    public partial class DbFilter : Form
    {
        public delegate void DbFilter_GetSqlHandler(string[] sql);
        public DbFilter_GetSqlHandler DbFilter_GetSqlEvent;

        //sql中列选择 与 值关系
        private string[] _sql=new string[3];
        public string[] sql
        {
            get { return _sql; }
            set { _sql = value; }
        }

        public DbFilter()
        {
            InitializeComponent();

            MakeDelegate();

            //this.Text = "数据筛选";
        }

        private void MakeDelegate()
        {
            //关闭对话框
            btn_close.Click += (sender, eve) => { this.Close(); };
            //构成sql筛选语句事件
            btn_apply.Click += (sender, eve) => 
            {
                sql[0] = tb_chooseColumn.Text;
                sql[1] = tb_valueReletion.Text;
                sql[2] = tb_order.Text;
                DbFilter_GetSqlEvent?.Invoke(this.sql);
            };

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
