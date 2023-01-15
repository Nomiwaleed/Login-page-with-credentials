using System.ComponentModel.DataAnnotations;

namespace Login_page_with_validations.Models
{
    public class LoginModel
    {
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
