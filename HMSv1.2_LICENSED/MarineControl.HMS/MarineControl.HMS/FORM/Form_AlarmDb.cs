using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.DataBase;

namespace MarineControl.HMS.FORM
{
    public partial class Form_AlarmDb : Form
    {
        //数据库操作助手对象
        SQLiteHelper sh;

        //刷新表格Timer
        System.Timers.Timer timer_refresh = new System.Timers.Timer();

        //绑定数据源到datagridview代理
        private delegate void Bind();
        private Bind bind;

        #region DataTable
        DataTable dt1 = new DataTable();
        #endregion

        public Form_AlarmDb()
        {
            InitializeComponent();

            //数据库连接
            var con = SQLiteHelper.GetDataBasePath();
            sh = new SQLiteHelper(con);
            sh.OpenDb();

            //绑定委托
            bind = delegate
            {
                if (dt1 == null)
                    return;

                dataGridView1.DataSource = dt1;
            };

            timer_refresh.Interval = 2500;//定时器间隔
            timer_refresh.Elapsed += SyncData;
            timer_refresh.Start();

            dataGridView1.DataError += (s, e) => { };

            //列宽调整
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //设置定时器
            refreshSpan.ValueChanged += (s, e) =>
            {
                if(refreshSpan.Value<=0)
                {
                    return;
                }    
                timer_refresh.Interval = (double)refreshSpan.Value * 1000;
            };
            //显示数量
            dispalyNum.ValueChanged += (s, e) => 
            {
                if (dispalyNum.Value > 0)
                    num = (int)dispalyNum.Value;
            };

            cb_whichSensor.SelectedIndex = 6;
            cb_overWay.SelectedIndex = 2;
        }


        private int num=20;
        private string sql1 = "select * from Alarm ";
        private string sql3 = "order by Time desc limit ";
        /// <summary>
        /// 同步数据库内数据到datagridview上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SyncData(object sender,EventArgs e)
        {
            //不可见 就不更新点
            if (dataGridView1.Visible == false)
                return;

            dt1.Clear();

            Task task=new Task(()=> 
            {
                string sql="";

                if(cb_whichSensor.SelectedIndex!=6 && cb_overWay.SelectedIndex!=2)
                {
                    sql = sql1 + "where WhichSensor= " + cb_whichSensor.SelectedItem.ToString() + " and " + "OverWay= " + cb_overWay.SelectedItem.ToString() + " " + sql3+num.ToString();
                }
                else if(cb_whichSensor.SelectedIndex != 6 && cb_overWay.SelectedIndex == 2)
                {
                    sql = sql1 + "where WhichSensor= " + cb_whichSensor.SelectedItem.ToString() + " "+sql3+num.ToString();
                }
                else if(cb_whichSensor.SelectedIndex==6 && cb_overWay.SelectedIndex != 2)
                {
                    sql = sql1 + "where OverWay= " + cb_overWay.SelectedItem.ToString() + " "+sql3+num.ToString();
                }
                else
                {
                    sql = sql1 + sql3+num.ToString();
                }

                
                dt1 = sh.ExecuteQuery(sql);
            });

            task.Start();
            task.Wait();
            this.Invoke(bind);
        }


    }
}
