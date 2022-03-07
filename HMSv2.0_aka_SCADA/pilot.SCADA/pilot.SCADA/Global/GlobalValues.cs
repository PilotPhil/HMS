using GalaSoft.MvvmLight.Messaging;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Global
{
    public class GlobalValues
    {
        /// <summary>
        /// 软件实例正在使用的 项目
        /// </summary>
        public static string CurrentProjectPath { get; set; } = "";//string.IsNullOrEmpty(GlobalValues.CurrentProjectPath);

        /// <summary>
        /// 系统是否正在监测
        /// </summary>
        public static bool IsOnMointoring { get; set; } = false;
    }
}
