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
    public partial class oxyplotLiner : Form
    {
        private LinearAxis axis_y;//Y轴

        private PlotModel _myPlotModel;

        public delegate void SetFFTParaHandler(int fftSize, int sampleRate);

        public event SetFFTParaHandler SetFFTParaEvent;

        public oxyplotLiner()
        {
            InitializeComponent();

            oxyplotLiner_Load();//加载
        }

        private void oxyplotLiner_Load()
        {
            //定义model
            _myPlotModel = new PlotModel()
            {
                //Title = "时历曲线",
                LegendTitle = "123",
                LegendOrientation = LegendOrientation.Vertical,//垂直图例
                LegendPlacement = LegendPlacement.Inside,//在图中显示
                LegendPosition = LegendPosition.RightTop,//位置
                LegendBackground = OxyColor.FromAColor(100, OxyColors.Aqua),
                LegendBorder = OxyColors.Black
            };

            //X轴
            //axis_x = new LinearAxis()
            //{
            //    MajorGridlineStyle = LineStyle.Solid,
            //    MinorGridlineStyle = LineStyle.Dot,
            //    IntervalLength = 80,
            //    IsZoomEnabled = true,
            //    IsPanEnabled = true,
            //    Maximum = 50,
            //    Minimum = -50
            //};
            //_myPlotModel.Axes.Add(axis_x);

            //Y轴
            axis_y = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = true,
                IsPanEnabled = true,
                Maximum = (double)axisYMax.Value,
                Minimum = (double)axisYmin.Value
            };
            _myPlotModel.Axes.Add(axis_y);

            //添加两条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Red,
                StrokeThickness = 2,
                //MarkerSize = 3,
                //MarkerStroke = OxyColors.DarkGreen,
                //MarkerType = MarkerType.Diamond,
                Title = "fft单边谱",
                //Smooth = true
            };
            _myPlotModel.Series.Add(series);

            plotView1.Model = _myPlotModel;
        }

        public void Draw_Append1Drop1_X_Y(List<float> xData, List<float> yData)
        {
            //勾选了节能显示 并且 画布区域不可见 就不更新点
            if (checkBox_saveEnegeDisp.Checked == true & plotView1.Visible == false)
                return;

            AutoAxixYRange(0.4);

            var lineSer = plotView1.Model.Series[0] as LineSeries;

            lineSer.Points.Clear();

            for (int i = 0; i < xData.Count; i++)
            {
                lineSer.Points.Add(new DataPoint(xData[i], yData[i]));
            }

            _myPlotModel.InvalidatePlot(true);
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

            axis_y.Minimum = min - percent * Math.Abs(min);
            axis_y.Maximum = max + percent * Math.Abs(max);

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

        //设置y轴范围
        private void SetAxisYRange(double min, double max)
        {
            if (min >= max)//min不能大于max值
                return;

            axis_y.Minimum = min;
            axis_y.Maximum = max;
        }

        private void button_setFFT_Click(object sender, EventArgs e)
        {
            if(SetFFTParaEvent!=null)//代理事件 设置fft参数
            {
                SetFFTParaEvent((int)fftSize.Value, (int)sampleRate.Value);
            }
        }
    }
}
