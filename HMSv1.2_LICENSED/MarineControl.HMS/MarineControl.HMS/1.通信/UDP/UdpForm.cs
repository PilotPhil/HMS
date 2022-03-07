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
        public bool CanOpen = false;

        UdpCom udp = new UdpCom();

        public delegate void GotUdpDataHandler(string udpData);
        public event GotUdpDataHandler GotUdpDataEvent;

        public UdpForm()
        {
            InitializeComponent();

            GetLocalIP();

            CheckForIllegalCrossThreadCalls = false;//

            cb_localIp.SelectedIndex = 0;
            cb_objIp.SelectedIndex = 0;

            udp.UdpCom_GetUdpDataEvent += (msg)=>GotUdpData(msg);
        }

        /// <summary>
        /// udp建立连接后，禁用改变连接参数
        /// </summary>
        /// <param name="can"></param>
        private void EnableChange(bool can)
        {
            cb_localIp.Enabled = can;
            cb_objIp.Enabled = can;
            tb_localPort.Enabled = can;
            tb_objPort.Enabled = can;
        }

        /// <summary>
        /// 开启、关闭 连接 复用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Switch()
        {
            if (CanOpen == false)
                return;

            //未连接，要连接
            if (udp.RunningFlag == false)
            {
                udp.localIP = cb_localIp.SelectedText;
                udp.localPort = tb_localPort.txtInput.Text;

                udp.RemoteIP = cb_objIp.SelectedText;
                udp.RemotePort = tb_objPort.txtInput.Text;

                udp.Connect();

                EnableChange(false);
            }
            else//已连接，要断开
            {
                udp.Disconnet();
                EnableChange(true);
            }
        }

        List<KeyValuePair<string, string>> ipList = new List<KeyValuePair<string, string>>();
        /// <summary>
        /// 获取IP到combox
        /// </summary>
        private void GetLocalIP()
        {
            var _ipList=udp.getIPAddress();

            for(int i=0;i<_ipList.Length;i++)
            {
                ipList.Add(new KeyValuePair<string, string>(i.ToString(), _ipList[i]));
            }

            cb_localIp.Source = ipList;
            cb_objIp.Source=ipList;
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="msg2send"></param>
        public void SendMsg(string msg2send)
        {
            if (udp.RunningFlag == false)
                return;

            udp.Send(msg2send);
        }

        private void GotUdpData(string msg)
        {
            if (GotUdpDataEvent != null)
                GotUdpDataEvent(msg);
        }

    }
}
