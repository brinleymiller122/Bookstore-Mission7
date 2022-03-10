using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bookstore.Models
{
    public partial class Book
    {
        //set up bookstore model
        [Key]
        [Required]
        public long BookId { get; set; }
        [Required(ErrorMessage = "Please enter a book title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter an author name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter a publisher")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Please enter an ISBN")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "Please enter a classification")]
        public string Classification { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
        [Required]
        [Range(0, long.MaxValue,
            ErrorMessage = "Please enter a positive page number")]
        public long PageCount { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        public double Price { get; set; }
    }
}
