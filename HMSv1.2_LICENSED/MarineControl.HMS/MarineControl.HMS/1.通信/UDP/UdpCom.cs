using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarineControl.HMS.Communiction
{
    class UdpCom
    {
        #region 成员
        private IPEndPoint ipLocalPoint;
        private EndPoint RemotePoint;
        private Socket mySocket;
        private bool _RunningFlag = false;
        public bool RunningFlag
        {
            get { return _RunningFlag; }
            set { _RunningFlag = value; }
        }
        #endregion

        #region IP 与 port
        //本地IP
        private string _localIP= "192.168.204.1";
        public string localIP
        {
            get { return _localIP; }
            set { _localIP = value; }
        }
        //本地端口
        private string _localPort="8848";
        public string localPort
        {
            get { return _localPort; }
            set { _localPort = value; }
        }
        //远端IP
        private string _RemoteIP= "192.168.204.1";
        public string RemoteIP
        {
            get { return _RemoteIP; }
            set { _RemoteIP = value; }
        }
        //远端端口
        private string _RemotePort="9090";
        public string RemotePort
        {
            get { return _RemotePort; }
            set { _RemotePort = value; }
        }
        #endregion

        /// <summary>
        /// 获取udp数据事件
        /// </summary>
        /// <param name="udpData">获取的udp数据</param>
        public delegate void UdpCom_GetUdpDataHandler(string udpData);
        public event UdpCom_GetUdpDataHandler UdpCom_GetUdpDataEvent;

        /// <summary>
        /// 构造
        /// </summary>
        public UdpCom()
        {
            
        }

        /// <summary>
        /// 建立连接
        /// </summary>
        public void Connect()
        {
            //得到本机IP，设置UDP端口号     
            var ip = GetValidIP(localIP);
            var port = GetValidPort(localPort);
            ipLocalPoint = new IPEndPoint(ip, port);

            //定义网络类型，数据连接类型和网络协议UDP  
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //绑定网络地址  
            mySocket.Bind(ipLocalPoint);

            //得到客户机IP  
            ip = GetValidIP(RemoteIP);
            port = GetValidPort(RemotePort);
            IPEndPoint ipep = new IPEndPoint(ip, port);
            RemotePoint = (EndPoint)(ipep);

            //启动一个新的线程，执行方法this.ReceiveHandle，  
            //以便在一个独立的进程中执行数据接收的操作  
            RunningFlag = true;
            //thread_receive = new Thread(ReceiveUdp);
            //thread_receive.Start();
            Task.Factory.StartNew(ReceiveUdp);
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnet()
        {
            RunningFlag = false;
            mySocket.Close();
        }

        /// <summary>
        /// 获得本机局域网IP地址  
        /// </summary>
        /// <returns></returns>
        public string[] getIPAddress()
        {
            var hostName = Dns.GetHostName();
            var IpEntry = Dns.GetHostEntry(hostName);

            List<string> IPList = new List<string>();

            foreach (var item in IpEntry.AddressList)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork)
                    IPList.Add(item.ToString());
            }

            IPList.Add("127.0.0.1");
            IPList.Add("0.0.0.0");

            return IPList.ToArray();
        }

        /// <summary>
        /// 测试端口号是否有效
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        private int GetValidPort(string port)
        {
            int lport;
            //
            try
            {
                //是否为空  
                if (port == "")
                {
                    throw new ArgumentException("端口号无效，不能启动DUP");
                }
                lport = System.Convert.ToInt32(port);
            }
            catch (Exception e)
            {
                Console.WriteLine("无效的端口号：" + e.ToString());
                return -1;
            }
            return lport;
        }

        /// <summary>
        /// 测试IP是否有效  
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private IPAddress GetValidIP(string ip)
        {
            IPAddress lip = null;
            //
            try
            {
                //是否为空  
                if (!IPAddress.TryParse(ip, out lip))
                {
                    throw new ArgumentException("IP无效，不能启动DUP");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("无效的IP：" + e.ToString());
                return null;
            }
            return lip;
        }

        /// <summary>
        /// 接收
        /// </summary>
        public void ReceiveUdp()
        {
            try
            {
                while (RunningFlag)
                {
                    if (mySocket.Available <= 0)//无消息可获取，不执行接收
                        continue;

                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);//用来保存发送方的IP和端口号
                    byte[] buffer = new byte[2048];//消息缓存区申请
                    int length = mySocket.ReceiveFrom(buffer, ref point);//接收数据报

                    //显示在消息列表里
                    int i;
                    for (i = 0; i < buffer.Length && buffer[i] != 0; i++) { }
                    var msg = Encoding.UTF8.GetString(buffer, 0, i);

                    UdpCom_GetUdpDataEvent?.Invoke(msg);
                }
            }
            catch(Exception e)
            {
                throw new AggregateException("udp接收异常"+e.ToString());
            }

        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="msg2send">要通过udp发送的消息</param>
        public void Send(string msg2send)
        {
            //发送UDP数据包  
            byte[] data = Encoding.Default.GetBytes(msg2send);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);
        }
    }
}
