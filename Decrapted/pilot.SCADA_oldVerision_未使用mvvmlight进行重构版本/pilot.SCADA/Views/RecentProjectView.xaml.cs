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
    /// RecentProjectView.xaml 的交互逻辑
    /// </summary>
    public partial class RecentProjectView : UserControl
    {
        public RecentProjectView()
        {
            InitializeComponent();

            this.DataContext = ProjectManagerViewModel.GetInstance();

            UpdatePrjItems();
        }

        /// <summary>
        /// 更新工程历史记录，仅在软件启动时出现，调用一次
        /// </summary>
        private void UpdatePrjItems()
        {
            var PrjMngListModel = ProjectManagerViewModel.GetInstance().ProjectRecordList;

            for (int i = 0; i < PrjMngListModel.Count; i++)
            {
                var prjItem = new PrjItem();
                var prjItemViewModel = new PrjItemViewModel(PrjMngListModel[i]);

                prjItem.DataContext = prjItemViewModel;

                this.stackPanel.Children.Add(prjItem);
            }
        }
    }
}
