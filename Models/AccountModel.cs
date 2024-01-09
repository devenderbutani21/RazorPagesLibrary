using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        [Required]
        public string LibCardNo { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }
    }
}
