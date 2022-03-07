using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MarineControl.HMS.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.FORM
{
    public partial class Form_simple : Form
    {
        //配置助手
        IniFileHelper IH = new IniFileHelper("sensor.ini");

        //
        public delegate void SendSensorCfgHandler(int id,string[] cfg);
        public SendSensorCfgHandler SendSensorCfgEvent;

        public Form_simple()
        {
            InitializeComponent();

            TableInit();
            TableDelegates();
        }

        /// <summary>
        /// 表格初始化
        /// </summary>
        private void TableInit()
        {
            //创建checkbox列
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "select";
            //列名称。
            checkBoxColumn.HeaderText = "启用";
            //添加到后边儿，
            dataGridView1.Columns.Add(checkBoxColumn);

            //Bitmap umMark = blank;
            var imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "保存配置";
            imgCol.Icon = new Icon("监测.ico");
            //imgCol.Image = new Bitmap("D:\\Gitee\\HMS_DotNet\\MarineControl.HMS\\MarineControl.HMS\\Resources\\保存.png");
            imgCol.Image = new Bitmap(Application.StartupPath + "\\ico\\save.png");
            dataGridView1.Columns.Add(imgCol);

            //从ini配置文件导入
            for (int i = 1; i <= 6; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());

                var temRow = dataGridView1.Rows[i - 1];
                temRow.Height = 38;
                var sensorName = "sensor" + i.ToString();
                temRow.Cells[0].Value = i;
                temRow.Cells[1].Value = IH.Read(sensorName, "name");
                temRow.Cells[2].Value = IH.Read(sensorName, "type");
                temRow.Cells[3].Value = IH.Read(sensorName, "location");
                temRow.Cells[4].Value = IH.Read(sensorName, "filter");
                temRow.Cells[5].Value = IH.Read(sensorName, "interval_short").ToString();
                temRow.Cells[6].Value = IH.Read(sensorName, "interval_long").ToString();
                temRow.Cells[7].Value = IH.Read(sensorName, "up").ToString();
                temRow.Cells[8].Value = IH.Read(sensorName, "down").ToString();

                temRow.Cells[9].Value = true;
            }

            //传感器序号设置为只读
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void TableDelegates()
        {

            dataGridView1.CellClick += SendSensorCfg;
        }

        //发送传感器配置
        private void SendSensorCfg(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 10)//若触发的并非为保存配置
                return;

            var seletedRow = dataGridView1.Rows[e.RowIndex];//触发的行

            string[] param = new string[9];

            param[0] = seletedRow.Cells[1].Value.ToString();//name
            param[1] = seletedRow.Cells[2].Value.ToString();//type
            param[2] = seletedRow.Cells[3].Value.ToString();//location
            param[3] = seletedRow.Cells[4].Value.ToString();//filter
            param[4] = seletedRow.Cells[5].Value.ToString();//interval_short
            param[5] = seletedRow.Cells[6].Value.ToString();//interval_long
            param[6] = seletedRow.Cells[7].Value.ToString();//up
            param[7] = seletedRow.Cells[8].Value.ToString();//down


            var str = seletedRow.Cells[9].Value.ToString();
            param[8] = str == "True" ? "1" : "0";


            var id = Convert.ToInt32(seletedRow.Cells[0].Value);
            SendSensorCfgEvent?.Invoke(id, param);
        }


        /// <summary>
        /// 获取传感器配置并更新到table上
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cfg"></param>
        public void GetSensorCfg2Update(int id,string[] cfg)
        {
            var rows = dataGridView1.Rows.Count;
            if(id>rows || rows<=0 || cfg.Length!=9)
            {
                FrmTips.ShowTipsInfo(new Form(), "Error!");
                return;
            }

            var seletedRow = dataGridView1.Rows[id-1];

            seletedRow.Cells[1].Value = cfg[0];//name
            seletedRow.Cells[2].Value = cfg[1];//type
            seletedRow.Cells[3].Value = cfg[2];//location
            seletedRow.Cells[4].Value = cfg[3];//filter
            seletedRow.Cells[5].Value = cfg[4];//interval_short
            seletedRow.Cells[6].Value = cfg[5];//interval_long
            seletedRow.Cells[7].Value = cfg[6];//up
            seletedRow.Cells[8].Value = cfg[7];//down
            seletedRow.Cells[9].Value = cfg[8]=="1"?true:false;//use?
        }
    }
}
