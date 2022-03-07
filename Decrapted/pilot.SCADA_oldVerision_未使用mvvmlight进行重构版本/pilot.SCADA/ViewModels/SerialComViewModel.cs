using pilot.SCADA.Models;
using pilot.SCADA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using pilot.SCADA.Global;
using pilot.SCADA.DAL;
using HandyControl.Controls;
using System.IO;

namespace pilot.SCADA.ViewModels
{
    class SerialComViewModel : NotificationObject
    {
        //串口通信参数模型
        private SerialComParamModel _serialComParamModel;
        public SerialComParamModel SerialComParamModel
        {
            get { return _serialComParamModel; }
            set
            {
                _serialComParamModel = value;
                this.RaisePropertyChanged("SerialComParamModel");
            }
        }

        //序列化
        private readonly JsonSerialize jsonSerialize = new JsonSerialize(Path.Combine(BasePath.SelectedProject.ProjectPath,"SerialComParamModel.json"));

        /// <summary>
        /// CTOR
        /// </summary>
        public SerialComViewModel()
        {
            //反序列化实例化对象
            SerialComParamModel = jsonSerialize.DeserializeRead<SerialComParamModel>();
            SerialComParamModel = SerialComParamModel ?? new SerialComParamModel()
            {
                BaudRate=9600,
                DataBit=8,
                Parity="无",
                StopBit="1"
            };

            //获取可用端口
            SerialComParamModel.PortList = SerialPort.GetPortNames().ToList();

            ConfirmCommand.ExecuteAction = new Action<object>(Confirm);
            ConfirmCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        /// <summary>
        /// 设置串口对象，设置静态唯一串口对象
        /// </summary>
        private void CreateSerial()
        {
            try
            {
                SerialObj.OnlySerial.PortName = SerialComParamModel.PortName;
                SerialObj.OnlySerial.BaudRate = SerialComParamModel.BaudRate;
                SerialObj.OnlySerial.DataBits = SerialComParamModel.DataBit;

                if (SerialComParamModel.StopBit == "1")
                    SerialObj.OnlySerial.StopBits = System.IO.Ports.StopBits.One;
                else if (SerialComParamModel.StopBit == "1.5")
                    SerialObj.OnlySerial.StopBits = System.IO.Ports.StopBits.OnePointFive;
                else
                    SerialObj.OnlySerial.StopBits = System.IO.Ports.StopBits.Two;

                if (SerialComParamModel.Parity == "无")
                    SerialObj.OnlySerial.Parity = System.IO.Ports.Parity.None;
                else if (SerialComParamModel.Parity == "偶校验")
                    SerialObj.OnlySerial.Parity = System.IO.Ports.Parity.Even;
                else
                    SerialObj.OnlySerial.Parity = System.IO.Ports.Parity.Odd;
                

                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "串口对象创建成功",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "成功"
                });

                jsonSerialize.SerializeWrite(SerialComParamModel);
            }
            catch (Exception e)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "串口对象创建失败，因为" + e.Message,
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });
            }
        }

        //确认 设置串口对象 命令
        public DelegateCommand ConfirmCommand { get; set; } = new DelegateCommand();
        public void Confirm(object param)
        {
            this.CreateSerial();

            Window SerialComView = param as Window;
            SerialComView.Close();
        }
    }
}
