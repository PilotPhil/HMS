using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MarineControl.HMS.Statics
{
    public partial class StaticsForm : Form
    {
        //统计算法对象
        Statics7 statics7 = new Statics7();

        /// <summary>
        /// 构造
        /// </summary>
        public StaticsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算一列数据中的统计结果
        /// </summary>
        /// <param name="dataList">数据列</param>
        /// <returns></returns>
        public double[] Apply2(List<double> dataList)
        {
            statics7.Apply2(dataList);

            double[] res = new double[7] { 0,0,0,0,0,0,0};

            res[0] = statics7.max;
            tb_max.InputText = Math.Round(res[0],3).ToString();

            res[1] = statics7.min;
            tb_min.InputText = Math.Round(res[1],3).ToString();

            res[2] = statics7.mean;
            tb_mean.InputText = Math.Round(res[2],3).ToString();

            res[3] = statics7.std;
            tb_std.InputText = Math.Round(res[3],3).ToString();

            res[4] = statics7.skw;
            tb_skw.InputText = Math.Round(res[4],3).ToString();

            res[5] = statics7.kut;
            tb_kut.InputText = Math.Round(res[5],3).ToString();

            res[6] = statics7.zcr;
            tb_zcr.InputText = Math.Round(res[6],3).ToString();

            return res;
        }
    }
}
