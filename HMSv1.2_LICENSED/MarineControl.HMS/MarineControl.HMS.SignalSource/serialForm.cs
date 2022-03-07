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
        /// <summary>
        /// 串口发送对象
        /// </summary>
        SerialCom serialCom = new SerialCom();

        Timer timerForFindPorts = new Timer();

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

            serialCom.ProcessSerialDataEvent += Display;

            CheckForIllegalCrossThreadCalls = false;


            FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "MarineControl.HMS.SerialHelper ";

            serialCom.AutoSendSerialDataEvent += AutoTimerSend;//定时发送回调
        }

        /// <summary>
        /// 获取可用端口
        /// </summary>
        private void GetPorts(object sender, EventArgs e)
        {
            cb_comName.Items.Clear();
            cb_comName.Items.AddRange(serialCom.GetEnablePort());

            if (cb_comName.Items.Count > 0)
                cb_comName.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取可用端口
        /// </summary>
        private void GetPorts()
        {
            cb_comName.Items.Clear();
            cb_comName.Items.AddRange(serialCom.GetEnablePort());

            if (cb_comName.Items.Count > 0)
                cb_comName.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置串口参数
        /// </summary>
        private void SetSerial()
        {
            if (cb_comName.Items.Count == 0)//没有查找到端口
                return;
            else
                timerForFindPorts.Stop();//已经找到了串口，关闭定时器

            try
            {
                serialCom.portName = cb_comName.SelectedItem.ToString();
                serialCom.baudRate = Convert.ToInt32(cb_braudt.SelectedItem.ToString());            
                serialCom.dataBit = Convert.ToInt32(cb_dataBits.SelectedItem.ToString());
                serialCom.parity = (Parity)Convert.ToInt32(cb_checkBit.SelectedIndex);
                serialCom.stopBit = (StopBits)Convert.ToInt32(cb_stopBit.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                throw new AggregateException("串口配置异常",ex.InnerException);
            }
        }

        /// <summary>
        /// 建立连接、断开连接 按钮 复用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openSerial_Click(object sender, EventArgs e)
        {
            if(serialCom.IsOpen==false)//未开串口
            {
                timerForFindPorts.Stop();
                btn_openSerial.Text = "断开连接";
                label_IsOpen.Text = "已连接串口" + serialCom.portName;
                SetSerial();
                serialCom.OpenSerial();
            }
            else if(serialCom.IsOpen==true)
            {
                serialCom.CloseSerial();
                timerForFindPorts.Start();
                btn_openSerial.Text = "建立连接";
                label_IsOpen.Text = "未连接";
            }
            else
            {

            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="msg"></param>
        private void Display(string msg)
        {
            textBox_receive.AppendText(msg);
        }

        private void textBox_receive_TextChanged(object sender, EventArgs e)
        {
            textBox_receive.SelectionStart = textBox_receive.Text.Length;
            //滚动到光标位置
            textBox_receive.ScrollToCaret();
        }

        /// <summary>
        /// 清空接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearReceive_Click(object sender, EventArgs e)
        {
            textBox_receive.Clear();
        }

        /// <summary>
        /// 清空发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearSend_Click(object sender, EventArgs e)
        {
            textBox_send.Clear();
        }

        /// <summary>
        /// 串口发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sendSerialMsg_Click(object sender, EventArgs e)
        {
            var msg = textBox_send.Text;

            try
            {
                serialCom.SendMsg(msg);
            }
            catch(Exception ex)
            {
                MessageBox.Show("串口发送异常");
            }
           
        }

        /// <summary>
        /// 定时发送开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_timerSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_timerSend.Checked == false)
            {
                serialCom.autoSendTimerSpan.Stop();
            }
            else
            {
                var interval = textBox_autoSendTime.Text;
                int _interval;

                if (int.TryParse(interval, out _interval) == false)
                    return;

                serialCom.autoSendTimerSpan.Interval = _interval;
                serialCom.autoSendTimerSpan.Start();
            }
            
        }

        /// <summary>
        /// 自动发送
        /// </summary>
        private void AutoTimerSend()
        {
            var msg = textBox_send.Text;

            serialCom.SendMsg(msg);
        }

        /// <summary>
        /// 设置interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_autoSendTime_TextChanged(object sender, EventArgs e)
        {
            var interval = textBox_autoSendTime.Text;
            int _interval;

            if (int.TryParse(interval, out _interval) == false)
                return;

            serialCom.autoSendTimerSpan.Interval = _interval;
        }

        /// <summary>
        /// HEX发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_HexSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_timerSend.Checked == true)
                serialCom.encode_w = "HEX";
            else
                serialCom.encode_w = "ASCII";
        }

        /// <summary>
        /// HEX接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_HexReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HexReceive.Checked == true)
                serialCom.encode_r = "HEX";
            else
                serialCom.encode_r = "ASCII";
        }
    }
}
