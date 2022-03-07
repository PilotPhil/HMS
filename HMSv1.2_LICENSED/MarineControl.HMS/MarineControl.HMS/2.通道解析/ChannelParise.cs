using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS
{
    /// <summary>
    /// 通道解析类
    /// 串口类读取到一段字符串后调用此类中方法，解析出传感器ID和值，再对应处理
    /// </summary>
    public class ChannelParise//单例模式
    {
        /// <summary>
        /// 分割符
        /// </summary>
        public string startStr { get; set; }//开始字符
        public string splitStr { get; set; }//分割符
        public string endStr { get;set; }//结束符

        private static ChannelParise _Instance;//唯一实例

        //定义一个标识确保线程同步
        private static readonly object locker = new object();

        /// <summary>
        /// 构造
        /// </summary>
        private ChannelParise()
        {
            startStr = "S";
            splitStr = "%";
            endStr = "E";
        }

        /// <summary>
        /// 获取实例 多线程安全
        /// </summary>
        /// <returns></returns>
        public static ChannelParise GetInstance()
        {
            // 当第一个线程运行到此，locker对象会 加锁
            //当第二个线程运行到此，首先检测到locker对象为“已上锁”状态，该线程就会挂起等待第一个线程解除加锁状态

            //lock语句运行完后，即线程运行完后，解锁
            if (_Instance == null)//先判断，双重锁定
            {
                lock (locker)
                {
                    if (_Instance == null)//实例不存在就实例化一个
                    {
                        _Instance = new ChannelParise();
                    }
                }
            }
            return _Instance;
        }
        
        /// <summary>
        /// 改变解析规则
        /// </summary>
        /// <param name="ruleStr"></param>
        public void ChangeRule(string ruleStr)
        {
            string[] rules = ruleStr.Split(',');
            if(rules.Length==4)
            {
                startStr = rules[0];
                endStr = rules[3];
                splitStr = rules[1];
            }
        }

        /// <summary>
        /// 字符串分割
        /// </summary>
        /// <param name="data"></param>
        /// <param name="splitChar"></param>
        /// <param name="sensorId"></param>
        /// <param name="sensorName"></param>
        public bool Parise(string data,out int id,out double value)
        {
            string sensorId;
            string sensorName;
            string sensorValue;

            id = -1;
            value = 0;

            //分割字符
            var splitChar = splitStr[0];
            //使用分割字符分割
            string[] sArray = data.Split(splitChar);
            //校验长度、首字符、尾字符
            if (sArray.Length==5 && sArray[0]==startStr && sArray[4]==endStr)
            {
                //MessageBox.Show(DateTime.Now.ToString());
                //Console.WriteLine(DateTime.Now.ToString());
                sensorId = sArray[1];
                sensorName = sArray[2];
                sensorValue = sArray[3];
            }
            else
            {
                return false;
            }

            //id和value有一个无法被解析为数字就返回
            if (int.TryParse(sensorId, out id) == false || double.TryParse(sensorValue, out value) == false)
            {
                MessageBox.Show("解析错误");
                return false;
                
            }

            return true;
        }
    }
}
