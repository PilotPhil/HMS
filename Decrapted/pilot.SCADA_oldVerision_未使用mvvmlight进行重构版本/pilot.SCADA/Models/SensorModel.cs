using Newtonsoft.Json;
using pilot.SCADA.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Models
{
    [JsonObject(MemberSerialization.OptOut)]
    public class SensorModel:NotificationObject
    {
        #region 基础信息
        //ID
        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                this.RaisePropertyChanged("ID");
            }
        }

        //名
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        //位置
        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                this.RaisePropertyChanged("Location");
            }
        }

        //类型
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                this.RaisePropertyChanged("Type");
            }
        }

        //使用数据源索引
        private int _dataSourceIndex;
        public int DataSourceIndex
        {
            get { return _dataSourceIndex; }
            set
            {
                _dataSourceIndex = value;
                this.RaisePropertyChanged("DataSourceIndex");
            }
        }

        //是否启用
        private bool _use;
        public bool Use
        {
            get { return _use; }
            set
            {
                _use = value;
                this.RaisePropertyChanged("Use");
            }
        }

        //单位
        private string _unit;
        public string Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                this.RaisePropertyChanged("Unit");
            }
        }

        //task list
        public ObservableCollection<TaskModuleModel> TaskList { get; set; } = new ObservableCollection<TaskModuleModel>();
        #endregion

        [JsonIgnore]
        public Func<object, object> TaskFlow;

        //传感 类型list
        [JsonIgnore]
        public ObservableCollection<string> TypeList { get; set; } = new ObservableCollection<string>() 
        {
            "应变","加速度","速度","角度","温度","长度","压强","应力"
        };

        //单位 类型list
        [JsonIgnore]
        public ObservableCollection<string> UnitList { get; set; } = new ObservableCollection<string>()
        {
            "mm","m","m^2/s","-","°C","°F","N","MPa"
        };
    }
}
