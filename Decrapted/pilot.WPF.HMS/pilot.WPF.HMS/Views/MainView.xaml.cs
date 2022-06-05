using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using pilot.HMS.Common;
using pilot.HMS.ViewModels;

namespace pilot.HMS.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        MainViewModel mainViewModel = new MainViewModel();

        //简要视图
        public SimplePage simplePage = new SimplePage();
        //详览视图
        public DetainedPage detainedPage = new DetainedPage();
        //通信设置界面
        public ComSettingView communicationSettingPage = new ComSettingView();
        //用户管理界面
        public UserManagementView userManagementView = new UserManagementView();

        public MainView()
        {
            InitializeComponent();

            this.DataContext = mainViewModel;

            this.PageContent.Content = new Frame() { Content = simplePage };
        }

        /*----------------------------------页面切换------------------------------------*/
        //simple Page
        private void page1_click(object sender, RoutedEventArgs e)
        {
            if(simplePage == null)
            {
                simplePage = new SimplePage();
            }

            this.PageContent.Content = new Frame(){ Content = simplePage };
        }

        //detained Page
        private void page2_click(object sender, RoutedEventArgs e)
        {
            if (detainedPage == null)
            {
                detainedPage = new DetainedPage();
            }

            this.PageContent.Content = new Frame() { Content = detainedPage };
        }

        //communication page
        private void CommunicationSetting_Click(object sender, RoutedEventArgs e)
        {
            if (communicationSettingPage == null)
            {
                communicationSettingPage = new ComSettingView();
            }

            this.PageContent.Content = new Frame() { Content = communicationSettingPage };
        }
        
        //User management page 
        private void UserManage_Click(object sender, RoutedEventArgs e)
        {
            if(GlobalValues.UserInfo.Authority!="admin")
            {
                string msg = "当前登录用户为：" + GlobalValues.UserInfo.Authority + "，无权进入此页。请询问系统管理员";

                ErrorView errorView = new ErrorView(msg);
                errorView.ShowDialog();
                return;
            }
                

            if (userManagementView == null)
            {
                userManagementView = new UserManagementView();
            }

            this.PageContent.Content = new Frame() { Content = userManagementView };
        }

        /*----------------------------------最小、最大化、关闭------------------------------------*/
        //移动窗口
        private void WindowMove(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if(this.WindowState == System.Windows.WindowState.Maximized)
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                }

                this.DragMove();
            }
            catch { }
        }

        //右键菜单 待做
        private void WindowTool(object sender, MouseButtonEventArgs e)
        {

        }

        //最小化
        private void Min_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.WindowState.Minimized;
                
            }
            catch { }
        }

        //退出系统（关闭）
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //new ConfirmExitView().ShowDialog();
                if(new WaringView("确定退出？").ShowDialog()==true)
                {
                    Environment.Exit(Environment.ExitCode);
                }
            }
            catch { }
        }

        //-----顶栏上的
        //最小化窗口
        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.WindowState.Minimized;
            }
            catch { }
        }

        //关闭窗口
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            try
            {
                //new ConfirmExitView().ShowDialog();
                if (new WaringView("确定退出？").ShowDialog() == true)
                {
                    Environment.Exit(Environment.ExitCode);
                }

            }
            catch { }
        }

        //最大化窗口
        private void MaximizeWindow(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.WindowState==System.Windows.WindowState.Maximized)
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                }
                else if(this.WindowState == System.Windows.WindowState.Normal)
                {
                    this.WindowState = System.Windows.WindowState.Maximized;
                    return;
                }
            }
            catch { }
        }


        /*-----------------------------------------------------------------------------*/
    }
}
