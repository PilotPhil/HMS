using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarineControl.HMS.DataBase;
using MarineControl.HMS.File;
using System.Data.SQLite;

namespace MarineControl.HMS.FORM
{
    public partial class Form_DatabaseView : Form
    {
        //数据库操作帮助对象
        SQLiteHelper sh;

        SQLiteParameter[] param ={new SQLiteParameter("@Table",DbType.String)};

        //工具提示（悬浮提示）
        ToolTip toolTip = new ToolTip();

        //导出到excel
        Export2Excel export = new Export2Excel();

        //筛选页面
        DbFilter dbFilter = new DbFilter();

        /// <summary>
        /// 构造
        /// </summary>
        public Form_DatabaseView()
        {
            InitializeComponent();
            //数据库助手
            var dbPath = SQLiteHelper.GetDataBasePath();
            sh = new SQLiteHelper(dbPath);
            //打开数据库
            sh.OpenDb();
            //添加主节点
            treeView1.Nodes.Add("HMS DataBase");
            //扫描数据库下的所有表
            ScanAllTable();

            //按钮提示
            toolTip.SetToolTip(btn_export, "导出视图内数据");
            //toolTip.SetToolTip(btn_inport, "导入数据");
            toolTip.SetToolTip(btn_scanTables,"刷新");
            toolTip.SetToolTip(btn_filter,"筛选数据");

            MakeDelegate();
        }

        /// <summary>
        /// 析构
        /// </summary>
        ~Form_DatabaseView()
        {
            sh.CloseDb();
        }

        /// <summary>
        /// 多代理 注册
        /// </summary>
        private void MakeDelegate()
        {
            //扫描 刷新 按钮
            btn_scanTables.Click += (sender, eve) => 
            { 
                ScanAllTable(); 
            };

            //导出
            btn_export.Click += (sender, eve) =>
            {
                //原来多线程可导出，现在未知愿意无法正常导出，故先注释掉
                //Task.Factory.StartNew(() =>
                //{
                //    export.OutputAsExcelFile(dataGridView1);
                //});
                export.OutputAsExcelFile(dataGridView1);
            };

            //筛选页面
            btn_filter.Click += (sender, eve) =>
            {
                dbFilter.ShowDialog();
            };

            dbFilter.DbFilter_GetSqlEvent += (sqls) =>
            {
                if (sqls[0] == null)
                    return;

                var table = treeView1.SelectedNode.Text;
                //要执行的sql语句
                //选择列
                string sql = "select " + sqls[0] + " from " + table;
                //值关系
                if (sqls[1]!="")
                    sql+= " where " + sqls[1];
                //排序
                if (sqls[2] != "")
                    sql += " order by " + sqls[2];

                Task<DataTable> task = new Task<DataTable>(() =>
                {
                    return sh.ExecuteQuery(sql);
                });
                task.Start();
                task.Wait();
                dataGridView1.DataSource = task.Result;
            };
        }

        /// <summary>
        /// 刷新 扫描 数据库内所有的表，并更新再treeview上
        /// </summary>
        private void ScanAllTable()
        {
            DataTable dt;
            Task<DataTable> task = new Task<DataTable>(() =>
              {
                  return sh.ExecuteQuery("select name from sqlite_master where type = 'table' order by name; ");
              });
            task.Start();
            task.Wait();
            dt=task.Result;//获取多线程结果
                
            //检验数据源是否为空
            if(dt.Rows.Count<=0)
            {
                MessageBox.Show("数据库内无表");
                return;
            }

            //清空原treeview中node
            treeView1.Nodes[0].Nodes.Clear();
            //添加node
            for(int i=0;i<dt.Rows.Count;i++)
            {
                treeView1.Nodes[0].Nodes.Add(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        /// <summary>
        /// 树型图 改变选择项后 更新数据库视图显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取要显示的表名
            var tableName = e.Node.Text;
            //构成要执行的sql语句
            var sql = "select * from " + tableName;
            //多线程执行sql语句
            Task<DataTable> task = new Task<DataTable>(() =>
              {
                  var dt = sh.ExecuteQuery(sql);
                  return dt;
              });
            task.Start();
            task.Wait();
            dataGridView1.DataSource = task.Result;//设置表格的数据源 为 sql执行结果

            //数据源列数
            int num = dataGridView1.Columns.Count;
            //表格宽度
            int wth = dataGridView1.Width;
            //设置表格中每一列的宽度
            for (int i = 0; i < num; i++)
            {
                dataGridView1.Columns[i].Width = (int)(0.8 * wth / num);
            }
        }
    }
}
