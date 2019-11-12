using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9.Models
{
    /// <summary>
    /// 组合扩展实体
    /// </summary>
    class StudentExt
    {
        public Student ObjStudent { get; set; }

        public StudentClass ObjClass { get; set; }

        public StudentScore ObjScore { get; set; }
    }
}
