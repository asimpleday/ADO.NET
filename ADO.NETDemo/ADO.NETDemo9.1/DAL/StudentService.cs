using ADO.NETDemo9._1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9._1.DAL
{
    class StudentService
    {
        /// <summary>
        /// 拿到学生总数
        /// </summary>
        /// <returns></returns>
        public object GetCount()
        {
            string sql = "select count(*) from Students";
            object result = SQLHelper.GetStringResult(sql);
            return result;
        }

        /// <summary>
        /// 添加一名学生
        /// </summary>
        /// <returns></returns>
        public int AddStudent()
        {
            string sql = "insert into Students(StudentName, Gender, Birthday, ";
            sql += "StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId)";
            sql+= "values('杨幂', '女', '1991-02-12', 10009, 28, '13000000000', '上海市', 5)";
            int result = SQLHelper.Update(sql);
            return result;
        }

        /// <summary>
        /// 拿到一个学生的详细信息
        /// </summary>
        /// <returns></returns>
        public Student GetStudnetInfo(string studentId)
        {
            string sql = "select * from Students where StudentId = {0}";
            sql = string.Format(sql, studentId);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Student stu = null;
            if (objReader.Read())
            {
                stu = new Student()
                {
                    StudentId = Convert.ToInt16(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString()
                };
            }
            objReader.Close();
            return stu;
        }
    }
}
