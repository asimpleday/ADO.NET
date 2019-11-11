using ADO.NETDemo8.DAL;
using ADO.NETDemo8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用数据访问方法获取学员对象
            StudentService objStudentService = new StudentService();
            List<Student> list = objStudentService.GetAllStudnets();

            if (list.Count != 0)
            {
                // 解析对象
                foreach (Student item in list)
                {
                    Console.WriteLine(item.StudentName + "--" + item.StudentIdNo + "--" + item.Age);
                }
            }
            else
            {
                Console.WriteLine("没有要显示的数据！");
            }
        }
    }
}
