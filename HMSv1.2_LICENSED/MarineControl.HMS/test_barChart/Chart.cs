using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MarineControl.HMS.Plot
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        public void Draw<T>(T[] x,T[] y,Series objSeries)
        {
            if (x.Length != y.Length)//若x和y轴长度不一致
                return;

            objSeries.Points.Clear();//先清空原有的点
            var len = x.Length;

            for(int i=0;i<len;i++)
            {
                objSeries.Points.AddXY(x[i], y[i]);
            }

            objSeries.Points.ResumeUpdates();
        }
    }
}
