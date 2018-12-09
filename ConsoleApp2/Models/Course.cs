using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseInstructor = new HashSet<CourseInstructor>();
            Enrollment = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
