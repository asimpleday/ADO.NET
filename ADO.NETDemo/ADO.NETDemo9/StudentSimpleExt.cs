using ADO.NETDemo9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo9
{
    class StudentSimpleExt:Student
    {
        public string ClassName { get; set; }

        public int AvgScore { get; set; }
    }
}
