using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo6.Models
{
    /// <summary>
    /// 学生实体类
    /// </summary>
    class Student
    {
        public string StudentName { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }

        public int StudentIdNo { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string StudentAddress { get; set; }

        public int ClassId { get; set; }
    }
}
