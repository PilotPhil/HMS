using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;


namespace MarineControl.HMS.Filter
{
    /// <summary>
    /// 基于从matlab导出的dll封装的Fir滤波器类
    /// </summary>
    class FirFilter
    {
        /// <summary>
        /// dll内的滤波器对象
        /// </summary>
        private FirFilterClass ft = new FirFilterClass();

        /// <summary>
        /// 滤波器因数
        /// </summary>
        private List<double> _cof = new List<double>();

        /// <summary>
        /// 滤波器阶数
        /// </summary>
        private uint _order;
        public uint order
        {
            get { return _order; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "阶数应当大于零");
                }
                else
                {
                    _order = value;
                }
            }
        }

        /// <summary>
        /// 截止频率
        /// </summary>
        private double _fc;
        public double fc
        {
            get { return _fc; }
            set 
            {
                if(value<=0 || value>=1)
                {
                    throw new ArgumentOutOfRangeException("value", "滤波器截止频率应当介于0~1之间");
                }
                else
                {
                    _fc = value;
                }
            }
        }

        /// <summary>
        /// 滤波器类型：高通 或 低通
        /// </summary>
        private uint _type;
        public uint type
        {
            get { return _type; }
            set 
            {
                if(value!=0 && value!=1)
                {
                    throw new ArgumentOutOfRangeException("value","滤波器类型可选为0-低通；1-高通");
                }
                else
                {
                    _type = value;
                }
            }
        }

        /*------------------------------------------------------------*/

        /// <summary>
        /// 构造
        /// </summary>
        public FirFilter()
        {
            order = 40;
            fc = 0.5;
            type = 0;
            _cof.Clear();
        }

        /// <summary>
        /// 获取Fir滤波器的滤波器因数存储在对象内部cof成员中
        /// </summary>
        /// <param name="order"></param>
        /// <param name="cutoff"></param>
        /// <param name="type"></param>
        /// <param name="cof"></param>
        public void GetFilterCof()
        {
            MWArray res = ft.FirFilter(order, fc, type);//获取滤波器因数

            var tem1 = (double[,])res.ToArray();//滤波器因数从matlab数据类型转换为数组

            var tem2 = new List<double>();
            for (int i = 0; i < tem1.Length; i++)
                tem2.Add(tem1[0, i]);

            _cof.Clear();
            _cof = tem2;
        }

        /// <summary>
        /// 滤波函数 aka conv卷积，使用对象内部cof因数与信号卷积进行滤波
        /// </summary>
        /// <param name="signal"></param>
        /// <param name="res"></param>
        public List<double> Apply2(List<double> signal)
        {
            var tem=(double[,])ft.Apply2(new MWNumericArray(signal.ToArray()), new MWNumericArray(_cof.ToArray())).ToArray();

            var tem_res = new List<double>();
            for (int i = 0; i < tem.Length; i++)
                tem_res.Add(tem[0, i]);

            return tem_res;
        }

        /// <summary>
        /// 测试函数
        /// </summary>
        public void Test()
        {
            double cutoff = (double)(2*1000)/(2*2048);

            this.fc = cutoff;
            this.order = 20;

            Console.WriteLine(order);
            Console.WriteLine(_fc);

            GetFilterCof();

            Console.WriteLine("传感器因数:");
            _cof.ForEach((i) => Console.WriteLine(i));
        }

        /// <summary>
        /// 滤波函数 aka 卷积conv
        /// </summary>
        public void TestFilter()
        {
            var signal = new List<double>();
            for(int i=0;i<2048;i++)
            {
                signal.Add(50 * Math.Sin(Math.PI * 10 * i) + 200 * Math.Sin(Math.PI * 650 * i) + 130 * Math.Sin(Math.PI * 1200 * i));
            }

            var res = Apply2(signal);
            res.ForEach((i) => Console.WriteLine(i));
        }
    }
}
