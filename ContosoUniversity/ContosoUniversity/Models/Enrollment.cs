using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; } //primary key
        public int CourseId { get; set;  //one to one
        public int StudentId { get; set; } //one to one
        public Grade? Grade { get; set; } //nullable

        public virtual Course Course { get; set;} //one to one
        public virtual Student Student { get; set; } //one to one
    }
}