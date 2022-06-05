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

namespace serialCom
{
    public partial class DCharts : Form
    {
        List<float> data;

        private ChartArea chartArea;//绘制区域

        Series series;

        public bool axisYAutoAdjust;//是否自动调整Y轴范围

        Random r;

        private int len;


        //构造
        public DCharts(int len=100)
        {
            InitializeComponent();

            this.len = len;

            data = new List<float>();

            axisYAutoAdjust = true;

            series = chart.Series[0];            //选择序列0

            series.YValueType = ChartValueType.Int32;   //设置轴显示整型
            series.XValueType = ChartValueType.Int32;

            series.ChartType = SeriesChartType.Line;    // 画样条曲线（Spline）(折线)
            series.BorderWidth = 1;                     // 线宽2个像素
            series.Color = System.Drawing.Color.Blue;   // 线的颜色：红色          
            series.IsVisibleInLegend = false;           //隐藏图例   

            chartArea = chart.ChartAreas[0];            // 设置显示范围

            chartArea.AxisX.Minimum = 1;               //X轴范围
            chartArea.AxisX.Maximum = len;

            chartArea.AxisY.Minimum = -100;            //Y轴范围
            chartArea.AxisY.Maximum = 100d;
        }

        //调整轴范围
        public void SetAxisRange(double min, double max)
        {
            if (min > max)//范围大小错误
            {
                MessageBox.Show("min应小于max");
                return;
            }
            chartArea.AxisY.Minimum = min;
            chartArea.AxisY.Maximum = max;
        }

        //自动调整Y轴范围，扩大百分之percent的范围，0<=percent<=1
        private void AutoYAxis(double percent=0.2)
        {
            if (axisYAutoAdjust == false)
                return;

            if (percent < 0 | percent > 1)
                percent = 0;

            double min = data.Min();
            double max = data.Max();

            if(chartArea.AxisY.Minimum.CompareTo(min)>0)
                chartArea.AxisY.Minimum = min - percent * Math.Abs(min);

            if (chartArea.AxisY.Maximum.CompareTo(min) < 0)
                chartArea.AxisY.Maximum = max + percent * Math.Abs(max);
        }

        //增加绘制 Y
        private void DrawAllY(List<float> Y, Series seriesInChart)
        {
            if (Y.Count <= 0)
                return;

            seriesInChart.Points.Clear();

            for (int i = 0; i < Y.Count; i++)
                seriesInChart.Points.AddY(Y.ElementAt(i));
        }

        //增加绘制 X Y
        private void DrawAllXY(List<float> X, List<float> Y,Series seriesInChart)
        {
            if (X.Count!=Y.Count | X.Count<=0 | Y.Count<=0)//坐标点xy坐标长度不匹配直接结束
                return;

            seriesInChart.Points.Clear();

            for (int i=0;i<X.Count;i++)
                seriesInChart.Points.AddXY(X.ElementAt(i), Y.ElementAt(i));
        }

        //绘制刷新(增加一个点)
        //public void Draw<T>(T dataPoint)
        //{
        //    float dp=0;                                           //

        //    if(dataPoint is string)
        //        if(float.TryParse(dataPoint.ToString(), out dp) == false)//string 2 float
        //            return;
        //    else
        //        dp = (float)Convert.ToDouble(dataPoint);

        //    if (chartDataFlow.Count > 100)                    //长度大于100的话 axis_x_max - axis_x_min
        //        chartDataFlow.Dequeue();                        //移除并返回位于 Queue<T> 开始处的对象。

        //    chartDataFlow.Enqueue(dp);                          //将对象添加到 Queue<T> 的结尾处。

        //    AutoYAxis(0.1);                                     //自动调整


        //    chart.Series[0].Points.Clear();

        //    float[] arr = chartDataFlow.ToArray();

        //    foreach(float i in arr)
        //        chart.Series[0].Points.AddY(i);

        //    //DrawAllY(chartDataFlow, this.chart.Series[0]);
        //}

        public void Draw(string d)
        {
            try
            {
                float dp;
                bool flg=float.TryParse(d, out dp);

                data.Add(dp);
                ListRemove(data);

                if(flg)
                    DrawAllY(data, this.chart.Series[0]);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void ListRemove(List<float> list)
        {
            if(list.Count>=len)
            {
                list.RemoveAt(0);
            }
        }

        /// 绘制刷新(全部重绘一组点)
        //public void Draw(float [] dataFlow,int length)
        //{
        //    if (axisYAutoAdjust == true)
        //    {
        //        AutoYAxis();//
        //    }

        //    chartDataFlow.Clear();

        //    foreach(float d in dataFlow)
        //    {
        //        chartDataFlow.Enqueue(d);
        //    }

        //    DrawAllY(chartDataFlow, chart.Series[0]);
        //}
    }
}

