using System;
using System.Collections.Generic;


namespace ContosoUniversity.Models
{
    public class Student
    {
        //the ID property becomes the primary key column of the database
        //table that corresponds to this class
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //the Enrollments property is a navigation property.
        //navigation properties hold other entities related to
        //this entity
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}