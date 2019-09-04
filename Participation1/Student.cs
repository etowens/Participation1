using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int StudentID { get; set; }

        public List<Course> Courses = new List<Course>();
        
    Student()
        {
            FirstName = "";
            LastName = "";
            StudentID = 0;
        }
    }
}
