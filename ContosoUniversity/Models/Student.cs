using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [Display(Name="Last Name")]
        [StringLength(50,ErrorMessage ="Last name can no be greater than 50 characters")]
        public string LastName { get; set; }
        [Required]
        [Display(Name="First Name")]
        [StringLength(50, ErrorMessage = "First name can no be greater than 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z ' '-' \s]*$")]
        public string FirstName { get; set; }
        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get
            {
                return LastName + ", " + FirstName;
            }
        }
        [Display(Name = "Student's Courses")]
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
