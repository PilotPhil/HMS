 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.Plot;
using MarineControl.HMS.Layout;

using MarineControl.HMS.Filter;
using MarineControl.HMS.Statics;
using MarineControl.HMS.Alarm;
using MarineControl.HMS.Fatigue;
using MarineControl.HMS.Predict;

using MarineControl.HMS.DataBase;
using System.Data.SQLite;
using System.Diagnostics;
using HZH_Controls.Forms;

namespace MarineControl.HMS.Sensor
{
    /// <summary>
    /// 单个传感器的详览界面
    /// </summary>
    public partial class SensorForm : Form
    {
        #region 对象
        //传感器对象 配置
        public Sensor sensor = new Sensor();
        //绘图 实时 时历 动态曲线
        RealTimePlot plot = new RealTimePlot();
        //布局器 将form加载到panel
        MyLayout layout = new MyLayout();
        //预测图表 傅里叶变换预测后结果呈现表
        PredictChart predictChart = new PredictChart();
        #endregion

        #region datalist 处理 对象 流程
        StaticsForm staticsForm = new StaticsForm();//统计
        AlarmForm alarmForm = new AlarmForm();//阈值报警
        FatigueForm fatigueForm = new FatigueForm();//疲劳损伤
        PredictFft predictFft = new PredictFft();//预测
        #endregion

        #region 数据库
        string sql_statics;//统计结果保存sql语句
        string sql_alarm;//报警结果保存sql语句
        string sql_timeSeries;//
        SQLiteHelper SH;//数据库使用助手

        //统计 结果 插入 数据库 参数
        SQLiteParameter[] param_statics;//使用数据库助手获取内容
        //报警 结果 插入 数据库 参数
        SQLiteParameter[] param_alarm;
        //
        SQLiteParameter[] param_timeSeries;
        #endregion

        //发送传感器配置文件 事件
        public delegate void SendSensorCfg_sensorForm_Handler(int id, string[] cfg);
        public SendSensorCfg_sensorForm_Handler SendSensorCfg_sensorForm_Event;

        //发送 alarm 报警信息
        public delegate void SendSensorAlarm_Handler(string time, int sensorId, string type, double value);
        public SendSensorAlarm_Handler SendSensorAlarm_Event;

        /// <summary>
        /// 构造
        /// </summary>
        public SensorForm()
        {
            InitializeComponent();

            //启动时窗口位置-屏幕中间
            this.StartPosition = FormStartPosition.CenterScreen;
            //传感器id
            tb_sensorId.InputText = sensor.id.ToString();
            tb_sensorId.Enabled = false;//获取id后禁用，只读
            //更新传感器其他参数
            tb_sensorType.InputText = sensor.type;
            tb_sensorLocation.InputText = sensor.location;
            tb_sensorName.InputText = sensor.name;
            interval_long.InputText = sensor.interval_long.ToString();
            interval_short.InputText = sensor.interval_short.ToString();
            tb_filter.InputText = sensor.filter;
            tb_up.InputText = sensor.up.ToString();
            tb_down.InputText = sensor.down.ToString();
            cb_use.Checked = sensor.use;

            alarmForm.up = sensor.up;
            alarmForm.down = sensor.down;
            plot.SetAnnotionValue(sensor.down, sensor.up);

            //加载 Form
            layout.LoadForm2Panel(plot, panel_timeSeries);//实时绘图form
            layout.LoadForm2Panel(staticsForm, panel_statics);//统计form
            layout.LoadForm2Panel(fatigueForm, panel_fatigue);//疲劳损伤度form
            layout.LoadForm2Panel(predictChart, panel_predict);

            //数据库初始化
            DataBaseInit();
            //建立事件注册
            MakeDelegate();
        }

        /// <summary>
        /// 数据库初始化设置
        /// </summary>
        private void DataBaseInit()
        {
            try
            {
                //连接并打开数据库
                var dbPath = SQLiteHelper.GetDataBasePath();
                SH = new SQLiteHelper(dbPath);
                SH.OpenDb();

                //根据传感器ID确定要插入到哪一张表
                string table_statics = "Sensor" + sensor.id.ToString() + "_statics";
                string table_timeSeries = "Sensor" + sensor.id.ToString() + "_timeSeries";
                string table_alarm = "Sensor" + sensor.id.ToString() + "_alarm";

                //获取sql语句 与 参数
                SQLiteHelper.GetAlarmSqlParam(table_alarm, out sql_alarm, out param_alarm);
                SQLiteHelper.GetStaticsParam(table_statics, out sql_statics, out param_statics);
                SQLiteHelper.GetTimeSeriesSqlParam(table_timeSeries, out sql_timeSeries, out param_timeSeries);
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库初始化错误" + ex.ToString());
            }
        }

        /// <summary>
        /// 注册事件
        /// </summary>
        public void MakeDelegate()
        {
            //长周期 数据 处理
            sensor.sensor_DataPrepared4LongPeriodEvent += Process_long;
            //短周期 数据 处理
            sensor.Sensor_DataPrepared4ShortPeriodEvent += Process_short;
            //预测 数据 处理
            sensor.Sensor_DataPrepared4PredictEvent += Process_predict;
            //阈值报警
            alarmForm.sendOverRangeValueEvent += (over, value) =>
            {
                Task.Factory.StartNew(() =>//一定要多线程，不然会阻塞曲线的刷新
                {
                    try
                    {
                        var time= DateTime.Now.ToString();

                        //数据绑定
                        param_alarm[0].Value = time;
                        param_alarm[1].Value = "sensor" + sensor.id.ToString();
                        param_alarm[2].Value = over;
                        param_alarm[3].Value = value;
                        //
                        var len=SH.ExecuteNonQuery(sql_alarm, param_alarm);

                        SendSensorAlarm_Event?.Invoke(time, sensor.id, over, value);//发射alarm报警信息
                    }
                    catch (Exception e)
                    {
                        throw new AggregateException("保存报警信息到数据库失败" + e.ToString());
                    }
                });
            };

            //关闭改为隐藏
            btn_close.Click += (sender, eve) => { this.Hide(); };
            //标题栏 移动
            panel_titleBar.MouseDown += On_TitleBar_MouseDown;
            panel_titleBar.MouseMove += On_TitleBar_MouseMove;

            // 更新、设置传感器信息
            btn_updateSensorInf.BtnClick += (s, e) =>
              {
                  FrmTips.ShowTipsInfo(this, "已保存参数");

                  //sensor.id = (uint)Convert.ToInt32(tb_sensorId.Text);//id不可更改 只读，因为存入数据要靠id索引
                  sensor.location = tb_sensorLocation.InputText;
                  sensor.name = tb_sensorName.InputText;
                  sensor.type = tb_sensorType.InputText;
                  sensor.interval_long = Convert.ToInt32(interval_long.InputText);//分钟
                  sensor.interval_short = Convert.ToInt32(interval_short.InputText);//秒
                  sensor.up = Convert.ToDouble(tb_up.InputText);
                  sensor.down = Convert.ToDouble(tb_down.InputText);
                  sensor.filter = tb_filter.InputText;

                  plot.SetAnnotionValue(sensor.down, sensor.up);

                  sensor.SetTimer();

                  //发送传感器配置出去
                  string[] cfg = new string[9];

                  cfg[0] = tb_sensorName.InputText;//name
                  cfg[1] = tb_sensorType.InputText;//type
                  cfg[2] = tb_sensorLocation.InputText;//location
                  cfg[3] = tb_filter.InputText;//filter
                  cfg[4] = interval_short.InputText;//short
                  cfg[5] = interval_long.InputText;//long
                  cfg[6] = tb_up.InputText;//up
                  cfg[7] = tb_down.InputText;//down
                  cfg[8] = cb_use.Checked ? "1" : "0";//use?

                  SendSensorCfg_sensorForm_Event?.Invoke(sensor.id, cfg);
              };
        }

        /// <summary>
        /// 从form1传来传感器cfg，1.更新cfg到sensor对象成员内同时利用属性保存到ini中，2.更新到sensorForm界面上
        /// </summary>
        /// <param name="param"></param>
        public void UpdateSensorParams(string[] param)
        {
            if (param.Length != 9)
            {
                FrmTips.ShowTipsInfo(this, "保存参数出错");
                return;
            }

            sensor.name = param[0];
            tb_sensorName.InputText = sensor.name;

            sensor.type = param[1];
            tb_sensorType.InputText = sensor.type;

            sensor.location = param[2];
            tb_sensorLocation.InputText = sensor.location;

            sensor.filter = param[3];
            tb_filter.InputText = sensor.filter;

            sensor.interval_short = Convert.ToInt32(param[4]);
            interval_short.InputText = sensor.interval_short.ToString();

            sensor.interval_long = Convert.ToInt32(param[5]);
            interval_long.InputText = sensor.interval_long.ToString();

            sensor.up = Convert.ToDouble(param[6]);
            tb_up.InputText = sensor.up.ToString();

            sensor.down = Convert.ToDouble(param[7]);
            tb_down.InputText = sensor.down.ToString();

            sensor.use = Convert.ToInt32(param[8]) == 1 ? true : false;
            cb_use.Checked = sensor.use;

            alarmForm.up = sensor.up;
            alarmForm.down = sensor.down;
            plot.SetAnnotionValue(sensor.down, sensor.up);
        }

        /// <summary>
        /// 压入数据
        /// </summary>
        /// <param name="dataPoint"></param>
        public void PrepareData(double dataPoint)
        {
            sensor.PushDataPoint(dataPoint);
            alarmForm.Detect(dataPoint);////////////////////////////////

            //保存实时测点数据
            //Task.Factory.StartNew(()=> 
            //{
            //    param_timeSeries[0].Value = DateTime.Now.ToString();
            //    param_timeSeries[1].Value = dataPoint;

            //    SH.ExecuteNonQuery(sql_timeSeries, param_timeSeries);
            //});
        }

        #region 长 短 周期数据处理
        /// <summary>
        /// 长期 数列 处理
        /// </summary>
        /// <param name="dataList"></param>
        private void Process_long(List<double> dataList)
        {
            //多线程处理
            Task.Factory.StartNew(()=>
              {
                  try
                  {
                      //疲劳计算
                      fatigueForm.Apply2(dataList);

                      //统计计算
                      var staticsRes = staticsForm.Apply2(dataList);

                      //数据库数据绑定
                      param_statics[0].Value = DateTime.Now.ToString();//time
                      param_statics[1].Value = staticsRes[0];
                      param_statics[2].Value = staticsRes[1];
                      param_statics[3].Value = staticsRes[2];
                      param_statics[4].Value = staticsRes[3];
                      param_statics[5].Value = staticsRes[4];
                      param_statics[6].Value = staticsRes[5];
                      param_statics[7].Value = staticsRes[6];
                      SH.ExecuteNonQuery(sql_statics, param_statics);
                  }
                  catch (Exception e)
                  {
                      MessageBox.Show("统计数据保存出错" + e.ToString());
                  }
              });
        }
        /// <summary>
        /// 短期 数据列 处理
        /// </summary>
        /// <param name="dataList"></param>
        private void Process_short(List<double> dataList)
        {
            Task.Factory.StartNew(() =>
            {
                if (dataList.Count == 0)
                {
                    MessageBox.Show("Null dataList");
                    return;
                }

                double mean = 0;
                dataList.ForEach((item) => mean += item);
                mean = mean / dataList.Count;

                var nowTime = DateTime.Now;

                plot.Draw(nowTime, (float)mean, 0);

                var max = dataList.Max();
                plot.Draw(nowTime,(float)max,1);

                var min = dataList.Min();
                plot.Draw(nowTime, (float)min, 2);
            });
        }
        /// <summary>
        /// 预测 数据列 处理
        /// </summary>
        /// <param name="dataList"></param>
        private void Process_predict(List<float> dataList)
        {
            Task.Factory.StartNew(() =>
            {
                var len = dataList.Count;
                var sigs = dataList.ToArray();

                //将数据分为4份 四个小时数据分为每一个小时的
                int splitLen = len / 4;
                var sig1 = dataList.Skip(0).Take(splitLen).ToArray();
                var sig2 = dataList.Skip(splitLen).Take(splitLen).ToArray();
                var sig3 = dataList.Skip(2 * splitLen).Take(splitLen).ToArray();
                var sig4 = dataList.Skip(3 * splitLen).Take(dataList.Count-3*splitLen).ToArray();

                float[] res=predictFft.Allpy2(sig1, sig2, sig3, sig4);

                //绘图更新
                predictChart.Draw(res);
            });
        }
        #endregion

        #region 自定义标题栏
        /// <summary>
        /// 设置标题
        /// </summary>
        public void SetTitle(string titleText)
        {
            label_title.Text = titleText;
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
        #endregion
    }
}
