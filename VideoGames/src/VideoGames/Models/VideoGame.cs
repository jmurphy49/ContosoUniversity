﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGames.Models
{
    public class VideoGame
    {
        [Key]
        public int VideoGameID { get; set; }
        public string Title { get; set; }
        [Display (Name ="Rating")]
        public int RatingID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        [ForeignKey("RatingID")]
        public Rating Ratings { get; set;}


    }
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        public string Description { get; set; }

    }
}