using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class CourseInstructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Person Instructor { get; set; }
    }
}
