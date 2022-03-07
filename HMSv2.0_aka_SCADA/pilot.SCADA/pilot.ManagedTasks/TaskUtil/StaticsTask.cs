
using GalaSoft.MvvmLight.Command;
using pilot.DAL;
using pilot.DataBuffer;
using pilot.ManagedTasks.Algorithm;
using System;
using System.Timers;

namespace pilot.ManagedTasks.TaskUtil
{
    /// <summary>
    /// 统计 任务
    /// </summary>
    public class StaticsTask : TaskBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_dataSourceIndex">数据源索引</param>
        public StaticsTask(IDataBuffer _dataBuffer, uint _dataSourceIndex) : base(_dataBuffer, _dataSourceIndex)
        {
            Version = "0.2.1";
            TaskName = "基础统计";
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
                StaticsRes = statics7.Calculate(SampledBuffer);

                DataAcess.InsertStaticsData(sGuid, StaticsRes, DateTime.Now.ToString());

                SampledBuffer.Clear();
            });
        }

        #region 属性


        //统计算法应用
        private readonly Statics7 statics7 = new Statics7();

        private float[] staticsRes = new float[7];
        /// <summary>
        /// 统计计算结果
        /// </summary>
        public float[] StaticsRes
        {
            get { return staticsRes; }
            set
            {
                if (staticsRes == value) { return; }
                staticsRes = value;
                RaisePropertyChanged(() => StaticsRes);
            }
        }

        #endregion
    }
}
