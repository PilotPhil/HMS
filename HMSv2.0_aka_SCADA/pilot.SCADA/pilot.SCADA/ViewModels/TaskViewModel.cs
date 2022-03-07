using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CommonServiceLocator;
using pilot.SCADA.Models;
using pilot.DataBuffer;
using GalaSoft.MvvmLight.Command;
using pilot.ManagedTasks;

namespace pilot.SCADA.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public TaskViewModel()
        {
            var sensorList = ServiceLocator.Current.GetInstance<SensorManagerViewModel>().SensorList.ToList();


            SensorIndex = 1;//1 base
        }

        private SensorModel selectedSensor;
        /// <summary>
        /// selected Sensor
        /// </summary>
        public SensorModel SelectedSensor
        {
            get { return selectedSensor; }
            set
            {
                if (selectedSensor == value) { return; }
                selectedSensor = value;
                RaisePropertyChanged(() => SelectedSensor);
            }
        }

        private int sensorIndex;
        /// <summary>
        /// SensorIndex
        /// </summary>
        public int SensorIndex
        {
            get { return sensorIndex; }
            set
            {
                if (sensorIndex == value) { return; }
                sensorIndex = value;
                this.SelectedSensor = ServiceLocator.Current.GetInstance<SensorManagerViewModel>().SensorList[value - 1];
                RaisePropertyChanged(() => SensorIndex);
            }
        }

    }
}
