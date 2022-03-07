//using GalaSoft.MvvmLight.Command;
//using pilot.Comms.DataBuffer;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace pilot.algorithm.Task
//{
//    public class DamageTask : TaskBase
//    {
//        /// <summary>
//        /// ctor
//        /// </summary>
//        /// <param name="_dataSourceIndex">数据源索引</param>
//        public DamageTask(IDataBuffer _dataBuffer) : base( _dataBuffer)
//        {
//            Version = "1.0.1";
//            TaskName = "线性累积疲劳";
//            Autho = "Pilot.Phil";


//            //定时定时器 事件
//            timer4process.Elapsed += (s, e) =>
//            {
//                Random r = new Random();
//                //this.Res = DamageUtil.Apply2(StaticsBuffer) as float[];
//                this.Res = (double)DamageUtil.Apply2(new List<float>()
//                {
//                    r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) ,
//                    r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) ,
//                    r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) ,
//                    r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) ,
//                });
//                SampledBuffer.Clear();
//            };

//            //设置定时器
//            this.Set(null);
//        }

//        #region 属性
//        /// <summary>
//        /// 疲劳累积算法应用
//        /// </summary>
//        private readonly CumulativeDamageUtil DamageUtil = new CumulativeDamageUtil();

//        private double res;
//        /// <summary>
//        /// 计算结果
//        /// </summary>
//        public double Res
//        {
//            get { return res; }
//            set
//            {
//                if (res == value) { return; }
//                res = value;
//                RaisePropertyChanged(() => Res);
//            }
//        }


//        #endregion

//        #region 命令
//        private RelayCommand<object> _myCommand1;
//        /// <summary>
//        /// 设置定时器间隔 的命令
//        /// </summary>
//        public RelayCommand<object> SetCommand
//        {
//            get
//            {
//                return _myCommand1 ?? (_myCommand1 = new RelayCommand<object>(Set));
//            }
//        }
//        public void Set(object param)
//        {
//            if (IsEnable == true)
//            {
//                timer4process.Interval = ProcessInterval * 60.0 * 1000.0;//分钟-->ms
//                timer4process.Start();

//                Timer4Sample.Interval = 1000 / SampleFreq;//Hz-->ms
//                Timer4Sample.Start();
//            }
//            else
//            {
//                timer4process.Stop();
//                Timer4Sample.Stop();
//            }
//        }

//        #endregion
//    }
//}
