using LiveCharts;
using pilot.DataBuffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pilot.ManagedTasks.TaskUtil
{
    public class CurveTask : TaskBase
    {
        public CurveTask(IDataBuffer _dataBuffer,uint _dataSourceIndex) : base(_dataBuffer, _dataSourceIndex)
        {
            Version = "0.1.1";
            TaskName = "实时曲线";
            Autho = "Pilot.Phil";

            SampleFreq = 1;

            this.DataSourceIndex = _dataSourceIndex;
        }

        //Random random = new Random();


        /// <summary>
        /// 采样定时器 处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void SampleTimeDo(object sender, ElapsedEventArgs e)
        {
            while (CurvePoints.Count >= CurveLength)
            {
                CurvePoints.RemoveAt(0);
            }

            //CurvePoints.Add(random.Next(0, 100));//随机数 测试
            var currentValue = this.DataBuffer.GetDataByAddr((ushort)DataSourceIndex);
            if (currentValue != null)
            {
                CurvePoints.Add(currentValue.value);
                Console.WriteLine("sensor "+this.DataSourceIndex+"   value: "+currentValue.value);
            }

        }

        /// <summary>
        /// 重写开关方法 命令
        /// </summary>
        /// <param name="param"></param>
        public override void Set(object param)
        {
            //如果此算法确定是启用的，那就是只要设定两个定时器的处理间隔，如果未启用，则要关闭定时器
            if (IsEnable == true)
            {
                SampleTimer.Interval = (double)(1000.0 / SampleFreq);//Hz-->ms
                SampleTimer.Start();
            }
            else
            {
                SampleTimer.Stop();
            }
        }

        #region 属性
        private uint curveLength = 25;
        /// <summary>
        /// 曲线长度
        /// </summary>
        public uint CurveLength
        {
            get { return curveLength; }
            set
            {
                if (curveLength == value) { return; }
                curveLength = value;
                RaisePropertyChanged(() => CurveLength);
            }
        }

        private ChartValues<double> curvePoints = new ChartValues<double>();
        /// <summary>
        /// myVar
        /// </summary>
        public ChartValues<double> CurvePoints
        {
            get { return curvePoints; }
            set
            {
                if (curvePoints == value) { return; }
                curvePoints = value;
                RaisePropertyChanged(() => CurvePoints);
            }
        }
        #endregion
    }
}
