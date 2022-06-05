using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MarineControl.HMS
{
    /// <summary>
    /// 数据准备类
    /// 串口将通道数据解析出来后，分别调用此类，此类将单个数据点压入数据列中，当定时器超时后触发处理事件，并将数据列清空。
    /// </summary>
    class DataPrepare
    {
        /// <summary>
        /// 定时器到时后发送数据列事件
        /// </summary>
        /// <param name="dataList"></param>
        public delegate void SeneorDataPreparedHandler(List<double> dataList);
        public event SeneorDataPreparedHandler SeneorDataPreparedEvent;

        /// <summary>
        /// 实时数据点处理事件：实时数据点显示 文本和 曲线
        /// </summary>
        /// <param name="dataPoint"></param>
        //public delegate void SeneorRealTimeDataHandler(double dataPoint);
        //public event SeneorRealTimeDataHandler SeneorRealTimeDataEvent;

        /// <summary>
        /// 定时器事件间隔
        /// </summary>
        private int _timeSpan;//5000ms
        public int timeSpan
        {
            get { return _timeSpan; }
            set { _timeSpan = value; }
        }

        /// <summary>
        /// 定时器对象
        /// </summary>
        public Timer timer = new Timer();

        /// <summary>
        /// 数据列
        /// </summary>
        public List<double> dataList = new List<double>();

        /// <summary>
        /// 构造
        /// </summary>
        public DataPrepare()
        {
            timeSpan = 5000;
            timer.Interval = timeSpan;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(TimerUp);
        }


        /// <summary>
        /// 准备数据
        /// </summary>
        /// <param name="dataPoint"></param>
        public void Prepare(string dataPoint)
        {
            double dp;

            if (double.TryParse(dataPoint, out dp) == false)
                return;
            dataList.Add(dp);
        }

        /// <summary>
        /// 准备数据
        /// </summary>
        /// <param name="dataPoint"></param>
        public void Prepare(double dataPoint)
        {
            dataList.Add(dataPoint);
        }


        /// <summary>
        /// 定时器到时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(SeneorDataPreparedEvent != null)//代理非空
            {
                //深拷贝一个，数据处理时为异步，若为引用传递，会被下一步clear干扰
                List<double> dataList2send = new List<double>(dataList);

                SeneorDataPreparedEvent(dataList2send);//发送数据处理
                dataList.Clear();//情况数据列
            }
        }
    }
}
