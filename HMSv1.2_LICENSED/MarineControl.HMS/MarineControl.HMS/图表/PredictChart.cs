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
    public partial class PredictChart : Form
    {
        private DateTimeAxis _dateAxis;//X轴 时间轴
        private LinearAxis _valueAxis;//Y轴 数值轴

        private PlotModel _myPlotModel;

        /// <summary>
        /// 构造
        /// </summary>
        public PredictChart()
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
                //MinorGridlineStyle = LineStyle.Dot,
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
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 100,
                Minimum = -100
            };
            _myPlotModel.Axes.Add(_valueAxis);

            //添加标注线，温度上下限和湿度上下限
            //lineMaxAnnotation = new LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Color = OxyColors.Red,
            //    LineStyle = LineStyle.Solid,
            //    Y = 100,
            //    Text = "上阈值：100"
            //};
            //_myPlotModel.Annotations.Add(lineMaxAnnotation);

            //lineMinAnnotation = new LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Y = -100,
            //    Text = "下阈值：-100",
            //    Color = OxyColors.Red,
            //    LineStyle = LineStyle.Solid
            //};
            //_myPlotModel.Annotations.Add(lineMinAnnotation);


            //添加曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Red,
                StrokeThickness = 1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.Blue,
                MarkerType = MarkerType.Cross,
                Title = "Forecast Result",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series);

            plotView1.Model = _myPlotModel;
        }

       /// <summary>
       /// 绘图
       /// </summary>
       /// <param name="predictRes">预测结果序列</param>
       /// <param name="timeSpan">预测时间跨度，默认1小时，单位ms</param>
        public void Draw(float[] predictRes,int timeSpan=3600000)
        {
            //勾选了节能显示 并且 画布区域不可见 就不更新点
            //if (checkBox_saveEnegeDisp.Checked == true & plotView1.Visible==false)
            //    return;

            //判断是否为空
            if (predictRes==null || predictRes.Length <= 0)
                return;
            //设置Y轴范围
            float max = predictRes.Max();
            float min = predictRes.Min();
            float distance = max - min;
            _valueAxis.Maximum = Math.Ceiling(max + 0.125 * Math.Abs(distance));
            _valueAxis.Minimum = Math.Floor(min - 0.125 * Math.Abs(distance));

            //计算点点之间时间间隔
            int interval = timeSpan/ predictRes.Length;
            //获取series
            var lineSer = plotView1.Model.Series[0] as LineSeries;
            //清空原有的
            lineSer.Points.Clear();
            //获取时间
            var time = DateTime.Now;
            //逐个更新
            for (int i=0;i<predictRes.Length;i++)
            {
                //设置x轴最大值
                _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(time);
                //series添加点
                lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), predictRes[i]));
                //时间自增毫秒数
                time = time.AddMilliseconds(interval);
            }
            //????important注释后将无法动态刷新曲线
            _myPlotModel.InvalidatePlot(true);
        }
    }
}
