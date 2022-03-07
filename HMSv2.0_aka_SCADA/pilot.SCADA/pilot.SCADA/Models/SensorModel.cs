using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using pilot.ManagedTasks;
using pilot.DataBuffer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;

namespace pilot.SCADA.Models
{
    [JsonObject(MemberSerialization.OptOut)]
    public class SensorModel : ObservableObject, ICloneable
    {
        /// <summary>
        /// ctor
        /// </summary>
        public SensorModel()
        {
            snum++;//每次构造传感器数量自增1

            SGuid = Guid.NewGuid();//先生成唯一的传感器标识符
            SName = "Sensor" + snum.ToString();//默认传感器名
            SLocation = "Location" + snum.ToString();//默认安装位置
            DataSourceIndex = (uint)snum;//数据索引
            IsEnable = true;//默认启用

            var buffer = ServiceLocator.Current.GetInstance<IDataBuffer>();
            StaskFlow = new TaskFlow(buffer, this.DataSourceIndex)//数据处理流程
            {
                SGuid = SGuid.ToString()
            };

            dataSourceIndexChanged += (index) => { StaskFlow.DataSourceIndex = index; };
        }

        public object Clone()
        {
            SensorModel newSensorModel = new SensorModel()
            {
                SGuid = Guid.NewGuid(),
                SName = "Sensor" + snum.ToString(),
                SLocation = "Location" + snum.ToString(),
                SType = stype,
                DataSourceIndex = (uint)snum,
                IsEnable = isEnable,
                Unit = unit,
            };

            var buffer = ServiceLocator.Current.GetInstance<IDataBuffer>();
            newSensorModel.StaskFlow = new TaskFlow(buffer, (uint)snum)//克隆里面保证任务流的 传感器标识 和 数据索引 正确
            {
                SGuid = newSensorModel.SGuid.ToString(),
            };

            return newSensorModel;
        }

        private Action<uint> dataSourceIndexChanged;

        #region 基础信息
        static int snum = 0;

        private Guid sguid;
        /// <summary>
        /// sensor guid全局唯一标识
        /// </summary>
        public Guid SGuid
        {
            get { return sguid; }
            set
            {
                if (sguid == value) { return; }
                sguid = value;
                RaisePropertyChanged(() => SGuid);
            }
        }

        private string sname;
        /// <summary>
        /// 名
        /// </summary>
        public string SName
        {
            get { return sname; }
            set
            {
                if (sname == value) { return; }
                sname = value;
                RaisePropertyChanged(() => SName);
            }
        }

        private string slocation;
        /// <summary>
        /// Location
        /// </summary>
        public string SLocation
        {
            get { return slocation; }
            set
            {
                if (slocation == value) { return; }
                slocation = value;
                RaisePropertyChanged(() => SLocation);
            }
        }

        private string stype;
        /// <summary>
        /// Type
        /// </summary>
        public string SType
        {
            get { return stype; }
            set
            {
                if (stype == value) { return; }
                stype = value;
                RaisePropertyChanged(() => SType);
            }
        }

        private uint dataSourceIndex;
        /// <summary>
        /// 使用数据源索引
        /// </summary>
        public uint DataSourceIndex
        {
            get { return dataSourceIndex; }
            set
            {
                if (dataSourceIndex == value) { return; }
                dataSourceIndex = value;
                dataSourceIndexChanged?.Invoke(value);
                RaisePropertyChanged(() => DataSourceIndex);
            }
        }

        private bool isEnable;
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                if (isEnable == value) { return; }
                isEnable = value;
                RaisePropertyChanged(() => IsEnable);
            }
        }

        private string unit;
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set
            {
                if (unit == value) { return; }
                unit = value;
                RaisePropertyChanged(() => Unit);
            }
        }

        #endregion

        private TaskFlow staskFlow;
        /// <summary>
        /// 任务流程
        /// </summary>
        public TaskFlow StaskFlow
        {
            get { return staskFlow; }
            set
            {
                if (staskFlow == value) { return; }
                staskFlow = value;
                RaisePropertyChanged(() => StaskFlow);
            }
        }


        //传感 类型list
        [JsonIgnore]
        public ObservableCollection<string> TypeList { get; private set; } = new ObservableCollection<string>()
        {
            "应变","加速度","速度","角度","温度","长度","压强","应力"
        };

        //单位 类型list
        [JsonIgnore]
        public ObservableCollection<string> UnitList { get; private set; } = new ObservableCollection<string>()
        {
            "-","m/s^2","m/s","Km/h","°","ω/rad","℃","℉","m","MPa"
        };
    }
}
