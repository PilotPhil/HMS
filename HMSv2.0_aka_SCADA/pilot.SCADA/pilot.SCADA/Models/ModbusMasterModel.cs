using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;

namespace pilot.SCADA.Models
{
    public class ModbusMasterModel : ObservableObject
    {
        /// <summary>
        /// ctor
        /// </summary>
        public ModbusMasterModel()
        {
            //IP地址初始化
            var hostName = Dns.GetHostName();
            var IpEntry = Dns.GetHostEntry(hostName);

            this.IpAddress = new List<string>();

            foreach (var item in IpEntry.AddressList)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    this.IpAddress.Add(item.ToString());
                }
            }

            this.IpAddress.Add("127.0.0.1");
            this.IpAddress.Add("0.0.0.0");

            SelectedIPAdress = IpAddress?.ElementAt(0);

            //串口初始化
            PortList = SerialPort.GetPortNames().ToList();//获取可用端口
        }


        #region 连接 读取 model
        private byte slaveId = 0;
        /// <summary>
        /// 从站地址
        /// </summary>
        public byte SlaveId
        {
            get { return slaveId; }
            set
            {
                if (slaveId == value) { return; }
                slaveId = value;
                RaisePropertyChanged(() => SlaveId);
            }
        }

        private ushort startAddr = 0;
        /// <summary>
        /// 起始地址
        /// </summary>
        public ushort StartAddr
        {
            get { return startAddr; }
            set
            {
                if (startAddr == value) { return; }
                startAddr = value;
                RaisePropertyChanged(() => StartAddr);
            }
        }

        private ushort readNum = 10;
        /// <summary>
        /// 读取数量
        /// </summary>
        public ushort ReadNum
        {
            get { return readNum; }
            set
            {
                if (readNum == value) { return; }
                readNum = value;
                RaisePropertyChanged(() => ReadNum);
            }
        }

        private uint scanRate = 1000;
        /// <summary>
        /// 扫描间隔 ms
        /// </summary>
        public uint ScanRate
        {
            get { return scanRate; }
            set
            {
                if (scanRate == value) { return; }
                scanRate = value;
                RaisePropertyChanged(() => ScanRate);
            }
        }

        #endregion


        #region guide 引导 model
        
        private List<string> connectionMode = new List<string>() { "SerialPort", "Modbus TCP/IP", "Modbus UDP/IP" };
        /// <summary>
        /// 连接模式
        /// </summary>
        [JsonIgnore]
        public List<string> ConnectionMode
        {
            get { return connectionMode; }
            set
            {
                if (connectionMode == value) { return; }
                connectionMode = value;
                RaisePropertyChanged(() => ConnectionMode);
            }
        }

        private string selectedConnectionMode = "SerialPort";
        /// <summary>
        /// 已选择的连接模式
        /// </summary>
        public string SelectedConnectionMode
        {
            get { return selectedConnectionMode; }
            set
            {
                if (selectedConnectionMode == value) { return; }
                selectedConnectionMode = value;

                if (selectedConnectionMode == "SerialPort")
                {
                    UseSerialModel = true;
                }
                else
                {
                    UseSerialModel = false;
                }

                RaisePropertyChanged(() => SelectedConnectionMode);
            }
        }

        private bool useSerialModel = true;
        /// <summary>
        /// 是否使用串口模式，要不就是socket
        /// </summary>
        public bool UseSerialModel
        {
            get { return useSerialModel; }
            set
            {
                if (useSerialModel == value) { return; }
                useSerialModel = value;
                RaisePropertyChanged(() => UseSerialModel);
            }
        }

        private bool useRtu = true;
        /// <summary>
        /// 使用Rtu还是ASCII
        /// </summary>
        public bool UseRtu
        {
            get { return useRtu; }
            set
            {
                if (useRtu == value) { return; }
                useRtu = value;
                RaisePropertyChanged(() => UseRtu);
            }
        }

        #endregion


        #region Socket 参数
        private int port = 2121;
        /// <summary>
        /// 端口
        /// </summary>
        public int Port
        {
            get { return port; }
            set
            {
                if (port == value) { return; }
                port = value;
                RaisePropertyChanged(() => Port);
            }
        }

        private List<string> ipAddress;
        /// <summary>
        /// IP 地址
        /// </summary>
        [JsonIgnore]
        public List<string> IpAddress
        {
            get { return ipAddress; }
            set
            {
                if (ipAddress == value) { return; }
                ipAddress = value;
                RaisePropertyChanged(() => IpAddress);
            }
        }

        private string selectedIPAdress;
        /// <summary>
        /// 选中的ip地址
        /// </summary>
        [JsonIgnore]
        public string SelectedIPAdress
        {
            get { return selectedIPAdress; }
            set
            {
                if (selectedIPAdress == value) { return; }
                selectedIPAdress = value;
                RaisePropertyChanged(() => SelectedIPAdress);
            }
        }

        #endregion


        #region 串口 参数
        //串口号
        [JsonIgnore]
        public string PortName { get; set; }
        [JsonIgnore]
        public List<string> PortList { get; set; }

        //波特率
        public int BaudRate { get; set; } = 9600;
        [JsonIgnore]
        public List<int> BaudRateList { get; set; } = new List<int>()
        {
            110,
            300,
            600,
            1200,
            2400,
            4800,
            9600,
            14400,
            19200,
            38400
        };

        //数据位
        public int DataBit { get; set; } = 8;
        [JsonIgnore]
        public List<int> DataBitList { get; set; } = new List<int>()
        {
            6,
            7,
            8
        };

        //校验位
        public string Parity { get; set; } = "无";
        [JsonIgnore]
        public List<string> ParityList { get; set; } = new List<string>()
        {
            "无",
            "偶校验",
            "奇校验"
        };

        //停止位
        public string StopBit { get; set; } = "1";
        [JsonIgnore]
        public List<string> StopBitList { get; set; } = new List<string>()
        {
            "1",
            "1.5",
            "2"
        };
        #endregion
    }
}
