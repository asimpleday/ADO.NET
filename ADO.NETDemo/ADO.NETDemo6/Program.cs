using ADO.NETDemo6.DAL;
using ADO.NETDemo6.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            //// 1.1、获取用户输入
            Console.WriteLine("请输入学员姓名：");
            objStudent.StudentName = Console.ReadLine();
            Console.WriteLine("请输入性别：");
            objStudent.Gender = Console.ReadLine();
            Console.WriteLine("请输入生日：");
            objStudent.Birthday = Console.ReadLine();
            Console.WriteLine("请输入学号：");
            objStudent.StudentIdNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入年龄：");
            objStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入手机号：");
            objStudent.PhoneNumber = Console.ReadLine();
            Console.WriteLine("请输入地址：");
            objStudent.StudentAddress = Console.ReadLine();
            Console.WriteLine("请输入班级id");
            objStudent.ClassId = Convert.ToInt32(Console.ReadLine());

            // 1.2、调用数据访问方法
            StudentService objStuService = new StudentService();
            int result = objStuService.AddStudent(objStudent);
            //int result = objStuService.AddStudent("徐", "男", "1994-02-19", 10008, 25, "18521347105", "上海市虹口区安汾路780弄虹北公寓49号楼402室", 5);
            if (result > 0)
            {
                Console.WriteLine("添加成功");
            }
            Console.ReadLine();


            // 2.1、根据班级id查看班级人数
            //StudentService objStuService = new StudentService();
            //int result = objStuService.GetStuCouByClassId(5);
            //Console.WriteLine(result);
        }
    }
}
