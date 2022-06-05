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
    public partial class MyChart : Form
    {
        public MyChart()
        {
            InitializeComponent();

            chart1.Series[0].IsValueShownAsLabel = true;

            chart1.Series[0]["PointWidth"] = "0.4";
        }

        /// <summary>
        /// 设置图表类型
        /// </summary>
        /// <param name="type"></param>
        /// <param name="seriesIndex"></param>
        public void SetSeriesType(SeriesChartType type,int borderWidth,int seriesIndex=0)
        {
            if (seriesIndex > chart1.Series.Count)
                return;

            chart1.Series[0].ChartType = type;

            chart1.Series[0].BorderWidth = borderWidth;
        }

        /// <summary>
        /// 绘图
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x">x轴</param>
        /// <param name="y">y轴</param>
        /// <param name="seriesIndex">要更新的曲线序列索引</param>
        public void Draw<T>(T[] x,T[] y,int seriesIndex=0)
        {
            if (x == null || y == null)
                return;

            int len = Math.Min(x.Length, y.Length);

            if (len <= 0)
                return;

            var objSeries = chart1.Series[seriesIndex];

            objSeries.Points.Clear();//先清空原有的点

            for(int i=0;i<len;i++)
                objSeries.Points.AddXY(x[i], y[i]);

            objSeries.Points.ResumeUpdates();
        }

        public void SetLegend(string legend)
        {
            chart1.Series[0].Name = legend;
        }

        public void SetAxisTitle(string xTitle,string yTitle)
        {
            chart1.ChartAreas[0].AxisX.Title = xTitle;
            chart1.ChartAreas[0].AxisY.Title = yTitle;
        }

    }
}
