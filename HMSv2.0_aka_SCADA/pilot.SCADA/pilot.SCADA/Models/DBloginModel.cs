using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Models
{
    public class DBloginModel : ObservableObject
    {
        private string serverName;
        /// <summary>
        /// 服务器名称
        /// </summary>
        public string ServerName
        {
            get { return serverName; }
            set
            {
                if (serverName == value) { return; }
                serverName = value;
                RaisePropertyChanged(() => ServerName);
            }
        }

        private string dbName;
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DBName
        {
            get { return dbName; }
            set
            {
                if (dbName == value) { return; }
                dbName = value;
                RaisePropertyChanged(() => DBName);
            }
        }

        private string userName;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set
            {
                if (userName == value) { return; }
                userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        private string pwd;
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            get { return pwd; }
            set
            {
                if (pwd == value) { return; }
                pwd = value;
                RaisePropertyChanged(() => PassWord);
            }
        }

        private bool isRememberPwd;
        /// <summary>
        /// 是否记住密码
        /// </summary>
        public bool IsRememberPwd
        {
            get { return isRememberPwd; }
            set
            {
                if (isRememberPwd == value) { return; }
                isRememberPwd = value;
                RaisePropertyChanged(() => IsRememberPwd);
            }
        }
    }
}
