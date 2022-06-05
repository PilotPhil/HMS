using pilot.SCADA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Models
{
    /// <summary>
    /// 项目记录 模型
    /// </summary>
    class ProjectRecordModel:NotificationObject
    {
        //正使用的项目路径---文件夹，内有多个json配置文件
        private string _ProjectPath;
        public string ProjectPath
        {
            get { return _ProjectPath; }
            set
            {
                _ProjectPath = value;
                this.RaisePropertyChanged("ProjectPath");
            }
        }

        private string _ProjectName;
        public string ProjectName
        {
            get { return _ProjectName; }
            set
            {
                _ProjectName = value;
                this.RaisePropertyChanged("ProjectName");
            }
        }

        //保存时间
        private string _saveTime;
        public string SaveTime
        {
            get { return _saveTime; }
            set
            {
                _saveTime = value;
                this.RaisePropertyChanged("SaveTime");
            }
        }
    }
}
