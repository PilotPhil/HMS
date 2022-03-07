using System;

namespace pilot.DAL.Log
{
    public class LogRecordModel
    {
        //记录时间
        public string RecordTime { get; private set; } = DateTime.Now.ToString();

        //操作员(登陆者)身份
        public LogIdentity LogIdentity { get; private set; } = LogIdentity.Developer;

        //记录内容
        public string Content { get; set; }
    }

    public enum LogIdentity
    {
        Developer = -1,
        Administer = 0,
        User = 2
    }
}
