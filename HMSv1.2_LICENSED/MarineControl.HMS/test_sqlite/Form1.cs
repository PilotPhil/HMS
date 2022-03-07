using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using MarineControl.HMS.DataBase;
using System.Data.SqlClient;

using System.Configuration;
using System.Collections;

using TestConfig;

namespace test_sqlite
{
    public partial class Form1 : Form
    {
        

        SQLiteParameter[] param = 
        {
            new SQLiteParameter("@CreateTime",DbType.String),
            new SQLiteParameter("@Name",DbType.String),
            new SQLiteParameter("@Authority",DbType.Int32)
        };

        SQLiteHelper sh;

        

        public Form1()
        {
            InitializeComponent();

            sh = new SQLiteHelper(Application.StartupPath + "\\Data\\HMS.db");
            //sh.OpenDb();

            treeView1.Nodes.Add("HMS DataBase");
            //treeView1.SelectedNode.Nodes.Add("sensor1");

            //IDictionary idTest1 = (IDictionary)ConfigurationManager.GetSection("Test1");
            //MessageBox.Show((string)idTest1["setting1"]);

            var key1 = ConfigHelper.ReadSetting("key1");
            MessageBox.Show(key1);

            ConfigHelper.WriteSetting("key1", "1126");

            
        }

        ~Form1()
        {
            sh.CloseDb();
            MessageBox.Show("已关闭数据库连接");
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="dbPath"></param>
        private void AddStars(string dbPath)
        {
            SQLiteHelper sqlHelper = new SQLiteHelper(dbPath);
            sqlHelper.OpenDb();
            string commandStr = "insert into User(CreateTime,Name,Authority) values(@CreateTime,@Name,@Authority)";

            param[0].Value="2021-4-30";
            param[1].Value="DWB";
            param[2].Value = 0;


            sqlHelper.ExecuteNonQuery(commandStr,param );

            sqlHelper.CloseDb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var dt=sh.ExecuteQuery("select * from User where Authority<0");
            var dt=sh.ExecuteQuery("select name from sqlite_master where type='table' order by name;");
            dataGridView1.DataSource = dt;

            for(int i=0;i<dt.Rows.Count;i++)
            {
                var tem = dt.Rows[i].ItemArray[0].ToString();
                treeView1.Nodes[0].Nodes.Add(tem);
            }

        }
    }
}
