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

namespace serialCom
{
    public partial class Fouries : Form
    {
        Fft fft;

        int length;

        float[] p2;
        float[] p1;

        public Fouries(int length=1024)
        {
            InitializeComponent();

            fft = new Fft(length);//实例化指定长度的FFT

            this.length = length;//FFT的长度
        }

        public void FftDirect(float [] signal,int sigLength,int fs,out float [] x,out float [] y)
        {
            p2 = new float[sigLength];//双边谱
            p1 = new float[sigLength / 2];//单边谱

            if (sigLength<length)//长度不够 补零
            {
                float[] FixedSignal = new float[length];

                for(int i=0;i<sigLength;i++)
                {
                    FixedSignal[i] = signal[i];
                }

                for(int i=sigLength;i<length;i++)//补零
                {
                    FixedSignal[i] = 0;
                }

                fft.Direct(FixedSignal, p2);//进行FFT计算, 得到双边谱P2
            }
            else//长度相等的话
            {
                fft.Direct(signal, p2);//进行FFT计算, 得到双边谱P2
            }

            for(int i=0;i< length; i++)
            {
                p2[i] = Math.Abs(p2[i] / length);//双边谱
            }

            for(int i=0;i< length / 2;i++)
            {
                p1[i] = 2*p2[i];
            }

            y = p1;

            float[] xx = new float[p1.Length];
            int len = p1.Length;
            for(int i=0;i<len;i++)
            {
                xx[i] = fs*i/len;
            }

            x = xx;

        }
    }
}
