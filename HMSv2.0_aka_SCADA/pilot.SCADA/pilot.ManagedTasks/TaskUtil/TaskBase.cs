using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using pilot.DataBuffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pilot.ManagedTasks.TaskUtil
{
    /// <summary>
    /// 任务基类
    /// </summary>
    public abstract class TaskBase : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_dataSourceIndex"></param>
        public TaskBase(IDataBuffer _dataBuffer,uint _dataSourceIndex)
        {
            this.DataBuffer = _dataBuffer;//依赖注入，传感器数据抓取接口
            this.DataSourceIndex = _dataSourceIndex;

            SampleTimer.Elapsed += new ElapsedEventHandler(SampleTimeDo);//采样定时器 超时 事件
            ProcessTimer.Elapsed += new ElapsedEventHandler(ProcessTimerDo);//处理定时器 超时 事件
        }


        #region 基本信息
        /// <summary>
        /// 传感器标识
        /// </summary>
        public string sGuid { get; set; } = string.Empty;

        private string taskName = "TaskName";
        /// <summary>
        /// 任务 名
        /// </summary>
        public string TaskName
        {
            get { return taskName; }
            set
            {
                if (taskName == value) { return; }
                taskName = value;
                RaisePropertyChanged(() => TaskName);
            }
        }

        private string version = "0.0.1";
        /// <summary>
        /// 版本
        /// </summary>
        public string Version
        {
            get { return version; }
            set
            {
                if (version == value) { return; }
                version = value;
                RaisePropertyChanged(() => Version);
            }
        }

        private string autho = "Pilot.Phil";
        /// <summary>
        /// 作者
        /// </summary>
        public string Autho
        {
            get { return autho; }
            set
            {
                if (autho == value) { return; }
                autho = value;
                RaisePropertyChanged(() => Autho);
            }
        }

        private bool isEnable = true;
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                if (isEnable == value) { return; }
                isEnable = value;
                RaisePropertyChanged(() => IsEnable);
            }
        }
        #endregion


        #region 定时器
        /// <summary>
        /// 数据采样定时器
        /// </summary>
        public readonly Timer SampleTimer = new Timer();
        private double sampleFreq = 1.0;
        /// <summary>
        /// 采样间隔 频率 Hz
        /// </summary>
        public double SampleFreq
        {
            get { return sampleFreq; }
            set
            {
                if (sampleFreq == value) { return; }
                sampleFreq = value;
                RaisePropertyChanged(() => SampleFreq);
            }
        }
        /// <summary>
        /// 可重写的采样定时器超时处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void SampleTimeDo(object sender, ElapsedEventArgs e)
        {
            //随机数模拟
            //Random r = new Random();
            //SampledBuffer.Add(r.Next(0, 100));

            //真实 从 buffer库里面读取
            var Data = DataBuffer.GetDataByAddr((ushort)DataSourceIndex);
            if (Data != null)
            {
                SampledBuffer.Add(Data.value);
            }
        }

        /// <summary>
        /// 数据处理定时器
        /// </summary>
        public readonly Timer ProcessTimer = new Timer();
        private double processInterval = 0.1;
        /// <summary>
        /// 统计 计时器 间隔 分钟
        /// </summary>
        public double ProcessInterval
        {
            get { return processInterval; }
            set
            {
                if (processInterval == value) { return; }
                processInterval = value;
                RaisePropertyChanged(() => ProcessInterval);
            }
        }
        /// <summary>
        /// 可重写的处理定时器超时处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ProcessTimerDo(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 数据获取，给处理用的数据缓冲区
        /// <summary>
        /// 数据读取接口
        /// </summary>
        protected readonly IDataBuffer DataBuffer;

        public uint DataSourceIndex { get; set; } = 0;

        /// <summary>
        /// 统计 数据缓冲区
        /// </summary>
        protected List<float> SampledBuffer = new List<float>();
        #endregion


        #region 命令
        private RelayCommand<object> _setCommand;
        /// <summary>
        /// 设置命令
        /// </summary>
        public RelayCommand<object> SetCommand
        {
            get
            {
                return _setCommand ?? (_setCommand = new RelayCommand<object>(Set));
            }
        }
        public virtual void Set(object param)
        {
            //如果此算法确定是启用的，那就是只要设定两个定时器的处理间隔，如果未启用，则要关闭定时器
            if (IsEnable == true)
            {
                SampleTimer.Interval = (double)(1000.0 / SampleFreq);//Hz-->ms
                SampleTimer.Start();

                ProcessTimer.Interval = (double)ProcessInterval * 60.0 * 1000.0;//分钟-->ms
                ProcessTimer.Start();
            }
            else
            {
                ProcessTimer.Stop();
                SampleTimer.Stop();
            }
        }
        #endregion


    }
}
