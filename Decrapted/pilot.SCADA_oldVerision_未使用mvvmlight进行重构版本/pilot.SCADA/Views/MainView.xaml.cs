using pilot.SCADA.Converter;
using pilot.SCADA.Global;
using pilot.SCADA.ViewModels;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();

            AllSetBindingsFromOtherViemModels();

            //Assembly assembly = Assembly.LoadFile(@"D:\Gitee\pilot.SCADA\pilot.SCADA\WpfCustomControlLibrary1\bin\Debug\pilot.Task.dll");
            //Type type = assembly.GetType("pilot.Task.Views.StaticsDisplayView");
            //object instance = Activator.CreateInstance(type);
            //(instance as Window).Show();
        }

        //设置从非mainviewmodel的绑定
        private void AllSetBindingsFromOtherViemModels()
        {
            //log record time
            this.tb_recordTime.SetBinding(TextBlock.TextProperty, new Binding()
            {
                Source = LoggerRecordViewModel.GetInstance(),
                Path = new PropertyPath("CurrentLog.RecordTime")
            });

            //log record content
            this.tb_recordContent.SetBinding(TextBlock.TextProperty, new Binding()
            {
                Source = LoggerRecordViewModel.GetInstance(),
                Path = new PropertyPath("CurrentLog.Content")
            });

            //log record type
            this.tb_recordType.SetBinding(TextBlock.TextProperty, new Binding()
            {
                Source = LoggerRecordViewModel.GetInstance(),
                Path = new PropertyPath("CurrentLog.Type")
            });

            //log record identy
            this.tb_identity.SetBinding(TextBlock.TextProperty, new Binding()
            {
                Source = LoggerRecordViewModel.GetInstance(),
                Path = new PropertyPath("CurrentLog.Identity")
            });

            //grid background
            this.grid_log.SetBinding(Grid.BackgroundProperty, new Binding()
            {
                Source = LoggerRecordViewModel.GetInstance(),
                Path = new PropertyPath("CurrentLog.Type"),
                Converter=new LogBackGroundConverter()
            });

            //打开工程命令绑定
            this.mi_openPrg.SetBinding(MenuItem.CommandProperty, new Binding()
            {
                Source = ProjectManagerViewModel.GetInstance(),
                Path = new PropertyPath("OpenProjectCommand")
            });
        }
    }
}
