using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.FATIGUE
{
    using DF = List<double>;//类似于typedef

    /// <summary>
    /// 应力响应柱状图细分统计
    /// </summary>
    class HistroGram
    {
        /// <summary>
        /// 疏度
        /// </summary>
        public int degree {
            get { return degree; } 
            set
            {
                if (value > 0)
                    degree = value;
                else
                    throw new ArgumentException();
            }
        }
            
        /// <summary>
        /// 构造
        /// </summary>
        public HistroGram()
        {
            degree = 5;
        }

        /// <summary>
        /// 总计算
        /// </summary>
        /// <param name="range"></param>
        /// <param name="index"></param>
        /// <param name="num"></param>
        public void Apply2(DF range, out List<int> index, out List<int> num)
        {
            int min = (int)Math.Floor(range.Min());
            int max = (int)Math.Ceiling(range.Max());

            if (((max - min) / degree) < 1)
            {
                
                index = null;
                num = null;
                return;
            }

            var axis = new List<int>();

            int tem = min;
            int pls = (max - min) / degree;

            while (tem <= max)//生成统计轴
            {
                axis.Add(tem);
                tem += pls;
            }

            int[] nums = new int[axis.Count - 1];
            for (int i = 0; i < axis.Count - 1; i++)//取统计轴的间隔
            {
                double _min = axis.ElementAt(i);
                double _max = axis.ElementAt(i + 1);

                for (int j = 0; j < range.Count; j++)
                    if (_min <= range.ElementAt(j) && range.ElementAt(j) < _max)
                        nums[i] += 1;
            }

            index = axis;

            num = nums.ToList();
        }
    }
}
