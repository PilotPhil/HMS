using pilot.SCADA.Common;
using pilot.SCADA.DAL;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    class CreateSensorModelView : NotificationObject
    {
        //传感器基本信息 model
        private SensorModel _sensorModel;
        public SensorModel SensorModel
        {
            get { return _sensorModel; }
            set
            {
                _sensorModel = value;
                this.RaisePropertyChanged("SensorModel");
            }
        }

        //已加载的任务列表
        private ObservableCollection<TaskModuleModel> LoadedTaskList { get; set; }

        //窗口标题（新建 编辑 复用）
        private string _windowTitle;
        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                this.RaisePropertyChanged("WindowTitle");
            }
        }

        //按钮上显示的内容
        private string _buttonText;
        public string ButtonText
        {
            get { return _buttonText; }
            set
            {
                _buttonText = value;
                this.RaisePropertyChanged("ButtonText");
            }
        }

        //判断是否处于编辑模式
        private readonly bool isEdit = false;

        /// <summary>
        /// ctor
        /// </summary>
        public CreateSensorModelView(ref SensorModel editSensorModel, string title = null)
        {
            isEdit = title != null;

            WindowTitle = title ?? "新建传感器";

            ButtonText = title != null ? "保存" : "创建";

            SensorModel = editSensorModel;

            LoadedTaskList = TaskFlowManageViewModel.GetInstance().TaskList;

            NewSensorCommand.ExecuteAction = new Action<object>(NewSensor);
            NewSensorCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            AddOneTaskCommand.ExecuteAction = new Action<object>(AddOneTask);
            AddOneTaskCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            RemoveOneTaskCommand.ExecuteAction = new Action<object>(RemoveOneTask);
            RemoveOneTaskCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        //创建传感器命令
        public DelegateCommand NewSensorCommand { get; set; } = new DelegateCommand();
        private void NewSensor(object param)
        {
            if (isEdit == true)
            {
                (param as Window).Close();
                return;
            }

            if (SensorManagerViewModel.GetInstance().AddOneSensor(SensorModel) == true)
            {
                (param as Window).Close();
            }
        }

        /// <summary>
        /// 添加一个任务
        /// </summary>
        public DelegateCommand AddOneTaskCommand { get; set; } = new DelegateCommand();
        private void AddOneTask(object param)
        {
            int index = (int)param;

            var tasks = TaskFlowManageViewModel.GetInstance().TaskList;

            if (index < 0 || index > tasks.Count - 1)
            {
                return;
            }
            else
            {
                var toAddTask = tasks.ElementAt(index);

                //是否重复
                if (this.SensorModel.TaskList.Any(inp => inp.Path == toAddTask.Path) == true)
                {
                    return;
                }

                this.SensorModel.TaskList.Add(toAddTask);
            }
        }

        /// <summary>
        /// 移除一个任务
        /// </summary>
        public DelegateCommand RemoveOneTaskCommand { get; set; } = new DelegateCommand();
        private void RemoveOneTask(object param)
        {
            int index = (int)param;

            if (index < 0 || index > this.SensorModel.TaskList.Count - 1)
            {
                return;
            }
            else
            {
                this.SensorModel.TaskList.RemoveAt(index);
            }
        }
    }
}
