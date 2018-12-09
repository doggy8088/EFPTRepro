using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class OfficeAssignment
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public Person Instructor { get; set; }
    }
}
