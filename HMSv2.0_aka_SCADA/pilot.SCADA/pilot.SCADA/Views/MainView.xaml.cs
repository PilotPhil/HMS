using CommonServiceLocator;
using GalaSoft.MvvmLight.Messaging;
using HandyControl.Controls;
using HandyControl.Data;
using pilot.ProjConfiguration.Log;
using pilot.SCADA.Converter;
using pilot.SCADA.Global;
using pilot.SCADA.ViewModels;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

            Messenger.Default.Register<object>(this, "ProjectedOpened", (o) =>
            {
                this.Row_ProjectWelcome.Height = new GridLength(0, GridUnitType.Pixel);
                this.Row_control.Height = new GridLength(1, GridUnitType.Star);
            });
        }
    }
}
