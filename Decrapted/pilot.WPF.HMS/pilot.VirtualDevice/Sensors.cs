using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace pilot.VirtualDevice
{
    class Sensors
    {
        public event Action<int[]> SendSensorsValuesEvent;

        Random R = new Random();

        //频率 Hz 一秒钟多少次
        private int _freq = 10;
        public int Freq
        {
            get { return _freq; }
            set
            {
                if (Freq <= 0)
                {
                    MessageBox.Show("Freq can not less than 0");
                }
                else if (Freq > 500)
                {
                    MessageBox.Show("Freq can not more than 500");
                }
                else
                {
                    _freq = value;
                }

            }
        }

        //定时器
        Timer timer = new Timer();

        //
        public int[] SensorValues { get; set; }

        //传感器数量
        private int _sensorNum = 6;
        public int SensorNum
        {
            get { return _sensorNum; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Number of sensors can not less than 1");
                }
                else
                    _sensorNum = value;
            }
        }

        public Sensors()
        {
            //超时处理
            timer.Elapsed += new ElapsedEventHandler(GenerateSensorValues);

            SensorValues = new int[SensorNum];
        }

        /// <summary>
        /// 重新给传感器数值数组分配地址
        /// </summary>
        public void UpdateSensorValueArray()
        {
            SensorValues = new int[SensorNum];
        }

        /// <summary>
        /// 生成传感器数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateSensorValues(object sender, ElapsedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < SensorValues.Length; i++)
                {
                    SensorValues[i] = R.Next(10 * i, 50 * i);
                }
            });
            SendSensorsValuesEvent?.Invoke(SensorValues);
        }

        /// <summary>
        /// 设置定时器
        /// </summary>
        public void SetTimer()=>timer.Interval = 1000 / Freq;
        /// <summary>
        /// 开启定时器
        /// </summary>
        public void StartTimer() => timer.Start();
        /// <summary>
        /// 关闭定时器
        /// </summary>
        public void StopTimer() => timer.Stop();
    }
}
