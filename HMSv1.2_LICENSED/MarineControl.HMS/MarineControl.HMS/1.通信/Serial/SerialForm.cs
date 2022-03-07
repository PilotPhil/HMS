using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarineControl.HMS.Communiction
{
    public partial class SerialForm : Form
    {
        public bool CanOpen = false;

        /// <summary>
        /// 串口发送对象
        /// </summary>
        SerialCom serialCom = new SerialCom();

        Timer timerForFindPorts = new Timer();

        /// <summary>
        /// 获取到serialcom对象中串口数据后触发此事件
        /// </summary>
        /// <param name="msg"></param>
        public delegate void GotSerialDataHandler(string msg);
        public event GotSerialDataHandler GotSerialDataEvent;

        public SerialForm()
        {
            InitializeComponent();

            //设置自动查找可用端口的Timer
            timerForFindPorts.Interval = 1000;
            timerForFindPorts.Tick += new EventHandler(GetPorts);//超时后就查找端口
            //timerForFindPorts.Start();//开启timer

            cb_braudt.SelectedIndex = 5;                            //波特率
            cb_dataBits.SelectedIndex = 3;                          //数据位
            cb_stopBit.SelectedIndex = 0;                           //停止位
            cb_checkBit.SelectedIndex = 0;                          //校验位

            GetPorts();

            //serialCom.ProcessSerialDataEvent += Display;
            serialCom.ProcessSerialDataEvent += GotSerialData;

            CheckForIllegalCrossThreadCalls = false;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "MarineControl.HMS.SerialHelper ";

            //serialCom.AutoSendSerialDataEvent += AutoTimerSend;//定时发送回调

            //初始化
            SerialInit();
        }

        /// <summary>
        /// 串口初始化
        /// </summary>
        private void SerialInit()
        {
            //波特率
            List<KeyValuePair<string, string>> barudt = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("0","2400"),
                new KeyValuePair<string, string>("1","4800"),
                new KeyValuePair<string, string>("2","9600"),
                new KeyValuePair<string, string>("3","19200"),
                new KeyValuePair<string, string>("4","38400"),
                new KeyValuePair<string, string>("5","57600"),
                new KeyValuePair<string, string>("6","115200"),
                new KeyValuePair<string, string>("7","128000"),
                new KeyValuePair<string, string>("8","230400"),
                new KeyValuePair<string, string>("9","256000")
            };
            cb_braudt.Source = barudt;
            cb_braudt.SelectedIndex = 2;

            //数据位
            List<KeyValuePair<string, string>> dataBits = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("0","5"),
                new KeyValuePair<string, string>("1","6"),
                new KeyValuePair<string, string>("2","7"),
                new KeyValuePair<string, string>("3","8")
            };
            cb_dataBits.Source = dataBits;
            cb_dataBits.SelectedIndex = 3;

            //校验位
            List<KeyValuePair<string, string>> checkBits = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("0","None"),
                new KeyValuePair<string, string>("1","Odd"),
                new KeyValuePair<string, string>("2","Even"),
                new KeyValuePair<string, string>("3","Mark"),
                new KeyValuePair<string, string>("4","Space")
            };
            cb_checkBit.Source = checkBits;
            cb_checkBit.SelectedIndex = 0;

            //停止位
            List<KeyValuePair<string, string>> stopBits = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("0","1"),
                new KeyValuePair<string, string>("1","1.5"),
                new KeyValuePair<string, string>("2","2")
            };
            cb_stopBit.Source = stopBits;
            cb_stopBit.SelectedIndex = 0;
        }


        private List<KeyValuePair<string, string>> portName = new List<KeyValuePair<string, string>>();
        /// <summary>
        /// 获取可用端口
        /// </summary>
        private void GetPorts(object sender, EventArgs e)
        {
            var _pn = serialCom.GetEnablePort();
            portName.Clear();
            for(int i=0;i<_pn.Length;i++)
            {
                portName.Add(new KeyValuePair<string, string>(i.ToString(), _pn[i]));
            }
            cb_portName.Source = portName;

            if (cb_portName.Source.Count>0)
                cb_portName.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取可用端口
        /// </summary>
        private void GetPorts()
        {
            var _pn = serialCom.GetEnablePort();
            portName.Clear();
            for (int i = 0; i < _pn.Length; i++)
            {
                portName.Add(new KeyValuePair<string, string>(i.ToString(), _pn[i]));
            }
            cb_portName.Source = portName;

            if (cb_portName.Source.Count > 0)
                cb_portName.SelectedIndex = 0;
        }

        /// <summary>
        /// 设置串口参数
        /// </summary>
        private void SetSerial()
        {
            if (cb_portName.Source.Count == 0)//没有查找到端口
                return;
            else
                timerForFindPorts.Stop();//已经找到了串口，关闭定时器

            try
            {
                serialCom.portName = cb_portName.SelectedText;
                serialCom.baudRate = Convert.ToInt32(cb_braudt.SelectedText);            
                serialCom.dataBit = Convert.ToInt32(cb_dataBits.SelectedText);
                serialCom.parity = (Parity)Convert.ToInt32(cb_checkBit.SelectedIndex);
                serialCom.stopBit = (StopBits)Convert.ToInt32(cb_stopBit.SelectedText);
            }
            catch(Exception ex)
            {
                throw new AggregateException("串口配置异常",ex.InnerException);
            }
        }

        /// <summary>
        /// serial建立连接后，禁用改变连接参数
        /// </summary>
        /// <param name="can"></param>
        private void EnableChange(bool can)
        {
            cb_braudt.Enabled = can;
            cb_portName.Enabled = can;
            cb_dataBits.Enabled = can;
            cb_stopBit.Enabled = can;
            cb_checkBit.Enabled = can;
        }

        /// <summary>
        /// 建立连接、断开连接 按钮 复用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Switch()
        {
            if (CanOpen == false)
                return;

            if (serialCom.IsOpen == false)//未开串口
            {
                timerForFindPorts.Stop();
                SetSerial();
                serialCom.OpenSerial();

                EnableChange(false);
            }
            else if (serialCom.IsOpen == true)
            {
                serialCom.CloseSerial();
                timerForFindPorts.Start();

                EnableChange(true);
            }
            else
            {

            }
        }

        ///// <summary>
        ///// 显示
        ///// </summary>
        ///// <param name="msg"></param>
        //private void Display(string msg)
        //{
        //    textBox_receive.AppendText(msg);
        //}

        /// <summary>
        /// 获取到串口数据后进行处理事件
        /// </summary>
        /// <param name="msg"></param>
        private void GotSerialData(string msg)
        {
            //MessageBox.Show(msg);

            if (GotSerialDataEvent != null)
                GotSerialDataEvent(msg);
        }

        /////// <summary>
        /////// textbox内容变化槽函数
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void textBox_receive_TextChanged(object sender, EventArgs e)
        ////{
        ////    textBox_receive.SelectionStart = textBox_receive.Text.Length;
        ////    //滚动到光标位置
        ////    textBox_receive.ScrollToCaret();
        ////}

        /////// <summary>
        /////// 清空接收
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void btn_clearReceive_Click(object sender, EventArgs e)
        ////{
        ////    textBox_receive.Clear();
        ////}

        /////// <summary>
        /////// 清空发送
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void btn_clearSend_Click(object sender, EventArgs e)
        ////{
        ////    textBox_send.Clear();
        ////}

        ///// <summary>
        ///// 串口发送
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn_sendSerialMsg_Click(object sender, EventArgs e)
        //{
        //    var msg = textBox_send.Text;

        //    try
        //    {
        //        serialCom.SendMsg(msg);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("串口发送异常");
        //    }

        //}

        ///// <summary>
        ///// 定时发送开关
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void checkBox_timerSend_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox_timerSend.Checked == false)
        //    {
        //        serialCom.autoSendTimerSpan.Stop();
        //    }
        //    else
        //    {
        //        var interval = textBox_autoSendTime.Text;
        //        int _interval;

        //        if (int.TryParse(interval, out _interval) == false)
        //            return;

        //        serialCom.autoSendTimerSpan.Interval = _interval;
        //        serialCom.autoSendTimerSpan.Start();
        //    }

        //}

        ///// <summary>
        ///// 自动发送
        ///// </summary>
        //private void AutoTimerSend()
        //{
        //    var msg = textBox_send.Text;

        //    serialCom.SendMsg(msg);
        //}

        ///// <summary>
        ///// 设置interval
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void textBox_autoSendTime_TextChanged(object sender, EventArgs e)
        //{
        //    var interval = textBox_autoSendTime.Text;
        //    int _interval;

        //    if (int.TryParse(interval, out _interval) == false)
        //        return;

        //    serialCom.autoSendTimerSpan.Interval = _interval;
        //}

        ///// <summary>
        ///// HEX发送
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void checkBox_HexSend_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox_timerSend.Checked == true)
        //        serialCom.encode_w = "HEX";
        //    else
        //        serialCom.encode_w = "ASCII";
        //}

        ///// <summary>
        ///// HEX接收
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void checkBox_HexReceive_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox_HexReceive.Checked == true)
        //        serialCom.encode_r = "HEX";
        //    else
        //        serialCom.encode_r = "ASCII";
        //}
    }
}
