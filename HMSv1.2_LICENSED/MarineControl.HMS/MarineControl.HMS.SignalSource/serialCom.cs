using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Timers;

namespace MarineControl.HMS.Communiction
{
    class SerialCom
    {
        /*--------------------------------------成员--------------------------*/
        /// <summary>
        /// 串口对象
        /// </summary>
        private SerialPort serial = new SerialPort();
        /// <summary>
        /// 定时发送Timer
        /// </summary>
        public Timer autoSendTimerSpan = new Timer();


        public delegate void ProcessSerialDataHandler(string serialData);
        public event ProcessSerialDataHandler ProcessSerialDataEvent;

        public delegate void AutoSendSerialDataHandle();
        public event AutoSendSerialDataHandle AutoSendSerialDataEvent;

        /// <summary>
        /// 端口名
        /// </summary>
        private string _portName;
        public string portName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        /// <summary>
        /// 波特率
        /// </summary>
        private int _baudRate;
        public int baudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// 校验位
        /// </summary>
        private Parity _parity;
        public Parity parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// 数据位
        /// </summary>
        private int _dataBit;
        public int dataBit
        {
            get { return _dataBit; }
            set { _dataBit = value; }
        }

        /// <summary>
        /// 停止位
        /// </summary>
        private StopBits _stopBit;
        public StopBits stopBit
        {
            get { return _stopBit; }
            set { _stopBit = value; }
        }

        /// <summary>
        /// 编码方式读取
        /// </summary>
        private String _encode_r;
        public String encode_r
        {
            get { return _encode_r; }
            set { _encode_r = value; }
        }

        /// <summary>
        /// 编码方式发送
        /// </summary>
        private String _encode_w;
        public String encode_w
        {
            get { return _encode_w; }
            set { _encode_w = value; }
        }

        /// <summary>
        /// 串口是否打开标志
        /// </summary>
        private bool _IsOpen;
        public bool IsOpen
        {
            get { return _IsOpen; }
            set { _IsOpen = value; }
        }

        /*----------------------------------方法-------------------------------*/

        /// <summary>
        /// 构造
        /// </summary>
        public SerialCom()
        {
            portName = "COM3";
            baudRate = 9600;
            parity = Parity.None;
            dataBit = 8;
            stopBit = StopBits.One;

            encode_r = "ASCII";
            encode_w = "ASCII";

            IsOpen = false;

            //串口接收到数据后回调
            serial.DataReceived += ProcessReceivedData;

            this.OpenSerial();

            autoSendTimerSpan.Interval = 1000;
            autoSendTimerSpan.Elapsed += AutosendMsg;
        }

        /// <summary>
        /// 处理接收到的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReadDatas = new byte[serial.BytesToRead];               //开辟用于接收数据的空间

            serial.Read(ReadDatas, 0, ReadDatas.Length);                   //从串口读取接收到的数据

            //接收到的数据的解码与显示
            if (encode_r=="HEX")//16进制
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ReadDatas.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", ReadDatas[i]);
                }
                ProcessData(sb.ToString().ToUpper());
            }
            else
            {
                Console.WriteLine(ReadDatas);
                ProcessData(new UTF8Encoding().GetString(ReadDatas));//UTF-8编码
            }
        }

        //读取到数据后处理事件
        private void ProcessData(string content)
        {
            if (ProcessSerialDataEvent != null)//代理 事件非空的话
            {
                ProcessSerialDataEvent(content);
            }
        }

        public void  OpenSerialPort()
        {
            if(serial.IsOpen==false)
            {
                try//尝试开启串口
                {
                    serial.Open();
                }
                catch (Exception ex)
                {
                    throw new AggregateException(ex);
                }
            }
        }

        /// <summary>
        /// 获取可用端口
        /// </summary>
        /// <returns></returns>
        public string[] GetEnablePort(){ return SerialPort.GetPortNames(); }

        /// <summary>
        /// 打开串口
        /// </summary>
        public void OpenSerial()
        {
            serial.PortName = this.portName;
            serial.BaudRate = (int)this.baudRate;
            serial.Parity = this.parity;
            serial.DataBits = (int)this.dataBit;
            serial.StopBits = this.stopBit;

            if (serial.IsOpen == true)
                return;

            try//尝试打开串口
            {
                serial.Open();
            }
            catch (Exception ex)
            {
                //throw new AggregateException("串口打开异常");
            }

            this.IsOpen = serial.IsOpen;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public void CloseSerial()
        {
            if (serial.IsOpen == false)
                return;
            try
            {
                serial.Close();
            }
            catch (Exception ex)
            {
                throw new AggregateException("串口关闭异常",ex.InnerException);
            }
            this.IsOpen = serial.IsOpen;
        }

        /*---------------------------发送--------------------------*/
        public void SendMsg(string msg)
        {
            byte[] _msg = null;

            string msg2send = msg.Trim();

            if (encode_w == "HEX")
                _msg = StrToHex(msg2send);
            else
                _msg = Encoding.UTF8.GetBytes(msg2send);

            if (serial.IsOpen == false)
                return;
            
            try
            {
                serial.Write(_msg, 0, _msg.Length);
            }
            catch (Exception ex)
            {
                throw new AggregateException("串口发送异常",ex.InnerException);
            }
            
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
        /// 自动定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutosendMsg(object sender, EventArgs e)
        {
            if (AutoSendSerialDataEvent != null)
                AutoSendSerialDataEvent();
        }

    }
}
