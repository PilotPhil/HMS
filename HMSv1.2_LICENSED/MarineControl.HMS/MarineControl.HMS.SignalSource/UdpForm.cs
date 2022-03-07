using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.Communiction
{
    public partial class UdpForm : Form
    {
        UdpCom udp = new UdpCom();

        public UdpForm()
        {
            InitializeComponent();

            GetLocalIP();

            CheckForIllegalCrossThreadCalls = false;//

            cb_localIp.SelectedIndex = 0;
            cb_objIp.SelectedIndex = 0;

            udp.ProcessUDPDataEvent += (msg) => { tb_receive.AppendText(msg); };
        }

        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //未连接，要连接
            if(udp.RunningFlag==false)
            {
                udp.localIP = cb_localIp.SelectedItem.ToString();
                udp.localPort = tb_localPort.Text;

                udp.RemoteIP = cb_objIp.SelectedItem.ToString();
                udp.RemotePort = tb_objPort.Text;

                udp.Connect();

                btn_connect.Text = "断开连接";
            }
            else//已连接，要断开
            {
                udp.Disconnet();

                btn_connect.Text = "建立连接";
            }
        }
        
        /// <summary>
        /// 获取IP到combox
        /// </summary>
        private void GetLocalIP()
        {
            var ipList=udp.getIPAddress();
            cb_localIp.Items.AddRange(ipList);
            cb_objIp.Items.AddRange(ipList);
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            var msg2send = tb_send.Text;
            udp.Send(msg2send);
        }
    }
}
