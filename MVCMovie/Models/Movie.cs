using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z' '-' \s]*$", ErrorMessage = " Please enter only Alpha numeric characters.")]
        [StringLength(30)]
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(1,100)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z' '-' \s]*$", ErrorMessage =" Please enter only Alpha numeric characters.") ]
        [StringLength(5, MinimumLength = 1)]
        public string Rating { get; set; }



    }
}
