using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pilot.HMS.Common;
using pilot.HMS.DataAccess;
using pilot.HMS.Models;

namespace pilot.HMS.ViewModels
{
    public class LoginViewModel
    {
        public LoginModel loginModel { get; set; } = new LoginModel();

        //登录界面关闭退出
        public DelegateCommand ExitLoginCmd { get; set; }
        private void ExitLogin(object para)
        {
            (para as Window).Close();
        }

        //登录按钮命令
        public DelegateCommand LoginCommand { get; set; }
        private void Login(object para)//
        {
            loginModel.ErrorMsg = "";
            if (string.IsNullOrEmpty(loginModel.UserName) == true || string.IsNullOrEmpty(loginModel.PassWord) == true)
            {
                loginModel.ErrorMsg = "用户名和密码不能为空";
                return;
            }

            //多线程执行用户登录校验
            Task.Run(() =>
            {
                try
                {
                    var user = SqlServerDataAccess.GetInstance().CheckUserInfo
                        (loginModel.UserName, loginModel.PassWord);

                    if (user == null)
                    {
                        throw new Exception("登录失败，用户名或密码错误!");
                    }

                    //校验成功
                    GlobalValues.UserInfo = user;

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        (para as Window).DialogResult = true;//登录成功，给对话框状态真

                    });

                    loginModel.ErrorMsg = "登录成功";
                }
                catch (Exception ex)
                {
                    loginModel.ErrorMsg = ex.Message;
                }
            });
        }

        //ctor
        public LoginViewModel()
        {
            loginModel.UserName = "admin";
            loginModel.PassWord = "123456";

            ExitLoginCmd = new DelegateCommand();
            ExitLoginCmd.ExecuteAction = new Action<object>(ExitLogin);

            LoginCommand = new DelegateCommand();
            LoginCommand.ExecuteAction = new Action<object>(Login);
        }
    }
}
