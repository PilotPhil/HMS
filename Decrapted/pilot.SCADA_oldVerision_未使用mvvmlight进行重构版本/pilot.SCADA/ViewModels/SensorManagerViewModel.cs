using pilot.SCADA.Common;
using pilot.SCADA.DAL;
using pilot.SCADA.Global;
using pilot.SCADA.Models;
using pilot.SCADA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.SCADA.ViewModels
{
    public class SensorManagerViewModel : NotificationObject
    {
        //传感器列表
        public ObservableCollection<SensorModel> SensorList { get; set; }

        private readonly JsonSerialize jsonSerialize = new JsonSerialize(Path.Combine(BasePath.SelectedProject.ProjectPath,"SensorList.json"));

        #region 单例
        private static SensorManagerViewModel _instance;

        private SensorManagerViewModel()
        {
            SensorList = jsonSerialize.DeserializeRead<ObservableCollection<SensorModel>>();
            SensorList = SensorList ?? new ObservableCollection<SensorModel>();

            SaveCommand.ExecuteAction = new Action<object>(Save);
            SaveCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            NewSensorCommand.ExecuteAction = new Action<object>(NewSensor);
            NewSensorCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            DeleteOneSensorCommand.ExecuteAction = new Action<object>(DeleteOneSensor);
            DeleteOneSensorCommand.CanExecuteFunc = new Func<object, bool>(o => true);

            EditSensorCommand.ExecuteAction = new Action<object>(EditSensor);
            EditSensorCommand.CanExecuteFunc = new Func<object, bool>(o => true);
        }

        public static SensorManagerViewModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SensorManagerViewModel();
            }
            return _instance;
        }
        #endregion

        /// <summary>
        /// 添加一个传感器并序列化保存
        /// </summary>
        /// <param name="sensor"></param>
        public bool AddOneSensor(SensorModel sensor)
        {
            if (SensorList.Any(cus => cus.ID == sensor.ID) == true)
            {
                LoggerRecordViewModel.GetInstance().Record(new Models.LogRecordModel()
                {
                    RecordTime = DateTime.Now.ToString(),
                    Content = "传感器序号重复，重新设置序号",
                    Identity = Registrant.Name ?? "未登录",
                    Type = "错误"
                });

                return false;
            }

            SensorList.Add(sensor);
            jsonSerialize.SerializeWrite(SensorList);

            return true;
        }

        /// <summary>
        /// 移除一个传感器
        /// </summary>
        /// <param name="sensor"></param>
        /// <returns></returns>
        public bool RemoveOneSensor(int indexID)
        {
            if (SensorList.Any(cus => cus.ID == indexID) == false)
            {
                MessageBox.Show("指定传感器不存在");
                return false;
            }

            for (int i = 0; i < SensorList.Count; i++)
            {
                if (SensorList[i].ID == indexID)
                {
                    SensorList.RemoveAt(i);
                    jsonSerialize.SerializeWrite(SensorList);
                    return true;
                }
            }

            return true;
        }

        //保存命令 序列化到json
        public DelegateCommand SaveCommand { get; set; } = new DelegateCommand();
        private void Save(object param)
        {
            jsonSerialize.SerializeWrite(SensorList);
        }

        //新建传感器命令
        public DelegateCommand NewSensorCommand { get; set; } = new DelegateCommand();
        private void NewSensor(object param)
        {
            try
            {
                //var typeStr = "pilot.SCADA.Views." + param.ToString();
                //Type type = Type.GetType(typeStr);

                //if (type == null)//找不到此类型结束
                //    return;

                //object obj = type.Assembly.CreateInstance(typeStr);

                //var view = obj as Window;
                //view.ShowDialog();

                var model = new Models.SensorModel();
                new CreateSensorView(ref model, null).ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //编辑传感器命令
        public DelegateCommand EditSensorCommand { get; set; } = new DelegateCommand();
        private void EditSensor(object param)
        {
            try
            {
                int index = (int)param;
                var sensor2edit = SensorList[index];

                var wid = new CreateSensorView(ref sensor2edit, "编辑传感器");
                wid.ShowDialog();

                jsonSerialize.SerializeWrite(SensorList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DelegateCommand DeleteOneSensorCommand { get; set; } = new DelegateCommand();
        private void DeleteOneSensor(object param)
        {
            var index = (int)param;

            if (index < 0 || index > SensorList.Count - 1)
            {
                MessageBox.Show("索引越界");
            }

            SensorList.RemoveAt(index);

            Save(param);
        }
    }
}
