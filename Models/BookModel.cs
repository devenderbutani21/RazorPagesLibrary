using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? ISBN { get; set; }

        [Display(Name = "Publication Date"), DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public int Pages { get; set; }
        [Display(Name = "")]
        public string CoverImagePath { get; set; }
    }
}
