using pilot.SCADA.Common;
using pilot.SCADA.Models;
using pilot.SCADA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pilot.SCADA.Views
{
    /// <summary>
    /// PrjItem.xaml 的交互逻辑
    /// </summary>
    public partial class PrjItem : UserControl
    {
        public PrjItem()
        {
            InitializeComponent();
        }
    }

    class PrjItemViewModel:NotificationObject
    {
        private ProjectRecordModel _prjModel;
        public ProjectRecordModel PrjModel
        {
            get { return _prjModel; }
            set
            {
                _prjModel = value;
                this.RaisePropertyChanged("PrjModel");
            }
        }

        public PrjItemViewModel(ProjectRecordModel prjModel)
        {
            PrjModel = new ProjectRecordModel
            {
                ProjectName = prjModel.ProjectName,
                ProjectPath = prjModel.ProjectPath,
                SaveTime = prjModel.SaveTime
            };

            OpenPrjCommand.ExecuteAction = new Action<object>(OpenPrj);
            OpenPrjCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        public DelegateCommand OpenPrjCommand { get; set; } = new DelegateCommand();
        public void OpenPrj(object param)
        {
            ProjectManagerViewModel.GetInstance().OpenProjectFromRecord(PrjModel);
        }
    }
}
