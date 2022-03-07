using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDP_TEST2
{
    class Class1
    {
        static UdpCom udp = new UdpCom();
        static void Main()
        {
            udp.Connect();

            Console.ReadKey();
        }
    }
}
