using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineControl.HMS.Statics
{
    class Statics7
    {
        /// <summary>
        /// 最小值
        /// </summary>
        private double _min;
        public double min 
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        /// 最大值
        /// </summary>
        private double _max;
        public double max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        /// 平均值
        /// </summary>
        private double _mean;
        public double mean
        {
            get { return _mean; }
            set { _mean = value; }
        }

        /// <summary>
        /// 标准差
        /// </summary>
        private double _std;
        public double std
        {
            get { return _std; }
            set { _std = value; }
        }

        /// <summary>
        /// 偏度
        /// </summary>
        private double _skw;
        public double skw
        {
            get { return _skw; }
            set { _skw = value; }
        }

        /// <summary>
        /// 峭度
        /// </summary>
        private double _kut;
        public double kut
        {
            get { return _kut; }
            set { _kut = value; }
        }


        /// <summary>
        /// 平均跨零率
        /// </summary>
        private double _zcr;
        public double zcr
        {
            get { return _zcr; }
            set { _zcr = value; }
        }


        /// <summary>
        /// 构造
        /// </summary>
        public Statics7() { }

        /// <summary>
        /// 最大值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyMax(List<double> inp){  max=inp.Max(); return max; }

        /// <summary>
        /// 最小值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyMin(List<double> inp) { min=inp.Min(); return min; }

        /// <summary>
        /// 平均值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyMean(List<double> inp)
        {
            if (inp.Count <= 0)
                return 0;

            double tem = 0d;
            double len = inp.Count();

            inp.ForEach((item) => { tem += item / len; });

            mean = tem;
            return mean;
        }

        /// <summary>
        /// 标准差
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyStd(List<double> inp)
        {
            if (inp.Count <= 0)
                return 0;

            double tem = 0d;
            int len = inp.Count();

            inp.ForEach((item) =>
            {
                tem+= Math.Pow((item - _mean), 2);
            });

            tem /= len;
            tem = Math.Sqrt(tem);

            std = tem;
            return std;
        }

        /// <summary>
        /// 偏度
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MySkw(List<double> inp)
        {
            if (inp.Count <= 0)
                return 0;

            double tem1 = 0d;
            double tem2 = 0d;
            double len = inp.Count();

            inp.ForEach((item) =>
            {
                tem1 += Math.Pow(item - mean, 3);
            });
            tem1 /= len;

            inp.ForEach((item) =>
            {
                tem2 += Math.Pow(item-mean,2);
            });
            tem2 /= len;
            tem2 = Math.Pow(tem2, 1.5);

            skw = tem1 / tem2;

            return skw;
        }

        /// <summary>
        /// 峭度
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyKut(List<double> inp)
        {
            if (inp.Count <= 0)
                return 0;

            double tem1 = 0d;
            double tem2 = 0d;
            double len = inp.Count();

            inp.ForEach((item) =>
            {
                tem1 += Math.Pow(item - mean, 4);
            });
            tem1 /= len;

            inp.ForEach((item) =>
            {
                tem2 += Math.Pow(item - mean, 2);
            });
            tem2 /= len;
            tem2 = Math.Pow(tem2, 2);

            kut = tem1 / tem2;

            return kut;
        }

        /// <summary>
        /// 平均跨零率
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double MyZcr(List<double> inp)
        {
            if (inp.Count <= 0)
                return 0;

            double num = 0;
            double len = inp.Count();

            int i = 0;
            while (i < len - 1)
            {
                if (inp[i] * inp[i + 1] < 0)
                {
                    num++;
                    i++;
                }
                else if (inp[i] * inp[i + 1] == 0)
                {
                    num++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            zcr = num / len;
            return zcr;
        }

        /// <summary>
        /// 总计算
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public double[] Apply2(List<double> inp)
        {
            var min = MyMin(inp);
            var max = MyMax(inp);
            var mean = MyMean(inp);
            var std = MyStd(inp);
            var skw = MySkw(inp);
            var kut = MyKut(inp);
            var zcr = MyZcr(inp);

            double[] res = new double[7] { min,max,mean,std,skw,kut,zcr };
            return res;
        }

    }
}
