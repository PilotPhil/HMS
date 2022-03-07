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
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;


namespace plot
{
    public partial class PlotColumn : Form
    {
        PlotModel model;

        public PlotColumn()
        {
            InitializeComponent();

            model = new PlotModel { Title = "应力响应柱状图" };
        }


        public void Draw(List<int> x, List<int> y)//
        {
            model.Series.Clear();


            var str = new List<string>();
            for (int i = 0; i < x.Count - 1; i++)
            {
                str.Add(x.ElementAt(i).ToString());
            }


            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Right,
                Key = "CakeAxis",
                ItemsSource = str
            });

            var itemSource = new List<BarItem>();
            foreach(int i in y)
            {
                itemSource.Add(new BarItem(i));
            }

            var barSeries = new BarSeries
            {
                ItemsSource = itemSource,

                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            model.Series.Add(barSeries);


            plotView1.Model = model; 
        }
        
    }
}
