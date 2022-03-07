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

namespace pilot.WPF.HMS.Views
{
    /// <summary>
    /// ConfirmExitView.xaml 的交互逻辑
    /// </summary>
    public partial class ConfirmExitView : Window
    {
        public ConfirmExitView()
        {
            InitializeComponent();
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

        /// <summary>
        /// 确认退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmExit(object sender, RoutedEventArgs e)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            catch
            {
            }
        }

        private void CancelExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
