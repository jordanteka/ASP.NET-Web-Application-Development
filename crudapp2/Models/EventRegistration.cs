using System.ComponentModel.DataAnnotations;

namespace CrudApp1.Models
{
    public class EventRegistration
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
    }
}
