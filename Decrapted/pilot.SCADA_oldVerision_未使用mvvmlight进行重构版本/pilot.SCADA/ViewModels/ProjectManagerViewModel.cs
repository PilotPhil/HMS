using Microsoft.WindowsAPICodePack.Dialogs;
using pilot.SCADA.Common;
using pilot.SCADA.DAL;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace pilot.SCADA.ViewModels
{
    class ProjectManagerViewModel : NotificationObject
    {
        private static ProjectManagerViewModel _instance;

        /// <summary>
        /// ctor
        /// </summary>
        private ProjectManagerViewModel()
        {
            ProjectRecordList = new List<ProjectRecordModel>();

            ProjectRecordList = jsonSerialize.DeserializeRead<List<ProjectRecordModel>>() ?? new List<ProjectRecordModel>();

            OpenProjectCommand.ExecuteAction = new Action<object>(OpenProject);
            OpenProjectCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            NewProjectCommand.ExecuteAction = new Action<object>(NewProject);
            NewProjectCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static ProjectManagerViewModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProjectManagerViewModel();
            }
            return _instance;
        }

        //基础项目管理路径
        public static string BasicPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        //序列化
        private readonly JsonSerialize jsonSerialize = new JsonSerialize(Path.Combine(BasicPath, "Cfg", "ProjectRecordList.json"));


        private List<ProjectRecordModel> _projectRecordList;
        public List<ProjectRecordModel> ProjectRecordList
        {
            get { return _projectRecordList; }
            set
            {
                _projectRecordList = value;
                this.RaisePropertyChanged("ProjectRecordList");
            }
        }

        //已经选中了项目 事件
        public delegate void HadSelectedProjectHandler();
        public event HadSelectedProjectHandler HadSelectedProjectEvent;

        //是否选中过了项目
        public static bool IsSelectedProject = false;

        /// <summary>
        /// 添加一个项目记录
        /// </summary>
        /// <param name="model"></param>
        private void AddOnePrj(ProjectRecordModel model)
        {
            //如果发现有重复的，修改其保存时间
            for (int i = 0; i < ProjectRecordList.Count; i++)
            {
                if (ProjectRecordList[i].ProjectPath == model.ProjectPath)
                {
                    ProjectRecordList[i].SaveTime = model.SaveTime;
                    return;
                }
            }

            ProjectRecordList.Insert(0, model);

            if (ProjectRecordList.Count > 10)//限制显示10条记录
            {
                ProjectRecordList.RemoveAt(ProjectRecordList.Count);
            }
        }

        /// <summary>
        /// 打开工程命令
        /// </summary>
        public DelegateCommand OpenProjectCommand { get; set; } = new DelegateCommand();
        private void OpenProject(object param)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;//设置为选择文件夹
                dialog.Title = "选择工程文件所在文件夹";

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var filePath = dialog.FileName;
                    var name = filePath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).Last<string>();//截取到项目名---文件夹名

                    //
                    OpenProjectFromRecord(new ProjectRecordModel()
                    {
                        ProjectPath = filePath,
                        ProjectName = name,
                        SaveTime = string.Format("{0:MM/dd HH:mm}", DateTime.Now)
                    });
                }
            }

        }

        /// <summary>
        /// 打开工程
        /// </summary>
        /// <param name="model"></param>
        public void OpenProjectFromRecord(ProjectRecordModel model)
        {
            //硬拷贝
            BasePath.SelectedProject.ProjectName = model.ProjectName;
            BasePath.SelectedProject.ProjectPath = model.ProjectPath;
            BasePath.SelectedProject.SaveTime = model.SaveTime;

            //
            AddOnePrj(BasePath.SelectedProject);

            IsSelectedProject = true;
            HadSelectedProjectEvent?.Invoke();

            jsonSerialize.SerializeWrite(ProjectRecordList);

            LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
            {
                RecordTime = DateTime.Now.ToString(),
                Content = "已打开位于" + BasicPath + "的工程",
                Identity = Registrant.Name ?? "未登录",
                Type = "成功"
            });
        }

        /// <summary>
        /// 新建工程命令
        /// </summary>
        public DelegateCommand NewProjectCommand { get; set; } = new DelegateCommand();
        private void NewProject(object param)
        {
            if (ProjectManagerViewModel.IsSelectedProject == true)//已经设置好当前系统实例的工程
            {
                System.Diagnostics.Process.Start(System.Windows.Application.ResourceAssembly.Location);//重开一个实例
                return;
            }

            new NewProjectView().ShowDialog();
        }

        /// <summary>
        /// 新建工程
        /// </summary>
        public void NewProject()
        {

        }
    }
}
