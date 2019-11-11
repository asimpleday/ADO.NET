using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义连接字符串
            string connString = "server=.;DataBase=StudentManageDB;Uid=sa;Pwd=123456;";
            SqlConnection conn = new SqlConnection(connString);

            // 组合需要的sql语句
            string sql = "select TOP 5 StudentName,Birthday,Age from Students;select TOP 10 StudentId,StudentName,Gender from Students;";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 打开连接执行查询
            conn.Open();
            SqlDataReader objReader = cmd.ExecuteReader();

            // 读取第一个结果集
            while (objReader.Read())
            {
                Console.WriteLine(objReader["StudentName"] + "\t" + objReader["Birthday"] + "\t" + objReader["Age"]);
            }

            Console.WriteLine("-------------------------------------------------------");

            // 判断是否有下一个结果集
            if (objReader.NextResult())
            {
                while (objReader.Read())
                {
                    Console.WriteLine(objReader["StudentId"] + "\t" + objReader["StudentName"] + "\t" + objReader["Gender"]);
                }
            }

            objReader.Close();
            conn.Close();



        }
    }
}
