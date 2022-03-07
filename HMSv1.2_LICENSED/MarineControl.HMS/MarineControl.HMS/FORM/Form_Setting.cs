using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.Communiction;
using MarineControl.HMS.Layout;
using MarineControl.HMS;
using HZH_Controls.Forms;

namespace MarineControl.HMS.FORM
{
    public partial class Form_Setting : Form
    {
        //布局对象
        MyLayout ly = new MyLayout();
        //串口通讯
        SerialForm serialForm = new SerialForm();
        //udp通讯
        UdpForm udpForm = new UdpForm();

        //串口通讯
        SerialForm serialForm2 = new SerialForm();
        //udp通讯
        UdpForm udpForm2 = new UdpForm();

        //通讯方式combox
        private List<KeyValuePair<string, string>> comWay = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string,string>("0","udp"),
            new KeyValuePair<string,string>("1","serial")
        };

        //获取到传感器数据流
        public delegate void GotSensorsDataFlowHandler(string dataMsg);
        public GotSensorsDataFlowHandler GotSensorsDataFlowEvent;


        //通道解析
        ChannelParise cp = ChannelParise.GetInstance();
        //传感器列表
        //
        List<int> sensorIdList = new List<int>();

        public delegate void GetSensorDataHandler(int id, double value);
        public GetSensorDataHandler GetSensorDataEvent;


        public Form_Setting()
        {
            InitializeComponent();

            //通讯
            ComInit();
            ComDelegate();

            //解析
            PariseDelegate();
        }

        #region 通讯设置

        /// <summary>
        /// 通讯初始化
        /// </summary>
        private void ComInit()
        {
            //加载form
            ly.LoadForms2Panel(udpForm, panel_com);
            ly.LoadForms2Panel(serialForm, panel_com);
            udpForm.Show();

            ly.LoadForms2Panel(udpForm2, panel_com2);
            ly.LoadForms2Panel(serialForm2, panel_com2);
            udpForm2.Show();

            //先禁用serial通讯
            serialForm.Enabled = false;
            udpForm.Enabled = true;

            //初始为udp
            cb_comMode.Source = comWay;
            cb_comMode.SelectedIndex = 0;

            cb_comMode2.Source = comWay;
            cb_comMode2.SelectedIndex = 0;

            udpForm.CanOpen = true;

            udpForm.GotUdpDataEvent += TransmitMsg_Udp;
        }

        /// <summary>
        /// 通讯开关
        /// </summary>
        public void SwitchCom()
        {
            var mode = cb_comMode.SelectedIndex;
            
            switch(mode)
            {
                case 0:udpForm.Switch();break;
                case 1:serialForm.Switch();break;
                default:break;
            }
        }

        /// <summary>
        /// 通讯配置中事件注册
        /// </summary>
        private void ComDelegate()
        {
            //列自适应
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //切换通讯方式
            cb_comMode.SelectedChangedEvent += (s, e) =>
              {
                  var mode = cb_comMode.SelectedIndex;
                  switch(mode)
                  {
                      case 0://udp
                          FrmTips.ShowTipsInfo(new Form(), DateTime.Now.ToString() + "\n" + "切换到UDP通讯");//临时方法
                          ly.SwitchFrom(udpForm);

                          udpForm.Enabled = true;
                          udpForm.CanOpen = true;
                          serialForm.Enabled = false;
                          serialForm.CanOpen = false;

                          udpForm.GotUdpDataEvent += TransmitMsg_Udp;
                          serialForm.GotSerialDataEvent -= TransmitMsg_Serial;
                          break;
                      case 1://serial
                          FrmTips.ShowTipsInfo(new Form(), DateTime.Now.ToString() + "\n" + "切换到串口通讯");
                          ly.SwitchFrom(serialForm);

                          udpForm.Enabled = false;
                          udpForm.CanOpen = false;
                          serialForm.Enabled = true;
                          serialForm.CanOpen = true;

                          udpForm.GotUdpDataEvent -= TransmitMsg_Udp;
                          serialForm.GotSerialDataEvent += TransmitMsg_Serial;
                          break;
                      default:
                          break;
                  }
              };
        }

        //转发收到的消息
        private void TransmitMsg_Udp(string msg)
        {
            GotSensorsDataFlowEvent?.Invoke(msg);
        }
        private void TransmitMsg_Serial(string msg)
        {
            GotSensorsDataFlowEvent?.Invoke(msg);
        }
        #endregion

        #region 解析
        private void PariseDelegate()
        {
            //解析注册
            GotSensorsDataFlowEvent += (msg) =>
              {
                  int id;
                  double value;
                  //通道解析，得到传感器ID和value
                  if (cp.Parise(msg, out id, out value) == false)//解析出错
                      return;

                  if (sensorIdList.Contains(id) == false)//若列表中未包含
                  {
                      sensorIdList.Add(id);
                      var index = dataGridView1.Rows.Add(new DataGridViewRow());
                      dataGridView1.Rows[index].Cells[0].Value = id;
                      dataGridView1.Rows[index].Cells[1].Value = "sensor"+id.ToString();
                  }
                  //按照传感器id的压入数据点到datalist，当timer超时时触发每多少分钟处理一次
                  GetSensorDataEvent?.Invoke(id, value);
              };

            //更改解析规则
            tb_rule.TextChanged += (s, e) => { cp.ChangeRule(tb_rule.txtInput.ToString()); };
        }
        #endregion

    }
}
