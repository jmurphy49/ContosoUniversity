using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity.Models
{
    public enum Grade { A, B, C, D, F }
    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}
