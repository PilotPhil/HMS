using pilot.SCADA.Common;

namespace pilot.SCADA.Models
{
    public class LogRecordModel:NotificationObject
    {
        //记录时间
        private string _recordTime;
        public string RecordTime
        {
            get { return _recordTime; }
            set
            {
                _recordTime = value;
                this.RaisePropertyChanged("RecordTime");
            }
        }

        //操作员(登陆者)身份
        private string _identity;
        public string Identity
        {
            get { return _identity; }
            set
            {
                _identity = value;
                this.RaisePropertyChanged("Identity");
            }
        }

        //记录内容
        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                this.RaisePropertyChanged("Content");
            }
        }

        //记录类型
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                this.RaisePropertyChanged("Type");
            }
        }

        //
    }
}
