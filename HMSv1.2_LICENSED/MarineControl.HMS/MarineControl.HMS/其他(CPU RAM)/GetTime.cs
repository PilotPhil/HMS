using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MarineControl.HMS.Other
{
    class GetTime
    {
        Timer timer4systemTime = new Timer();

        //public delegate void GetSysTimeHandler(string time);
        //public GetSysTimeHandler GetSysTimeEvent;

        public delegate void GetSysRunTimeHandler(string time);
        public GetSysRunTimeHandler GetSysRunTimeEvent;

        //
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        /// <summary>
        /// 构造
        /// </summary>
        public GetTime()
        {
            timer4systemTime.Interval = 1000;//每一秒刷新一次
            timer4systemTime.Start();//默认构造中就启用

            //在主窗体加载后开始计时
            sw.Start();
            timer4systemTime.Elapsed += GetSysRunTime;
        }


        ///获取现在的运行时间
        private void GetSysRunTime(object sender, EventArgs e)
        {
            Task.Factory.StartNew(()=>
            {
                var time = "系统时间：" + DateTime.Now.ToString();

                //获取程序从"sw.Start();"到现在的时间
                TimeSpan ts = sw.Elapsed;
                var runTime = "运行时间：" + ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";

                var timeStr = time + "\r\n" + runTime;

                if(GetSysRunTimeEvent!=null)
                {
                    GetSysRunTimeEvent(timeStr);
                }
            });
        }
    }
}
