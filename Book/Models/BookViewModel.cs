using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    
    public class BookViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        public string? Img { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Zadługie tytół ")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfPublication { get; set; }

        [Required(ErrorMessage ="Podaj liczbe stron")]
        public int PageNumber { get; set; }
        public string? Author { get; set; }
        public string? PubHouse { get; set; }
        public BookType Types { get; set; }
        public double Price { get; set; }


    }

    public enum BookType
    {
        [Display(Name = "Sci–Fi")] SciFi = 0,
        [Display(Name = "Romans")] Roman = 1,
        [Display(Name = "Horror")] Horror = 2,
        [Display(Name = "Anime")] Anime = 3,
    }


}
