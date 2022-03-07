using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.FATIGUE
{
    using DF = List<double>;//类似于typedef
    class Fatigue
    {
        /// <summary>
        /// 雨流计数法单批处理数据点个数
        /// </summary>
        public int processSize
        {
            get { return processSize; }
            set
            {
                if (value > 0)
                    processSize = value;
                else
                    throw new ArgumentException();
            }
        }

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


        /// <summary>
        /// 要做雨流计数的数据
        /// </summary>
        private List<double> data2Rainflow = new List<double>();

        /*--------------------------------------------------------------*/

        /// <summary>
        /// 构造
        /// </summary>
        public Fatigue()
        {
            processSize = 100;
        }

        /// <summary>
        /// 疲劳损伤度计算(一组数据直接计算)
        /// </summary>
        /// <param name="rawData"></param>
        /// <param name="Dam"></param>
        //public void Apply2(DF rawData, out double Dam)
        //{
        //    //结果清空
        //    Res.ClearAllMember();

        //    //雨流计数法运算
        //    rainflow.Apply2(rawData, out Res);

        //    var index = new List<int>();
        //    var nums = new List<int>();

        //    //统计出应力响应
        //    history.Apply2(Res.range, out index, out nums);

        //    //计算损伤度
        //    damage.Apply2(Res.range, Res.mean, out Dam);
        //}

        /// <summary>
        /// 疲劳损伤度计算(一个数据，构造数据list再计算)
        /// </summary>
        /// <param name="rawDataPoint"></param>
        /// <param name="Dam"></param>
        public void Apply2(double rawDataPoint, out double Dam,out List<int> index, out List<int> nums)
        {
            if(PrepareData(rawDataPoint)==true)
            {
                Res.ClearAllMember();
                rainflow.Apply2(data2Rainflow, out Res);

                history.Apply2(Res.range, out index, out nums);

                damage.Apply2(Res.range, Res.mean, out Dam);

            }
        }


        /// <summary>
        /// 准备数据，准备好后返回
        /// </summary>
        /// <param name="rawDataPoint"></param>
        /// <returns></returns>
        private bool PrepareData(double rawDataPoint)
        {
            if(data2Rainflow.Count< processSize | data2Rainflow.Count > processSize)
            {
                data2Rainflow.Add(rawDataPoint);//添加数据点
                return false;
            }

            return true;
        }
    }
}
