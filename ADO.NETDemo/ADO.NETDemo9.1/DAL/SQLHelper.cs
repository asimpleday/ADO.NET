using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9._1.DAL
{
    class SQLHelper
    {
        private static string connString = "Server=.;Database=StudentManageDB;Uid=sa;Pwd=123456";

        /// <summary>
        /// 返回单一结果的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetStringResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

        /// <summary>
        /// 增、删、改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        /// <summary>
        /// 返回单一结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return objReader;
        }
    }
}
