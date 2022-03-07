using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using HandyControl.Controls;
using pilot.ProjConfiguration.Log;
using pilot.SCADA.Models;
using pilot.SCADA.Views;
using ProjConfig;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace pilot.SCADA.ViewModels
{
    public class SensorManagerViewModel : ViewModelBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="serialize"></param>
        public SensorManagerViewModel(ILog log, IProjConfig projConfig)
        {
            this.log = log;

            this.projConfig = projConfig;
            sensorList = projConfig.Init<ObservableCollection<SensorModel>>("SensorList") ?? new ObservableCollection<SensorModel>();

            Messenger.Default.Register<SensorModel>(this, "SendASensorModel", this.OnReceiveASensorModel);

            Messenger.Default.Register<string>(this, "SavePrj", s =>
            {
                this.projConfig.Save("SensorList", SensorList);
                Growl.SuccessGlobal("保存成功");
            });
        }


        #region 属性
        private readonly IProjConfig projConfig;
        private readonly ILog log;

        private ObservableCollection<SensorModel> sensorList;
        /// <summary>
        /// SensorList
        /// </summary>
        public ObservableCollection<SensorModel> SensorList
        {
            get { return sensorList; }
            set
            {
                if (sensorList == value) { return; }
                sensorList = value;
                RaisePropertyChanged(() => SensorList);
            }
        }


        #endregion


        #region 业务方法

        /// <summary>
        /// 添加一个传感器并序列化保存
        /// </summary>
        /// <param name="receivedSensorModel"></param>
        private void OnReceiveASensorModel(SensorModel receivedSensorModel)
        {
            try
            {
                var guid = receivedSensorModel.SGuid;//获取GUID
                var isExist = SensorList.Any(i => i.SGuid == guid);

                if (isExist)//存在就是更新
                {
                    for (int i = 0; i < SensorList.Count; i++)
                    {
                        if (SensorList[i].SGuid == guid)
                        {
                            SensorList[i] = receivedSensorModel;
                            break;
                        }
                    }
                }
                else//不存在，guid不重复，就是增加一个传感器
                {
                    SensorList.Add(receivedSensorModel);
                }
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        #endregion


        #region 命令
        private RelayCommand<object> _myCommand2;
        /// <summary>
        /// 新建传感器 的命令
        /// </summary>
        public RelayCommand<object> NewSensorCommand
        {
            get
            {
                return _myCommand2 ?? (_myCommand2 = new RelayCommand<object>(NewSensor));
            }
        }
        private void NewSensor(object param)
        {
            try
            {
                var createSensorViewModel = new CreateSensorViewModel(null);
                var createSensorView = new CreateSensorView();
                createSensorView.DataContext = createSensorViewModel;
                createSensorView.ShowDialog();
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _myCommand_cloneSensor;
        /// <summary>
        /// 克隆传感器 的命令
        /// </summary>
        public RelayCommand<object> CloneSensorCommand
        {
            get
            {
                return _myCommand_cloneSensor ?? (_myCommand_cloneSensor = new RelayCommand<object>(CloneSensor));
            }
        }
        private void CloneSensor(object param)
        {
            if (param == null)
            {
                Growl.WarningGlobal("未选择要克隆的传感器");
                return;
            }

            try
            {
                var selectedSensorModel = param as SensorModel;
                var newSensorModel = selectedSensorModel.Clone() as SensorModel;//实现了IClonable接口，深拷贝
                SensorList.Add(newSensorModel);
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _myCommand3;
        /// <summary>
        /// 编辑传感器 的命令
        /// </summary>
        public RelayCommand<object> EditSensorCommand
        {
            get
            {
                return _myCommand3 ?? (_myCommand3 = new RelayCommand<object>(EditSensor));
            }
        }
        private void EditSensor(object param)
        {
            if (param == null)
            {
                Growl.WarningGlobal("未选择要编辑的传感器");
                return;
            }

            try
            {
                var selectedSensorGuid = (param as SensorModel).SGuid;//获取要编辑的传感器的唯一标识符
                var sensor2edit = SensorList.Single(i => i.SGuid == selectedSensorGuid);//通过linq获取到对应guid的传感器对象
                //new CreateSensorView().Show();
                //Messenger.Default.Send<SensorModel>(sensor2edit, "SendSensor2Edit");//发message即sensormodel给编辑界面

                var createSensorViewModel = new CreateSensorViewModel(sensor2edit);
                var createSensorView = new CreateSensorView();
                createSensorView.DataContext = createSensorViewModel;
                createSensorView.ShowDialog();
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }

        private RelayCommand<object> _myCommand4;
        /// <summary>
        /// 删除一个传感器 的命令
        /// </summary>
        public RelayCommand<object> DeleteOneSensorCommand
        {
            get
            {
                return _myCommand4 ?? (_myCommand4 = new RelayCommand<object>(DeleteOneSensor));
            }
        }
        private void DeleteOneSensor(object param)
        {
            if (param == null)
            {
                Growl.WarningGlobal("未选择要删除的传感器");
                return;
            }

            try
            {
                var selectedSensorGuid = (param as SensorModel).SGuid;//获取要编辑的传感器的唯一标识符
                var sensor2delete = SensorList.Single(i => i.SGuid == selectedSensorGuid);
                this.sensorList.Remove(sensor2delete);
            }
            catch (Exception ex)
            {
                log.Record(new LogRecordModel() { Content = ex.Message });
            }
        }


        //#region Group
        //private RelayCommand<object> _groupSensorsCommand;
        ///// <summary>
        ///// 传感器成组 的命令
        ///// </summary>
        //public RelayCommand<object> GroupSensorsCommand
        //{
        //    get
        //    {
        //        return _groupSensorsCommand ?? (_groupSensorsCommand = new RelayCommand<object>(GroupSensors));
        //    }
        //}
        //private void GroupSensors(object param)
        //{
        //    var selectedSensor = SensorList.Where(i => i.CheckGroup == true);//获取 勾选了 要成组 的传感器
        //    if (selectedSensor.ToList().Count <= 0)//没选
        //    {
        //        return;
        //    }

        //    var hasGrouped = selectedSensor.Where(i => i.IsGrouped == true).ToList();//获取要成组传感器中已经成组的

        //    if (hasGrouped.Count > 0)//选择的要成组的传感器中存在已经成组的
        //    {
        //        string temName = "";
        //        hasGrouped.ForEach(i => temName += i.Name + ", ");
        //        System.Windows.MessageBox.Show(temName + "已经成组了，重新选择");
        //        return;
        //    }

        //    var newGroup = new GroupModel();//新组
        //    foreach (var item in selectedSensor)
        //    {
        //        newGroup.IncludeSensor.Add(item);
        //        item.GroupName = newGroup.NodeName;

        //        item.CheckGroup = false;//取消勾选
        //        item.IsGrouped = true;//设为已经成组
        //    }

        //    GroupList.Add(newGroup);//添加组
        //}


        //private RelayCommand<object> _ungroupSensorsCommand;
        ///// <summary>
        ///// 解组 的命令
        ///// </summary>
        //public RelayCommand<object> UngroupSensorsCommand
        //{
        //    get
        //    {
        //        return _ungroupSensorsCommand ?? (_ungroupSensorsCommand = new RelayCommand<object>(UngroupSensors));
        //    }
        //}
        //private void UngroupSensors(object param)
        //{
        //    var selected = SensorList.Where(i => i.CheckGroup == true);
        //    if (selected.ToList().Count <= 0)
        //        return;


        //    var num = selected.GroupBy(i => i.GroupName)
        //                         .Where(j => j.Count() > 0)
        //                         .Select(k => k.Key)
        //                         .ToList()
        //                         .Count;

        //    if (num > 1)
        //    {
        //        System.Windows.MessageBox.Show("所选传感器属于不同组，重选");
        //        return;
        //    }

        //    var groupName2delete = selected.ToList()[0].GroupName;
        //    GroupList.RemoveAll(i => i.NodeName == groupName2delete);

        //    var all = SensorList.Where(i => i.GroupName == groupName2delete);
        //    foreach (var item in all)
        //    {
        //        item.GroupName = "";
        //        item.IsGrouped = false;
        //    }
        //}

        //private RelayCommand<object> _moveOutGroupCommand;
        ///// <summary>
        ///// 移出组 的命令
        ///// </summary>
        //public RelayCommand<object> MoveOutGroupCommand
        //{
        //    get
        //    {
        //        return _moveOutGroupCommand ?? (_moveOutGroupCommand = new RelayCommand<object>(MoveOutGroup));
        //    }
        //}
        //private void MoveOutGroup(object param)
        //{
        //    //var selected = SensorList.Where(i => i.CheckGroup == true);
        //    //if (selected.ToList().Count <= 0)
        //    //{
        //    //    return;
        //    //}

        //    //foreach (var item in selected)
        //    //{
        //    //    var tem = GroupList.Where(i => i.NodeName == item.GroupName)
        //    //                          .ToList()
        //    //                          .RemoveAll(j=>j.IncludeSensor.)

        //    //    item.IsGrouped = false;
        //    //    item.GroupName = "";
        //    //}
        //}
        //#endregion


        #endregion
    }
}
