using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NETDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义连接字符串
            string connString = "Server=.;Database=StudentManageDB;Uid=sa;Pwd=123456;";

            // 创建连接对象
            SqlConnection conn = new SqlConnection(connString);

            // 编写SQL语句
            // 增
            //string sql = "insert into Students(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId) values('李四', '男', '1996-02-15', 10006, 26, 13021347105, '上海杨浦', 5)";
            // 改
            //string sql = "update Students set StudentName = '王力宏' where StudentId = 10020";
            // 删
            //string sql = "delete from Students where StudentId = 10019";
            // 增加多条
            //string sql = "insert into Students(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId)";
            //sql += " values('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}', {7})";
            //string sql1 = string.Format(sql, "周杰伦", "男", "1996-02-15", 10006, 26, 13021347105, "上海杨浦", 5);
            //string sql2 = string.Format(sql, "杨紫", "女", "1996-02-15", 10006, 26, 13021347105, "上海杨浦", 5);
            //string sql3 = string.Format(sql, "沈腾", "男", "1996-02-15", 10006, 26, 13021347105, "上海杨浦", 5);
            //string sql4 = sql1 + ";" + sql2 + ";" + sql3;

            // select @@identity
            string sql = "insert into Students(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId)";
            sql += " values('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}', {7});select @@identity";
            string sql1 = string.Format(sql, "刘德华", "男", "1996-02-15", 10006, 26, 13021347105, "上海杨浦", 5);


            // 创建Commond对象
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = sql;
            //cmd.Connection = conn;
            SqlCommand cmd = new SqlCommand(sql1, conn);

            // 打开连接
            conn.Open();

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            // 关闭连接
            conn.Close();

            // 判断是否添加成功
            if (result > 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("添加失败");
            }
        }
    }
}
