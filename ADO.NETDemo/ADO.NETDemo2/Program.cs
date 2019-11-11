using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义连接字符串
            string connString = "server=.;DataBase=StudentManageDB;Uid=sa;Pwd=123456;";
            SqlConnection conn = new SqlConnection(connString);

            // 查询字符串
            string sql = "select TOP 10 StudentId,StudentName,Gender from Students;";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            //执行查询方法，返回DataReader对象
            SqlDataReader objReader = cmd.ExecuteReader();

            // 读取数据
            while (objReader.Read())
            {
                Console.WriteLine(objReader["StudentId"].ToString() + "\t" + objReader["StudentName"].ToString() + "\t" + objReader["Gender"].ToString());
            }

            // 关闭读取器
            objReader.Close();
            conn.Close();
        }
    }
}
