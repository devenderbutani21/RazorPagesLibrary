using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class ContactUsModel
    {   
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3), Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }
        [StringLength(60), Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Write your query here")]
        public string message { get; set; }
    }
}
