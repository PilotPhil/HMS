using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineControl.HMS.Fatigue
{
    using DF = List<double>;//类似于typedef
    class FatigueCompute
    {
        /// <summary>
        /// 雨流计数法内部计算数据对象
        /// </summary>
        public RData Res = new RData();

        /// <summary>
        /// 雨流计数对象
        /// </summary>
        public Rainflow rainflow = new Rainflow();

        /// <summary>
        /// 损伤度计算对象
        /// </summary>
        public Damage damage = new Damage();

        /// <summary>
        /// 应力响应柱状图细分统计对象
        /// </summary>
        public HistroGram history = new HistroGram();

        /*--------------------------------------------------------------*/

        /// <summary>
        /// 构造
        /// </summary>
        public FatigueCompute()
        {

        }

        /// <summary>
        /// 疲劳损伤度计算(一组数据直接计算)
        /// </summary>
        /// <param name="inp"></param>
        /// <param name="Dam"></param>
        public double Apply2(List<double> inp)
        {
            //结果清空
            Res.ClearAllMember();

            //雨流计数法运算
            rainflow.Apply2(inp, out Res);

            var index = new List<int>();
            var nums = new List<int>();

            //统计出应力响应
            history.Apply2(Res.range, out index, out nums);

            double Dam;

            //计算损伤度
            damage.Apply2(Res.range, Res.mean, out Dam);

            return Dam;
        }
    }
}
