using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength =3, ErrorMessage = "Course Title must be between 3 and 50 characters.")]
        [Display(Name= "Course Title")]
        public string Title { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        public Department Department { get; set; }

        public ICollection <CourseAssignment> Assignments { get; set; }

    }
}
