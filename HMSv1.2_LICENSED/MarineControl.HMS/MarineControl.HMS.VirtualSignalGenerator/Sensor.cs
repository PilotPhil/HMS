using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MarineControl.HMS.VirtualSignalGenerator
{
    class Sensor
    {
        /// <summary>
        /// 传感器列表
        /// </summary>
        public static List<Sensor> sensorList = new List<Sensor>();

        public static uint instanceNum=0;

        private Random r = new Random();

        public string name { get; set; }

        /// <summary>
        /// 随机数上下限
        /// </summary>
        public int r_min { get; set; }
        public int r_max { get; set; }

        public Timer timer = new Timer();

        public int ID;

        /// <summary>
        /// 采样定时器间隔
        /// </summary>
        private int _interval;
        public int interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public delegate void SensorDataHandler();
        public event SensorDataHandler SensorDataEvent;

        /// <summary>
        /// 构造
        /// </summary>
        public Sensor()
        {
            sensorList.Add(this);
            instanceNum++;

            r_min = -10;
            r_max = 30;

            timer.Elapsed += Timer_Elapsed;

            interval = 100;
            timer.Interval = interval;

            timer.Start();

            ID = (int)instanceNum;

            name = "SG" + ID.ToString();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (SensorDataEvent != null)
                SensorDataEvent();
        }

        /// <summary>
        /// 移除实例
        /// </summary>
        /// <param name="s"></param>
        public void RemoveInstance(Sensor s)
        {
            sensorList.Remove(s);
            instanceNum--;
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public double GetRandomData()
        {
            double tem = 0;

            if (r_min < r_max)
            {
                tem = r.Next(r_min, r_max);
            }
            return tem;
        }

    }
}
