using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Models
{
    public class ModbusParamModel
    {
        //从站地址
        public byte SlaveId { get; set; }

        //起始地址
        public ushort StartAddr { get; set; }

        //读取数量
        public ushort ReadNum { get; set; }

        //扫描间隔 ms
        public uint ScanRate { get; set; }

        //使用Rtu还是Ascii
        public bool UseRtu { get; set; }
    }
}
