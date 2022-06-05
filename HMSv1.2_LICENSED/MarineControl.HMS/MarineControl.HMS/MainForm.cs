using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.Layout;

using MarineControl.HMS.Communiction;
using MarineControl.HMS.Filter;
using MarineControl.HMS.Sensor;
using MarineControl.HMS.FORM;
using MarineControl.HMS.Other;
using MarineControl.HMS.Cfg;
using System.Threading;
using System.Collections.Specialized;

using HZH_Controls.Forms;

namespace MarineControl.HMS
{
    public partial class MainForm : Form
    {
        #region 页面form对象
        //加载页面对象
        //Load load = new Load();
        //登录界面
        LoginForm loginForm = new LoginForm();

        Form_simple form_simple = new Form_simple();
        //传感器监测界面对象
        Form_Sensors form_Sensors = new Form_Sensors();//form2
        //报警界面对象
        Form_AlarmDb form_alarmDb = new Form_AlarmDb();//form3
        //数据库视图对象
        Form_DatabaseView form_DatabaseView = new Form_DatabaseView();//form4
        //其他设置视图对象
        Form_Setting form_setting = new Form_Setting();//form5
        //其他外部设备
        Form_otherDevice form_otherDevice = new Form_otherDevice();
        #endregion

        #region 其他工具对象
        //布局对象
        MyLayout ly = new MyLayout();

        //获取 运行时间、系统时间 对象
        GetTime gt = new GetTime();
        //获取系统性能对象
        GetSysPerformace gp = new GetSysPerformace();

        //悬浮提示
        ToolTip toolTip = new ToolTip();
        #endregion


        /// <summary>
        /// 构造
        /// </summary>
        public MainForm()
        {
            //加载页面
            //load.Show();
            //Thread.Sleep(3000);
            //load.Close();

            InitializeComponent();

            //启动时位于屏幕中间
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadForms();
            MakeDelegate();
        }

        /// <summary>
        /// 加载Form
        /// </summary>
        private void LoadForms()
        {
            //首先显示通讯界面

            var tem = Location.X + Size.Width / 2 - label_HMS.Size.Width / 2;
            label_HMS.Location = new Point(tem, label_HMS.Location.Y);

            //使label始终保持在panel中间
            ly.KeepCenter(panel_titleBar, label_HMS);

            //加载多个form到同一个panel中
            ly.LoadForms2Panel(form_simple, panel_Upper);
            ly.LoadForms2Panel(form_Sensors, panel_Upper);
            ly.LoadForms2Panel(form_alarmDb, panel_Upper);
            ly.LoadForms2Panel(form_DatabaseView, panel_Upper);
            ly.LoadForms2Panel(form_otherDevice, panel_Upper);
            ly.LoadForms2Panel(form_setting, panel_Upper);

            form_simple.Show();
        }

        /// <summary>
        /// 连接代理
        /// </summary>
        private void MakeDelegate()
        {
            //切换页面
            btn_communiction.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_simple, panel_mark, btn_communiction); });
            btn_mointor.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_Sensors, panel_mark, btn_mointor); });
            btn_alarm.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_alarmDb, panel_mark, btn_alarm); });
            btn_database.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_DatabaseView, panel_mark, btn_database); });
            btn_setting.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_setting, panel_mark, btn_setting); });
            btn_otherDevice.Click += new EventHandler((object sender, EventArgs e) => { ly.SwitchFrom(form_otherDevice, panel_mark, btn_otherDevice); });

            //标题栏 自定义 三个按钮
            btn_close.Click += On_titleBtn_clicked;
            btn_max.Click += On_titleBtn_clicked;
            btn_min.Click += On_titleBtn_clicked;

            //标题栏 移动
            panel_titleBar.MouseDown += On_TitleBar_MouseDown;
            panel_titleBar.MouseMove += On_TitleBar_MouseMove;

            form_simple.SendSensorCfgEvent += (id,cfg) =>
            {
                form_Sensors.SaveSensorCfgFrom1(id, cfg);
            };

            form_Sensors.SendSensorCfg2TableEvent += (id, cfg) =>
            {
                form_simple.GetSensorCfg2Update(id, cfg);
            };


            /////////////////////////////////////////////////////////////////////
            //按照解析的id，压入传感器value/*-------------IMPORTANT--------------*/
            form_setting.GetSensorDataEvent += (id, val) => { form_Sensors.PushSensorIdValue(id, val); };
            //form_com.Form_Communication_GetSensorDataEvent += (id, value) => form_Sensors.PushSensorIdValue(id, value);
            

            /////////////////////////////////////////////////////////////////////
            //开始监测按钮
            //停止监测按钮
            BossSwitch.CheckedChanged += (s, e) => 
            {
                if(BossSwitch.Checked==true)
                {
                    //压入数据点，增加事件
                    form_Sensors.isOnPushing = true;
                    form_setting.SwitchCom();
                    FrmTips.ShowTipsInfo(this,DateTime.Now.ToString()+"\n"+"已开启监测");
                }
                else
                {
                    //停止压入数据点，减去事件
                    form_Sensors.isOnPushing = false;
                    form_setting.SwitchCom();
                    FrmTips.ShowTipsInfo(this, DateTime.Now.ToString() + "\n" + "已停止监测");
                }
            };

            //登录
            btn_login.Click += (sender, eve) =>
            {
                loginForm.ShowDialog();
            };

            //获取系统现在时间
            gt.GetSysRunTimeEvent += (timeStr) => { tb_sysRuntime.Text = timeStr; };

            //获取cpu占用率
            gp.GetCpuUsageEvent += (cpuUsage,menUsage) => 
            {
                this.pl_cpu.Value = (int)cpuUsage;
                this.pl_ram.Value = (int)menUsage;
            };
        }

        /*---------------------------------自定义标题栏---------------------------------*/
        /// <summary>
        /// 关闭、最小化、最大化 按钮槽函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_titleBtn_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Tag.ToString())
            {
                case "close":
                    this.Close();
                    break;
                case "max":
                    {
                        if (this.WindowState == FormWindowState.Maximized)
                            this.WindowState = FormWindowState.Normal;
                        else
                            this.WindowState = FormWindowState.Maximized;
                        break;
                    }
                case "min":
                    {
                        if (this.WindowState != FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// 使页面可以拖动
        /// </summary>
        private Point downPoint;
        private void On_TitleBar_MouseDown(object sender,MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }
        private void On_TitleBar_MouseMove(object sender,MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X+e.X-downPoint.X,
                    this.Location.Y+e.Y-downPoint.Y);
            }
        }

        /// <summary>
        /// 维持标题在中间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_titleBar_SizeChanged(object sender, EventArgs e)
        {
            ly.KeepCenter(panel_titleBar, label_HMS);
        }


        /*---------------------------------自定义标题栏---------------------------------*/
    }
}
