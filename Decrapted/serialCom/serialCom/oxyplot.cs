﻿using System;
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

namespace serialCom
{
    public partial class oxyplot : Form
    {
        private DateTimeAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴

        private PlotModel _myPlotModel;
        private Random rand = new Random();//用来生成随机数
        public oxyplot()
        {
            InitializeComponent();
        }

        private void oxyplot_Load(object sender, EventArgs e)
        {
            //定义model
            _myPlotModel = new PlotModel()
            {
                Title = "时历曲线",
                LegendTitle = "Legend",
                LegendOrientation = LegendOrientation.Vertical,//垂直图例
                LegendPlacement = LegendPlacement.Inside,//在图中显示
                LegendPosition = LegendPosition.TopLeft,//位置
                LegendBackground = OxyColor.FromAColor(200, OxyColors.Aqua),
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
                Angle = 60,
                IsZoomEnabled = true,
                IsPanEnabled = true,
                Maximum = 100,
                Minimum = -100
            };
            _myPlotModel.Axes.Add(_valueAxis);

            //添加标注线，温度上下限和湿度上下限
            var lineTempMaxAnnotation = new OxyPlot.Annotations.LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Color = OxyColors.Red,
                LineStyle = LineStyle.Solid,
                Y = 90,
                Text = "上阈值"
            };
            _myPlotModel.Annotations.Add(lineTempMaxAnnotation);

            var lineTempMinAnnotation = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Y = -90,
                Text = "下阈值",
                Color = OxyColors.Red,
                LineStyle = LineStyle.Solid
            };
            _myPlotModel.Annotations.Add(lineTempMinAnnotation);


            //添加两条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2,
                MarkerSize = 3,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Diamond,
                Title = "Temp",
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
            var date = DateTime.Now;
            _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(date.AddSeconds(1));

            var lineSer = plotView1.Model.Series[0] as LineSeries;

            lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), data));

            if (lineSer.Points.Count > 100)
            {
                lineSer.Points.RemoveAt(0);
            }

            _myPlotModel.InvalidatePlot(true);

        }
    }
}
