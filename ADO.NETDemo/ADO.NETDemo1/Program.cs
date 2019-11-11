using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建connection对象
            string connString = "server=.;DataBase=StudentManageDB;Uid=sa;Pwd=123456";
            SqlConnection conn = new SqlConnection(connString);

            // 创建command对象
            string sql = "select count(*) from Students where StudentId = 10016";
            //string sql = "select StudentName from Students where StudentId = 10003";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 打开连接执行查询
            conn.Open();
            object result = cmd.ExecuteScalar();

            // 关闭连接处理结果
            conn.Close();
            Console.WriteLine("学生总数：{0}", result.ToString());
        }
    }
}
