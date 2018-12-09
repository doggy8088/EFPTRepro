﻿using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class Person
    {
        public Person()
        {
            CourseInstructor = new HashSet<CourseInstructor>();
            Department = new HashSet<Department>();
            Enrollment = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Discriminator { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
        public ICollection<Department> Department { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
