using pilot.SCADA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.SCADA.Global
{
    class DataStorage : NotificationObject
    {
        private static DataStorage _instance;

        /// <summary>
        /// ctor
        /// </summary>
        private DataStorage()
        {
            AccumulatedDatalist = new List<List<DataPoint>>();
            RealTimeDataList = new List<DataPoint>();

            NumOfSourceList = new List<int>();
            NumOfSource = 0;
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static DataStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataStorage();
            }
            return _instance;
        }

        /// <summary>
        /// 实时数据列
        /// </summary>
        private List<DataPoint> _realTimeDataList;
        public List<DataPoint> RealTimeDataList
        {
            get { return _realTimeDataList; }
            set
            {
                _realTimeDataList = value;
                this.RaisePropertyChanged("RealTimeDataList");

                this.SyncDimension();
                this.AddDataPoint2AccumulatedList();
            }
        }

        /// <summary>
        /// 累积的数据列，多维
        /// </summary>
        private List<List<DataPoint>> _accumulatedDataList;
        public List<List<DataPoint>> AccumulatedDatalist
        {
            get { return _accumulatedDataList; }
            set
            {
                _accumulatedDataList = value;
                this.RaisePropertyChanged("AccumulatedDatalist");
            }
        }

        /// <summary>
        /// 数据源数量
        /// </summary>
        private int _numOfSource;
        public int NumOfSource
        {
            get { return _numOfSource; }
            set
            {
                _numOfSource = value;
                this.RaisePropertyChanged("NumOfSource");
            }
        }

        /// <summary>
        /// 数据源索引列
        /// </summary>
        private List<int> _numOfSourceList;
        public List<int> NumOfSourceList
        {
            get { return _numOfSourceList; }
            set
            {
                _numOfSourceList = value;
                this.RaisePropertyChanged("NumOfSourceList");
            }
        }

        /// <summary>
        /// 同步维度到累积数据列
        /// </summary>
        /// <param name="col"></param>
        private void SyncDimension()
        {
            var col = RealTimeDataList.Count;

            if (col <= 0 || AccumulatedDatalist.Count == col)
            {
                return;
            }

            AccumulatedDatalist = new List<List<DataPoint>>();
            for (int i = 0; i < col; i++)
            {
                AccumulatedDatalist.Add(new List<DataPoint>());
            }
        }

        /// <summary>
        /// 添加实时值到累积数据列
        /// </summary>
        private void AddDataPoint2AccumulatedList()
        {
            var cot1 = RealTimeDataList.Count;
            var cot2 = AccumulatedDatalist.Count;
            if (cot1 <= 0 || cot2 <= 0 || cot1 != cot2)
            {
                return;
            }

            for (int i = 0; i < cot2; i++)
            {
                AccumulatedDatalist[i].Add(RealTimeDataList[i]);
            }
        }

        /// <summary>
        /// 更新数据到实时数据
        /// </summary>
        /// <param name="inp"></param>
        public void Update(List<ushort> inp)
        {
            if (inp.Count <= 0) { return; }

            var tem = new List<DataPoint>();

            for (int i = 0; i < inp.Count; i++)
            {
                tem.Add(new DataPoint(inp[i]));
            }

            RealTimeDataList = tem;

            //更新数据源数量
            if(NumOfSource!=RealTimeDataList.Count)
            {
                NumOfSource = RealTimeDataList.Count;

                for (int i = 0; i < NumOfSource; i++)
                {
                    NumOfSourceList.Add(i + 1);
                }
            }
        }

        /// <summary>
        /// 清除累积数据列中的一条数据列
        /// </summary>
        /// <param name="index"></param>
        public void ClearOneAccumulatedData(int index)
        {
            var col = AccumulatedDatalist.Count;
            if(index<=0 || index>col || col <= 0) { return; }

            AccumulatedDatalist[index].Clear();
        }

        /// <summary>
        /// 清理累计数据列中所有数据列
        /// </summary>
        public void ClearAccumulatedDataList()
        {
            var col = AccumulatedDatalist.Count;
            if (col <= 0) { return; }

            for (int i = 0; i < col; i++)
            {
                AccumulatedDatalist[i].Clear();
            }
        }
    }

    class DataPoint
    {
        public DateTime TimeStamp { get; set; }
        public ushort Value { get; set; }

        public DataPoint(ushort val)
        {
            TimeStamp = DateTime.UtcNow;
            Value = val;
        }
    }


}
