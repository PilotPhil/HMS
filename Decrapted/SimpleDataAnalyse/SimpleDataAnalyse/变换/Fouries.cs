using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NWaves.Transforms;
using NWaves.Windows;
using NWaves.Signals;
using NWaves.Signals.Builders;

using plot;

using HMS.LAYOUT;

namespace serialCom
{
    public partial class Fouries : Form
    {
        private Fft fft;//傅里叶变换对象

        public int fftSize;
        public int sampleRate;

        private float[] p2;//双边普
        private float[] p1;//单边普

        Queue<float> data2fft = new Queue<float>();

        oxyplotLiner chartFft = new oxyplotLiner();

        public Fouries()
        {
            InitializeComponent();

            var layout = new MyLayout();
            layout.LoadForm2Panel(chartFft, panel_fftChart);

            SetFFT(2048);

            chartFft.SetFFTParaEvent += this.SetFFT;//注册事件
        }

        //设置FFT长度以及采样率
        public void SetFFT(int len=256,int sampleRate=2048)
        {
            if((len>0) && (len & (len-1))!=0)
            {
                MessageBox.Show("FFT长度应该为2的幂次且大于零", "设置失败", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (sampleRate <= 0)
            {
                MessageBox.Show("采样率应该大于零", "设置失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            this.fftSize = len;
            this.sampleRate = sampleRate;
            
            fft = new Fft(len);
        }

        //为fft准备数据（补零等等）
        private float[] PrepareData2FFT(float  data)
        {
            data2fft.Enqueue(data);

            if (data2fft.Count > fftSize)//大于fft长度 就从头删除直到相等
                while (data2fft.Count > fftSize)
                    data2fft.Dequeue();

            //开始补零
            float[] signal = new float[fftSize];

            for (int i = 0; i < data2fft.Count; i++)
                signal[i] = data2fft.ElementAt(i);

            if (data2fft.Count<fftSize)
                for(int i=data2fft.Count;i<fftSize;i++)
                    signal[i] = 0;

            return signal;
        }

        public void FftDirect(float[] data)
        {
            p2 = new float[fftSize];//双边谱
            p1 = new float[fftSize / 2];//单边谱

            if(data.Length==fftSize)
            {
                fft.Direct(data, p2);//进行FFT计算, 得到双边谱P2

                for (int i = 0; i < fftSize; i++)
                    p2[i] = Math.Abs(p2[i] / fftSize);//双边谱

                for (int i = 0; i < fftSize / 2; i++)
                    p1[i] = 2 * p2[i];

                int len = p1.Length;
                float[] xx = new float[len];
                for (int i = 0; i < len; i++)
                    xx[i] = this.sampleRate * i / len;

                chartFft.Draw_Append1Drop1_X_Y(xx.ToList(), p1.ToList());
            }
        }

        public void FftDirect(float data)
        {
            float [] signal=PrepareData2FFT(data);

            p2 = new float[fftSize];//双边谱
            p1 = new float[fftSize / 2];//单边谱

            fft.Direct(signal, p2);//进行FFT计算, 得到双边谱P2

            for (int i=0;i< fftSize; i++)
                p2[i] = Math.Abs(p2[i] / fftSize);//双边谱

            for(int i=0;i< fftSize / 2;i++)
                p1[i] = 2*p2[i];

            int len = p1.Length;
            float[] xx = new float[len];
            for(int i=0;i<len;i++)
                xx[i] = this.sampleRate*i/len;

            chartFft.Draw_Append1Drop1_X_Y(xx.ToList(), p1.ToList());
        }

        private void LoadForm(Form frm, Panel objPanel, DockStyle ds = DockStyle.Fill)
        {
            frm.TopLevel = false;
            frm.TopMost = false;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为无边框

            objPanel.Controls.Clear();//清除原有的

            objPanel.Controls.Add(frm);//添加

            frm.Dock = ds;//设置dock属性

            frm.Show();//使显示
        }
    }
}
