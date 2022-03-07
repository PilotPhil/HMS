using pilot.SCADA.Common;
using pilot.SCADA.Global;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    class MainViewModel : NotificationObject
    {
        public MainViewModel()
        {
            //初始页面为 最近工程记录
            var startView = new RecentProjectView();
            MainDispContent = startView;

            ExitCommand.ExecuteAction = new Action<object>(Exit);
            ExitCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            OpenNewSensorCommand.ExecuteAction = new Action<object>(OpenNewSensor);
            OpenNewSensorCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            OpenViewCommand.ExecuteAction = new Action<object>(OpenView);
            OpenViewCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            SwitchContentCommand.ExecuteAction = new Action<object>(SwitchContent);
            SwitchContentCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            StartReadCommand.ExecuteAction = new Action<object>(StartRead);
            StartReadCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            StopReadCommand.ExecuteAction = new Action<object>(StopRead);
            StopReadCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            MainNewProjectCommand.ExecuteAction = new Action<object>(MainNewProject);
            MainNewProjectCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            SaveProjectCommand.ExecuteAction = new Action<object>(SaveProject);
            SaveProjectCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            RestartCommand.ExecuteAction = new Action<object>(Restart);
            RestartCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            //一旦工程管理 里面的 选中的工程 改变了，就切换到 TiledView，跳转页面
            ProjectManagerViewModel.GetInstance().HadSelectedProjectEvent += new ProjectManagerViewModel.HadSelectedProjectHandler(() => 
            { 
                this.SwitchContent("TiledView"); 
            });
        }

        private FrameworkElement _mainDispContent;
        public FrameworkElement MainDispContent
        {
            get { return _mainDispContent; }
            set
            {
                _mainDispContent = value;
                this.RaisePropertyChanged("MainDispContent");
            }
        }

        //退出系统命令
        public DelegateCommand ExitCommand { get; set; } = new DelegateCommand();
        private void Exit(object param)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //打开新建传感器view
        public DelegateCommand OpenNewSensorCommand { get; set; } = new DelegateCommand();
        private void OpenNewSensor(object param)
        {
            try
            {
                //还未选择工程文件时
                if (ProjectManagerViewModel.IsSelectedProject == false)
                {
                    LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                    {
                        RecordTime = DateTime.Now.ToString(),
                        Content = "请新建或者打开工程",
                        Identity = Registrant.Name ?? "未登录",
                        Type = "错误"
                    });
                    return;
                }

                var model = new Models.SensorModel();
                new CreateSensorView(ref model, null).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //打开 串口 socket modbus设置页面 命令
        public DelegateCommand OpenViewCommand { get; set; } = new DelegateCommand();
        private void OpenView(object param)
        {
            try
            {
                //还未选择工程文件时
                if (ProjectManagerViewModel.IsSelectedProject == false)
                {
                    LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                    {
                        RecordTime=DateTime.Now.ToString(),
                        Content= "请新建或者打开工程",
                        Identity=Registrant.Name??"未登录",
                        Type="错误"
                    });
                    return;
                }

                var typeStr = "pilot.SCADA.Views." + param.ToString();
                Type type = Type.GetType(typeStr);

                if (type == null)//找不到此类型结束
                    return;

                object obj = type.Assembly.CreateInstance(typeStr);

                var view = obj as Window;
                view.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DelegateCommand SwitchContentCommand { get; set; } = new DelegateCommand();
        private void SwitchContent(object param)
        {
            //还未选择工程文件时
            if (ProjectManagerViewModel.IsSelectedProject == false)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "请新建或者打开工程",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });
                return;
            }

            var typeStr = "pilot.SCADA.Views." + param.ToString();
            Type type = Type.GetType(typeStr);

            if (type == null)
                return;

            ConstructorInfo cti = type.GetConstructor(Type.EmptyTypes);
            MainDispContent = (FrameworkElement)cti.Invoke(null);
        }


        /// <summary>
        /// 开始读取命令
        /// </summary>
        public DelegateCommand StartReadCommand { get; set; } = new DelegateCommand();
        private void StartRead(object param)
        {
            //还未选择工程文件时
            if (ProjectManagerViewModel.IsSelectedProject == false)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "请新建或者打开工程",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });
                return;
            }

            LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
            {
                RecordTime = DateTime.Now.ToString(),
                Content = "已开始监测",
                Identity = Registrant.Name ?? "未登录",
                Type = "成功"
            });

            ModbusViewModel.GetInstance().StartRead();
            SysStatue.IsMointoring = true;
        }

        /// <summary>
        /// 停止读取命令
        /// </summary>
        public DelegateCommand StopReadCommand { get; set; } = new DelegateCommand();
        private void StopRead(object param)
        {
            //还未选择工程文件时
            if (ProjectManagerViewModel.IsSelectedProject == false)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "请新建或者打开工程",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });
                return;
            }

            ModbusViewModel.GetInstance().StopRead();

            LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
            {
                RecordTime = DateTime.Now.ToString(),
                Content = "已停止监测",
                Identity = Registrant.Name ?? "未登录",
                Type = "成功"
            });
            SysStatue.IsMointoring = false;
        }

        /// <summary>
        /// 新建工程命令
        /// </summary>
        public DelegateCommand MainNewProjectCommand { get; set; } = new DelegateCommand();
        private void MainNewProject(object param)
        {
            if(ProjectManagerViewModel.IsSelectedProject==true)//已经设置好当前系统实例的工程
            {
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);//重开一个实例
                return;
            }

            new NewProjectView().ShowDialog();
        }

        /// <summary>
        /// 保存工程文件命令
        /// </summary>
        public DelegateCommand SaveProjectCommand { get; set; } = new DelegateCommand();
        private void SaveProject(object param)
        {
            LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
            {
                RecordTime = DateTime.Now.ToString(),
                Content = "保存成功",
                Identity = Registrant.Name ?? "未登录",
                Type = "成功"
            });
        }

        /// <summary>
        /// 重启命令
        /// </summary>
        public DelegateCommand RestartCommand { get; set; } = new DelegateCommand();
        private void Restart(object param)
        {
            Application.Current.Shutdown();//关闭程序

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);//重启软件
        }

    }
}
