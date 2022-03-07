using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.ManagedTasks.Algorithm
{
    public class Statics7
    {
        #region 算法代理
        /// <summary>
        /// 统计计算函数
        /// </summary>
        /// <param name="inp">输入数据</param>
        /// <returns></returns>
        public float[] Calculate(List<float> inp)
        {
            float[] res = new float[7];
            try
            {
                res[0] = MaxFun(inp);
                res[1] = MinFun(inp);
                res[2] = MeanFun(inp);
                res[3] = StdFun(inp);
                res[4] = SkwFun(inp);
                res[5] = KutFun(inp);
                res[6] = ZcrFun(inp);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("输入参数inp长度不能为零，不能被零除：" + e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("输入参数为空引用：" + e.Message);
            }
            return res;
        }

        /// <summary>
        /// 最大值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float MaxFun(List<float> inp) { return inp.Max(); }

        /// <summary>
        /// 最小值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float MinFun(List<float> inp) { return inp.Min(); }

        /// <summary>
        /// 平均值
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float MeanFun(List<float> inp) 
        {
            var len = inp.Count();
            float res = 0;
            inp.ForEach((item) => { res += item / len; });
            return res;
        }

        /// <summary>
        /// 标准差
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float StdFun(List<float> inp)
        {
            var len = inp.Count();
            float res = 0;

            var mean = this.MeanFun(inp);

            inp.ForEach((item) =>
            {
                res += (float)Math.Pow((item - mean), 2);
            });

            res /= len - 1;
            res = (float)Math.Sqrt(res);

            return res;
        }

        /// <summary>
        /// 偏度skewness：用于衡量x的对称性。
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float SkwFun(List<float> inp)
        {
            float numerator = 0;
            float denominator = 0;

            float len = inp.Count();
            float res = 0;

            var mean = this.MeanFun(inp);

            inp.ForEach((item) =>
            {
                numerator += (float)Math.Pow(item - mean, 3);
            });
            numerator /= len;

            inp.ForEach((item) =>
            {
                denominator += (float)Math.Pow(item - mean, 2);
            });
            denominator /= len;
            denominator = (float)Math.Pow(denominator, 1.5);

            res = numerator / denominator;

            return res;
        }

        /// <summary>
        /// 峰度kurtosis：用于度量x偏离某分布的程度
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float KutFun(List<float> inp)
        {
            float tem1 = 0;
            float tem2 = 0;
            float len = inp.Count();

            var mean = this.MeanFun(inp);
            float res = 0;

            inp.ForEach((item) =>
            {
                tem1 += (float)Math.Pow(item - mean, 4);
            });
            tem1 /= len;

            inp.ForEach((item) =>
            {
                tem2 += (float)Math.Pow(item - mean, 2);
            });
            tem2 /= len;
            tem2 = (float)Math.Pow(tem2, 2);

            res = tem1 / tem2;

            return res;
        }

        /// <summary>
        /// 跨零率
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        protected float ZcrFun(List<float> inp)
        {
            float num = 0;
            float len = inp.Count();
            float res = 0;

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

            res = num / len;
            return res;
        }
        #endregion
    }
}
