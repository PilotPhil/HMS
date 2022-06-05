using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using pilot.SCADA.Common;
using pilot.SCADA.Global;
using pilot.SCADA.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pilot.SCADA.Views
{
    /// <summary>
    /// CheckValueView.xaml 的交互逻辑
    /// </summary>
    public partial class CheckValueView
    {
        private readonly ChartViewModel chartViewModel = new ChartViewModel();

        public CheckValueView()
        {
            InitializeComponent();

            this.DataContext = DataStorage.GetInstance();

            this.chart.DataContext = chartViewModel;

            this.combox_select.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Path = new PropertyPath("NumOfSourceList"),
                Source = DataStorage.GetInstance()
            });

            this.combox_select.SetBinding(ComboBox.SelectedIndexProperty, new Binding()
            {
                Path = new PropertyPath("SelectDispIndex"),
                Source = chartViewModel
            });

            this.tb_freq.SetBinding(TextBox.TextProperty, new Binding()
            {
                Path = new PropertyPath("UpdateFreq"),
                Source = chartViewModel
            });

            this.tb_num.SetBinding(TextBox.TextProperty, new Binding()
            {
                Path = new PropertyPath("LenOfAxisX"),
                Source = chartViewModel
            });

            chartViewModel.InitAxis();
        }
    }


    class ChartViewModel : NotificationObject
    {
        public SeriesCollection SeriesCollection { get; set; } = new SeriesCollection { };
        public List<string> XLabels { get; set; } = new List<string>();

        private double _trend;//虽然不知道为什么，但给series.value幅值时，先用此字段接受一下，再把此字段给value.add(...)，这样不会报转换错误

        //x轴长度
        private int _lenOfAxisX;
        public int LenOfAxisX
        {
            get { return _lenOfAxisX; }
            set
            {
                _lenOfAxisX = value;
                this.RaisePropertyChanged("LenOfAxisX");

                this.XLabels.Clear();
                this.SeriesCollection[0].Values.Clear();
            }
        }

        //更新频率
        private float _updateFreq;
        public float UpdateFreq
        {
            get { return _updateFreq; }
            set
            {
                _updateFreq = value;
                this.RaisePropertyChanged("UpdateFreq");
            }
        }

        //定时更新 定时器
        private readonly Timer timer = new Timer();

        //选择要更新（显示）的数据源
        private int _selectDispIndex;
        public int SelectDispIndex
        {
            get { return _selectDispIndex; }
            set
            {
                _selectDispIndex = value;
                this.RaisePropertyChanged("SelectDispIndex");

                this.XLabels.Clear();
                this.SeriesCollection[0].Values.Clear();
            }
        }

        public ChartViewModel()
        {
            LineSeries mylineseries = new LineSeries()
            {
                Title = "Temp",
                LineSmoothness = 0,
                PointGeometry = null,
                Values = new ChartValues<double>()
            };

            SeriesCollection.Add(mylineseries);


            SelectDispIndex = -1;
            LenOfAxisX = 20;
            UpdateFreq = 1;

            timer.Interval = 1000 / UpdateFreq;
            timer.Elapsed += Update;
            timer.Start();
        }

        private void UpdatePoint(string label, double value)
        {
            _trend = value;

            XLabels.Add(label);
            SeriesCollection[0].Values.Add(_trend);

            if (XLabels.Count > LenOfAxisX)
            {
                XLabels.RemoveAt(0);
                SeriesCollection[0].Values.RemoveAt(0);
            }
        }

        private async void Update(object sender, ElapsedEventArgs e)
        {
            await Task.Run(() =>
            {
                if (DataStorage.GetInstance().NumOfSource <= 0 || SelectDispIndex == -1)
                    return;

                var data = DataStorage.GetInstance().RealTimeDataList[SelectDispIndex];

                var label = data.TimeStamp.ToString("T");//转换为 短时间
                var val = data.Value;

                this.UpdatePoint(label, val);
            });
        }

        public void InitAxis()
        {
            XLabels = new List<string>() { "0:00:00", "0:00:01", "0:00:02", "0:00:03", "0:00:04" };
            _trend = 0;
            SeriesCollection[0].Values.Add(_trend);
            SeriesCollection[0].Values.Add(_trend);
            SeriesCollection[0].Values.Add(_trend);
            SeriesCollection[0].Values.Add(_trend);
            SeriesCollection[0].Values.Add(_trend);
            SeriesCollection[0].Values.Add(_trend);
        }
    }

}
