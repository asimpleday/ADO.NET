using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo5.DAL
{
    /// <summary>
    /// 学员信息数据访问类
    /// </summary>
    class StudentService
    {
        /// <summary>
        /// 增加一条学员信息
        /// </summary>
        /// <param name="StudentName"></param>
        /// <param name="Gender"></param>
        /// <param name="Birthday"></param>
        /// <param name="StudentIdNo"></param>
        /// <param name="Age"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="StudentAddress"></param>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public int AddStudent(string StudentName, string Gender, string Birthday, int StudentIdNo, int Age, string PhoneNumber, string StudentAddress, int ClassId)
        {
            string sql = "insert into Students(StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId)";
            sql += " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})";
            sql = string.Format(sql, StudentName, Gender, Birthday, StudentIdNo, Age, PhoneNumber, StudentAddress, ClassId);
            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 根据班级id获得班级总人数
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public int GetStuCouByClassId(int classId)
        {
            string sql = "select count(*) from Students where ClassId = " + classId;
            return Convert.ToInt32(SQLHelper.GetStringResult(sql));
        }
    }
}
