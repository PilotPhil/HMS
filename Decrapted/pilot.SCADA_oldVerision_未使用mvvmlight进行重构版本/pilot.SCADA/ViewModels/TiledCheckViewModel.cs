using LiveCharts;
using pilot.SCADA.Common;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pilot.SCADA.ViewModels
{
    class TiledCheckViewModel : NotificationObject
    {
        private ChartValues<double> _values;
        public ChartValues<double> Values
        {
            get { return _values; }
            set
            {
                _values = value;
                //this.RaisePropertyChanged("Values");
            }
        }

        private SensorModel _sensorModel;
        public SensorModel SensorModel
        {
            get { return _sensorModel; }
            set
            {
                _sensorModel = value;
                this.RaisePropertyChanged("SensorModel");
            }
        }

        private double _sensorValue;
        public double SensorValue
        {
            get { return _sensorValue; }
            set
            {
                _sensorValue = value;
                this.RaisePropertyChanged("SensorValue");
            }
        }

        //定时更新 定时器
        Timer timer = new Timer();

        /// <summary>
        /// ctor
        /// </summary>
        public TiledCheckViewModel(SensorModel sensorModel)
        {
            Values = new ChartValues<double>() { 0, 0, 0, 0, 0, 0 };

            this.SensorModel = sensorModel;

            SensorValue = 0;

            timer.Interval = 1000;
            timer.Elapsed += Update;
            timer.Start();
        }

        private async void Update(object sender, ElapsedEventArgs e)
        {
            if (!SysStatue.IsMointoring)
            {
                return;
            }

            if (DataStorage.GetInstance().NumOfSource <= 0 || SensorModel.Use == false)
                return;

            await Task.Run(() =>
            {
                SensorValue = DataStorage.GetInstance().RealTimeDataList[SensorModel.DataSourceIndex].Value;

                Values.Add(SensorValue);

                if (this.Values.Count >= 6)
                {
                    Values.RemoveAt(0);
                }

                this.RaisePropertyChanged("Values");
            });


        }

    }
}
