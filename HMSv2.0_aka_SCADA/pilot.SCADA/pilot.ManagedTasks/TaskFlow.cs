using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using pilot.DataBuffer;
using pilot.ManagedTasks.TaskUtil;

namespace pilot.ManagedTasks
{
    public class TaskFlow : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_datasourceIndex"></param>
        public TaskFlow(IDataBuffer _dataBuffer,uint _dataSourceIndex)
        {
            this.dataSourceIndex = _dataSourceIndex;

            CurveTask = new CurveTask(_dataBuffer, _dataSourceIndex);
            StaticsTask = new StaticsTask(_dataBuffer, _dataSourceIndex);
            AlarmTask = new AlarmTask(_dataBuffer, _dataSourceIndex);
            RTSaveTask = new RTSaveTask(_dataBuffer, _dataSourceIndex);

            //由开始监测统一发送信号 开始多个任务
            Messenger.Default.Register<string>("setstart", (str) =>
            {
                CurveTask.Set(null);
                RTSaveTask.Set(null);
                StaticsTask.Set(null);
                AlarmTask.Set(null);
                //......
                //......
                //......
            });
        }

        /// <summary>
        /// 数据索引源
        /// </summary>
        private uint dataSourceIndex=0;
        public uint DataSourceIndex
        {
            get { return dataSourceIndex; }
            set 
            { 
                dataSourceIndex = value;

                RTSaveTask.DataSourceIndex = value;
                staticsTask.DataSourceIndex = value;
                AlarmTask.DataSourceIndex = value;
            }
        }

        /// <summary>
        /// 传感器唯一标识符
        /// </summary>
        private string sGuid;
        public string SGuid
        {
            get { return sGuid; }
            set 
            { 
                sGuid = value;

                RTSaveTask.sGuid = value;
                staticsTask.sGuid = value;
                AlarmTask.sGuid = value;
            }
        }


        #region 任务 对象
        private CurveTask curveTask;
        /// <summary>
        /// 实时曲线任务
        /// </summary>
        public CurveTask CurveTask
        {
            get { return curveTask; }
            set
            {
                if (curveTask == value) { return; }
                curveTask = value;
                RaisePropertyChanged(() => CurveTask);
            }
        }   

        private RTSaveTask rtSaveTask;
        /// <summary>
        /// 传感器实时存储任务
        /// </summary>
        public RTSaveTask RTSaveTask
        {
            get { return rtSaveTask; }
            set
            {
                if (rtSaveTask == value) { return; }
                rtSaveTask = value;
                RaisePropertyChanged(() => RTSaveTask);
            }
        }

        private StaticsTask staticsTask;
        /// <summary>
        /// 统计任务
        /// </summary>
        public StaticsTask StaticsTask
        {
            get { return staticsTask; }
            set
            {
                if (staticsTask == value) { return; }
                staticsTask = value;
                RaisePropertyChanged(() => StaticsTask);
            }
        }

        private AlarmTask alarmTask;
        /// <summary>
        /// 阈值报警任务
        /// </summary>
        public AlarmTask AlarmTask
        {
            get { return alarmTask; }
            set
            {
                if (alarmTask == value) { return; }
                alarmTask = value;
                RaisePropertyChanged(() => AlarmTask);
            }
        }

        #endregion
    }
}
