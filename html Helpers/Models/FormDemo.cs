using System.ComponentModel.DataAnnotations;

namespace htmlhelpers.Models
{
    public class FormDemo
    {
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string HiddenInfo { get; set; }

        public bool AgreeToTerms { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Country")]
        public string SelectedCountry { get; set; }

        public List<string> SelectedLanguages { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
