
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using HandyControl.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using pilot.ProjConfiguration.Serialization;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class NewProjectViewModel : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="serialize"></param>
        public NewProjectViewModel(ISerialize serialize)
        {
            this.serialize = serialize;
            this.serialize.SetPath(Path.Combine(BasicPath, "Cfg", "DefaultPrjPath.json"));//序列化 默认项目创建地址

            DefaultProjectPath = this.serialize.Read<string>();
            DefaultProjectPath = DefaultProjectPath ?? "";
            NewPrjPath = DefaultProjectPath;
        }


        #region 属性
        private readonly ISerialize serialize;//序列化
        public static string BasicPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;//基础项目管理路径
        public static string DefaultProjectPath { get; set; }//默认新建工程path

        private string newPrjName;
        /// <summary>
        /// 新建工程名
        /// </summary>
        public string NewPrjName
        {
            get { return newPrjName; }
            set
            {
                if (newPrjName == value) { return; }
                newPrjName = value;
                RaisePropertyChanged(() => NewPrjName);
            }
        }

        private string newPrjPath;
        /// <summary>
        /// 新建工程路径
        /// </summary>
        public string NewPrjPath
        {
            get { return newPrjPath; }
            set
            {
                if (newPrjPath == value) { return; }
                newPrjPath = value;
                RaisePropertyChanged(() => NewPrjPath);
            }
        }

        private bool isSetDefaultPrjPath;
        /// <summary>
        /// 是否选中为默认项目创建地址
        /// </summary>
        public bool IsSetDefaultPrjPath
        {
            get { return isSetDefaultPrjPath; }
            set
            {
                if (isSetDefaultPrjPath == value) { return; }
                isSetDefaultPrjPath = value;
                RaisePropertyChanged(() => IsSetDefaultPrjPath);
            }
        }

        /// <summary>
        /// 项目文件初始化字符串
        /// </summary>
        private readonly string ProjInitStr =
@"
[ProjectParams]
ModbusParams=""""
SensorList=""""

";

        #endregion


        #region 命令
        private RelayCommand<object> _myCommand1;
        /// <summary>
        /// 确认创建新工程 的命令
        /// </summary>
        public RelayCommand<object> ConfirmCommand
        {
            get
            {
                return _myCommand1 ?? (_myCommand1 = new RelayCommand<object>(Confirm));
            }
        }
        private void Confirm(object param)
        {
            try
            {
                if (NewPrjPath == null || NewPrjPath == "" || NewPrjName == null || NewPrjName == "")
                {
                    Growl.WarningGlobal("工程名和工程路径不能为空");
                    throw new Exception("工程名和工程路径不能为空");
                }

                //创建工程文件，并写入初始字符串
                using (FileStream fs = File.Create(NewPrjPath)) { };
                File.WriteAllText(NewPrjPath, ProjInitStr);

                if (IsSetDefaultPrjPath == true)
                {
                    serialize.Write(DefaultProjectPath);
                }

                var newPrjModel = new ProjectRecordModel()
                {
                    ProjectName = NewPrjName,
                    ProjectPath = NewPrjPath,
                    SaveTime = string.Format("{0:MM/dd HH:mm}", DateTime.Now)
                };


                Messenger.Default.Send<ProjectRecordModel>(newPrjModel, "CreateProjectToken");
                Growl.SuccessGlobal("已创建位于" + NewPrjName + "的工程" + NewPrjName);
            }
            catch (Exception)
            {

            }
            finally
            {
                (param as System.Windows.Window).Close();
            }
        }

        private RelayCommand<object> _myCommand2;
        /// <summary>
        /// 取消并关闭窗口 的命令
        /// </summary>
        public RelayCommand<object> CancelCommand
        {
            get
            {
                return _myCommand2 ?? (_myCommand2 = new RelayCommand<object>(Cancel));
            }
        }
        private void Cancel(object param)
        {
            (param as System.Windows.Window).Close();
        }

        private RelayCommand<object> _myCommand3;
        /// <summary>
        /// 选择项目路径 的命令
        /// </summary>
        public RelayCommand<object> ChoosePathCommand
        {
            get
            {
                return _myCommand3 ?? (_myCommand3 = new RelayCommand<object>(ChoosePath));
            }
        }
        private void ChoosePath(object param)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;//设置为选择文件夹
                dialog.Title = "选择工程文件所在文件夹";
                dialog.InitialDirectory = DefaultProjectPath;//初始path

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var path = dialog.FileName;
                    DefaultProjectPath = path;
                    this.NewPrjPath = Path.Combine(path, NewPrjName + ".hmsproj");
                }
                (param as System.Windows.Window).Activate();//选择完路径后将新建工程view设为激活的，放在上层
            }
        }

        #endregion


    }


}
