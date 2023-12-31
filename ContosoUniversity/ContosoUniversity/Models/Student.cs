﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; } //primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
         
        public DateTime EnrollmentDate { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } //one to many

    }
}