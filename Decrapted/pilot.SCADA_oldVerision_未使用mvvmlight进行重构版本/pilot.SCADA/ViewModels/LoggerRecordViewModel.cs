using pilot.SCADA.Common;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.ViewModels
{
    class LoggerRecordViewModel : NotificationObject
    {
        #region 单例
        private static LoggerRecordViewModel _instance=null;
        private LoggerRecordViewModel()
        {
            CurrentLog = new LogRecordModel();
            LogList = new List<LogRecordModel>();
        }

        public static LoggerRecordViewModel GetInstance()
        {
            _instance = _instance ?? new LoggerRecordViewModel();
            return _instance;
        }
        #endregion

        //当前记录 一条
        private LogRecordModel _currentLog;
        public LogRecordModel CurrentLog
        {
            get { return _currentLog; }
            set
            {
                _currentLog = value;
                this.RaisePropertyChanged("CurrentLog");
            }
        }

        //工程日志记录
        private List<LogRecordModel> _logList;
        public List<LogRecordModel> LogList
        {
            get { return _logList; }
            set
            {
                _logList = value;
                this.RaisePropertyChanged("LogList");
            }
        }

        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="model"></param>
        public void Record(LogRecordModel model)
        {
            CurrentLog = model;
            LogList.Add(model);
        }


    }
}
