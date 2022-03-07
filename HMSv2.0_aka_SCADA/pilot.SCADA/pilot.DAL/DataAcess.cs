using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.DAL
{
    public class DataAcess
    {
        //private static string DBConfig = ConfigurationManager.ConnectionStrings["db_config"].ToString();
        public static string DBConfig = @"Server=DESKTOP-UAEUH32\SQLEXPRESS;DataBase=TestDB;Uid=sa;Pwd=1126";//default db connection

        /// <summary>
        /// 保存一条实时数据
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="sValue"></param>
        /// <param name="sTime"></param>
        /// <returns></returns>
        public static int InsertRTData(string sGuid, double sValue, string sTime)
        {
            string sql = "INSERT INTO RTData(sGuid,sValue,sTime) VALUES(@sGuid,@sValue,@sTime)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@sGuid",SqlDbType.VarChar),
                new SqlParameter("@sValue",SqlDbType.Float),
                new SqlParameter("@sTime",SqlDbType.VarChar),
            };

            param[0].Value = sGuid;
            param[1].Value = sValue;
            param[2].Value = sTime;

            return SqlHelper.ExecuteNonQuery(DBConfig, CommandType.Text, sql, param);
        }

        /// <summary>
        /// 保存一条统计计算结果
        /// </summary>
        /// <param name="sGuis"></param>
        /// <param name="sValue"></param>
        /// <param name="sTime"></param>
        /// <returns></returns>
        public static int InsertStaticsData(string sGuid, float[] sValue, string sTime)
        {
            string sql = "INSERT INTO StaticsData(sTime,sGuid,max,min,mean,std,skw,kut,zcr) VALUES(@sTime,@sGuid,@max,@min,@mean,@std,@skw,@kut,@zcr)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@sTime",SqlDbType.VarChar),
                new SqlParameter("@sGuid",SqlDbType.VarChar),
                new SqlParameter("@max",SqlDbType.Float),
                new SqlParameter("@min",SqlDbType.Float),
                new SqlParameter("@mean",SqlDbType.Float),
                new SqlParameter("@std",SqlDbType.Float),
                new SqlParameter("@skw",SqlDbType.Float),
                new SqlParameter("@kut",SqlDbType.Float),
                new SqlParameter("@zcr",SqlDbType.Float)
            };

            param[0].Value = sTime;
            param[1].Value = sGuid;
            param[2].Value = sValue[0];
            param[3].Value = sValue[1];
            param[4].Value = sValue[2];
            param[5].Value = sValue[3];
            param[6].Value = sValue[4];
            param[7].Value = sValue[5];
            param[8].Value = sValue[6];

            return SqlHelper.ExecuteNonQuery(DBConfig, CommandType.Text, sql, param);
        }

        /// <summary>
        /// 保存一条阈值报警信息
        /// </summary>
        /// <param name="sGuidsGuid"></param>
        /// <param name="aInfo"></param>
        /// <param name="ExtValue"></param>
        /// <param name="AvgValue"></param>
        /// <param name="sTime"></param>
        /// <returns></returns>
        public static int InsertAlarmRes(string sTime, string sGuid, string aInfo, float extValue, float avgValue)
        {
            string sql = "INSERT INTO AlarmData(sTime,sGuid,aInfo,extValue,avgValue) VALUES(@sTime,@sGuid,@aInfo,@extValue,@avgValue)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@sTime",SqlDbType.VarChar),
                new SqlParameter("@sGuid",SqlDbType.VarChar),
                new SqlParameter("@aInfo",SqlDbType.VarChar),
                new SqlParameter("@extValue",SqlDbType.Float),
                new SqlParameter("@avgValue",SqlDbType.Float)
            };

            param[0].Value = sTime;
            param[1].Value = sGuid;
            param[2].Value = aInfo;
            param[3].Value = extValue;
            param[4].Value = avgValue;

            return SqlHelper.ExecuteNonQuery(DBConfig, CommandType.Text, sql, param);
        }

        public static DataSet SelectAll()
        {
            string sql = "SELECT * FROM TaskTable";
            var res = SqlHelper.ExecuteDataset(DBConfig, CommandType.Text, sql);
            return res;
        }
    }
}
