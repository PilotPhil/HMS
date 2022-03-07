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
using MarineControl.HMS.Plot;
using MarineControl.HMS.Layout;


namespace MarineControl.HMS.Fatigue
{
    using DF = List<double>;//类似于typedef

    public partial class FatigueForm : Form
    {
        // 雨流计数对象
        Rainflow rainflow = new Rainflow();
        // 计算损伤度
        Damage damage = new Damage();    
        //细分度
        int degree;
        //barchart
        Plot.MyChart barChart = new Plot.MyChart();
        //布局对象
        MyLayout ly = new MyLayout();

        public FatigueForm()
        {
            InitializeComponent();

            cbb_k.SelectedIndex = 0;
            //极限应力
            ultraStress.Value = 235;
            //细分度
            degree = 10;
            //设置图表
            barChart.SetSeriesType(SeriesChartType.Column, 5);
            //加载barchart到panel
            ly.LoadForm2Panel(barChart, panel_barchart);
        }

        /*--------------------------主方法--------------------------*/
        public double Apply2(DF rawData)
        {
            Console.WriteLine("rawDataLength:" + rawData.Count);
            Console.WriteLine("rawDataMax:" + rawData.Max());

            //雨流计数法
            RData Res = new RData();
            rainflow.Apply2(rawData, out Res);

            Console.WriteLine("ResMax:" + Res.range.Max());

            //应力柱状图
            List<int> index = new List<int>();
            List<int> nums = new List<int>();
            HistroGram(Res.range, out index, out nums);

            //Console.WriteLine("index Length:" + index.Count);
            //Console.WriteLine("nums Length:" + nums.Count);

            if (index!=null && nums!=null && index.Count>=2)
            {
                barChart.Draw<int>(index.ToArray(), nums.ToArray());
            }

            //损伤度计算
            double Dam;
            damage.Apply2(Res.range, Res.mean, out Dam);

            tb_damage.Text = (Dam * 100).ToString() + "%";

            return Dam;
        }

        /*--------------------------私有--------------------------*/
        //k参数设置
        private void cbb_k_SelectedIndexChanged(object sender, EventArgs e)
        {
            double k=0d;
            switch(cbb_k.SelectedIndex)
            {
                case 0:
                    k = 5.8E12;//B
                    break;
                case 1:
                    k = 3.464E12;//C
                    break;
                case 2:
                    k = 1.520E12;//D
                    break;
                case 3:
                    k = 1.026E12;//E
                    break;
                case 4:
                    k = 6.319E11;//F
                    break;
                case 5:
                    k = 4.330E11;//F2
                    break;
                case 6:
                    k = 2.481E11;//G
                    break;
                case 7:
                    k = 9.279E10;//w
                    break;
                default:
                    break;
            }

            damage.k=k;
        }

        private void ultraStress_ValueChanged(object sender, EventArgs e)
        {
            double us = (double)ultraStress.Value;
            if (us <= 0)
            {
                //MessageBox.Show("极限应力应当大于零且单位为兆帕斯卡MP","参数错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                
            damage.ultraStress=us;
        }

        /// <summary>
        /// 应力响应柱状图细分统计
        /// </summary>
        /// <param name="range">雨流计数结果赋值</param>
        /// <param name="index">索引</param>
        /// <param name="num">数量</param>
        private void HistroGram(DF range,out List<int> index,out List<int> num)
        {
            if (range.Count <= 0)
            {
                index = null;
                num = null;
                return;
            }

            int min = (int)Math.Floor(range.Min());
            int max = (int)Math.Ceiling(range.Max());

            Console.WriteLine("Max:" + max.ToString());

            if(((max-min)/degree)<1)
            {
                //MessageBox.Show("疏度太大无法统计", "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                index = null;
                num = null;
                return;
            }

            List<int> axis = new List<int>();

            int tem = min;
            int pls = (max - min) / degree;

            while(tem<=max)//生成统计轴
            {
                axis.Add(tem);
                tem += pls;
            }

            int[] nums = new int[axis.Count - 1];
            for(int i=0;i<axis.Count-1;i++)//取统计轴的间隔
            {
                double _min = axis.ElementAt(i);
                double _max = axis.ElementAt(i + 1);

                for(int j=0;j<range.Count;j++)
                    if(_min<=range.ElementAt(j) && range.ElementAt(j) < _max)
                        nums[i]+= 1;
            }

            index = axis;

            num = nums.ToList();
        }

    }
}
