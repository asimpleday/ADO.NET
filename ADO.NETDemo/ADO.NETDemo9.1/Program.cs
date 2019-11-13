using ADO.NETDemo9._1.DAL;
using ADO.NETDemo9._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService stuSer = new StudentService();

            // 拿到学生总数
            //string result = stuSer.GetCount().ToString();
            //Console.WriteLine("学生总数：{0}", result);

            // 增加一名学生
            //int result1 = stuSer.AddStudent();
            //if (result1 > 0)
            //{
            //    Console.WriteLine("添加成功");
            //}
            //else
            //{
            //    Console.WriteLine("添加失败");
            //}

            // 拿到一个学生的详细信息
            Student stu = stuSer.GetStudnetInfo("10028");
            Console.WriteLine(stu.StudentId + "--" + stu.StudentName + "--" + stu.Gender);

        }
    }
}
