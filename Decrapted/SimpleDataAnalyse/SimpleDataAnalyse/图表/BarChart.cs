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

namespace Chart
{
    public partial class BarChart : Form
    {
        public BarChart()
        {
            InitializeComponent();
        }

        public void Draw(int[] x,int[] y)
        {
            chart1.Series.Clear();

            Series Strength = new Series("应力响应");  //new 一个叫做【Strength】的系列

            Strength.ChartType = SeriesChartType.Column;  //设置chart的类型，这里为柱状图
            Strength.IsValueShownAsLabel = true; //把值当做标签展示（默认false）
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0;  //设置网格间隔（这里设成0.5，看得更直观一点）

            ////chart1.ChartAreas[0].AxisX.Maximum = 100;//设定x轴的最大值
            //chart1.ChartAreas[0].AxisY.Maximum = 100;//设定y轴的最大值
            //chart1.ChartAreas[0].AxisX.Minimum = 0;//设定x轴的最小值
            //chart1.ChartAreas[0].AxisY.Minimum = 0;//设定y轴的最小值

            chart1.ChartAreas[0].AxisY.Interval = 10; //设置Y轴每个刻度的跨度


            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            for (int i = 0; i < x.Length; i++)
            {
                Strength.Points.AddXY(x[i], y[i]);
            }
            //把series添加到chart上
            chart1.Series.Add(Strength);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int[] x = new int[] { 2, 5, 8, 11, 14 };
        //    int[] y = new int[] { 5, 3, 9, 12, 5 };

        //    draw(x,y);
        //}

    }

}
