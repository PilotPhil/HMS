using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineControl.HMS.Alarm
{
    class LimitAlarm
    {
        /// <summary>
        /// 上限
        /// </summary>
        private double _up;
        public double up
        {
            get { return _up; }
            set { _up = value; }
        }

        /// <summary>
        /// 下限
        /// </summary>
        private double _down;
        public double down
        {
            get { return _down; }
            set { _down = value; }
        }

        public delegate void DetectOverValueHandler(string dateTime,string meanValue);
        public DetectOverValueHandler DetectOverValueEvent;

        /// <summary>
        /// 构造
        /// </summary>
        public LimitAlarm()
        {
            up = 8;
            down = -8;
        }

        List<int> checkBit = new List<int>();
        List<double> checkValue = new List<double>();

        public void Detect(double dataPoint)
        {
            //连续三个值 检测过就清空
            if (checkBit.Count == 3)
            {
                var time= DateTime.Now.ToString();
                double sumValue=0; 
                int sumIndex=0;

                var tem1 = new List<double>(checkValue);
                var tem2 = new List<int>(checkBit);

                tem1.ForEach((value)=> { sumValue += value; });
                tem2.ForEach((value)=> { sumIndex += value; });

                if(sumIndex == 3 || sumIndex == -3)
                {
                    DetectOverValueEvent?.Invoke(time, (sumValue/3).ToString());
                }
                checkBit.Clear();
                checkValue.Clear();
            }
                

            var tem = Check(dataPoint);
            if (tem != 0)
            {
                checkBit.Add(tem);
                checkValue.Add(dataPoint);
            }
        }
        
        /// <summary>
        /// 标志位裁定
        /// </summary>
        /// <param name="dataPoint"></param>
        /// <returns></returns>
        private int Check(double dataPoint)
        {
            if (dataPoint > up)
                return 1;
            else if (dataPoint <= down)
                return -1;
            else
                return 0;
        }
    }
}
