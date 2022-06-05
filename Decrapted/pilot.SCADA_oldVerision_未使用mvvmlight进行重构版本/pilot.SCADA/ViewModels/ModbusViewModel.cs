using NModbus;
using NModbus.Serial;
using NModbus.Utility;
using pilot.SCADA.Common;
using pilot.SCADA.DAL;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    public class ModbusViewModel : NotificationObject
    {
        //序列化对象
        private readonly JsonSerialize jsonSerialize = new JsonSerialize(Path.Combine(BasePath.SelectedProject.ProjectPath, "ModbusModel.json"));

        //modbus参数模型
        private ModbusParamModel _modbusModel;
        public ModbusParamModel ModbusModel
        {
            get { return _modbusModel; }
            set
            {
                _modbusModel = value;
                this.RaisePropertyChanged("ModbusModel");
            }
        }

        #region 单例
        private static ModbusViewModel _instance;//唯一实例

        /// <summary>
        /// ctor
        /// </summary>
        private ModbusViewModel()
        {
            ModbusModel = jsonSerialize.DeserializeRead<ModbusParamModel>();
            ModbusModel = ModbusModel ?? new ModbusParamModel()
            {
                ScanRate = 1000,
                StartAddr = 0,
                ReadNum = 0,
                SlaveId = 0,
                UseRtu = true
            };

            //读取定时器
            timer4Read.Interval = ModbusModel.ScanRate;
            timer4Read.Elapsed += this.ReadSensorValues;

            StartReadCommand.ExecuteAction = new Action<object>(this.StartRead);
            StartReadCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            StopReadCommand.ExecuteAction = new Action<object>(this.StopRead);
            StopReadCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            ConfirmCommand.ExecuteAction = new Action<object>(Confirm);
            ConfirmCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static ModbusViewModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ModbusViewModel();
            }

            return _instance;
        }
        #endregion

        //用于读取的计时器
        Timer timer4Read = new Timer();

        //master
        static IModbusSerialMaster master;

        /// <summary>
        /// 创建Modbus Master
        /// </summary>
        private void CreateMaster()
        {
            SerialPort SelectedPort = SerialObj.OnlySerial;

            timer4Read.Interval = ModbusModel.ScanRate;
            try
            {
                //序列化并写入
                jsonSerialize.SerializeWrite(ModbusModel);

                if (SelectedPort.IsOpen)
                    SelectedPort.Close();

                SelectedPort.Open();

                var factory = new ModbusFactory();

                if (ModbusModel.UseRtu)
                    master = factory.CreateRtuMaster(SelectedPort);
                else
                    master = factory.CreateAsciiMaster(SelectedPort);

                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "Modbus Master创建成功",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "成功"
                });
            }
            catch (Exception ex)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "Modbus Master创建失败，因为" + ex.Message,
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });
            }
        }

        /// <summary>
        /// 读取传感器数值
        /// </summary>
        /// <returns></returns>
        public async void ReadSensorValues(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var ValueList = master.ReadInputRegisters(ModbusModel.SlaveId, ModbusModel.StartAddr, ModbusModel.ReadNum).ToList();

                DataStorage.GetInstance().Update(ValueList);
            });
        }

        //确认 创建modbus master对象 命令
        public DelegateCommand ConfirmCommand { get; set; } = new DelegateCommand();
        private void Confirm(object param)
        {
            this.CreateMaster();

            var window = param as Window;
            window.Close();
        }

        //开始读取命令
        public DelegateCommand StartReadCommand { get; set; } = new DelegateCommand();
        private void StartRead(object para)
        {
            if (master == null)
            {
                MessageBox.Show("未设置Modbus Master");
                return;
            }
            timer4Read.Start();
        }
        public void StartRead()
        {
            if (master == null)
            {
                MessageBox.Show("未设置Modbus Master");
                return;
            }
            timer4Read.Start();
        }

        //停止读取命令
        public DelegateCommand StopReadCommand { get; set; } = new DelegateCommand();
        private void StopRead(object para)
        {
            timer4Read.Stop();
        }
        public void StopRead()
        {
            timer4Read.Stop();
        }
    }


}
