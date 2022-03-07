using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace MarineControl.HMS.Fatigue
{
    using DF = List<double>;//类似于typedef

    class Rainflow
    {
        public RData RD = new RData();

        DataTable dt = new DataTable();//创建DataTable对象

        /// <summary>
        /// 构造
        /// </summary>
        public Rainflow()
        {
            
        }

        /// <summary>
        /// 主应用方法
        /// </summary>
        /// <param name="rawData"></param>
        /// <param name="res"></param>
        public void Apply2(DF rawData,out RData res)
        {
            KeepPeaksAndValleys(ref rawData);//提取峰谷

            ExtractCycles(ref rawData);//提取循环

            res = RD;
        }

        /// <summary>
        /// 构造表格形态显示
        /// </summary>
        /// <returns></returns>
        public DataTable GetTableData()//创建数据源
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();

            dt.Columns.Add("Count", System.Type.GetType("System.Double"));
            dt.Columns.Add("Range", System.Type.GetType("System.Double"));
            dt.Columns.Add("Mean", System.Type.GetType("System.Double"));
            dt.Columns.Add("Start", System.Type.GetType("System.Double"));
            dt.Columns.Add("End", System.Type.GetType("System.Double"));

            for (int i = 0; i < RD.range.Count; i++)
            {
                DataRow dr = dt.NewRow();//创建1行

                dr[0] = RD.count.ElementAt(i);
                dr[1] = RD.range.ElementAt(i);
                dr[2] = RD.mean.ElementAt(i);
                dr[3] = RD.start.ElementAt(i);
                dr[4] = RD.end.ElementAt(i);

                dt.Rows.Add(dr);//把行加入到；列表中     
            }
            return dt;
        }

        /// <summary>
        /// 提取峰谷
        /// </summary>
        /// <param name="series"></param>
        /// <returns></returns>
        private DF KeepPeaksAndValleys(ref DF series)
        {
            int id = 1;
            RD.index.Add(0);//索引
            int lt = series.Count;//获取序列原始长度

            for (var it = 1; it < series.Count - 1; ++it)//从1开始判断，并非0，因为0 1 2 才构成判断峰谷的序列长度条件。并到倒数第二结束判断
            {
                var isPeak = series[it] > series[it - 1] && series[it] > series[it + 1];     //判断是否为峰：it-1<it>it+1
                var isValley = series[it] < series[it - 1] && series[it] < series[it + 1];   //判断是否为谷：it-1>it<it+1

                if (isPeak == false && isValley == false)//非峰非谷 擦除此点
                {
                    series.RemoveAt(it);//对参数series进行了删改
                    it--;
                }
                else//否则索引添加，添加的是原始未删减序列中元素的标号
                {
                    RD.index.Add(id);
                }
                id++;
            }

            RD.index.Add(lt - 1);


            return RD.index;
        }

        /// <summary>
        /// 提取循环重载，带有起始终值点输出
        /// </summary>
        /// <param name="series"></param>
        /// <returns></returns>
        private RData ExtractCycles(ref DF series)
        {
            List<double> points = new List<double>();
            List<double> id = new List<double>();

            for (int i = 0; i < series.Count; i++)//在此循环中，利用points逐个元素拷贝series，并没有对series做出改动，所以使用引用传递是安全的
            {
                points.Add(series[i]);//拷贝峰谷点到双向序列中
                id.Add(RD.index[i]);

                while (points.Count >= 3)//序列长度大于等于3就一直运行
                {
                    double x1 = points.ElementAt(points.Count - 3);//获取序列中三个点（倒数：因为上面append是往后面添加）
                    double x2 = points.ElementAt(points.Count - 2);
                    double x3 = points.ElementAt(points.Count - 1);

                    double X = Math.Abs(x3 - x2);//幅值绝对值
                    double Y = Math.Abs(x2 - x1);//幅值绝对值

                    if (X < Y)//是否构成循环？
                    {
                        break;
                    }
                    else if (points.Count == 3)
                    {
                        //Y include Z
                        //yes:
                        //1.count Y as 1/2 cycle
                        //2.discard the first reversal of Y
                        //3.set Z to the second reversal of Y

                        FormatOutput(points.ElementAt(0), points.ElementAt(1), 0.5, id.ElementAt(0), id.ElementAt(1));//1/2 cycle，只有三个点，索引用0 1 即可
                        points.RemoveAt(0);//Removes the head item in the queue
                        id.RemoveAt(0);//Removes the head item in the queue
                    }
                    else
                    {
                        //Y include Z
                        //no:
                        //1.count Y as 1 cycle
                        //2.discard both points of Y

                        FormatOutput(points.ElementAt(points.Count - 3), points.ElementAt(points.Count - 2), 1.0,
                                     id.ElementAt(points.Count - 3), id.ElementAt(points.Count - 2));

                        double last = points.ElementAt(points.Count - 1);//先保存最后一个点
                        points.RemoveAt(points.Count - 1);//删除末尾三个点
                        points.RemoveAt(points.Count - 1);
                        points.RemoveAt(points.Count - 1);
                        points.Add(last);//添加最后一个点

                        double last2 = id.ElementAt(id.Count - 1);
                        id.RemoveAt(id.Count - 1);
                        id.RemoveAt(id.Count - 1);
                        id.RemoveAt(id.Count - 1);
                        id.Add(last2);
                    }
                }
            }
            while (points.Count > 1)//做完上述循环后，序列长度肯定小于等于3
            {
                FormatOutput(points.ElementAt(0), points.ElementAt(1), 0.5, id.ElementAt(0), id.ElementAt(1));
                points.RemoveAt(0);//Removes the head item in the queue
                id.RemoveAt(0);//Removes the head item in the queue
            }

            return RD;
        }

        /// <summary>
        /// 格式化输出
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="cot"></param>
        /// <param name="st"></param>
        /// <param name="ed"></param>
        private void FormatOutput(double point1, double point2, double cot, double st, double ed)
        {
            RD.range.Add(Math.Abs(point1 - point2)); //添加幅值
            RD.mean.Add((point1 + point2) * 0.5);      //添加均值
            RD.count.Add(cot);                     //添加计数
            RD.start.Add(st);                      //添加开始点
            RD.end.Add(ed);                        //添加结束点
        }
    }
}