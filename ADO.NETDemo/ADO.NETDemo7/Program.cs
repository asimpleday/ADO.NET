using ADO.NETDemo7.DAL;
using ADO.NETDemo7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用数据访问方法获取学员对象
            StudentService objStudentService = new StudentService();
            Student objStudent = objStudentService.GetStudentById("10027");

            // 解析对象
            Console.WriteLine(objStudent.StudentName + "--" + objStudent.StudentIdNo + "--" + objStudent.Age);
        }
    }
}
