using CommonServiceLocator;
using HandyControl.Controls;
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
    /// TaskView.xaml 的交互逻辑
    /// </summary>
    public partial class TaskView : UserControl
    {
        public TaskView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示和设置之间的切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch(object sender, RoutedEventArgs e)
        {
            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_statics_disp.Height == full)
            {
                this.row_statics_disp.Height = zero;
                this.row_statics_setting.Height = full;
            }
            else
            {
                this.row_statics_disp.Height = full;
                this.row_statics_setting.Height = zero;
            }
        }

        private void Switch_fatigue(object sender, RoutedEventArgs e)
        {
            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_fatigue_disp.Height == full)
            {
                this.row_fatigue_disp.Height = zero;
                this.row_fatigue_setting.Height = full;
            }
            else
            {
                this.row_fatigue_disp.Height = full;
                this.row_fatigue_setting.Height = zero;
            }
        }

        /// <summary>
        /// 选择的传感器 索引 改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch_selected_sensor(object sender, HandyControl.Data.FunctionEventArgs<int> e)
        {
            var index = (sender as Pagination)?.PageIndex;

            ServiceLocator.Current.GetInstance<TaskViewModel>().SensorIndex = (int)index;
        }

        private void Switch_fft(object sender, RoutedEventArgs e)
        {
            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_fatigue_disp.Height == full)
            {
                this.row_fft_disp.Height = zero;
                this.row_fft_setting.Height = full;
            }
            else
            {
                this.row_fft_disp.Height = full;
                this.row_fft_setting.Height = zero;
            }
        }

        private void Switch_alarm(object sender, RoutedEventArgs e)
        {
            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_alarm_disp.Height == full)
            {
                this.row_alarm_disp.Height = zero;
                this.row_alarm_setting.Height = full;
            }
            else
            {
                this.row_alarm_disp.Height = full;
                this.row_alarm_setting.Height = zero;
            }
        }

        private void Switch_rtSave(object sender, RoutedEventArgs e)
        {
            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_rtSave_disp.Height == full)
            {
                this.row_rtSave_disp.Height = zero;
                this.row_rtSave_setting.Height = full;
            }
            else
            {
                this.row_rtSave_disp.Height = full;
                this.row_rtSave_setting.Height = zero;
            }
        }

        private void Switch_rtCurve(object sender, RoutedEventArgs e)
        {

            var full = new GridLength(1, GridUnitType.Star);
            var zero = new GridLength(0, GridUnitType.Pixel);

            if (this.row_rtCurve_disp.Height == full)
            {
                this.row_rtCurve_disp.Height = zero;
                this.row_rtCurve_setting.Height = full;
            }
            else
            {
                this.row_rtCurve_disp.Height = full;
                this.row_rtCurve_setting.Height = zero;
            }
        }
    }
}
