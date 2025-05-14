using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(21, 30, ErrorMessage = "Age must be between 21 and 30")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "User ID must be between 7 and 20 characters")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "User ID must contain at least one capital letter and one digit")]
        public string UserId { get; set; }
    }
}
