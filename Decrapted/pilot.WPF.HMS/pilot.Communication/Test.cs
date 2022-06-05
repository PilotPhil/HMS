using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.Communication
{
    class Test
    {
        

        static async Task<int> Main()
        {
            //ModBus modBus = new ModBus();
            TestModbus testModbus = new TestModbus();


            try
            {
                await testModbus.SlaveTest();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }

            Console.Read();

            return 0;
        }
    }
}
