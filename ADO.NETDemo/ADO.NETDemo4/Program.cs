using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 增加
            //string sql = "insert into Students(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId)";
            //sql += "values('李若彤', '女', '1994-01-16', 10008, 26, 18521347105, '安徽安庆', 6)";
            //int reustl = SQLHelper.Update(sql);
            //if (reustl > 0)
            //{
            //    Console.WriteLine("受影响的行数：{0}", reustl);
            //    Console.WriteLine("添加成功~");
            //}

            // 删除
            //string sql = "delete from Students where StudentName = '徐林俊'";
            //int reustl = SQLHelper.Update(sql);
            //if (reustl > 0)
            //{
            //    Console.WriteLine("受影响的行数：{0}", reustl);
            //    Console.WriteLine("删除成功~");
            //}

            // 修改
            //string sql = "update Students set StudentName = '刘亦菲' where StudentId = 10038";
            //int reustl = SQLHelper.Update(sql);
            //if (reustl > 0)
            //{
            //    Console.WriteLine("受影响的行数：{0}", reustl);
            //    Console.WriteLine("修改成功~");
            //}

            //查询
            //string sql = "select count(*) from Students";
            //object result = SQLHelper.GetStringResult(sql);
            //Console.WriteLine(result);


            // 返回一个结果集的查询
            string sql = "select top 5 StudentId, StudentName, Gender from Students;";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                Console.WriteLine(objReader["StudentId"] + "\t" + objReader["StudentName"] + "\t" + objReader["Gender"]);
            }
            objReader.Close();   // 关闭读取器（同时自动关闭关联的连接）
        }
    }
}
