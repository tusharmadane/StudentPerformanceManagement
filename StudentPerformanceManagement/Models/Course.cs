using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.Models
{

    public class Course
    {
        public int code;
        public string title;
        public string description;
        public int cid;

        Course()
        {
        }

        public Course(int code, string title, string description)
        {
            this.code = code;
            this.title = title;
            this.description = description;
        }

    }

}
