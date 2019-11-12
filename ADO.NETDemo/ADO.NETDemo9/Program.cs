using ADO.NETDemo9.DAL;
using ADO.NETDemo9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用数据访问对象返回扩展实体对象集合
            StudentService objStudentService = new StudentService();
            List<StudentExt> list = objStudentService.GetStudentExt();

            // 解析扩展实体对象集合
            if (list.Count != 0)
            {
                // 解析对象
                foreach (StudentExt item in list)
                {
                    Console.WriteLine(item.ObjStudent.StudentName + "--" +item.ObjStudent.StudentId + "--" + item.ObjClass.ClassName);
                }
            }
            else
            {
                Console.WriteLine("没有要显示的数据！");
            }
        }
    }
}
