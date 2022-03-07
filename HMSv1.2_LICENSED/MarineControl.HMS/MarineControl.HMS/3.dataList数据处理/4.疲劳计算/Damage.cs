using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineControl.HMS.Fatigue
{
    using DF = List<double>;//类似于typedef

    class Damage
    {
        private DF meanStress = new DF();

        /// <summary>
        /// 参数k 
        /// </summary>
        private double _k;
        public double k 
        { 
            get { return _k; }
            set
            {
                if (value > 0)
                    _k = value;
                else
                    throw new AggregateException("K值参数有误");
            }
        }

        /// <summary>
        /// 极限应力 只读
        /// </summary>
        public double ultraStress { get; set; }

        /// <summary>
        /// 损伤度 只读
        /// </summary>
        public double damage { get; set; }

        /// <summary>
        /// 构造器
        /// </summary>
        public Damage()
        {
            k = 5.8e12;
            ultraStress = 235;
            damage = 0;
        }

        /// <summary>
        /// 主方法应用计算损伤度
        /// </summary>
        /// <param name="range"></param>
        /// <param name="mean"></param>
        /// <param name="damage"></param>
        public void Apply2(DF range, DF mean, out double damage)
        {
            MeanStressCorrection(ref range, ref mean);//平均应力修正
            DamageCompute(out damage);//损伤计算
        }

        /// <summary>
        /// 平均应力修正
        /// </summary>
        /// <param name="range"></param>
        /// <param name="mean"></param>
        private void MeanStressCorrection(ref DF range, ref DF mean)
        {
            meanStress.Clear();

            for (int i = 0; i<range.Count; i++)
                meanStress.Add((2 * ultraStress * range.ElementAt(i)) / (ultraStress - mean.ElementAt(i)));
        }

        /// <summary>
        /// 计算损伤
        /// </summary>
        /// <param name="damage"></param>
        private void DamageCompute(out double damage)
        {
            this.damage = 0;//先归零

            foreach (double m in meanStress)
                this.damage += 1 / Math.Pow(10, Math.Log10(k) - 3 * Math.Log10(m));

            damage=this.damage;
        }
    }
}
