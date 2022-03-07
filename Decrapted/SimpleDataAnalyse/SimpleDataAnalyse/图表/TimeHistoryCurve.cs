using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace plot
{
    public partial class MyPlotWithData : Form
    {
        private DateTimeAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴

        LineAnnotation lineMaxAnnotation;
        LineAnnotation lineMinAnnotation;

        private PlotModel _myPlotModel;
        private Random rand = new Random();//用来生成随机数

        public MyPlotWithData()
        {
            InitializeComponent();

            MyPlot_Load();
        }

        private void MyPlot_Load()//object sender, EventArgs e
        {
            //定义model
            _myPlotModel = new PlotModel()
            {
                //Title = "时历曲线",
                //LegendTitle = "LEGEND",
                LegendOrientation = LegendOrientation.Vertical,//垂直图例
                LegendPlacement = LegendPlacement.Inside,//在图中显示
                LegendPosition = LegendPosition.RightTop,//位置
                LegendBackground = OxyColor.FromAColor(100, OxyColors.Aqua),
                LegendBorder = OxyColors.Black
            };
            //X轴
            _dateAxis = new DateTimeAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalLength = 80,
                IsZoomEnabled = true,
                IsPanEnabled = true
            };
            _myPlotModel.Axes.Add(_dateAxis);

            //Y轴
            _valueAxis = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = true,
                IsPanEnabled = true,
                Maximum = 100,
                Minimum = -100
            };
            _myPlotModel.Axes.Add(_valueAxis);

            //添加标注线，温度上下限和湿度上下限
            lineMaxAnnotation = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Color = OxyColors.Red,
                LineStyle = LineStyle.Solid,
                Y = 200,
                Text = "上阈值：200"
            };
            _myPlotModel.Annotations.Add(lineMaxAnnotation);

            lineMinAnnotation = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Y = -200,
                Text = "下阈值：-200",
                Color = OxyColors.Red,
                LineStyle = LineStyle.Solid
            };
            _myPlotModel.Annotations.Add(lineMinAnnotation);


            //添加两条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Circle,
                Title = "data",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series);

            plotView1.Model = _myPlotModel;

            //Task.Factory.StartNew(() =>
            //{
            //    while (true)
            //    {

            //        var date = DateTime.Now;
            //        _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(date.AddSeconds(1));

            //        var lineSer = plotView1.Model.Series[0] as LineSeries;
            //        lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), rand.Next(100, 300) / 10.0));
            //        if (lineSer.Points.Count > 100)
            //        {
            //            lineSer.Points.RemoveAt(0);
            //        }

            //        _myPlotModel.InvalidatePlot(true);

            //        Thread.Sleep(10);
            //    }
            //});
        }

        public void Draw_Append1Drop1_WithTime(float data)
        {
            //勾选了节能显示 并且 画布区域不可见 就不更新点
            if (checkBox_saveEnegeDisp.Checked == true & plotView1.Visible==false)
                return;
                
            var date = DateTime.Now;
            _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(date.AddSeconds(1));

            var lineSer = plotView1.Model.Series[0] as LineSeries;

            lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), data));

            if (lineSer.Points.Count > 100)
            {
                lineSer.Points.RemoveAt(0);
            }

            AutoAxixYRange(0.45);

            _myPlotModel.InvalidatePlot(true);
        }


        //改变上限
        private void chartMaxAnn_ValueChanged(object sender, EventArgs e)
        {
            lineMaxAnnotation.Y = (double)chartMaxAnn.Value;
            lineMaxAnnotation.Text = "上阈值：" + chartMaxAnn.Value.ToString();
        }

        //改变下限
        private void chartMinAnn_ValueChanged(object sender, EventArgs e)
        {
            lineMinAnnotation.Y = (double)chartMinAnn.Value;
            lineMinAnnotation.Text = "下阈值：" + chartMinAnn.Value.ToString();
        }

        private void SetAxisYRange(double min,double max)
        {
            if (min >= max)//min不能大于max值
                return;

            _valueAxis.Minimum = min;
            _valueAxis.Maximum = max;
        }

        //自动调整Y轴范围
        private void AutoAxixYRange(double percent = 0.2)
        {
            if (checkBox_autoY.Checked != true)
                return;

            if (percent < 0 | percent > 1)
                percent = 0;

            var lineSer = plotView1.Model.Series[0] as LineSeries;

            double min = lineSer.MinY;
            double max = lineSer.MaxY;

            _valueAxis.Minimum = min - percent * Math.Abs(min);
            _valueAxis.Maximum = max + percent * Math.Abs(max);

            //if (chartArea.AxisY.Minimum.CompareTo(min) > 0)
            //    chartArea.AxisY.Minimum = min - percent * Math.Abs(min);

            //if (chartArea.AxisY.Maximum.CompareTo(min) < 0)
            //    chartArea.AxisY.Maximum = max + percent * Math.Abs(max);
        }

        //是否自动Y轴范围调整
        private void checkBox_autoY_CheckedChanged(object sender, EventArgs e)
        {
            bool state = checkBox_autoY.Checked;
            buttonSetAxisY.Enabled = !state;//自动调整时，把手动调整的禁用掉
            axisYMax.Enabled = !state;
            axisYmin.Enabled = !state;
        }

        //手动设置Y轴范围
        private void buttonSetAxisY_Click(object sender, EventArgs e)
        {
            SetAxisYRange((double)axisYmin.Value, (double)axisYMax.Value);
        }
    }
}
