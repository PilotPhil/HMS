using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.ProjConfiguration.Log
{
    public interface ILog
    {
        void Record(LogRecordModel model);
    }
}
