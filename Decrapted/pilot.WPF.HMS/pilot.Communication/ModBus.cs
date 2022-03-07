//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Timers;
//using NModbus;
//using NModbus.Utility;
//using NModbus.Serial;

//namespace pilot.Communication
//{
//    public class ModBus
//    {
//        public ModBus()
//        {
//            //串口发送
//            SerialPort serial = new SerialPort()
//            {
//                PortName = "COM9",
//                BaudRate = 9600,
//                Parity = Parity.None,
//                StopBits = StopBits.One,
//                DataBits = 8
//            };
//            serial.Open();

//            MasterTest(serial);
//            //SlaveMater(serial);
//        }


//        private void MasterTest(SerialPort serial)
//        {
//            var master = ModbusSerialMaster.CreateRtu(serial);
//            master.Transport.ReadTimeout = 1000;

//            byte slaveID = 3;
//            ushort adddress = 0;
//            ushort[] res = master.ReadInputRegisters(slaveID, adddress, 10);
//        }

//        private void SlaveMater(SerialPort serial)
//        {
//            byte slaveID = 3;
//            var slave = ModbusSerialSlave.CreateRtu(slaveID, serial);
//            slave.ModbusSlaveRequestReceived += new EventHandler<ModbusSlaveRequestEventArgs>(Modbus_Request_Event);
//            slave.DataStore = Modbus.Data.DataStoreFactory.CreateDefaultDataStore();
//            slave.DataStore.DataStoreWrittenTo += new EventHandler<Modbus.Data.DataStoreEventArgs>(Modbus_DataStoreWriteTo);

//            slave.DataStore.InputRegisters[1] = 123;
//            Console.WriteLine(slave.DataStore.InputRegisters.Count);
//        }




//        //private void Modbus_DataStoreWriteTo(object sender, DataStoreEventArgs e)
//        //{
//        //    switch (e.ModbusDataType)
//        //    {
//        //        case ModbusDataType.HoldingRegister:
//        //            for (int i = 0; i < e.Data.B.Count; i++)
//        //            {
//        //                //Set AO 
//        //                //e.Data.B[i] already write to slave.DataStore.HoldingRegisters[e.StartAddress + i + 1]
//        //           //e.StartAddress starts from 0
//        //           //You can set AO value to hardware here 
//        //            }
//        //            break;
//        //        case ModbusDataType.Coil:
//        //            for (int i = 0; i < e.Data.A.Count; i++)
//        //            {
//        //                //set DO
//        //                //e.Data.A[i] already write to slave.DataStore.CoilDiscretes[e.StartAddress + i + 1]
//        //           //e.StartAddress starts from 0
//        //           //You can set DO value to hardware here
//        //            }
//        //            break;
//        //    }
//        //}

//        //private void Modbus_Request_Event(object sender, Modbus.Device.ModbusSlaveRequestEventArgs e)
//        //{
//        //    //disassemble packet from master
//        //    byte fc = e.Message.FunctionCode;
//        //    byte[] data = e.Message.MessageFrame;
//        //    byte[] byteStartAddress = new byte[] { data[3], data[2] };
//        //    byte[] byteNum = new byte[] { data[5], data[4] };
//        //    Int16 StartAddress = BitConverter.ToInt16(byteStartAddress, 0);
//        //    Int16 NumOfPoint = BitConverter.ToInt16(byteNum, 0);

//        //    Console.WriteLine(fc.ToString() + "," + StartAddress.ToString() + "," + NumOfPoint.ToString());
//        //}

//        /// <summary>
//        /// 读线圈状态测试
//        /// </summary>
//        public void Test_0x01()
//        {
//            List<byte> command = new List<byte>();
//            command.Add(0x01);//从站地址：1号从站
//            command.Add(0x01);//功能码：读线圈状态

//            ushort startAddr = 0;
//            ushort readLen = 10;
//            command.Add(BitConverter.GetBytes(startAddr)[1]);//起始地址高位
//            command.Add(BitConverter.GetBytes(startAddr)[0]);//起始地址低位

//            command.Add(BitConverter.GetBytes(readLen)[1]);//读取长度高位
//            command.Add(BitConverter.GetBytes(readLen)[0]);//读取长度低位

//            command=CRC16(command);//CRC校验


//            //串口发送
//            SerialPort serial = new SerialPort()
//            {
//                PortName = "COM9",
//                BaudRate = 9600,
//                Parity = Parity.None,
//                StopBits = StopBits.One,
//                DataBits = 8
//            };

//            serial.Open();

//            serial.Write(command.ToArray(),0, command.Count);

//            //报文的接受与解析
//            byte[] respBytes = new byte[serial.BytesToRead];
//            serial.Read(respBytes, 0, respBytes.Length);


//        }

//        /// <summary>
//        /// CRC16校验
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="poly"></param>
//        /// <param name="crcInit"></param>
//        /// <returns></returns>
//        private List<byte> CRC16(List<byte> value,ushort poly=0xA001,ushort crcInit=0xFFFF)
//        {
//            if(value==null || !value.Any())
//            {
//                throw new ArgumentException("");
//            }

//            //
//            ushort crc = crcInit;
//            for (int i = 0; i < value.Count; i++)
//            {
//                crc = (ushort)(crc ^ (value[i]));

//                for (int j = 0; j < 8; j++)
//                {
//                    crc = (crc & 1) != 0 ? (ushort)((crc >> 1) ^ poly) : (ushort)(crc >> 1);
//                }
//            }

//            byte hi = (byte)((crc & 0xFF00) >> 8);
//            byte lo = (byte)(crc & 0x00FF);

//            List<byte> buffer = new List<byte>();
//            buffer.AddRange(value);
//            buffer.Add(lo);
//            buffer.Add(hi);

//            return buffer;
//        }
//    }
//}
