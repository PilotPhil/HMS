using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.Sensor;
using MarineControl.HMS.Cfg;

using HZH_Controls.Controls;
using MarineControl.HMS.Plot;
using MarineControl.HMS.Layout;

using System.Windows.Forms.DataVisualization.Charting;

namespace MarineControl.HMS.FORM
{

    public partial class Form_Sensors : Form
    {
        AlarmStateColor alarmColor = new AlarmStateColor();

        public SensorForm sf1 = new SensorForm();
        public SensorForm sf2 = new SensorForm();
        public SensorForm sf3 = new SensorForm();
        public SensorForm sf4 = new SensorForm();
        public SensorForm sf5 = new SensorForm();
        public SensorForm sf6 = new SensorForm();

        //是否会压入数据点
        private bool _isOnPushing =false;
        public bool isOnPushing
        {
            get { return _isOnPushing; }
            set { _isOnPushing = value; }
        }

        public delegate void SendSensorCfg2TableHandler(int id, string[] cfg);
        public SendSensorCfg2TableHandler SendSensorCfg2TableEvent;

        //继续发送alarm警报信息到mainform
        public delegate void ReSendSensorAlarm_Handler(string time, int sensorId, string type, double value);
        public ReSendSensorAlarm_Handler ReSendSensorAlarm_Event;

        private MyLayout ly = new MyLayout();

        public Form_Sensors()
        {
            InitializeComponent();

            sf1.SetTitle("1 号传感器详览");
            sf2.SetTitle("2 号传感器详览");
            sf3.SetTitle("3 号传感器详览");
            sf4.SetTitle("4 号传感器详览");
            sf5.SetTitle("5 号传感器详览");
            sf6.SetTitle("6 号传感器详览");

            //点击查看传感器详细情况
            s1Lamp.Click += (object sender,EventArgs e) => {  sf1.Show();  };
            s2Lamp.Click += (object sender,EventArgs e) => {  sf2.Show();  };
            s3Lamp.Click += (object sender,EventArgs e) => {  sf3.Show();  };
            s4Lamp.Click += (object sender,EventArgs e) => {  sf4.Show();  };
            s5Lamp.Click += (object sender,EventArgs e) => {  sf5.Show();  };
            s6Lamp.Click += (object sender,EventArgs e) => {  sf6.Show();  };

            sf1.SendSensorCfg_sensorForm_Event += SendSensorCfg;
            sf2.SendSensorCfg_sensorForm_Event += SendSensorCfg;
            sf3.SendSensorCfg_sensorForm_Event += SendSensorCfg;
            sf4.SendSensorCfg_sensorForm_Event += SendSensorCfg;
            sf5.SendSensorCfg_sensorForm_Event += SendSensorCfg;
            sf6.SendSensorCfg_sensorForm_Event += SendSensorCfg;

            //设置表的线种类为spline样条曲线
            waveChart.SetSeriesType(SeriesChartType.Column,5);
            swChart.SetSeriesType(SeriesChartType.Column,5);

            waveChart.SetAxisTitle("测点","波浪弯矩");
            swChart.SetAxisTitle("测点","静水弯矩");

            //计时器超时操作
            timerForWaveMoment.Elapsed += (s, e) => 
            { 
                ClacuteWBM();
                CalcuteSWBM();
            };
            timerForWaveMoment.Start();
            //装载开始按钮
            button_sw.Click += (s, e) => 
            { 
                loadFlag = !loadFlag;
                if (loadFlag)
                    button_sw.Text = "停止装载";
                else
                    button_sw.Text = "开始装载";
            };
            ly.LoadForm2Panel(waveChart, panel_waveMoment);
            ly.LoadForm2Panel(swChart, panel_staticMoment);
            swChart.SetLegend("静水弯矩");
            waveChart.SetLegend("波浪弯矩");

            //接续发送alarm报警信息
            sf1.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
            sf2.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
            sf3.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
            sf4.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
            sf5.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
            sf6.SendSensorAlarm_Event += (time, id, type, value) => ReSendSensorAlarm_Event?.Invoke(time, id, type, value);
        }

        private void SendSensorCfg(int id,string[] cfg)
        {
            SendSensorCfg2TableEvent?.Invoke(id, cfg);
        }

        int i = 0;
        int calibration = 16;
        /// <summary>
        /// 按传感器ID 压入传感器值
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strain"></param>
        public void PushSensorIdValue(int id, double strain)
        {
            //停止压入 返回
            if (isOnPushing == false)
                return;

            //var stress = strain * 210000;//原来软件需要
            var stress = strain*200;//海航器比赛直接发送应力，不需要

            var strength = GetLongitudinalStrength(stress);
            if (strength!=-1)
            {//总纵强度更新到ui
                tb_lstrength.InputText = Math.Round(strength,3).ToString() + "MPa";
            }

            if(id!=6)
            {
                strainList[id - 1] = strain;
                
                if(i%2==0)
                    strainList2[id - 1] = strain;
            }
            i++;
                
            switch (id)
            {
                case 1: 
                    sf1.PrepareData(stress);
                    alarmColor.SetLampColor(s1Lamp, stress);
                    break;
                case 2: 
                    sf2.PrepareData(stress);
                    alarmColor.SetLampColor(s2Lamp, stress);
                    break;
                case 3: 
                    sf3.PrepareData(stress);
                    alarmColor.SetLampColor(s3Lamp, stress);
                    break;
                case 4: 
                    sf4.PrepareData(stress);
                    alarmColor.SetLampColor(s4Lamp, stress);
                    break;
                case 5: 
                    sf5.PrepareData(stress);
                    alarmColor.SetLampColor(s5Lamp, stress);
                    break;
                case 6:
                    sf6.PrepareData(stress);
                    alarmColor.SetLampColor(s6Lamp, stress);
                    break;
                default: break;
            }
        }

        public void SaveSensorCfgFrom1(int id,string[] cfg)
        {
            switch (id)
            {
                case 1: sf1.UpdateSensorParams(cfg); break;
                case 2: sf2.UpdateSensorParams(cfg); break;
                case 3: sf3.UpdateSensorParams(cfg); break;
                case 4: sf4.UpdateSensorParams(cfg); break;
                case 5: sf5.UpdateSensorParams(cfg); break;
                case 6: sf6.UpdateSensorParams(cfg); break;
                default: break;
            }
        }

        //存储各传感器值列表，用于计算总纵强度
        List<double> sValList = new List<double>();
        /// <summary>
        /// 计算总纵强度
        /// </summary>
        /// <param name="val">各传感器值</param>
        /// <returns></returns>
        private double GetLongitudinalStrength(double val)
        {
            sValList.Add(val);

            if(sValList.Count>=600)
            {
                var tem= sValList.Max();
                sValList.Clear();

                return tem;
            }
            else
            {
                return -1;
            }
        }

        //静水弯矩用图表
        MyChart swChart = new MyChart();
        //是否计算静水弯矩flag  即 是否在装载flag
        bool loadFlag = false;
        //波浪弯矩用图表
        MyChart waveChart = new MyChart();
        //应变list
        double[] strainList = new double[5];
        double[] strainList2 = new double[5];
        //惯性矩list
        double[] Ix = new double[5] {46073.94*0.6, 46073.94 * 0.7, 46073.94 * 0.8, 46073.94 * 0.72, 46073.94 * 0.5 };
        //距离惯性矩距离y
        double[] y = new double[5] { 2.51 * 0.6, 2.51 * 0.7, 2.51 * 0.8, 2.51 * 0.72, 2.51 * 0.5 };
        //杨氏模量
        private double E = 210;//GPa
        //计算波浪弯矩的timer
        System.Timers.Timer timerForWaveMoment = new System.Timers.Timer(2500);//间隔为2s
        //x轴
        double[] axisX = new double[5] { 1, 2, 3, 4, 5 };
        Random r_tem = new Random();
        /// <summary>
        /// 计算静水弯矩
        /// </summary>
        private void CalcuteSWBM()
        {
            if (loadFlag == false)
                return;

            var delta = new double[5];
            for (int i = 0; i < 5; i++)
            {
                delta[i] = strainList2[i] - strainList[i];
                delta[i] = Math.Round(delta[i] * 210 * 10 * Ix[i] / y[i]);
            }
            this.swChart.Draw<double>(axisX, delta);

            //var max = strainList.Max();
            //var tem = new double[5];
            //tem[0] = Math.Round(max * (float)(1 - r_tem.Next(30, 40) / 100));
            //tem[1] = Math.Round(max * (float)(1 - r_tem.Next(20, 30) / 100));
            //tem[2] = Math.Round(max * (float)(1 - r_tem.Next(20, 30) / 100));
            //tem[3] = Math.Round(max * (float)(1 - r_tem.Next(24, 35) / 100));
            //tem[4] = Math.Round(max * (float)(1 - r_tem.Next(27, 45) / 100));

            //this.swChart.Draw<double>(axisX, tem);
        }

        /// <summary>
        /// 计算波浪弯矩
        /// </summary>
        private void ClacuteWBM()
        {
            var tem = new double[5];
            for(int i=0;i<5;i++)
            {
                tem[i] =Math.Round(strainList[i] * 210*10 * Ix[i] / y[i]);//计算波浪弯矩
            }
            //绘图更新
            this.waveChart.Draw<double>(axisX,tem);
        }
    }

    /// <summary>
    /// 颜色类
    /// </summary>
    public class AlarmStateColor
    {
        public Color class1 = new Color();//正常
        public Color class2 = new Color();//一级报警
        public Color class3 = new Color();//二级报警
        public Color class4 = new Color();//未使用
        public Color class5 = new Color();//传感器故障

        IniFileHelper IH = new IniFileHelper();

        //应力等级点
        static private double v1;
        static private double v2;
        static private double v3;
        static private double v4;
        static private double v5;

        private double[] valueRange = new double[5] { v1, v2, v3, v4, v5 };


        /// <summary>
        /// 构造
        /// </summary>
        public AlarmStateColor()
        {
            v1 = Convert.ToInt32(IH.Read("stressClass", "v1"));
            v2 = Convert.ToInt32(IH.Read("stressClass", "v2"));
            v3 = Convert.ToInt32(IH.Read("stressClass", "v3"));
            v4 = Convert.ToInt32(IH.Read("stressClass", "v4"));
            v5 = Convert.ToInt32(IH.Read("stressClass", "v5"));

            class1 = Color.Blue;//等级颜色 参考 气象预警信号
            class2 = Color.Yellow;
            class3 = Color.Orange;
            class4 = Color.Red;
            class5 = Color.Black;
        }
        
        /// <summary>
        /// 获取应力等级
        /// </summary>
        /// <param name="classIndex"></param>
        /// <returns></returns>
        private int CheckClass(double sVal,out Color lampColor)
        {
            int rank=0;//等级

            for (int i = 0; i < valueRange.Length; i++)
            {
                if(i<valueRange.Length-1)//
                {
                    var fore = valueRange[i];
                    var afte = valueRange[i + 1];

                    if (fore <= sVal && sVal < afte)//校验是否在范围内
                    {
                        rank = i + 1;
                        break;
                    }
                }
                else//当索引到最后一个等级点
                {
                    var last = valueRange[i];
                    if(sVal>=last)
                    {
                        rank = i + 1;
                        break;
                    }
                }
            }

            //返回颜色
            switch(rank)
            {
                case 1:lampColor = class1;break;
                case 2:lampColor = class2;break;
                case 3:lampColor = class3;break;
                case 4:lampColor = class4;break;
                case 5:lampColor = class5;break;
                default:lampColor = class1;break;
            }

            return rank;
        }

        public void SetLampColor(UCAlarmLamp objLamp,double sVal)
        {
            Color color;
            CheckClass(sVal, out color);

            if (color != null)
                objLamp.LampColor[0] = color;
        }
    }



}
