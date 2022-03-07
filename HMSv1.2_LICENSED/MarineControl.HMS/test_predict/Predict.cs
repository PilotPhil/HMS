using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWaves.Transforms;

namespace MarineControl.HMS.Predict
{
    class PredictFft
    {
        /// <summary>
        /// 构造
        /// </summary>
        public PredictFft() { }

        /// <summary>
        /// 预测函数
        /// </summary>
        /// <param name="sig1"></param>
        /// <param name="sig2"></param>
        /// <param name="sig3"></param>
        /// <param name="sig4"></param>
        public float[] Allpy2(float[] sig1, float[] sig2, float[] sig3, float[] sig4)
        {
            //获取四段信号的最大长度
            var maxLen = (int)Compare(Math.Max, sig1.Length, sig2.Length, sig3.Length, sig4.Length);

            //计算适合的fft长度
            var fftLen = GetCloseLen(maxLen);

            //截短或者补0
            InterceptCompletion(ref sig1, fftLen);
            InterceptCompletion(ref sig2, fftLen);
            InterceptCompletion(ref sig3, fftLen);
            InterceptCompletion(ref sig4, fftLen);

            //fft
            var fft = new RealFft(fftLen);
            //1
            var real1 = new float[fftLen];
            var imag1 = new float[fftLen];
            fft.Direct(sig1, real1, imag1);
            //2
            var real2 = new float[fftLen];
            var imag2 = new float[fftLen];
            fft.Direct(sig2, real2, imag2);
            //1
            var real3 = new float[fftLen];
            var imag3 = new float[fftLen];
            fft.Direct(sig3, real3, imag3);
            //1
            var real4 = new float[fftLen];
            var imag4 = new float[fftLen];
            fft.Direct(sig4, real4, imag4);

            //求频率对应的最大值
            var tem_real = new float[fftLen];
            var tem_imag = new float[fftLen];
            for (int i = 0; i < maxLen; i++)
            {
                tem_real[i] = Compare(Math.Min, real1[i], real2[i], real3[i], real4[i]);
                tem_imag[i] = Compare(Math.Min, imag1[i], imag2[i], imag3[i], imag4[i]);
            }

            //ift
            var res = new float[fftLen];
            fft.Inverse(tem_real, tem_imag, res);

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = res[i] / fftLen;
            }

            return res;
        }

        /// <summary>
        /// 四数比较大小
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private float Compare(Func<float, float, float> fun, float a, float b, float c, float d)
        {
            var tem1 = fun(a, b);
            var tem2 = fun(c, d);
            return fun(tem1, tem2);
        }

        /// <summary>
        /// 截取与补全
        /// </summary>
        /// <param name="array"></param>
        /// <param name="len"></param>
        private void InterceptCompletion(ref float[] array, int len)
        {
            if (array.Length > len)//截取
            {
                var tem = array.Take(len).ToArray();
                array = tem;
            }
            else if (array.Length < len)//补零
            {
                var zero = new float[len - array.Length];//零数组

                var tem = new List<float>();
                tem.AddRange(array.ToList());
                tem.AddRange(zero);

                array = tem.ToArray();
            }
            else//相等不操作
            {

            }
        }

        /// <summary>
        /// 获取最近的2的幂次
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        private int GetCloseLen(int inp)
        {
            if (IsPowerOf2(inp) == true)
                return inp;
            else
            {
                while (IsPowerOf2(inp) == false)
                {
                    if (inp % 2 == 0)
                        inp += 2;
                    else
                        inp += 1;
                }
                return inp;
            }
        }

        /// <summary>
        /// 判断是否为2的幂
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        private bool IsPowerOf2(int inp)
        {
            if ((inp & (inp - 1)) == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取测试数据
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        private float[] GetTestData(int len = 1024)
        {
            Random r = new Random();

            var data = new float[len];
            for (int i = 0; i < len; i++)
            {
                data[i] = r.Next(-100, 100);
            }

            return data;
        }
    }
}
