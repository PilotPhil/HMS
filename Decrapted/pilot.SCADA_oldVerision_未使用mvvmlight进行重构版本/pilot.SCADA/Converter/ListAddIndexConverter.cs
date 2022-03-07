using pilot.SCADA.Global;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace pilot.SCADA.Converter
{
    /// <summary>
    /// 用于将Modbus接受的数据转换一层加上序号，用于数据监视器
    /// </summary>
    public class ListAddIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<DataPoint> raw)
            {
                List<string> res = new List<string>();

                for (int i = 0; i < raw.Count; i++)
                {
                    res.Add(raw[i].TimeStamp.ToString() + "   " + (i + 1).ToString() + "号:   " + raw[i].Value.ToString());
                }
                return res;

            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
