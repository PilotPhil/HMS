using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using pilot.HMS.Common;

namespace pilot.HMS.ViewModels
{
    class SerialSeletedModel : NotificationObject
    {

        #region 初始串口参数
        //当前串口号
        private string port;
        public string Port
        {
            get { return port; }
            set
            {
                port = value;
                this.RaisePropertyChanged("Port");
            }
        }
        //当前波特率
        private int baudRate;
        public int BaudRate
        {
            get { return baudRate; }
            set
            {
                baudRate = value;
                this.RaisePropertyChanged("BaudRate");
            }
        }
        //当前数据位
        private int dataBit;
        public int DataBit
        {
            get { return dataBit; }
            set
            {
                dataBit = value;
                this.RaisePropertyChanged("DataBit");
            }
        }
        //当前校验位
        private string parity;
        public string Parity
        {
            get { return parity; }
            set
            {
                parity = value;
                this.RaisePropertyChanged("Parity");
            }
        }
        //当前停止位
        private string stopBit;
        public string StopBit
        {
            get { return stopBit; }
            set
            {
                stopBit = value;
                this.RaisePropertyChanged("StopBit");
            }
        }
        #endregion

        private SerialPort serialPort;
        public SerialPort SerialPort
        {
            get { return serialPort; }
            set { serialPort = value; this.RaisePropertyChanged("SerialPort"); }
        }

        private string dataReceiveInfo;
        private string sendData;
        private bool isOpen;
        private bool receiveFormat16 = false;
        private bool sendFormat16 = false;
        private bool enableSelect = true;

        private int sendCount;
        private int receiveCount;

        public int SendCount
        {
            get { return sendCount; }
            set { sendCount = value; this.RaisePropertyChanged("SendCount"); }
        }

        /// <summary>
        /// 接收数量
        /// </summary>
        public int ReceiveCount
        {
            get { return receiveCount; }
            set { receiveCount = value; this.RaisePropertyChanged("ReceiveCount"); }
        }

        /// <summary>
        /// 接收区16进制
        /// </summary>
        public bool ReceiveFormat16
        {
            get { return receiveFormat16; }
            set { receiveFormat16 = value; this.RaisePropertyChanged("ReceiveFormat16"); }
        }

        public bool EnableSelect
        {
            get { return enableSelect; }
            set { enableSelect = value; this.RaisePropertyChanged("EnableSelect"); }
        }
        /// <summary>
        /// 接收区数据
        /// </summary>
        public string DataReceiveInfo
        {
            get { return dataReceiveInfo; }
            set { dataReceiveInfo = value; this.RaisePropertyChanged("DataReceiveInfo"); }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        public string SendData
        {
            get
            {
                return sendData;
            }
            set { sendData = value; this.RaisePropertyChanged("SendData"); }
        }

        /// <summary>
        /// 发送区16进制
        /// </summary>
        public bool SendFormat16
        {
            get { return sendFormat16; }
            set { sendFormat16 = value; this.RaisePropertyChanged("SendFormat16"); }
        }


        /// <summary>
        /// 打开按钮上文字
        /// </summary>
        private string _opneButtonStr="打开";

        public string OpenButtonStr
        {
            get { return _opneButtonStr; }
            set
            {
                _opneButtonStr = value;
                this.RaisePropertyChanged("OpenButtonStr");
            }
        }


        /// <summary>
        /// 开关
        /// </summary>
        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; this.RaisePropertyChanged("IsOpen"); }
        }

        public bool Open()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                return Close();
            }
            try
            {
                serialPort = new SerialPort();
                serialPort.BaudRate = this.BaudRate;
                serialPort.DataBits = this.DataBit;

                if (this.StopBit == "1")
                    serialPort.StopBits = System.IO.Ports.StopBits.One;
                else if (this.StopBit == "1.5")
                    serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                else
                    serialPort.StopBits = System.IO.Ports.StopBits.Two;

                if (this.Parity == "无")
                    serialPort.Parity = System.IO.Ports.Parity.None;
                else if (this.Parity == "偶校验")
                    serialPort.Parity = System.IO.Ports.Parity.Even;
                else
                    serialPort.Parity = System.IO.Ports.Parity.Odd;

                serialPort.PortName = this.Port;
                serialPort.RtsEnable = true;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();

                EnableSelect = false;

                if (serialPort.IsOpen)
                {
                    this.OpenButtonStr = "关闭";
                    return IsOpen = true;
                }
                else
                {
                    return IsOpen = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return IsOpen = false;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns></returns>
        public bool Close()
        {
            try
            {
                EnableSelect = true;
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    this.OpenButtonStr = "打开";
                    return IsOpen = serialPort.IsOpen;
                }
                else
                {
                    return IsOpen = serialPort.IsOpen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return IsOpen = false;
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        public void Send()
        {
            if (SerialPort != null)
            {
                if (SendFormat16)
                {
                    byte[] bytes = StrToHex(SendData);
                    this.SerialPort.Write(bytes, 0, bytes.Length);
                    //SendCount += bytes.Length; //不做增量
                }
                else
                {
                    this.SerialPort.Write(SendData);
                    SendCount += SendData.Length;
                }
            }
            else
                MessageBox.Show("串口未打开！");
        }

        /// <summary>
        /// 16进制编码
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] StrToHex(string hexString)
        {
            hexString = hexString.Replace(" ", "");

            if ((hexString.Length % 2) != 0)
                hexString += " ";

            byte[] returnBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);

            return returnBytes;
        }

        /// <summary>
        /// 清空接收区
        /// </summary>
        public void Clear()
        {
            this.DataReceiveInfo = string.Empty;
        }

        /// <summary>
        /// 清空发送区和缓存区
        /// </summary>
        public void ClearText()
        {
            this.SendData = string.Empty;
            this.SendCount = 0;
            this.ReceiveCount = 0;
        }

        private bool Listening = false;
        private bool Closing = false;
        private StringBuilder builder = new StringBuilder();
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Closing) return;
            try
            {
                Listening = true;
                int n = SerialPort.BytesToRead;
                byte[] buf = new byte[n];

                ReceiveCount += n;
                SerialPort.Read(buf, 0, n);
                builder.Clear();

                if (!ReceiveFormat16)
                    builder.Append(Encoding.GetEncoding("GB2312").GetString(buf));
                else
                {
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }

                DataReceiveInfo += builder.ToString()+"\r\n";
            }
            finally
            {
                Listening = false;
            }
        }
    }

}
