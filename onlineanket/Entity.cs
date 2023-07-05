using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineanket
{
    public class evaluations
    {
        public Guid evaluation_id { get; set; }
        public string student_id { get; set; }
        public string course_id { get; set; }
        public string rating { get; set; }
        
    }


    public class teachers
    {
        public Guid teacher_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string konusu { get; set; }

       
    }  

    public class students
    {
        internal Guid ID;

        public Guid student_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string sınıfı { get; set; }
       
    }

    public class courses
    {
        public Guid course_id { get; set; }
        public string name { get; set; }
        public string teacher_id { get; set; }
        public string clas { get; set; }
    }


    public class surveys
    {
    public Guid survey_id { get; set; }
    public string student_id { get; set; }
    public string course_id { get; set; }
    public string feedback { get; set; }

    }
}

