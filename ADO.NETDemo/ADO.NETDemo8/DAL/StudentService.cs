using ADO.NETDemo8.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo8.DAL
{
    class StudentService
    {
        public Student GetStudentById(string studentId)
        {
            string sql = "select StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId from Students where StudentId = {0}";
            sql = string.Format(sql, studentId);

            // 执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql);

            // 读取并封装对象
            Student objStudent = null;
            if (objReader.Read())
            {
                objStudent = new Student()
                {
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = objReader["Birthday"].ToString(),
                    StudentIdNo = Convert.ToInt32(objReader["StudentIdNo"]),
                    Age = Convert.ToInt32(objReader["Age"]),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt32(objReader["ClassId"])
            };
                
            }

            objReader.Close();
            return objStudent;
        }


        public List<Student> GetAllStudnets()
        {
            // 组合SQL语句
            string sql = "select StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId from Students";

            // 执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql);

            // 创建泛型集合对象
            List<Student> stuList = new List<Student>();

            while (objReader.Read())
            {
                // 封装对象
                Student objStu = new Student()
                {
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = objReader["Birthday"].ToString(),
                    StudentIdNo = Convert.ToInt32(objReader["StudentIdNo"]),
                    Age = Convert.ToInt32(objReader["Age"]),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt32(objReader["ClassId"])
                };

                // 将对象添加到集合
                stuList.Add(objStu);
            }
            objReader.Close();
        
            return stuList;
        }
    }
}
