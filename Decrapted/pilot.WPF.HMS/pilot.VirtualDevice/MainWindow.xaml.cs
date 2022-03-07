using pilot.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pilot.VirtualDevice
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        SlavePort slavePort = new SlavePort();
        TestModbus testModbus = new TestModbus();
        Sensors sensors = new Sensors();

        public MainWindow()
        {
            InitializeComponent();
            slavePort.OpenPort();

            sensors.SendSensorsValuesEvent += new Action<int[]>((a) => 
            {
                Task.Run(() => 
                {
                    for (ushort i = 0; i < a.Length; i++)
                    {
                        testModbus.Storage.InputRegisters[i] = (ushort)a[i];
                    }
                });
            });


        }

        /// <summary>
        /// 增加Slave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            testModbus.AddSlave(slavePort.slaveSerial);
        }

        /// <summary>
        /// 更新SLave ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_slaveID_TextChanged(object sender, TextChangedEventArgs e)
        {
            byte id = byte.Parse(tb_slaveID.Text);

            testModbus.SlaveID = id;
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            testModbus.RemoveSlave(byte.Parse(tb_slaveID2Remove.Text));
        }

        bool firstClickFlag = false;
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            if(firstClickFlag==false)
            {
                testModbus.StartListen();
            }

            firstClickFlag = true;

            sensors.StartTimer();
        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            sensors.Freq = int.Parse(tb_freq.Text);
            sensors.SensorNum = int.Parse(tb_sensorNum.Text);
            sensors.SetTimer();
            sensors.UpdateSensorValueArray();   
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            sensors.StopTimer();
        }
    }
}
