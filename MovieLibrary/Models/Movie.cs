using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Movie")]
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public List<Showtime> Showtimes { get; set; }
    }
}
