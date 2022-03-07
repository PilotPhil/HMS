using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pilot.HMS.Common;

namespace pilot.HMS.Models
{
    public class LoginModel:NotificationObject
    {
        //用户名
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                this.RaisePropertyChanged("UserName");
            }
        }

        //密码
        private string _passWord;
        public string PassWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
                this.RaisePropertyChanged("PassWord");
            }
        }

        //登录错误信息
        private string _errorMsg;
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set
            {
                _errorMsg = value;
                this.RaisePropertyChanged("ErrorMsg");
            }
        }

    }
}
