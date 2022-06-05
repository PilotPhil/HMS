using pilot.HMS.Common;
using pilot.HMS.DataAccess.DataEntity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pilot.HMS.DataAccess
{
    //单例
    public class SqlServerDataAccess
    {
        //
        private static SqlServerDataAccess _Instance=null;

        //
        private SqlServerDataAccess() { }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static SqlServerDataAccess GetInstance()
        {
            return _Instance ?? (new SqlServerDataAccess());
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        /// <summary>
        /// 回收处理
        /// </summary>
        private void Dispose()
        {
            if (dataAdapter != null)
            {
                dataAdapter.Dispose();
                dataAdapter = null;
            }

            if (command != null)
            {
                command.Dispose();
                command = null;
            }

            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        /// <returns></returns>
        private bool DBConnection()
        {
            //从配置文件获取连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["SqlServerDataBase"].ConnectionString;

            if (connection == null)
            {
                connection = new SqlConnection(connStr);//连接字符串
            }

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //throw ex;
                Console.WriteLine("db open failed");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable GetDatas(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if(DBConnection()==true)
                {
                    dataAdapter = new SqlDataAdapter(sql, connection);
                    dataAdapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            return dt;
        }

        /// <summary>
        /// 运行sql语句
        /// </summary>
        /// <param name="sql">要运行的sql语句</param>
        public void RunSql(string sql)
        {
            try
            {
                if(DBConnection()==true)
                {
                    command = new SqlCommand();
                    command.CommandText = sql;
                    command.Connection = this.connection;

                    command.ExecuteNonQuery();//执行且仅执行SQL命令，不反回结果集，用于插入、删除、修改命令
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Dispose();
            }
        }

        //校验用户，检查用户是否存在
        public UserEntity CheckUserInfo(string userName, string pwd)
        {
            try
            {
                if (DBConnection() == true)//数据库已打开
                {
                    string userSql = "select * from users where user_name=@user_name and password=@pwd and is_validation=1";

                    dataAdapter = new SqlDataAdapter(userSql, connection);

                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@user_name", SqlDbType.VarChar) { Value = userName });
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar) { Value = 
                        MD5Provider.GetMD5String(pwd+"@"+userName)});//MD5加密

                    DataTable dataTable = new DataTable();
                    int count = dataAdapter.Fill(dataTable);

                    if (count <= 0)
                    {
                        throw new Exception("用户名或密码不正确!");
                    }

                    DataRow dataRow = dataTable.Rows[0];

                    //用户实体
                    UserEntity userEntity = new UserEntity();

                    userEntity.UserId = dataRow.Field<string>("user_id");
                    userEntity.UserName = dataRow.Field<string>("user_name");
                    userEntity.Password = dataRow.Field<string>("password");
                    userEntity.Authority = dataRow.Field<string>("authority");

                    return userEntity;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
                
            }

            //
            return null;
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserInfo()
        {
            string strSql = "select * from users";
            return this.GetDatas(strSql);
        }

        /// <summary>
        /// 更新用户数据到数据库
        /// </summary>
        /// <param name="dt">与用户表DataGrid绑定的datagrid</param>
        public void Update2UserTable(DataTable dt)
        {
            try
            {
                if (DBConnection() == true)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("select * from users", connection);
                    SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
                    adapter.Update(dt);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Dispose();
            }


        }
    }
}
