using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NWaves.Filters;
using NWaves.Filters.Base;
using NWaves.Filters.Fda;
using NWaves.Signals;

using serialCom;

namespace SimpleDataAnalyse
{
    public partial class Form1 : Form
    {
        Fouries fft = new Fouries();

        public Form1()
        {
            InitializeComponent();

            LoadForm(fft, panel1);

            //待滤波数据
            var data = new List<float>();
            for (int i = 0; i < 2048; i++)
            {
                var temp = 50 * Math.Sin(Math.PI * 10 * i) + 200 * Math.Sin(Math.PI * 30 * i);
                data.Add((float)temp);
            }

            var data1 = new List<float>();
            for (int i = 0; i < 2048; i++)
            {
                var temp = 50 * Math.Sin(Math.PI * 10 * i);
                data1.Add((float)temp);
            }
            foreach (float i in data1)
                richTextBox3.AppendText(i.ToString() + "\n");


            foreach (float i in data)
                richTextBox1.AppendText(i.ToString() + "\n");

            //fft.SetFFT(2048);
            foreach(float f in data)
                fft.FftDirect(f);

            //低通滤波器核
            double[] lpKernel = DesignFilter.FirWinLp(21, 20*Math.PI/2048);
            //低通滤波器
            var lpFilter = new FirFilter(lpKernel);

            //构造信号
            var signal = new DiscreteSignal(2048, data);
            //滤波
            var res=lpFilter.ApplyTo(signal);

            foreach (float i in res.Samples)
                richTextBox2.AppendText(i.ToString() + "\n");
        }

        //加载form
        private void LoadForm(Form frm, Panel objPanel, DockStyle ds = DockStyle.Fill)
        {
            frm.TopLevel = false;
            frm.TopMost = false;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为无边框

            //objPanel.Controls.Clear();//清除原有的
            objPanel.Controls.Add(frm);//添加

            frm.Dock = ds;//设置dock属性

            frm.Show();//使显示
            //formList.Add(frm);
        }
    }
}
