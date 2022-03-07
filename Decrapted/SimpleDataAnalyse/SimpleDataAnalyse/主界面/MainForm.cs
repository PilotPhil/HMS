using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

using serialCom;
using plot;

using HMS;
using HMS.LAYOUT;
using HMS.FATIGUE;

namespace SimpleDataAnalyse
{
    public partial class MainForm : MetroForm
    {
        Communication communication = new Communication();

        MyPlotWithData chartCurve = new MyPlotWithData();

        Fouries fft = new Fouries();

        FatigueDamage fatiDam = new FatigueDamage();


        MyLayout layout = new MyLayout();

        public MainForm()
        {
            InitializeComponent();

            layout.LoadForms2Panel(communication, this.mainPanel);
            layout.LoadForms2Panel(chartCurve, this.mainPanel);
            layout.LoadForms2Panel(fft, this.mainPanel);
            layout.LoadForms2Panel(fatiDam, this.mainPanel);

            communication.Show();

            communication.ProcessComData += (data) =>
              {
                  //接收到数据后在chart上显示
                  float dp;
                  if (float.TryParse(data, out dp))
                  {
                      chartCurve.Draw_Append1Drop1_WithTime(dp);
                      fft.FftDirect(dp);
                      double Dam;
                      fatiDam.Apply2(dp,out Dam);
                  }
              };
        }
        //通信
        private void button_com_Click(object sender, EventArgs e)
        {
            MovePanelBar(button_com);
            layout.SwitchFrom(communication);
        }

        //时域曲线
        private void button_chart_Click(object sender, EventArgs e)
        {
            MovePanelBar(button_chart);
            layout.SwitchFrom(chartCurve);
        }

        //fft
        private void button_fft_Click(object sender, EventArgs e)
        {
            MovePanelBar(button_fft);
            layout.SwitchFrom(fft);
        }

        //疲劳损伤
        private void button_fatigue_Click(object sender, EventArgs e)
        {
            MovePanelBar(button_Fatigue);
            layout.SwitchFrom(fatiDam);
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            MovePanelBar(button_filter);
            //HideOtherForms(mp);
        }



        //移动显示条
        private void MovePanelBar(Button btn)
        {
            this.panelBar.Location=new Point(panelBar.Location.X, btn.Location.Y);
        }


    }
}
