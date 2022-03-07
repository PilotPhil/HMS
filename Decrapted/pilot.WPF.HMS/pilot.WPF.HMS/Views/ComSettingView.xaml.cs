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

using pilot.HMS.ViewModels;

namespace pilot.HMS.Views
{
    /// <summary>
    /// CommunicationSettingPage.xaml 的交互逻辑
    /// </summary>
    public partial class ComSettingView : Page
    {
        ComSettingViewModel comSettingViewModel = new ComSettingViewModel();

        public ComSettingView()
        {
            InitializeComponent();

            this.DataContext = comSettingViewModel;

            comSettingViewModel.UseSerial = true;

            comSettingViewModel.UseUdp = false;

        }


        //勾选使用serial
        private void UseSerial_Checked(object sender, RoutedEventArgs e)
        {
            comSettingViewModel.UseUdp = false;
        }

        //勾选使用UDP
        private void UseUdp_Checked(object sender, RoutedEventArgs e)
        {
            comSettingViewModel.UseSerial = false;
        }

        private void textBoxChanged(object sender, TextChangedEventArgs e)
        {
            this.receiveDispWord.ScrollToEnd();
        }
    }
}
