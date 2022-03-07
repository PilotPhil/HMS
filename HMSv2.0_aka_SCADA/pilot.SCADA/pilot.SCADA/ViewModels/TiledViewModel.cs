using CommonServiceLocator;
using GalaSoft.MvvmLight;
using LiveCharts;
using pilot.DataBuffer;
using pilot.SCADA.Global;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;

namespace pilot.SCADA.ViewModels
{
    public class TiledViewModel : ViewModelBase
    {
        public ObservableCollection<TiledItemView> CheckViewList { get; set; }

        public TiledViewModel()
        {
            CheckViewList = new ObservableCollection<TiledItemView>();

            int? numOfSensor = ServiceLocator.Current.GetInstance<SensorManagerViewModel>().SensorList.Count;

            //无传感器，不创建子元素
            if (numOfSensor==null || numOfSensor <= 0)
            {
                return;
            }

            //元素数量归零
            TiledCheckViewModel.numOfThisView = 0;

            //依次添加
            for (int i = 0; i < numOfSensor; i++)
            {
                var view = new TiledItemView();

                CheckViewList.Add(view);
            }
        }
    }

}
