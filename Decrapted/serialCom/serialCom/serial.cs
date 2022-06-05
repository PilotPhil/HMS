using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO.Ports;

using NWaves.Signals;

namespace serialCom
{
    public partial class serial : Form
    {
        private SerialPort com = new SerialPort();                      //串口对象

        Timer autoSendTimer = new Timer();                              //定时发送Timer

        public delegate void ProcessSerialDataHandler(string data_s);   //

        public event ProcessSerialDataHandler ProcessDataEvent;         //处理串口接收到的数据事件

        //构造函数
        public serial()
        {
            InitializeComponent();

            InitialConfig();

            autoSendTimer.Tick += new EventHandler(autoSendTimerEnentProcess);

            this.Text = "串口助手";

            Control.CheckForIllegalCrossThreadCalls = false;

            ManyEvents();
        }

        //许多事件
        private void ManyEvents()
        {
            //com接收到数据除法+的事件
            com.DataReceived += ProcessReceivedData;//简写
            //com.DataReceived += new SerialDataReceivedEventHandler(ProcessReceivedData);

            //富文本框显示接收到的数据
            ProcessDataEvent += (content) => { richTextBox_receive.AppendText(content); };

            //清空接受富文本框
            btn_clearReceive.Click += (sender, e) => richTextBox_receive.Clear();

            //清空接受富文本框
            btn_clearSend.Click += (sender, e) => richTextBox_send.Clear();

            //富文本框滚动到光标位置，始终显示最新数据
            richTextBox_receive.TextChanged += (sender,e) => 
            {
                richTextBox_receive.SelectionStart = richTextBox_receive.Text.Length;
                //滚动到光标位置
                richTextBox_receive.ScrollToCaret();
            };
        }

        //初始化串口配置
        private void InitialConfig()
        {
            cb_comName.Items.AddRange(SerialPort.GetPortNames());   //向cb中添加扫描到的串口名

            if (cb_comName.Items.Count > 0)
            {
                cb_comName.SelectedIndex = 0;                       //串口名默认选第一个
            }
            else
            {
                cb_comName.Text = "未扫描到串口";
            }

            cb_braudt.SelectedIndex = 5;                            //波特率
            cb_dataBits.SelectedIndex = 3;                          //数据位
            cb_stopBit.SelectedIndex = 0;                           //停止位
            cb_checkBit.SelectedIndex = 0;                          //校验位

            //com.Encoding = System.Text.Encoding.GetEncoding("UTF-8");
        }

        //串口有数据触发
        private void ProcessReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            
            byte[] ReadDatas = new byte[com.BytesToRead];               //开辟用于接收数据的空间

            com.Read(ReadDatas, 0, ReadDatas.Length);                   //从串口读取接收到的数据

            //接收到的数据的解码与显示
            if (checkBox_HexReceive.Checked == true)//16进制
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
                this.ProcessData(new UTF8Encoding().GetString(ReadDatas));//UTF-8编码
            }
        }

        //对话框显示数据
        private void ProcessData(string content)
        {
            if(ProcessDataEvent != null)//代理 事件非空的话
            {
                ProcessDataEvent(content);
            }

            //BeginInvoke(new MethodInvoker
            //    (
            //        delegate
            //        {
            //            richTextBox_receive.AppendText(content);
            //            double res;
            //            Double.TryParse(content, out res);
            //            //dc_rawData.Draw1P((float)res);

            //            //if(Q1.Count<1024)
            //            //{
            //            //    Q1.Enqueue((float)res);
            //            //}


            //            //if (Q1.Count >= 1024)
            //            //{
            //            //    float[] P1 = f.FftDirect(Q1.ToArray(), Q1.Count);

            //            //    //dyc_fouries.Draw_FFT(P1, Q1.Count / 2);

            //            //    Q1.Dequeue();
            //            //}
            //        }
            //    ));
        }

        //串口开关
        private void btn_openSerial_Click(object sender, EventArgs e)
        {
            if (cb_comName.Items.Count <= 0)
            {
                MessageBox.Show("未发现串口，请检查硬件设备或者驱动");
                return;
            }

            if (com.IsOpen == false)//未打开的话
            {
                //配置串口参数
                com.PortName = cb_comName.SelectedItem.ToString();
                com.BaudRate = Convert.ToInt32(cb_braudt.SelectedItem.ToString());

                com.Parity = (Parity)Convert.ToInt32(cb_checkBit.SelectedIndex);

                com.DataBits = Convert.ToInt32(cb_dataBits.SelectedItem.ToString());
                com.StopBits = (StopBits)Convert.ToInt32(cb_stopBit.SelectedItem.ToString());

                try//尝试开启串口
                {
                    com.Open();
                    btn_openSerial.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "未能成功打开串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btn_openSerial.Text = "关闭";
            }
            else
            {
                try//关闭串口
                {
                    com.Close();
                    btn_openSerial.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "串口关闭错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_openSerial.Text = "开启";
            }

            cb_comName.Enabled = !com.IsOpen;
            cb_braudt.Enabled = !com.IsOpen;
            cb_dataBits.Enabled = !com.IsOpen;
            cb_stopBit.Enabled = !com.IsOpen;
            cb_checkBit.Enabled = !com.IsOpen;
        }

        //将消息编码
        private void send_btn_click(object sender, EventArgs e)
        {
            if(richTextBox_send.Text.Length>0)
            {
                richTextBox_send.AppendText("\r\n");
            }

            byte[] sendData = null;

            string toSend = (richTextBox_send.Text).Trim();

            if(checkBox_HexSend.Checked==true)//16进制发送
            {
                sendData = StrToHexByte(toSend);
            }
            else
            {
                sendData = Encoding.UTF8.GetBytes(richTextBox_send.Text.Trim());
            }
            SendData(sendData);//发送
        }

        //编码后发送
        public bool SendData(byte [] data)
        {
            if(com.IsOpen==true)//已开串口
            {
                try
                {
                    com.Write(data, 0, data.Length);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//未打开
            {
                MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //16进制编码
        private byte [] StrToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");

            if ((hexString.Length % 2) != 0)
                hexString += " ";

            byte[] returnBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);

            return returnBytes;
        }

        //是否开启定时发送
        private void checkBox_timerSend_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_timerSend.Checked==true)//开启了定时发送
            {
                autoSendTimer.Interval = (int)numericUpDown_autoSend.Value;
                autoSendTimer.Enabled = true;

            }
            else
            {
                autoSendTimer.Enabled = false;
            }

        }

        //定时器 事件 处理
        private void autoSendTimerEnentProcess(object sender,EventArgs e)
        {
            try
            {
                this.send_btn_click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"串口未开启错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    };
}
