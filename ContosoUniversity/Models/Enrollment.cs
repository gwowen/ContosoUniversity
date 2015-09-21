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
        //this is the primary key
        public int EnrollmentID { get; set; }
        //foreign key
        public int CourseID { get; set; }
        //foreign key, the corresponding navigation
        //property is student
        //an Enrollment entity is associated with one Student
        //entity, so the property can only handle a single Student
        //entity
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}