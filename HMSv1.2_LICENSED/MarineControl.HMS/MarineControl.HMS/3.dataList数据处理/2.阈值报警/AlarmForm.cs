using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.Alarm
{
    public partial class AlarmForm : Form
    {
        /// <summary>
        /// 上限
        /// </summary>
        private double _up;
        public double up
        {
            get { return _up; }
            set { _up = value; }
        }

        /// <summary>
        /// 下限
        /// </summary>
        private double _down;
        public double down
        {
            get { return _down; }
            set { _down = value; }
        }

        /// <summary>
        /// 连续检验长度
        /// </summary>
        private double _checkLength = 3;
        public double checkLength
        {
            get { return _checkLength; }
            set 
            {
                if(value<=1)
                {
                    throw new AggregateException("检验长度不可小于1");
                }
                else
                {
                    _checkLength = value;
                }
            }
        }


        public delegate void SendOverRangeValueHandler(string up, double value);
        public SendOverRangeValueHandler sendOverRangeValueEvent;

        /// <summary>
        /// 构造
        /// </summary>
        public AlarmForm()
        {
            InitializeComponent();

            up = 8;
            down = -8;

            //列自适应
            //Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// 设置上下限
        /// </summary>
        /// <param name="up">上限</param>
        /// <param name="down">下限</param>
        public void SetUpDown(double up,double down)
        {
            if(up<=down)
            {
                MessageBox.Show("上限不可小于下限");
                return;
            }
            this.up = up;
            this.down = down;
        }

        //检测用标志位，通过其和判断
        private List<int> checkBit = new List<int>();
        //检测用值，通过其和取得平均值
        private List<double> checkValue = new List<double>();

        Stopwatch sw = new Stopwatch();
        /// <summary>
        /// 检测
        /// </summary>
        /// <param name="dataPoint">检测时压入的数据点</param>
        public void Detect(double dataPoint)
        {
            //连续三个值 检测过就清空
            if (checkBit.Count == 3)
            {
                var time = DateTime.Now.ToString();
                double sumValue = 0;
                int sumIndex = 0;

                var tem1 = new List<double>(checkValue);
                var tem2 = new List<int>(checkBit);

                tem1.ForEach((value) => { sumValue += value; });
                tem2.ForEach((value) => { sumIndex += value; });
                sw.Restart();////////////
                if (sumIndex == 3 || sumIndex == -3)
                {
                    //int index = dataGridView1.Rows.Add(new DataGridViewRow());
                    //dataGridView1.Rows[index].Cells[0].Value = index + 1;
                    //dataGridView1.Rows[index].Cells[1].Value = time;
                    //dataGridView1.Rows[index].Cells[2].Value = sumValue / 3;

                    if (sumIndex == 3)
                        sendOverRangeValueEvent?.Invoke("up", sumValue / 3);
                    else
                        sendOverRangeValueEvent?.Invoke("down", sumValue / 3);
                }
                checkBit.Clear();
                checkValue.Clear();

                /////////////////////
                sw.Stop();
                var t = sw.ElapsedMilliseconds;

                if (t > 0)
                    Console.WriteLine(t.ToString());
            }



            var tem = Check(dataPoint);
            if (tem != 0)
            {
                checkBit.Add(tem);
                checkValue.Add(dataPoint);
            }


        }

        /// <summary>
        /// 标志位裁定
        /// </summary>
        /// <param name="dataPoint"></param>
        /// <returns></returns>
        private int Check(double dataPoint)
        {
            if (dataPoint > up)
                return 1;
            else if (dataPoint <= down)
                return -1;
            else
                return 0;
        }
    }
}
