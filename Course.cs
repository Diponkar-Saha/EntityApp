using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApp
{
    public class Course
    {//Course Name, Fees
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseFees { get; set; }
        public List<Dog> teacher { get; set; }
        public List<Cat> student { get; set; }
        public Guid CourseId { get; set; }
    }
}

