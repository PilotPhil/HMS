/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:pilot.SCADA" x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using pilot.DataBuffer;
using pilot.ProjConfiguration.Log;
using pilot.ProjConfiguration.Serialization;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using pilot.SCADA.Views;
using ProjConfig;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Unity;
using Unity.ServiceLocation;

namespace pilot.SCADA.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var UnityContainer = new UnityContainer();
            var UnityServiceLocator = new UnityServiceLocator(UnityContainer);
            ServiceLocator.SetLocatorProvider(() => UnityServiceLocator);

            /*---------单例viewmodel---------*/
            UnityContainer.RegisterSingleton<ModbusMasterViewModel>();//modbus Master View
            UnityContainer.RegisterSingleton<TaskViewModel>();//task View
            UnityContainer.RegisterSingleton<TiledViewModel>();//Tiled View
            UnityContainer.RegisterSingleton<SensorManagerViewModel>();//Sensor Manager View
            UnityContainer.RegisterSingleton<DataCheckViewModel>();//Data Check View
            UnityContainer.RegisterSingleton<ConnectDBViewModel>();//Connect DB View

            /*---------每次实例---------*/
            //UnityContainer.RegisterType<CreateSensorViewModel>();//Sensor Manager View
            UnityContainer.RegisterType<NewProjectViewModel>();//New Project View

            /*---------服务接口---------*/
            UnityContainer.RegisterType<ISerialize, JsonSerialize>();//serialization service
            UnityContainer.RegisterSingleton<IDataBuffer, RelatedDataBuffer>();//Data Buffer service
            UnityContainer.RegisterSingleton<LogRecordViewModel>();
            UnityContainer.RegisterSingleton<ILog, LogRecordViewModel>();
            UnityContainer.RegisterSingleton<IProjConfig, JsonProjConfig>();

        }

        #region /*---------ViewModelÊôÐÔ---------*/
        public MainViewModel Main
            => ServiceLocator.Current.GetInstance<MainViewModel>();

        public NewProjectViewModel NewProject
            => ServiceLocator.Current.GetInstance<NewProjectViewModel>(Guid.NewGuid().ToString());

        public DataCheckViewModel DataCheck
            => ServiceLocator.Current.GetInstance<DataCheckViewModel>();

        //public CreateSensorViewModel CreateSensor
        //    => ServiceLocator.Current.GetInstance<CreateSensorViewModel>(Guid.NewGuid().ToString());

        public SensorManagerViewModel SensorManager
            => ServiceLocator.Current.GetInstance<SensorManagerViewModel>();

        public TiledViewModel Tiled
            => ServiceLocator.Current.GetInstance<TiledViewModel>(Guid.NewGuid().ToString());

        public TiledCheckViewModel TiledCheck
            => ServiceLocator.Current.GetInstance<TiledCheckViewModel>(Guid.NewGuid().ToString());

        public TaskViewModel Task
            => ServiceLocator.Current.GetInstance<TaskViewModel>();

        public ModbusMasterViewModel ModbusMaster
            => ServiceLocator.Current.GetInstance<ModbusMasterViewModel>();

        public LogRecordViewModel LogRecord
            => ServiceLocator.Current.GetInstance<LogRecordViewModel>();

        public ConnectDBViewModel ConnectDB
            => ServiceLocator.Current.GetInstance<ConnectDBViewModel>();

        #endregion

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}