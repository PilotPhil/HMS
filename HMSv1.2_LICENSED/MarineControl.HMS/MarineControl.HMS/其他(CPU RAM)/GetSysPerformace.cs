using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Timers;

namespace MarineControl.HMS.Other
{
    class GetSysPerformace
    {
        PerformanceCounter cpu = new PerformanceCounter();

        public delegate void GetCpuUsageHandler(double cpuUsage,double menUsage);
        public GetCpuUsageHandler GetCpuUsageEvent;

        Timer timer = new Timer();



        System.Diagnostics.PerformanceCounter performanceCounter1=new System.Diagnostics.PerformanceCounter();

        /// <summary>
        /// 构造
        /// </summary>
        public GetSysPerformace()
        {
            //cpu.CategoryName = "Processor";
            //cpu.CounterName = "%Processor Timer";
            //cpu.InstanceName = "_Total";

            performanceCounter1.CategoryName = "Processor";
            performanceCounter1.CounterName = "% Processor Time";
            performanceCounter1.InstanceName = "_Total";
            performanceCounter1.MachineName = "."; //本机

            timer.Interval = 1000;
            timer.Elapsed += GetCpuUsage;
            timer.Start();
        }

        //物理内存总量
        private double physicalMemory= SystemInfo.Instance.PhysicalMemory / 1024.0 / 1024.0 / 1024.0;

        /// <summary>
        /// 获取cpu占用率
        /// </summary>
        private void GetCpuUsage(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                var cpuUsage = Math.Round(performanceCounter1.NextValue());

                var availableMen = SystemInfo.Instance.MemoryAvailable / 1024 / 1024 / 1024;
                var menUsage = Math.Round((availableMen / physicalMemory) * 100);

                GetCpuUsageEvent?.Invoke(cpuUsage, menUsage);
            });


        }
    }
}
