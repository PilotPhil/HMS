using GalaSoft.MvvmLight.Command;
using pilot.DAL;
using pilot.DataBuffer;
using pilot.ManagedTasks.Algorithm;
using System;
using System.Timers;

namespace pilot.ManagedTasks.TaskUtil
{
    public class AlarmTask : TaskBase
    {
        public AlarmTask(IDataBuffer _dataBuffer, uint _dataSourceIndex) : base(_dataBuffer, _dataSourceIndex)
        {
            Version = "0.0.1";
            TaskName = "阈值报警";
            Autho = "Pilot.Phil";
        }

        /// <summary>
        /// 处理定时器 事件 重写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void ProcessTimerDo(object sender, ElapsedEventArgs e)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                AlarmRes = thresholdAlarm.CheckOutThreshold(SampledBuffer, H, L, Rate);
                if (AlarmRes.id != 0)
                {
                    DataAcess.InsertAlarmRes(DateTime.Now.ToString(), sGuid, AlarmRes.aInfo, AlarmRes.extValue, AlarmRes.avgValue);
                }
                SampledBuffer.Clear();
            });
        }


        #region 属性
        //阈值报警算法应用
        private readonly ThresholdAlarm thresholdAlarm = new ThresholdAlarm();

        private AlarmRes alarmRes;
        /// <summary>
        /// 报警信息
        /// </summary>
        public AlarmRes AlarmRes
        {
            get { return alarmRes; }
            set
            {
                if (alarmRes == value) { return; }
                alarmRes = value;
                RaisePropertyChanged(() => AlarmRes);
            }
        }

        private double h = 20;
        /// <summary>
        /// H
        /// </summary>
        public double H
        {
            get { return h; }
            set
            {
                if (h == value) { return; }
                h = value;
                RaisePropertyChanged(() => H);
            }
        }

        private double l = 10;
        /// <summary>
        /// l
        /// </summary>
        public double L
        {
            get { return l; }
            set
            {
                if (l == value) { return; }
                l = value;
                RaisePropertyChanged(() => L);
            }
        }

        private double rate = 0.2;
        /// <summary>
        /// 超越百分比设定
        /// </summary>
        public double Rate
        {
            get { return rate; }
            set
            {
                if (rate == value) { return; }
                rate = value;
                RaisePropertyChanged(() => Rate);
            }
        }

        #endregion


    }
}
