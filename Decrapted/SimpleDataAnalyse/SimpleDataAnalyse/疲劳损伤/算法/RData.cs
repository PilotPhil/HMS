using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.FATIGUE
{
    using DF = List<double>;//类似于typedef

    //雨流计数法用的数据类型
    class RData
    {
        public DF index=new DF();    //索引
        public DF range=new DF();    //幅值
        public DF mean=new DF();     //均值
        public DF count=new DF();    //计数
        public DF start=new DF();    //起始点
        public DF end=new DF();      //终止点

        /// <summary>
        /// 构造
        /// </summary>
        public RData()
        {
        
        }

        /// <summary>
        /// 清除所有成员
        /// </summary>
        public void ClearAllMember()
        {
            index.Clear();
            range.Clear();
            mean.Clear();
            count.Clear();
            start.Clear();
            end.Clear();
        }

        /// <summary>
        /// 以字符串格式返回所有成员的值
        /// </summary>
        /// <returns></returns>
        public string DispAllMember()
        {
            string res;

            res = "index:" + index.ToString() + "\n" +
                "range:" + range.ToString() + "\n" +
                "mean:" + mean.ToString() + "\n" +
                "count:" + count.ToString() + "\n" +
                "start" + start.ToString() + "\n" +
                "end" + end.ToString() + "\n";

            return res;
        }
    }
}
