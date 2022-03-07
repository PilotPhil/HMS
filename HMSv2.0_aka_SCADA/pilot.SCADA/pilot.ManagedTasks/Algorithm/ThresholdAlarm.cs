using System.Collections.Generic;
using System.Linq;

namespace pilot.ManagedTasks.Algorithm
{
    public class ThresholdAlarm
    {
        public AlarmRes CheckOutThreshold(List<float> inp, double H = 20, double L = -10, double rate = 0.3)
        {
            int num_h = 0;
            int num_l = 0;

            int num = inp.Count();
            inp.ForEach(i =>
              {
                  if (i > H)
                      num_h++;
                  else if (i < L)
                      num_l++;
              });

            var rate_h = (double)(num_h / num);
            var rate_l = (double)(num_l / num);

            if (rate_h > rate)
                return new AlarmRes() { aInfo = "High", extValue = inp.Max(), avgValue = inp.Average(), id = 1 };
            else if (rate_l > rate)
                return new AlarmRes() { aInfo = "Low", extValue = inp.Min(), avgValue = inp.Average(), id = -1 };
            else
                return new AlarmRes() { aInfo = "Normal", extValue = 0, avgValue = 0, id = 0 };
        }
    }

    public class AlarmRes
    {
        public int id { get; set; } = 0;
        public string aInfo { get; set; } = "High";
        public float extValue { get; set; } = 0;
        public float avgValue { get; set; } = 0;
    }
}
