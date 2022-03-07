using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using NModbus;
using NModbus.Serial;
using pilot.DataBuffer;
using pilot.ProjConfiguration.Serialization;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using ProjConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    public class ModbusMasterViewModel : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        public ModbusMasterViewModel(IDataBuffer _dataStorage, IProjConfig projConfig)
        {
            this.projConfig = projConfig;
            this.ModbusMasterModel = projConfig.Init<ModbusMasterModel>("ModbusMasterModel") ?? new ModbusMasterModel();

            this.dataStorage = _dataStorage;//依赖注入 存储区域

            //超时 处理
            timer4read.Elapsed += ReadInputRegisters;

            //注册消息，mainviewmodel中command控制开始、停止读取，发送messenger至modbusviewmodel进行开始、停止控制
            Messenger.Default.Register<object>(this, "StartModbusReadToken", StartRead);
            Messenger.Default.Register<object>(this, "StopModbusReadToken", StopRead);

            Messenger.Default.Register<string>(this, "SavePrj", s =>
            {
                this.projConfig.Save("ModbusParams", ModbusMasterModel);
                HandyControl.Controls.Growl.SuccessGlobal("保存成功");
            });
        }


        #region 属性
        private readonly ModbusFactory modbusFactory = new ModbusFactory();
        private IModbusMaster modbusMaster;
        private readonly Timer timer4read = new Timer();
        private readonly IDataBuffer dataStorage;//
        private readonly IProjConfig projConfig;
        private SerialPort SerialObj;

        private ModbusMasterModel modbusMasterModel;
        /// <summary>
        /// 读取 参数
        /// </summary>
        public ModbusMasterModel ModbusMasterModel
        {
            get { return modbusMasterModel; }
            set
            {
                if (modbusMasterModel == value) { return; }
                modbusMasterModel = value;
                RaisePropertyChanged(() => ModbusMasterModel);
            }
        }


        #endregion


        #region 方法
        /// <summary>
        /// 开始读取
        /// </summary>
        /// <param name="obj"></param>
        private void StartRead(object obj)
        {
            try
            {
                timer4read.Interval = ModbusMasterModel.ScanRate;
                timer4read.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 停止读取
        /// </summary>
        /// <param name="obj"></param>
        private void StopRead(object obj)
        {
            timer4read.Stop();
        }

        /// <summary>
        /// 读取输入寄存器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadInputRegisters(object sender, ElapsedEventArgs e)
        {
            if (this.modbusMaster == null)
                return;

            var ValueList = this.modbusMaster.ReadInputRegistersAsync(ModbusMasterModel.SlaveId, ModbusMasterModel.StartAddr, ModbusMasterModel.ReadNum).Result;

            this.dataStorage.AddDataPoint(ModbusMasterModel.StartAddr, ModbusMasterModel.ReadNum, DateTime.UtcNow, ValueList);
        }


        #endregion


        #region 命令
        private RelayCommand<object> _myCommand1;
        /// <summary>
        /// 确认 的命令
        /// </summary>
        public RelayCommand<object> ConfirmConnectionCommand
        {
            get
            {
                return _myCommand1 ?? (_myCommand1 = new RelayCommand<object>(ConfirmConnection));
            }
        }
        private void ConfirmConnection(object param)
        {
            try
            {
                if (ModbusMasterModel.SelectedConnectionMode == "SerialPort")
                {
                    SerialObj = new SerialPort();

                    SerialObj.PortName = ModbusMasterModel.PortName;
                    SerialObj.BaudRate = ModbusMasterModel.BaudRate;
                    SerialObj.DataBits = ModbusMasterModel.DataBit;

                    if (ModbusMasterModel.StopBit == "1")
                        SerialObj.StopBits = System.IO.Ports.StopBits.One;
                    else if (ModbusMasterModel.StopBit == "1.5")
                        SerialObj.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else
                        SerialObj.StopBits = System.IO.Ports.StopBits.Two;

                    if (ModbusMasterModel.Parity == "无")
                        SerialObj.Parity = System.IO.Ports.Parity.None;
                    else if (ModbusMasterModel.Parity == "偶校验")
                        SerialObj.Parity = System.IO.Ports.Parity.Even;
                    else
                        SerialObj.Parity = System.IO.Ports.Parity.Odd;

                    if (SerialObj.IsOpen == true)
                        SerialObj.Close();
                    SerialObj.Open();

                    //选择是rtu 还是 ascii
                    if (ModbusMasterModel.UseRtu == true)
                    {
                        modbusMaster = modbusFactory.CreateRtuMaster(SerialObj);
                    }
                    else
                    {
                        modbusMaster = modbusFactory.CreateAsciiMaster(SerialObj);
                    }
                }
                else if (ModbusMasterModel.SelectedConnectionMode == "Modbus TCP/IP")
                {
                    var iPEndPoint = new IPEndPoint(IPAddress.Parse(ModbusMasterModel.SelectedIPAdress), ModbusMasterModel.Port);
                    var tcpClient = new TcpClient(iPEndPoint);
                    modbusMaster = modbusFactory.CreateMaster(tcpClient);
                }
                else if (ModbusMasterModel.SelectedConnectionMode == "Modbus UDP/IP")
                {
                    var iPEndPoint = new IPEndPoint(IPAddress.Parse(ModbusMasterModel.SelectedIPAdress), ModbusMasterModel.Port);
                    var client = new UdpClient();
                    client.Connect(iPEndPoint);
                    modbusMaster = modbusFactory.CreateMaster(client);
                }

                (param as Window)?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private RelayCommand<object> _myCommand2;
        /// <summary>
        /// 确认读写参数 的命令
        /// </summary>
        public RelayCommand<object> ConfirmReadSetCommand
        {
            get
            {
                return _myCommand2 ?? (_myCommand2 = new RelayCommand<object>(ConfirmReadSet));
            }
        }
        private void ConfirmReadSet(object param)
        {
            (param as Window)?.Close();
        }
        #endregion

    }
}
