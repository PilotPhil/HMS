using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace serialCom
{
    public partial class MainForm : MetroForm
    {
        serial ser;//串口对象
        Fouries fft;//快速傅里叶变换对象

        Queue<float> Q1 = new Queue<float>();

        public MainForm()
        {
            InitializeComponent();

            ser = new serial();
            //dct = new DCharts(100);
            fft = new Fouries(4096);//长度为1024的傅里叶变换
            oxyplot op = new oxyplot();
            oxyplot2 op_fft = new oxyplot2();


            ser.ProcessDataEvent += (content) => 
            {
                float dp;
                if(float.TryParse(content,out dp))
                    op.Draw_Append1Drop1_WithTime(dp);
            };

            ser.ProcessDataEvent += (content) =>
            {
                float dp;
                if (float.TryParse(content, out dp))
                {
                    Q1.Enqueue(dp);

                    if (Q1.Count >= 4096)
                    {
                        float[] x;
                        float[] y;

                        fft.FftDirect(Q1.ToArray(), Q1.Count, 2048, out x, out y);

                        op_fft.Draw_Append1Drop1_X_Y(x.ToList(), y.ToList());

                        Q1.Dequeue();
                    }
                }
            };

            AddForm2Panel(ser, DockStyle.Fill, panel_serial);
            AddForm2Panel(op, DockStyle.Fill, panel_rawDataChart);
            AddForm2Panel(op_fft, DockStyle.Fill,panel_fft);
        }

        //将子form加入到主form中的panel中
        private void AddForm2Panel(Form f,DockStyle ds,Panel p)
        {
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = ds;
            f.Parent = p;
            f.Show();
        }
    }
}
