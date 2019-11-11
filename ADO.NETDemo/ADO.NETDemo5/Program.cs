using ADO.NETDemo5.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1.1、获取用户输入
            //Console.WriteLine("请输入学员姓名：");
            //string StudentName = Console.ReadLine();
            //Console.WriteLine("请输入性别：");
            //string Gender = Console.ReadLine();
            //Console.WriteLine("请输入生日：");
            //string Birthday = Console.ReadLine();
            //Console.WriteLine("请输入学号：");
            //int StudentIdNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入年龄：");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入手机号：");
            //string PhoneNumber = Console.ReadLine();
            //Console.WriteLine("请输入地址：");
            //string StudentAddress = Console.ReadLine();
            //Console.WriteLine("请输入班级id");
            //int ClassId = Convert.ToInt32(Console.ReadLine());

            //// 1.2、调用数据访问方法
            //StudentService objStuService = new StudentService();
            //int result = objStuService.AddStudent(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId);
            ////int result = objStuService.AddStudent("徐", "男", "1994-02-19", 10008, 25, "18521347105", "上海市虹口区安汾路780弄虹北公寓49号楼402室", 5);
            //if (result > 0)
            //{
            //    Console.WriteLine("添加成功");
            //}
            //Console.ReadLine();

            StudentService objStuService = new StudentService();
            int result = objStuService.GetStuCouByClassId(0);
            Console.WriteLine(result);
        }
    }
}
