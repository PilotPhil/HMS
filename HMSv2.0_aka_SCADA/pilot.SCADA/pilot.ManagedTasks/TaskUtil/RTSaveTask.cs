using GalaSoft.MvvmLight.Command;
using pilot.DAL;
using pilot.DataBuffer;
using System;
using System.Collections.Generic;
using System.Timers;

namespace pilot.ManagedTasks.TaskUtil
{
    public class RTSaveTask : TaskBase
    {
        public List<RTSaveModel> RTSaveData { get; set; } = new List<RTSaveModel>();

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_dataBuffer"></param>
        public RTSaveTask(IDataBuffer _dataBuffer, uint _dataSourceIndex) : base(_dataBuffer, _dataSourceIndex)
        {
            Version = "0.0.2";
            TaskName = "实时数据存储";
        }

        Random random = new Random();
        /// <summary>
        /// 采样定时器 超时 事件 重写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void SampleTimeDo(object sender, ElapsedEventArgs e)
        {
            
            RTSaveData.Add(new RTSaveModel()
            {
                sGuid = this.sGuid,
                sValue = random.Next(0, 100) + random.NextDouble(),
                sTime = DateTime.Now.ToString()
            });
        }

        /// <summary>
        /// 处理定时器 超时 事件 重写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void ProcessTimerDo(object sender, ElapsedEventArgs e)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                //RTSaveData.ForEach(i => DataAcess.InsertOneRTData(i.sGuid, i.sValue, i.sTime));
                for (int i = 0; i < RTSaveData.Count; i++)
                {
                    DataAcess.InsertRTData(RTSaveData[i].sGuid, RTSaveData[i].sValue, RTSaveData[i].sTime);
                }

                RTSaveData.Clear();
            });
        }
    }

    /// <summary>
    /// 传感器实时数据存入数据库模型，模拟表的结构
    /// </summary>
    public class RTSaveModel
    {
        public string sGuid { get; set; }//sensor global id
        public double sValue { get; set; }//sensor value
        public string sTime { get; set; }//save time
    }
}
