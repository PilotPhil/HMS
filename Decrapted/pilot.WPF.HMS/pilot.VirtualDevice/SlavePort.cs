using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pilot.VirtualDevice
{
    class SlavePort
    {
        public SerialPort slaveSerial { get; set; }

        public SlavePort()
        {
            slaveSerial = new SerialPort()
            {
                PortName = "COM20",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            };
        }

        public void OpenPort()
        {
            try
            {
                if (slaveSerial.IsOpen == true)
                {
                    slaveSerial.Close();
                }

                slaveSerial.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void ClosePort()
        {
            try
            {
                if(slaveSerial.IsOpen==true)
                {
                    slaveSerial.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Disposal()
        {
            slaveSerial.Close();
            slaveSerial.Dispose();
            slaveSerial = null;
        }
    }
}
