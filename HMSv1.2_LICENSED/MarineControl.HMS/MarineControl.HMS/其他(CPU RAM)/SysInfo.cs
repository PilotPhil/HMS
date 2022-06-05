﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Management;
using System.Runtime.InteropServices;

namespace MarineControl.HMS.Other
{
    ///  
    /// 系统信息类 - 获取CPU、内存、磁盘、进程信息
    ///  
    public class SystemInfo
    {
        #region 字段定义

        private int m_ProcessorCount = 0;   //CPU个数
        private PerformanceCounter pcCpuLoad;   //CPU计数器
        private long m_PhysicalMemory = 0;   //物理内存

        private const int GW_HWNDFIRST = 0;
        private const int GW_HWNDNEXT = 2;
        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 268435456;
        private const int WS_BORDER = 8388608;

        #endregion

        #region AIP声明

        [DllImport("IpHlpApi.dll")]
        extern static public uint GetIfTable(byte[] pIfTable, ref uint pdwSize, bool bOrder);

        [DllImport("User32")]
        private extern static int GetWindow(int hWnd, int wCmd);

        [DllImport("User32")]
        private extern static int GetWindowLongA(int hWnd, int wIndx);

        [DllImport("user32.dll")]
        private static extern bool GetWindowText(int hWnd, StringBuilder title, int maxBufSize);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static int GetWindowTextLength(IntPtr hWnd);

        #endregion

        #region 单例实现

        private static SystemInfo _instance = null;

        #region 构造函数
        ///  
        /// 构造函数，初始化计数器等
        ///  
        private SystemInfo()
        {
            ////初始化CPU计数器
            //pcCpuLoad = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //pcCpuLoad.MachineName = ".";
            //pcCpuLoad.NextValue();

            ////CPU个数
            //m_ProcessorCount = Environment.ProcessorCount;

            //获得物理内存
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (mo["TotalPhysicalMemory"] != null)
                {
                    m_PhysicalMemory = long.Parse(mo["TotalPhysicalMemory"].ToString());
                }
            }
        }
        #endregion

        /// <summary>
        /// 静态实例
        /// </summary>
        public static SystemInfo Instance
        {
            get
            {
                lock ("SystemInfo")
                {
                    if (_instance == null)
                    {
                        _instance = new SystemInfo();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        #region CPU个数

        ///  
        /// 获取CPU个数
        ///  
        public int ProcessorCount
        {
            get
            {
                return m_ProcessorCount;
            }
        }

        #endregion

        #region CPU占用率

        ///  
        /// 获取CPU占用率
        ///  
        public float CpuLoad
        {
            get
            {
                return pcCpuLoad.NextValue();
            }
        }

        #endregion

        #region 可用内存

        ///  
        /// 获取可用内存
        ///  
        public long MemoryAvailable
        {
            get
            {
                long availablebytes = 0;
                //ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_PerfRawData_PerfOS_Memory");
                //foreach (ManagementObject mo in mos.Get())
                //{
                //    availablebytes = long.Parse(mo["Availablebytes"].ToString());
                //}
                ManagementClass mos = new ManagementClass("Win32_OperatingSystem");
                foreach (ManagementObject mo in mos.GetInstances())
                {
                    if (mo["FreePhysicalMemory"] != null)
                    {
                        availablebytes = 1024 * long.Parse(mo["FreePhysicalMemory"].ToString());
                    }
                }
                return availablebytes;
            }
        }

        #endregion

        #region 物理内存

        ///  
        /// 获取物理内存
        ///  
        public long PhysicalMemory
        {
            get
            {
                return m_PhysicalMemory;
            }
        }

        #endregion
    }
}