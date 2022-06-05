using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pilot.HMS.Common;

namespace pilot.HMS.ViewModels
{
    class ComSettingViewModel : NotificationObject
    {

        #region 串口的
        //使用 串口
        private bool _useSerial;
        public bool UseSerial
        {
            get { return _useSerial; }
            set
            {
                _useSerial = value;
                this.RaisePropertyChanged("UseSerial");
            }
        }

        //使用 udp
        private bool _useUdp;
        public bool UseUdp
        {
            get { return _useUdp; }
            set
            {
                _useUdp = value;
                this.RaisePropertyChanged("UseUdp");
            }
        }

        //串口参数 属性 combox的选项来源绑定它
        private SerialParamModel _comPara;
        public SerialParamModel ComPara
        {
            get { return _comPara; }
            set
            {
                _comPara = value;
                this.RaisePropertyChanged("_comPara");
            }
        }

        //当前的串口参数 属性 combox当前选择项绑定它
        private SerialSeletedModel _currPara;
        public SerialSeletedModel CurrPara
        {
            get { return _currPara; }
            set
            {
                _currPara = value;
                this.RaisePropertyChanged("CurrPara");
            }
        }

        //
        public DelegateCommand OpenCom { get; set; } = new DelegateCommand();
        public DelegateCommand SendCom { get; set; } = new DelegateCommand();

        //开启串口
        private void ToOpen(object para) { CurrPara.Open(); }

        //关闭串口
        private void ToSend(object para) { CurrPara.Send(); }

        //其他设置
        private void SerialOtherSettings()
        {

            ComPara = new SerialParamModel();
            CurrPara = new SerialSeletedModel();

            this.OpenCom.ExecuteAction = new Action<object>(this.ToOpen);
            this.SendCom.ExecuteAction = new Action<object>(this.ToSend);

            //默认选择的项目
            CurrPara.Port = ComPara.Port[0];
            CurrPara.BaudRate = ComPara.BaudRate[6];
            CurrPara.DataBit = ComPara.DataBit[2];
            CurrPara.Parity = ComPara.Parity[0];
            CurrPara.StopBit = ComPara.StopBit[0];
        }

        #endregion


        public DelegateCommand ConnectCommand { get; set; } = new DelegateCommand();
        //连接 或 已连接断开
        public void Connect(object para)
        {
            if(UseSerial==true)
            {
                CurrPara.Open();
                return;
            }
            else if(UseUdp==true)
            {
                //......udp.open()?
                return;
            }
        }

        public DelegateCommand SendCommand { get; set; } = new DelegateCommand();
        //发送
        public void Send(object para)
        {
            if (UseSerial == true)
            {
                CurrPara.Send();
                return;
            }
            else if (UseUdp == true)
            {
                //......udp.send()?
                return;
            }
        }

        public DelegateCommand ClearReceiveCommand { get; set; } = new DelegateCommand();
        //清空接收区
        public void ClearReceive(object para)
        {
            if (UseSerial == true)
            {
                CurrPara.Clear();
                return;
            }
            else if (UseUdp == true)
            {
                //......udp.clear()?
                return;
            }
        }


        public DelegateCommand ClearSendCommand { get; set; } = new DelegateCommand();
        //清空发送
        public void ClearSend(object para)
        {
            if (UseSerial == true)
            {
                CurrPara.ClearText();
                return;
            }
            else if (UseUdp == true)
            {
                //......udp.ClearText()?
                return;
            }
        }
        


        //CTOR
        public ComSettingViewModel()
        {
            SerialOtherSettings();

            ConnectCommand.ExecuteAction = new Action<object>(this.Connect);
            SendCommand.ExecuteAction = new Action<object>(this.Send);
            ClearReceiveCommand.ExecuteAction = new Action<object>(this.ClearReceive);
            ClearSendCommand.ExecuteAction = new Action<object>(this.ClearSend);
        }
    }
}
