using NModbus;
using NModbus.Logging;
using NModbus.Serial;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace pilot.Communication
{
    class TestModbus
    {
        //从站存储空间
        public SlaveStorage Storage { get; set; } = new SlaveStorage();

        //slaveNetwork
        public IModbusSlaveNetwork slaveNetwork { get; set; }

        //从站地址
        private byte _slaveID=3;
        public byte SlaveID 
        {
            get { return _slaveID; }
            set
            {
                if(value<1 || value>247)
                {
                    MessageBox.Show("Slave address is range from 1 to 247");
                }
                else
                {
                    _slaveID = value;
                }
            }
        }


        /// <summary>
        /// 建立从站
        /// </summary>
        public void AddSlave(SerialPort slavePort)
        {
            var adapter = new SerialPortAdapter(slavePort);
            var functionServices = new IModbusFunctionService[] { new HmiBufferFunctionService() };
            var factory = new ModbusFactory(functionServices, true, new ConsoleModbusLogger(LoggingLevel.Debug));
            slaveNetwork = factory.CreateRtuSlaveNetwork(adapter);
            IModbusSlave slave1 = factory.CreateSlave(SlaveID, Storage);
            slaveNetwork.AddSlave(slave1);
        }

        /// <summary>
        /// 移除从站
        /// </summary>
        /// <param name="slaveID"></param>
        public void RemoveSlave(byte slaveID)
        {
            slaveNetwork.RemoveSlave(slaveID);
        }

        /// <summary>
        /// 开始监听
        /// </summary>
        /// <returns></returns>
        public void StartListen()
        {
            Task.Run(() => { slaveNetwork.ListenAsync(); });
        }


        //public async Task SlaveTest()
        //{
        //    using (SerialPort slavePort = new SerialPort("COM9"))
        //    {
        //        // configure serial port
        //        slavePort.BaudRate = 9600;
        //        slavePort.DataBits = 8;
        //        slavePort.Parity = Parity.None;
        //        slavePort.StopBits = StopBits.One;
        //        slavePort.Open();

        //        var adapter = new SerialPortAdapter(slavePort);

        //        var functionServices = new IModbusFunctionService[]
        //        {
        //            new HmiBufferFunctionService()
        //        };

        //        var factory = new ModbusFactory(functionServices, true, new ConsoleModbusLogger(LoggingLevel.Debug));

        //        // create modbus slave
        //        var slaveNetwork = factory.CreateRtuSlaveNetwork(adapter);

        //        Storage = new SlaveStorage();

        //        Storage.InputRegisters.StorageOperationOccurred += (sender, args) => Console.WriteLine($"DANFOSS Input registers: {args.Operation} starting at {args.StartingAddress}");
        //        Storage.HoldingRegisters.StorageOperationOccurred += (sender, args) => Console.WriteLine($"DANFOSS Holding registers: {args.Operation} starting at {args.StartingAddress}");

        //        IModbusSlave danfossSlave = factory.CreateSlave(3, Storage);

        //        slaveNetwork.AddSlave(danfossSlave);

        //        Storage.InputRegisters[1] = 123;

        //        await slaveNetwork.ListenAsync();
        //        //await slaveNetwork.ListenAsync(cancellationToken);
        //    }
        //}


    }

    /*----------------------------------------------------------------*/
    public class HmiBufferFunctionService : IModbusFunctionService
    {
        public byte FunctionCode => 45;

        public IModbusMessage CreateRequest(byte[] frame)
        {
            Console.WriteLine($"HMI Buffer Message Receieved - {frame.Length} bytes");

            var request = new HmiBufferRequestmessage();

            request.Initialize(frame);

            return request;
        }

        public IModbusMessage HandleSlaveRequest(IModbusMessage request, ISlaveDataStore dataStore)
        {
            Console.WriteLine("HMI Buffer Message Receieved");

            throw new NotImplementedException();
        }

        public int GetRtuRequestBytesToRead(byte[] frameStart)
        {
            byte registerCountMSB = frameStart[4];
            byte registerCountLSB = frameStart[5];

            int numberOfRegisters = (registerCountMSB << 8) + registerCountLSB;

            Console.WriteLine($"Got Hmi Buffer Request for {numberOfRegisters} registers.");

            return (numberOfRegisters * 2) + 1;
        }

        public int GetRtuResponseBytesToRead(byte[] frameStart)
        {
            return 4;
        }
    }

    public class HmiBufferRequestmessage : IModbusMessage
    {
        public byte FunctionCode { get; set; }

        public byte SlaveAddress { get; set; }

        public byte[] MessageFrame { get; private set; }

        public byte[] ProtocolDataUnit { get; private set; }

        public ushort TransactionId { get; set; }

        public void Initialize(byte[] frame)
        {
            SlaveAddress = frame[0];
            FunctionCode = frame[1];

            MessageFrame = frame
                .Take(frame.Length - 2)
                .ToArray();

            ProtocolDataUnit = frame
                .Skip(1)
                .ToArray();
        }
    }

    public class SlaveStorage : ISlaveDataStore
    {
        private readonly SparsePointSource<bool> _coilDiscretes;
        private readonly SparsePointSource<bool> _coilInputs;
        private readonly SparsePointSource<ushort> _holdingRegisters;
        private readonly SparsePointSource<ushort> _inputRegisters;

        public SlaveStorage()
        {
            _coilDiscretes = new SparsePointSource<bool>();
            _coilInputs = new SparsePointSource<bool>();
            _holdingRegisters = new SparsePointSource<ushort>();
            _inputRegisters = new SparsePointSource<ushort>();
        }

        public SparsePointSource<bool> CoilDiscretes
        {
            get { return _coilDiscretes; }
        }

        public SparsePointSource<bool> CoilInputs
        {
            get { return _coilInputs; }
        }

        public SparsePointSource<ushort> HoldingRegisters
        {
            get { return _holdingRegisters; }
        }

        public SparsePointSource<ushort> InputRegisters
        {
            get { return _inputRegisters; }
        }

        IPointSource<bool> ISlaveDataStore.CoilDiscretes
        {
            get { return _coilDiscretes; }
        }

        IPointSource<bool> ISlaveDataStore.CoilInputs
        {
            get { return _coilInputs; }
        }

        IPointSource<ushort> ISlaveDataStore.HoldingRegisters
        {
            get { return _holdingRegisters; }
        }

        IPointSource<ushort> ISlaveDataStore.InputRegisters
        {
            get { return _inputRegisters; }
        }
    }

    /// <summary>
    /// Sparse storage for points.
    /// </summary>
    public class SparsePointSource<TPoint> : IPointSource<TPoint>
    {
        private readonly Dictionary<ushort, TPoint> _values = new Dictionary<ushort, TPoint>();

        public event EventHandler<StorageEventArgs<TPoint>> StorageOperationOccurred;

        /// <summary>
        /// Gets or sets the value of an individual point wih tout 
        /// </summary>
        /// <param name="registerIndex"></param>
        /// <returns></returns>
        public TPoint this[ushort registerIndex]
        {
            get
            {
                TPoint value;

                if (_values.TryGetValue(registerIndex, out value))
                    return value;

                return default(TPoint);
            }
            set { _values[registerIndex] = value; }
        }

        public TPoint[] ReadPoints(ushort startAddress, ushort numberOfPoints)
        {
            var points = new TPoint[numberOfPoints];

            for (ushort index = 0; index < numberOfPoints; index++)
            {
                points[index] = this[(ushort)(index + startAddress)];
            }

            StorageOperationOccurred?.Invoke(this,
                new StorageEventArgs<TPoint>(PointOperation.Read, startAddress, points));

            return points;
        }

        public void WritePoints(ushort startAddress, TPoint[] points)
        {
            for (ushort index = 0; index < points.Length; index++)
            {
                this[(ushort)(index + startAddress)] = points[index];
            }

            StorageOperationOccurred?.Invoke(this,
                new StorageEventArgs<TPoint>(PointOperation.Write, startAddress, points));
        }
    }

    public class StorageEventArgs<TPoint> : EventArgs
    {
        private readonly PointOperation _pointOperation;
        private readonly ushort _startingAddress;
        private readonly TPoint[] _points;

        public StorageEventArgs(PointOperation pointOperation, ushort startingAddress, TPoint[] points)
        {
            _pointOperation = pointOperation;
            _startingAddress = startingAddress;
            _points = points;
        }

        public ushort StartingAddress
        {
            get { return _startingAddress; }
        }

        public TPoint[] Points
        {
            get { return _points; }
        }

        public PointOperation Operation
        {
            get { return _pointOperation; }
        }
    }

    public enum PointOperation
    {
        Read,

        Write
    }
}
