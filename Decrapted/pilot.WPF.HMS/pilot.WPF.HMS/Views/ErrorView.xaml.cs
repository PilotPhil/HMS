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
    public partial class ErrorView : Window
    {
        ErrorViewModel errorViewModel = new ErrorViewModel();

        public ErrorView(string errorMsg2disp)
        {
            InitializeComponent();

            this.DataContext = errorViewModel;

            errorViewModel.ErrorMsg = errorMsg2disp;
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }


    public class ErrorViewModel:NotificationObject
    {

        private string _errorMsg;

        public string ErrorMsg
        {
            get { return _errorMsg; }
            set
            {
                _errorMsg = value;
                this.RaisePropertyChanged("ErrorMsg");
            }
        }

        public ErrorViewModel()
        {
            ErrorMsg = "NO";
        }

    }
}
