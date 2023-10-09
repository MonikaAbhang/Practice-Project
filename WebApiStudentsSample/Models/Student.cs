using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiStudentsSample.Models
{
    public class Students
    {
        public int StudentId
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Course
        {
            get;
            set;
        }

    }
}