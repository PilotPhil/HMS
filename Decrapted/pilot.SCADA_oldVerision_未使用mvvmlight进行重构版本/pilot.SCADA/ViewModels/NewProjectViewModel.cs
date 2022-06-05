
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using pilot.SCADA.Common;
using pilot.SCADA.DAL;
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
    class NewProjectViewModel : NotificationObject
    {
        //默认新建工程path
        public static string DefaultProjectPath { get; set; }

        //新建工程名
        private string _newPrjName;
        public string NewPrjName
        {
            get { return _newPrjName; }
            set
            {
                _newPrjName = value;
                this.RaisePropertyChanged("NewPrjName");
            }
        }

        //新建工程路径
        private string _newPrjPath;
        public string NewPrjPath
        {
            get { return _newPrjPath; }
            set
            {
                _newPrjPath = value;
                this.RaisePropertyChanged("NewPrjPath");
            }
        }

        //是否选中为默认项目创建地址
        private bool _isSetDefaultPrjPath;
        public bool IsSetDefaultPrjPath
        {
            get { return _isSetDefaultPrjPath; }
            set
            {
                _isSetDefaultPrjPath = value;
                this.RaisePropertyChanged("IsSetDefaultPrjPath");
            }
        }

        //基础项目管理路径
        public static string BasicPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        //序列化 默认项目创建地址
        private readonly JsonSerialize jsonSerialize = new JsonSerialize(Path.Combine(BasicPath, "Cfg", "DefaultPrjPath.json"));

        public NewProjectViewModel()
        {
            DefaultProjectPath = jsonSerialize.DeserializeRead<string>();
            DefaultProjectPath = DefaultProjectPath ?? "";
            NewPrjPath = DefaultProjectPath;

            ConfirmCommand.ExecuteAction = new Action<object>(Confirm);
            ConfirmCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            CancelCommand.ExecuteAction = new Action<object>(Cancel);
            CancelCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            ChoosePathCommand.ExecuteAction = new Action<object>(ChoosePath);
            ChoosePathCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        /// <summary>
        /// 确认创建新工程命令
        /// </summary>
        public DelegateCommand ConfirmCommand { get; set; } = new DelegateCommand();
        private void Confirm(object param)
        {
            try
            {
                if (NewPrjPath == null || NewPrjPath == "" || NewPrjName == null || NewPrjName == "")
                {
                    LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                    {
                        RecordTime = DateTime.Now.ToString(),
                        Content = "工程名和工程路径不能为空",
                        Identity = Registrant.Name ?? "未登录",
                        Type = "错误"
                    });
                    return;
                }

                Directory.CreateDirectory(NewPrjPath + "\\" + NewPrjName);

                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "已创建位于" + NewPrjName + "的工程" + NewPrjName,
                    Identity = Registrant.Name ?? "未登录",
                    Type = "成功"
                });

                if (IsSetDefaultPrjPath == true)
                {
                    jsonSerialize.SerializeWrite(DefaultProjectPath);
                }

                //创建工程，加入到工程管理
                ProjectManagerViewModel.GetInstance().OpenProjectFromRecord(new ProjectRecordModel()
                {
                    ProjectPath = NewPrjPath + "\\" + NewPrjName,
                    ProjectName = NewPrjName,
                    SaveTime = string.Format("{0:MM/dd HH:mm}", DateTime.Now)
                });

                (param as Window).Close();
            }
            catch (Exception ex)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "项目创建错误，因为:" + ex.Message,
                    Identity = Registrant.Name ?? "未登录",
                    Type = "成功"
                });
            }

        }

        /// <summary>
        /// 取消并关闭窗口 命令
        /// </summary>
        public DelegateCommand CancelCommand { get; set; } = new DelegateCommand();
        private void Cancel(object param)
        {
            (param as Window).Close();
        }

        /// <summary>
        /// 选择项目路径 命令
        /// </summary>
        public DelegateCommand ChoosePathCommand { get; set; } = new DelegateCommand();
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
                    this.NewPrjPath = path;
                }

                (param as Window).Activate();//选择完路径后将新建工程view设为激活的，放在上层
            }
        }
    }


}
