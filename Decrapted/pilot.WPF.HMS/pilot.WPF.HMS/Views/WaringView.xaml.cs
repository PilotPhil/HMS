using pilot.HMS.Common;
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
using System.Windows.Shapes;

namespace pilot.HMS.Views
{
    /// <summary>
    /// WaringView.xaml 的交互逻辑
    /// </summary>
    public partial class WaringView : Window
    {
        WaringViewModel waringViewModel = new WaringViewModel();
        public WaringView(string waringMsg)
        {
            InitializeComponent();

            this.DataContext = waringViewModel;

            waringViewModel.WaringMsg= waringMsg;
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


    public class WaringViewModel:NotificationObject
    {
        //警告信息
        private string _waringMsg;
        public string WaringMsg
        {
            get { return _waringMsg; }
            set
            {
                _waringMsg = value;
                this.RaisePropertyChanged("WaringMsg");
            }
        }

    }

}
