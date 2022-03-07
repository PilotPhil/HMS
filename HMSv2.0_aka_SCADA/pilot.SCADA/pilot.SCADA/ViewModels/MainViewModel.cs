using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using HandyControl.Controls;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using pilot.ProjConfiguration.Log;
using pilot.ProjConfiguration.Serialization;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using pilot.SCADA.Views;
using ProjConfig;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// 主界面CTOR
        /// </summary>
        /// <param name="initContent">主界面初始显示页面</param>
        /// <param name="projectManagerViewModel">依赖项目管理对象</param>
        /// <param name="modbusViewModel">依赖modbus对象，通过其控制开始、停止读数据</param>
        public MainViewModel(ISerialize serialize, ILog log, IProjConfig projConfig)
        {
            this.log = log;

            this.serialize = serialize;
            this.serialize.SetPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cfg", "ProjectRecordList.json"));

            ProjectRecordList = new List<ProjectRecordModel>();
            ProjectRecordList = serialize.Read<List<ProjectRecordModel>>() ?? new List<ProjectRecordModel>();

            ProjectRecordList = ProjectRecordList.OrderByDescending(i => i.SaveTime).ToList();

            this.projConfig = projConfig;

            Messenger.Default.Register<ProjectRecordModel>(this, "CreateProjectToken", this.OpenProjectFromModel);
        }


        #region 属性
        //序列化
        private readonly ISerialize serialize;
        private readonly IProjConfig projConfig;

        //日志
        private readonly ILog log;

        private List<ProjectRecordModel> _projectRecordList;
        /// <summary>
        /// 工程记录list
        /// </summary>
        public List<ProjectRecordModel> ProjectRecordList
        {
            get { return _projectRecordList; }
            set
            {
                if (_projectRecordList == value) { return; }
                _projectRecordList = value;
                RaisePropertyChanged(() => ProjectRecordList);
            }
        }

        private FrameworkElement _mainDispContent;
        /// <summary>
        /// 主显示区域内容
        /// </summary>
        public FrameworkElement MainDispContent
        {
            get { return _mainDispContent; }
            set
            {
                if (_mainDispContent == value) { return; }
                _mainDispContent = value;
                RaisePropertyChanged(() => MainDispContent);
            }
        }

        #endregion


        #region 命令
        /*--------------------页面切换 类命令--------------------*/
        private RelayCommand<object> _myCommand3;
        /// <summary>
        /// 打开 串口 socket modbus设置页面 命令 的命令
        /// </summary>
        public RelayCommand<object> OpenViewCommand
        {
            get
            {
                return _myCommand3 ?? (_myCommand3 = new RelayCommand<object>(OpenView));
            }
        }
        private void OpenView(object param)
        {
            try
            {
                //还未选择工程文件时
                if (string.IsNullOrEmpty(GlobalValues.CurrentProjectPath))
                {
                    Growl.WarningGlobal("未新建或选择工程");
                    throw new Exception("未新建或选择工程");
                }

                if((param as string)== "CreateSensorView")//创建传感器不走viewmodellocator，要区别创建和编辑，无法使用自动依赖注入，需要手动判断注入
                {
                    var createSensorViewModel = new CreateSensorViewModel(null);
                    var createSensorView = new CreateSensorView();
                    createSensorView.DataContext = createSensorViewModel;
                    createSensorView.ShowDialog();
                    return;
                }

                var typeStr = "pilot.SCADA.Views." + param.ToString();
                Type type = Type.GetType(typeStr);

                if (type == null)//找不到此类型结束
                {
                    Growl.ErrorGlobal("找不到此类型");
                    throw new Exception("找不到此类型");
                }

                

                object obj = type.Assembly.CreateInstance(typeStr);

                var view = obj as System.Windows.Window;
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _myCommand4;
        /// <summary>
        /// 切换页面 的命令
        /// </summary>
        public RelayCommand<object> SwitchContentCommand
        {
            get
            {
                return _myCommand4 ?? (_myCommand4 = new RelayCommand<object>(SwitchContent));
            }
        }
        private void SwitchContent(object param)
        {
            try
            {
                //还未选择工程文件时
                if (string.IsNullOrEmpty(GlobalValues.CurrentProjectPath))
                {
                    Growl.WarningGlobal("未新建或选择工程");
                    throw new Exception("未新建或选择工程");
                }

                var typeStr = "pilot.SCADA.Views." + param.ToString();
                Type type = Type.GetType(typeStr);

                if (type == null)
                    return;

                ConstructorInfo cti = type.GetConstructor(Type.EmptyTypes);
                MainDispContent = (FrameworkElement)cti.Invoke(null);
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }


        /*--------------------操作 类命令--------------------*/
        private RelayCommand<object> _myCommand5;
        /// <summary>
        /// 开始读取 的命令
        /// </summary>
        public RelayCommand<object> StartReadCommand
        {
            get
            {
                return _myCommand5 ?? (_myCommand5 = new RelayCommand<object>(StartRead));
            }
        }
        private void StartRead(object param)
        {
            try
            {
                //还未选择工程文件时
                if (string.IsNullOrEmpty(GlobalValues.CurrentProjectPath))
                {
                    Growl.WarningGlobal("未新建或选择工程");
                    throw new Exception("未新建或选择工程");
                }

                //发送messenger通知modbusviewmodel开始读取
                Messenger.Default.Send<object>(null, "StartModbusReadToken");
                Growl.InfoGlobal("开始读取");
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _myCommand6;
        /// <summary>
        /// 停止读取 的命令
        /// </summary>
        public RelayCommand<object> StopReadCommand
        {
            get
            {
                return _myCommand6 ?? (_myCommand6 = new RelayCommand<object>(StopRead));
            }
        }
        private void StopRead(object param)
        {
            try
            {
                //还未选择工程文件时
                if (string.IsNullOrEmpty(GlobalValues.CurrentProjectPath))
                {
                    Growl.WarningGlobal("未新建或选择工程");
                    throw new Exception("未新建或选择工程");
                }

                //发送messenger通知modbusviewmodel停止读取
                Messenger.Default.Send<object>(null, "StopModbusReadToken");
                Growl.InfoGlobal("停止读取");
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _exitCommand;
        /// <summary>
        /// 退出系统 的命令
        /// </summary>
        public RelayCommand<object> Exitcommand
        {
            get
            {
                return _exitCommand ?? (_exitCommand = new RelayCommand<object>(Exit));
            }
        }
        private void Exit(object param)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _restartCommand;
        /// <summary>
        /// 重启 的命令
        /// </summary>
        public RelayCommand<object> RestartCommand
        {
            get
            {
                return _restartCommand ?? (_restartCommand = new RelayCommand<object>(Restart));
            }
        }
        private void Restart(object param)
        {
            try
            {
                Application.Current.Shutdown();//关闭程序
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);//重启软件
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }


        /*--------------------工程 类命令--------------------*/
        private RelayCommand<object> _newProjectCommand;
        /// <summary>
        /// 新建工程 的命令
        /// </summary>
        public RelayCommand<object> NewProjectCommand
        {
            get
            {
                return _newProjectCommand ?? (_newProjectCommand = new RelayCommand<object>(NewProject));
            }
        }
        private void NewProject(object param)
        {
            try
            {
                if (!string.IsNullOrEmpty(GlobalValues.CurrentProjectPath))//已经设置好当前系统实例的工程
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);//重开一个实例
                    return;
                }

                new NewProjectView().ShowDialog();
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _openProjectFromFile;
        /// <summary>
        /// 打开工程 的命令
        /// </summary>
        public RelayCommand<object> OpenProjectFormFileCommand
        {
            get
            {
                return _openProjectFromFile ?? (_openProjectFromFile = new RelayCommand<object>(OpenProjectFormFile));
            }
        }
        private void OpenProjectFormFile(object param)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = false;//设置为选择文件夹
                dialog.Title = "选择工程文件所在文件夹";

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var filePath = dialog.FileName;
                    var name = filePath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).Last<string>();//截取到项目名---文件夹名

                    OpenProjectFromModel(new ProjectRecordModel()
                    {
                        ProjectPath = filePath,
                        ProjectName = name,
                        SaveTime = string.Format("{0:MM/dd HH:mm}", DateTime.Now)
                    });
                }
            }
        }

        private RelayCommand<object> _openProjectFromRecord;
        /// <summary>
        /// 从记录中打开工程 的命令
        /// </summary>
        public RelayCommand<object> OpenProjectFromRecordCommand
        {
            get
            {
                return _openProjectFromRecord ?? (_openProjectFromRecord = new RelayCommand<object>(OpenProjectFromRecord));
            }
        }
        private void OpenProjectFromRecord(object param)
        {
            var filePath = param as string;
            var name = filePath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).Last<string>();//截取到项目名---文件夹名

            OpenProjectFromModel(new ProjectRecordModel()
            {
                ProjectPath = filePath,
                ProjectName = name,
                SaveTime = string.Format("{0:MM/dd HH:mm}", DateTime.Now)
            });

            Messenger.Default.Send<object>(null, "ProjectedOpened");
        }

        private RelayCommand<object> _saveProjectCommand;
        /// <summary>
        /// 保存工程 的命令
        /// </summary>
        public RelayCommand<object> SaveProjectCommand
        {
            get
            {
                return _saveProjectCommand ?? (_saveProjectCommand = new RelayCommand<object>(SaveProject));
            }
        }
        private void SaveProject(object param)
        {
            Messenger.Default.Send<string>("SavePrj", "SavePrj");
        }

        /*--------------------其他 命令--------------------*/
        private RelayCommand<object> openHelpPdfCommand;
        /// <summary>
        /// 打开帮助pdf 的命令
        /// </summary>
        public RelayCommand<object> OpenHelpPdfCommand
        {
            get
            {
                return openHelpPdfCommand ?? (openHelpPdfCommand = new RelayCommand<object>(OpenHelpPdf));
            }
        }
        private void OpenHelpPdf(object param)
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Help");

                Process.Start(path);
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> openWebSetCommand;
        /// <summary>
        /// 打开网站 的命令
        /// </summary>
        public RelayCommand<object> OpenWebSetCommand
        {
            get
            {
                return openWebSetCommand ?? (openWebSetCommand = new RelayCommand<object>(OpenWebSet));
            }
        }
        private void OpenWebSet(object param)
        {
            try
            {
                Process.Start("https://gitee.com/pilot12138/pilot.-scada");
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }

        }

        private RelayCommand<object> contactWithQQCommand;
        /// <summary>
        /// 使用QQ联系 的命令
        /// </summary>
        public RelayCommand<object> ContactWithQQCommand
        {
            get
            {
                return contactWithQQCommand ?? (contactWithQQCommand = new RelayCommand<object>(ContactWithQQ));
            }
        }
        private void ContactWithQQ(object param)
        {
            StartQQ("632913013");
        }
        #endregion


        #region 业务方法
        /// <summary>
        /// 从模型打开工程
        /// </summary>
        /// <param name="model"></param>
        private void OpenProjectFromModel(ProjectRecordModel model)
        {
            try
            {
                GlobalValues.CurrentProjectPath = model.ProjectPath;
                var obj = ProjectRecordList.SingleOrDefault(i => i.ProjectPath == model.ProjectPath);

                if (obj == null)//无重复
                {
                    ProjectRecordList.Add(model);
                }
                else
                {
                    var index = ProjectRecordList.IndexOf(obj);
                    ProjectRecordList[index] = model;
                }

                if (ProjectRecordList.Count > 10)//限制显示10条记录
                {
                    ProjectRecordList.RemoveAt(ProjectRecordList.Count);
                }

                projConfig.SetProjFilePath(model.ProjectPath);
                serialize.Write(ProjectRecordList);
                Messenger.Default.Send<object>(null, "ProjectedOpened");
                Growl.SuccessGlobal("已打开工程");
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        public void StartQQ(string QQ)
        {
            try
            {
                var openkey64 = @"SOFTWARE\Wow6432Node\Tencent\QQ2009";
                var openkey32 = @"SOFTWARE\Tencent\QQ2009";
                var openkeyTim64 = @"SOFTWARE\Wow6432Node\Tencent\TIM";

                var qqPath = "";
                RegistryKey reg64 = Registry.LocalMachine.OpenSubKey(openkey64);
                RegistryKey reg32 = Registry.LocalMachine.OpenSubKey(openkey32);
                RegistryKey regTim32 = Registry.LocalMachine.OpenSubKey(openkeyTim64);

                if (reg64 != null)
                {
                    qqPath = reg64.GetValue("Install").ToString();
                }
                else if (reg32 != null)
                {
                    qqPath = reg32.GetValue("Install").ToString();
                }
                else if (regTim32 != null)
                {
                    qqPath = regTim32.GetValue("Install").ToString();
                }


                if (!string.IsNullOrWhiteSpace(qqPath))
                {
                    var dizhi1 = qqPath + @"\Bin\Timwp.exe";
                    var arg = "tencent://message/?uin=" + QQ;
                    Process.Start(dizhi1, arg);
                    //ThisHidden();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("未检测到安装QQ");
                }
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        #endregion


    }
}
