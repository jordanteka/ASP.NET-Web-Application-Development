using System.ComponentModel.DataAnnotations;

namespace FeedBackForm.Models
{
    public class FeedBack
    {
        [Required]
        public int Customer_ID { get; set; }

        [Required]
        public string Customer_Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email_Address { get; set; }

        [Required]
        [Phone(ErrorMessage = "Enter a valid mobile number")]
        public string Mobile_No { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Comment cannot exceed 300 characters")]
        public string Comment { get; set; }
    }
}
