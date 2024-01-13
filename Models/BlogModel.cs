using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required,DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public int ReadTime {  get; set; }
        [Required]
        public string Description { get; set; }
    }
}
