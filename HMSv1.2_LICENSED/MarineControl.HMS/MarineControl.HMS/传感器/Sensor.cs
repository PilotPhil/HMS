using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MarineControl.HMS;
using MarineControl.HMS.Cfg;

using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;

namespace MarineControl.HMS.Sensor
{
    public class Sensor
    {
        //静态 传感器 数量
        public static uint num;
        //静态 传感器 对象列表
        public static List<Sensor> sensorList = new List<Sensor>();

        //配置文件中节点
        private string selectedNode;

        //传感器ID
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        //传感器名
        private string _name;
        public string name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                IH.Write<string>(selectedNode, "name", value);
            }//写入到配置文件
        }

        //传感器类别
        private string _type;
        public string type
        {
            get { return _type; }
            set 
            { 
                _type = value;
                IH.Write<string>(selectedNode, "type", value);
            }
        }

        //传感器位置
        private string _location;
        public string location
        {
            get { return _location; }
            set 
            { 
                _location = value;
                IH.Write<string>(selectedNode,"location",value); 
            }
        }

        //滤波器
        private string _filter;
        public string filter
        {
            get { return _filter; }
            set 
            {
                _filter = value;
                IH.Write<string>(selectedNode, "filter", value);
            }
        }

        //阈值上
        private double _up;
        public double up
        {
            get { return _up; }
            set
            {
                _up = value;
                IH.Write<double>(selectedNode, "up", value);
            }
        }

        //阈值下
        private double _down;
        public double down
        {
            get { return _down; }
            set
            {
                _down = value;
                IH.Write<double>(selectedNode, "down", value);
            }
        }

        //是否使用
        private bool _use;
        public bool use
        {
            get { return _use; }
            set 
            {
                _use = value;
                IH.Write<string>(selectedNode, "use", value ? "1" : "0"); 
            }
        }

        //配置助手
        private IniFileHelper IH = new IniFileHelper();
        //private IniFileHelper IH = new IniFileHelper("sensor.ini");

        /// <summary>
        /// 传感器值
        /// </summary>
        private double _value;
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// 构造
        /// </summary>
        public Sensor()
        {
            num++;
            //传感器id
            id = (int)num;
            //加入到传感器列表
            sensorList.Add(this);
            //传感器配置文件中的节点
            selectedNode = "sensor" + id.ToString();

            //从配置文件中加载
            type = IH.Read(selectedNode, "type");//传感器类型
            name = IH.Read(selectedNode, "name");//传感器名
            location = IH.Read(selectedNode, "location");//传感器位置
            interval_long = Convert.ToInt32(IH.Read(selectedNode, "interval_long"));//从配置文件 读取 长周期定时器间隔
            interval_short = Convert.ToInt32(IH.Read(selectedNode, "interval_short"));//从配置文件 读取 短周期定时器间隔
            up = Convert.ToDouble(IH.Read(selectedNode, "up"));//读取阈值上
            down = Convert.ToDouble(IH.Read(selectedNode, "down"));//读取阈值下
            filter = IH.Read(selectedNode, "filter");
            var tem = Convert.ToInt32(IH.Read(selectedNode, "use"));
            use = tem == 1 ? true : false;

            SensorInit();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void SensorInit()
        {
            //timer事件注册
            TimersDelegate();

            //设置定时器
            SetTimer();
        }

        /*--------------------数据准备------------------------*/
        //短周期数据列
        private List<double> dataList_short = new List<double>();
        //长周期数据列
        private List<double> dataList_long = new List<double>();
        //预测用数据列
        private List<float> dataList_predict = new List<float>();

        /// <summary>
        /// 压入数据点
        /// </summary>
        /// <param name="dataPoint"></param>
        public void PushDataPoint(double dataPoint)
        {
            dataList_short.Add(dataPoint);
            dataList_long.Add(dataPoint);
            dataList_predict.Add((float)dataPoint);
        }
        public void PushDataPoint(string dataPoint)
        {
            double _dataPoint=0;
            if (double.TryParse(dataPoint, out _dataPoint) == false)
                return;

            this.PushDataPoint(_dataPoint);
        }

        //长周期 处理
        //长周期 处理 数据源 准备完成 事件
        public delegate void Sensor_DataPrepared4LongPeriodHandler(List<double> dataList_long);
        public Sensor_DataPrepared4LongPeriodHandler sensor_DataPrepared4LongPeriodEvent;
        //长周期定时器
        System.Timers.Timer timer_long = new System.Timers.Timer();
        //长周期 定时器 时间间隔
        private int _interval_long=1;
        public int interval_long
        {
            get { return _interval_long; }
            set { _interval_long = value;IH.Write<int>(selectedNode, "interval_long", value); }
        }

        //短周期 处理 数据源 准备完成 事件
        public delegate void Sensor_DataPrepared4ShortPeriodHandler(List<double> dataList_short);
        public Sensor_DataPrepared4ShortPeriodHandler Sensor_DataPrepared4ShortPeriodEvent;
        //短周期定时器
        System.Timers.Timer timer_short = new System.Timers.Timer();
        //短周期 定时器 时间间隔
        private Int32 _interval_short=1;
        public Int32 interval_short
        {
            get { return _interval_short; }
            set { _interval_short = value; IH.Write<int>(selectedNode, "interval_short", value); }
        }

        //预测 处理 数据源 准备完成 事件
        public delegate void Sensor_DataPrepared4PredictHandler(List<float> dataList_short);
        public Sensor_DataPrepared4PredictHandler Sensor_DataPrepared4PredictEvent;
        //预测用定时器
        System.Timers.Timer timer_predict = new System.Timers.Timer();//

        /// <summary>
        /// 设置timer触发间隔,关闭再开启
        /// </summary>
        public void SetTimer()
        {
            timer_predict.Interval = Convert.ToInt32(IH.Read(selectedNode, "predict"));

            timer_short.Stop();
            timer_long.Stop();
            timer_predict.Stop();

            timer_long.Interval = 60000*interval_long;
            timer_short.Interval = interval_short*1000;

            timer_short.Start();
            timer_long.Start();
            timer_predict.Start();
        }

        /// <summary>
        /// timer事件注册
        /// </summary>
        private void TimersDelegate()
        {
            //long
            timer_long.Elapsed += (s,e) => 
            {
                if (dataList_long.Count <= 0)
                    return;
                var tem = new List<double>(dataList_long);
                sensor_DataPrepared4LongPeriodEvent?.Invoke(tem);
                dataList_long.Clear();
            };

            //short
            timer_short.Elapsed += (s, e) =>
            {
                if (dataList_short.Count <= 0)
                    return;
                var tem = new List<double>(dataList_short);
                Sensor_DataPrepared4ShortPeriodEvent?.Invoke(tem);
                dataList_short.Clear();
            };

            //predict
            timer_predict.Elapsed += (s, e) =>
              {
                  if (dataList_predict.Count <= 0)
                      return;

                  var tem = new List<float>(dataList_predict);//深拷贝
                  Sensor_DataPrepared4PredictEvent?.Invoke(tem);
                  dataList_predict.Clear();
              };
        }
    }
}
