using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    public class CreateSensorViewModel : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        public CreateSensorViewModel(SensorModel _sensorModel = null)
        {
            if (_sensorModel == null)//如果没有传入的话，就是新建传感器模式，
            {
                this.SensorModel = new SensorModel();
                this.title = "创建传感器";
            }
            else//传入非null的话就是编辑模式
            {
                this.SensorModel = _sensorModel;
            }

            ServiceLocator.Current.GetInstance<SensorManagerViewModel>();//直接创建传感器，确认后通过messenger发送设好的sendorModel给SensorManagerViewModel进行添加，此时需要SensorManagerViewModel实例已经存在，所以通过服务定位器进行一次调用，使得其存在
        }


        #region 属性
        private SensorModel sensorModel;
        /// <summary>
        /// 传感器基本信息 model
        /// </summary>
        public SensorModel SensorModel
        {
            get { return sensorModel; }
            set
            {
                if (sensorModel == value) { return; }
                sensorModel = value;
                RaisePropertyChanged(() => SensorModel);
            }
        }

        private string title = "编辑传感器";
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) { return; }
                title = value;
                RaisePropertyChanged(() => Title);
            }
        }
        #endregion


        #region 命令
        private RelayCommand<object> _myCommand1;
        /// <summary>
        /// 确认创建 的命令
        /// </summary>
        public RelayCommand<object> ConfirmCommand
        {
            get
            {
                return _myCommand1 ?? (_myCommand1 = new RelayCommand<object>(Confirm));
            }
        }
        private void Confirm(object param)
        {
            //确认 后 不管是 新建传感器还是编辑传感器模式，都将sensorModel发送出去，在manageviewmodel中通过Guid是否重复来判断是新建还是编辑
            Messenger.Default.Send<SensorModel>(sensorModel, "SendASensorModel");
            (param as Window)?.Close();
        }

        private RelayCommand<object> _myCommand2;
        /// <summary>
        /// 取消关闭窗口 的命令
        /// </summary>
        public RelayCommand<object> CancelCommand
        {
            get
            {
                return _myCommand2 ?? (_myCommand2 = new RelayCommand<object>(Cancel));
            }
        }
        private void Cancel(object param)
        {
            (param as Window)?.Close();
        }
        #endregion
    }
}
