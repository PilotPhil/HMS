using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Models
{
    public class GroupModel : ObservableObject
    {
        private static int NodeNum = 0;

        private string _nodeName;
        /// <summary>
        /// 节点、组 名
        /// </summary>
        public string NodeName
        {
            get { return _nodeName; }
            set
            {
                if (_nodeName == value) { return; }
                _nodeName = value;
                RaisePropertyChanged(() => NodeName);
            }
        }

        private List<SensorModel> _includedSensor = new List<SensorModel>();
        /// <summary>
        /// 所包含的传感器ming
        /// </summary>
        public List<SensorModel> IncludeSensor
        {
            get { return _includedSensor; }
            set
            {
                if (_includedSensor == value) { return; }
                _includedSensor = value;
                RaisePropertyChanged(() => IncludeSensor);
            }
        }


        public GroupModel()
        {
            NodeNum++;
            NodeName = "node" + NodeNum.ToString();
        }

    }
}
