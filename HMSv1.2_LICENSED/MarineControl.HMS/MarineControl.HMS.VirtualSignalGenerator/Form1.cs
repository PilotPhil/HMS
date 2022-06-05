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

using MarineControl.HMS.Communiction;


namespace MarineControl.HMS.VirtualSignalGenerator
{
    public partial class Form1 : Form
    {
        SerialCom serialCom = new SerialCom();

        UdpForm udpForm = new UdpForm();

        Timer timerForFindPorts = new Timer();

        private int i = 0;

        bool isOnMointor;
        public Form1()
        {
            InitializeComponent();

            this.Text = "MarineControl.HMS.VirtualSignalGenerator";

            //
            CheckForIllegalCrossThreadCalls = false;

            //列自适应
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //////////////////////////////////////////////////////////////////////////////

            //设置自动查找可用端口的Timer
            timerForFindPorts.Interval = 1000;
            timerForFindPorts.Tick += new EventHandler(GetPorts);//超时后就查找端口
            //timerForFindPorts.Start();//开启timer

            cb_braudt.SelectedIndex = 5;                            //波特率
            cb_dataBits.SelectedIndex = 3;                          //数据位
            cb_stopBit.SelectedIndex = 0;                           //停止位
            cb_checkBit.SelectedIndex = 0;                          //校验位

            GetPorts();

            isOnMointor = false;

            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小

            LoadForm2Panel(udpForm, panel_udp);
        }

        /// <summary>
        /// 开始虚拟监测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_startMointor_Click(object sender, EventArgs e)
        {
            if(isOnMointor==false)//未开始监测的话，开始监测
            {
                foreach (var item in Sensor.sensorList)
                {
                    item.SensorDataEvent += GetData;
                }

                btn_startMointor.Text = "关闭虚拟监测";
                btn_startMointor.ForeColor = Color.Red;

                isOnMointor = true;
            }
            else
            {
                foreach (var item in Sensor.sensorList)
                {
                    item.SensorDataEvent -= GetData;
                }
                btn_startMointor.Text = "开启虚拟监测";
                btn_startMointor.ForeColor = Color.White;

                isOnMointor = false;
            }

        }

        /// <summary>
        /// 添加一个虚拟传感器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add1sensor_Click(object sender, EventArgs e)
        {
            Sensor Instance = new Sensor();

            var num = Sensor.instanceNum;

            DataGridViewRow row = new DataGridViewRow();
            int index = dataGridView1.Rows.Add(row);
            dataGridView1.Rows[index].Cells[0].Value = Sensor.instanceNum;
        }

        /// <summary>
        /// 获取数据，每一个传感器的事件会调用此函数
        /// </summary>
        public void GetData()
        {
            foreach (var item in Sensor.sensorList)
            {
                //double tem = (double)180 * Math.Sin(i) + (double)item.GetRandomData();
                double tem1 = (double)50 * Math.Sin(6.28 * i / 10000) + (double)item.GetRandomData();
                double tem2 = (double)60 * Math.Sin(18 * i / 10000) + (double)item.GetRandomData();
                double tem3 = (double)40 * Math.Sin(30 * i / 10000) + (double)item.GetRandomData();

                double tem = tem1 + tem2 + tem3;
                i++;
                if (i >= 10000)
                    i= 0;

                tem /= 210000;

                //dataGridView1.Rows[(int)item.ID - 1].Cells[1].Value = Math.Round(tem,2);
                dataGridView1.Rows[(int)item.ID - 1].Cells[1].Value = tem;

                var msg ="S"+"%"+Convert.ToString(item.ID)+"%"+item.name + "%" + tem.ToString()+"%"+"E";

                udpForm.SendMsg(msg);

                //serial.SendMsg(msg);
                if (serialCom.IsOpen==true)//当串口打开才发送
                {
                    serialCom.SendMsg(msg);
                }
            }
        }



        /*-----------------------------------串口通信-----------------------------------*/
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
            catch (Exception ex)
            {
                throw new AggregateException("串口配置异常", ex.InnerException);
            }
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
        /// 建立连接、断开连接 按钮 复用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openSerial_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen == false)//未开串口
            {
                timerForFindPorts.Stop();
                btn_openSerial.Text = "断开连接";
                label_IsOpen.Text = "已连接串口" + serialCom.portName;
                SetSerial();
                serialCom.OpenSerial();
            }
            else if (serialCom.IsOpen == true)
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



        public void LoadForm2Panel(Form frm, Panel objPanel, DockStyle ds = DockStyle.Fill)
        {
            frm.TopLevel = false;
            frm.TopMost = false;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为无边框

            objPanel.Controls.Add(frm);

            frm.Dock = ds;

            frm.Show();
        }
    }
}
