using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.DAL.Log
{
    /// <summary>
    /// 日志业务
    /// </summary>
    public class LogRecordViewModel : ViewModelBase, ILog
    {
        /// <summary>
        /// ctor
        /// </summary>
        public LogRecordViewModel()
        {
            CurrentLog = new LogRecordModel();
            LogRecordList = new List<LogRecordModel>();
        }


        #region 业务方法
        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="model"></param>
        public void Record(LogRecordModel model)
        {
            CurrentLog = model;
            LogRecordList.Add(model);
        }

        #endregion


        #region 属性
        private LogRecordModel _currentLog;
        /// <summary>
        /// 当前记录 一条
        /// </summary>
        public LogRecordModel CurrentLog
        {
            get { return _currentLog; }
            set
            {
                if (_currentLog == value) { return; }
                _currentLog = value;
                RaisePropertyChanged(() => CurrentLog);
            }
        }

        private List<LogRecordModel> _LogRecordList;
        /// <summary>
        /// 工程日志记录
        /// </summary>
        public List<LogRecordModel> LogRecordList
        {
            get { return _LogRecordList; }
            set
            {
                if (_LogRecordList == value) { return; }
                _LogRecordList = value;
                RaisePropertyChanged(() => LogRecordList);
            }
        }

        #endregion
    }


}
