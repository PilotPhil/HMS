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

namespace test_sqlite
{
    public partial class Form2 : Form
    {
        SQLiteHelper sh;

        System.Timers.Timer timer = new System.Timers.Timer();

        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        private delegate void test();

        public Form2()
        {
            InitializeComponent();

            var path = SQLiteHelper.GetDataBasePath();
            sh = new SQLiteHelper(path);
            sh.OpenDb();

            timer.Interval = 2000;

            test test1 = delegate
            {
                try
                {
                    if (dt1.Rows.Count <= 0 || dt1 == null)
                        return;

                    dataGridView1.DataSource = dt1;
                    dataGridView2.DataSource = dt2;
                    dataGridView3.DataSource = dt3;
                    dataGridView4.DataSource = dt4;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            };

            dataGridView1.DataError += (s,e) => { };
            dataGridView2.DataError += (s,e) => { };
            dataGridView3.DataError += (s,e) => { };
            dataGridView4.DataError += (s,e) => { };

            timer.Elapsed += (s, e) =>
              {
                  try
                  {
                      Task task = new Task(()=> 
                      {
                          dt1 = sh.ExecuteQuery("select Time,OverWay,value from Sensor1_alarm limit 20");
                          dt2 = sh.ExecuteQuery("select Time,OverWay,value from Sensor2_alarm limit 20");
                          dt3 = sh.ExecuteQuery("select Time,OverWay,value from Sensor3_alarm limit 20");
                          dt4 = sh.ExecuteQuery("select Time,OverWay,value from Sensor4_alarm limit 20");
                      });

                      task.Start();
                      task.Wait();
                      dataGridView1.Invoke(test1);
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show(ex.ToString());
                  }
              };

            timer.Start();
        }
    }
}
