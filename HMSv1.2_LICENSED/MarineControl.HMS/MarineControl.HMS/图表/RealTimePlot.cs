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

namespace MarineControl.HMS.Plot
{
    public partial class RealTimePlot : Form
    {
        private DateTimeAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴

        LineAnnotation lineMaxAnnotation;
        LineAnnotation lineMinAnnotation;

        private PlotModel _myPlotModel;

        /// <summary>
        /// 构造
        /// </summary>
        public RealTimePlot()
        {
            InitializeComponent();

            MyPlot_Load();
        }

        /// <summary>
        /// 加载
        /// </summary>
        private void MyPlot_Load()//object sender, EventArgs e
        {
            //定义model
            _myPlotModel = new PlotModel()
            {
                //Title = "时历曲线(每秒刷新)",
                //LegendTitle = "LEGEND",
                LegendOrientation = LegendOrientation.Vertical,//垂直图例
                LegendPlacement = LegendPlacement.Inside,//在图中显示
                LegendPosition = LegendPosition.LeftTop,//位置
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
                Y = 100,
                Text = "上阈值：100"
            };
            _myPlotModel.Annotations.Add(lineMaxAnnotation);

            lineMinAnnotation = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Y = -100,
                Text = "下阈值：-100",
                Color = OxyColors.Red,
                LineStyle = LineStyle.Solid
            };
            _myPlotModel.Annotations.Add(lineMinAnnotation);


            //添加曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Black,
                StrokeThickness = 1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Circle,
                Title = "RealTime Value---mean",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series);

            //添加曲线
            var series_max = new LineSeries()
            {
                Color = OxyColors.Red,
                StrokeThickness = 1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Circle,
                Title = "RealTime Value---max",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series_max);

            //添加曲线
            var series_min = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Circle,
                Title = "RealTime Value---min",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series_min);

            plotView1.Model = _myPlotModel;
        }

        /// <summary>
        /// 绘图：x轴->时间点，y轴->data
        /// </summary>
        /// <param name="data">数据点y值</param>
        public void Draw(DateTime nowTime,float data,int seriesIndex)
        {
            //勾选了节能显示 并且 画布区域不可见 就不更新点
            if (checkBox_saveEnegeDisp.Checked == true & plotView1.Visible==false)
                return;
                
            var date = DateTime.Now;
            _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(date.AddSeconds(1));

            var lineSer = plotView1.Model.Series[seriesIndex] as LineSeries;

            lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(nowTime), data));

            if (lineSer.Points.Count > 100)
            {
                lineSer.Points.RemoveAt(0);
            }

            AutoAxixYRange(0.45);

            _myPlotModel.InvalidatePlot(true);
        }

        public void SetAnnotionValue(double up, double down)
        {
            lineMaxAnnotation.Y = up;
            lineMaxAnnotation.Text = "上阈值：" + up.ToString();

            lineMinAnnotation.Y = down;
            lineMinAnnotation.Text = "下阈值：" + down.ToString();
        }


        /// <summary>
        /// 设置Y轴范围
        /// </summary>
        /// <param name="min">Y轴下限</param>
        /// <param name="max">Y轴上限</param>
        private void SetAxisYRange(double min,double max)
        {
            if (min >= max)//min不能大于max值
            {
                MessageBox.Show("Y轴范围中上限不得小于下限");
                return;
            }

            _valueAxis.Minimum = min;
            _valueAxis.Maximum = max;
        }

        /// <summary>
        /// 自动调整Y轴范围
        /// </summary>
        /// <param name="percent">轴范围增大系数</param>
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
        }

        /// <summary>
        /// 是否自动Y轴范围调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_autoY_CheckedChanged(object sender, EventArgs e)
        {
            bool state = checkBox_autoY.Checked;
        }

        /// <summary>
        /// 手动设置Y轴范围
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void buttonSetAxisY_Click(object sender, EventArgs e)
        //{
        //    SetAxisYRange((double)axisYmin.Value, (double)axisYMax.Value);
        //}
    }
}
