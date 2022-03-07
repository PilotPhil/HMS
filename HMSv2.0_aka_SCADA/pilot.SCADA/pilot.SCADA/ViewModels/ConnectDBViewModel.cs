using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pilot.SCADA.Models;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;
using pilot.ProjConfiguration.Serialization;
using System.IO;
using GalaSoft.MvvmLight.Command;
using pilot.DAL;
using System.Windows;
using System.Data.SqlClient;

namespace pilot.SCADA.ViewModels
{
    public class ConnectDBViewModel : ViewModelBase
    {
        public ConnectDBViewModel(ISerialize serialize)
        {
            this.Serialize = serialize;
            this.Serialize.SetPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cfg", "DBConfig.json"));

            dbloginModel = serialize.Read<DBloginModel>() ?? new DBloginModel();

            if (DBloginModel.IsRememberPwd == false)
            {
                DBloginModel.PassWord = string.Empty;
            }

            ConnectionRes = "未连接";
        }

        #region 属性
        private ISerialize Serialize;

        private DBloginModel dbloginModel;
        /// <summary>
        /// 数据库登录模型
        /// </summary>
        public DBloginModel DBloginModel
        {
            get { return dbloginModel; }
            set
            {
                if (dbloginModel == value) { return; }
                dbloginModel = value;
                RaisePropertyChanged(() => DBloginModel);
            }
        }

        private string connectionRes;
        /// <summary>
        /// 连接结果
        /// </summary>
        public string ConnectionRes
        {
            get { return connectionRes; }
            set
            {
                if (connectionRes == value) { return; }
                connectionRes = value;
                RaisePropertyChanged(() => ConnectionRes);
            }
        }
        #endregion


        #region 命令
        private RelayCommand<object> _myCommand2;
        /// <summary>
        /// 验证连接 的命令
        /// </summary>
        public RelayCommand<object> VerifyConnectCommand
        {
            get
            {
                return _myCommand2 ?? (_myCommand2 = new RelayCommand<object>(VerifyConnect));
            }
        }
        private void VerifyConnect(object param)
        {
            try
            {
                string dbConfig = string.Format(@"Server={0};DataBase={1};Uid={2};Pwd={3}", DBloginModel.ServerName, DBloginModel.DBName, DBloginModel.UserName, DBloginModel.PassWord);
                var conn = new SqlConnection(dbConfig);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    ConnectionRes = "数据库连接成功";
                }
                conn.Close();
                conn = null;
            }
            catch (Exception ex)
            {
                ConnectionRes = "数据库连接失败: " + ex.Message;
            }
        }


        private RelayCommand<object> _myCommand1;
        /// <summary>
        /// 连接 的命令
        /// </summary>
        public RelayCommand<object> ConnectCommand
        {
            get
            {
                return _myCommand1 ?? (_myCommand1 = new RelayCommand<object>(Connect));
            }
        }
        private void Connect(object param)
        {
            //private static string DBConfig = @"Server=DESKTOP-UAEUH32\SQLEXPRESS;DataBase=TestDB;Uid=sa;Pwd=1126";
            //string dbConfig = string.Empty;
            //dbConfig += "Server=";
            //dbConfig += DBloginModel.ServerName;
            //dbConfig += ";DataBase=";
            //dbConfig += DBloginModel.DBName;
            //dbConfig += ";Uid=";
            //dbConfig += DBloginModel.UserName;
            //dbConfig += ";Pwd=";
            //dbConfig += DBloginModel.PassWord;

            string dbConfig = string.Format(@"Server={0};DataBase={1};Uid={2};Pwd={3}", DBloginModel.ServerName, DBloginModel.DBName, DBloginModel.UserName, DBloginModel.PassWord);

            DataAcess.DBConfig = dbConfig;

            if (DBloginModel.IsRememberPwd == true)
            {
                Serialize.Write(DBloginModel);
            }

            (param as Window).Close();
        }

        #endregion

    }
}
