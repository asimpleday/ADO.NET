using ADO.NETDemo7.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo7.DAL
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
    }
}
