using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Chart;

using HMS.LAYOUT;

namespace HMS.FATIGUE
{
    using DF = List<double>;//类似于typedef

    public partial class FatigueDamage : Form
    {
        /// <summary>
        /// 雨流计数对象
        /// </summary>
        Rainflow rainflow = new Rainflow();

        Damage damage = new Damage();       

        RData Res = new RData();        //雨流计数法内部计算数据对象

        BarChart bc = new BarChart();

        int degree;

        int processSize;

        Queue<double> data2Rainflow = new Queue<double>();

        MyLayout layout = new MyLayout();

        Fatigue fatigue = new Fatigue();

        public FatigueDamage()
        {
            InitializeComponent();

            cbb_k.SelectedIndex = 0;

            ultraStress.Value = 235;

            degree = 10;

            processSize = (int)rfProcessSize.Value;

            layout.LoadForm2Panel(bc, panel1);

            
        }

        /*--------------------------主方法--------------------------*/
        public void Apply2(DF rawData,out double Dam)
        {
            Res.ClearAllMember();

            rainflow.Apply2(rawData, out Res);

            List<int> index = new List<int>();
            List<int> nums = new List<int>();
            HistroGram(Res.range,out index,out nums);

            index.RemoveAt(index.Count - 1);
            if (ckb_barFresh.Checked == true)
                bc.Draw(index.ToArray(), nums.ToArray());

            damage.Apply2(Res.range, Res.mean, out Dam);

            tb_damage.Text = (Dam * 100).ToString() + "%";
        }

        public void Apply2(double rawDataPoint, out double Dam)
        {
            if (data2Rainflow.Count == processSize)
            {
                this.Apply2(data2Rainflow.ToList(), out Dam);
                data2Rainflow.Clear();
            }
            else if (data2Rainflow.Count > processSize)
            {
                data2Rainflow.Clear();
                Dam = 0;
            }
            else
                Dam = 0;
                
            data2Rainflow.Enqueue(rawDataPoint); 
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
                MessageBox.Show("极限应力应当大于零且单位为兆帕斯卡MP","参数错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                
            damage.ultraStress=us;
        }

        //应力响应柱状图细分统计
        private void HistroGram(DF range,out List<int> index,out List<int> num)
        {
            int min = (int)Math.Floor(range.Min());
            int max = (int)Math.Ceiling(range.Max());

            if(((max-min)/degree)<1)
            {
                MessageBox.Show("疏度太大无法统计", "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void rfProcessSize_ValueChanged(object sender, EventArgs e)
        {
            processSize = (int)rfProcessSize.Value;
        }
    }
}
