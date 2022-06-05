using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarineControl.HMS.Filter;
using MarineControl.HMS.Statics;
using MarineControl.HMS.Alarm;
using MarineControl.HMS.Fatigue;

namespace MarineControl.HMS
{
    class ProcessFlow
    {
        /// <summary>
        /// 滤波器因数
        /// </summary>
        private List<double> _cof;
        public List<double> cof 
        {
            get { return _cof; }
            set { _cof = value; }
        }

        /// <summary>
        /// 滤波器对象
        /// </summary>
        public FirFilter filter = new FirFilter();

        /// <summary>
        /// 统计对象
        /// </summary>
        public Statics7 statics = new Statics7();

        /// <summary>
        /// 阈值报警对象
        /// </summary>
        public LimitAlarm alarm = new LimitAlarm();

        /// <summary>
        /// 预测对象
        /// </summary>
        public Predict prediction = new Predict();

        /// <summary>
        /// 疲劳损伤计算
        /// </summary>
        public FatigueCompute fatigue = new FatigueCompute();

        

        /// <summary>
        /// 构造
        /// </summary>
        public ProcessFlow()
        {

        }

        public void Apply2(List<double> dataList)
        {
            Task task = new Task(()=> 
            {
                //滤波
                //filter.GetFilterCof(40, 0.4, 0);//执行滤波前应当通过UI调用此函数生成COF
                //var filterRes = filter.Apply2(dataList);

                //阈值报警
                //alarm.Apply2(dataList);//阈值报警检测

                //统计
                var staticsRes = statics.Apply2(dataList);

                //疲劳计算
                var dam=fatigue.Apply2(dataList);

                //预测
                //var predictRes = prediction.Apply2(ts1, ts2, ts3, ts4);//四个小时数据预测一个小时数据，使用不同定时器

            });

            task.Start();
        }

    }
}
