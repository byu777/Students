using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string eMail { get; set; }
    }
    public class Students
    {
        static List<Student> studentRecords = new List<Student>
        {
            new Student {LastName = "Wong", FirstName = "John", eMail = "jwong@msn.com" },
            new Student {LastName = "Chan", FirstName = "May", eMail = "mchan@gmail.com" },
            new Student {LastName = "Zhang", FirstName = "Lisa", eMail = "lzhang@qq.com" }
        };

        public static List<Student> getStudents()
        {
            return studentRecords;
        }
    }
}
