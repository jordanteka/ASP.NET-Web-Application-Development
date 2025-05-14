using System.ComponentModel.DataAnnotations;
namespace CrudApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [Range(1000, 2100, ErrorMessage = "Enter a valid year")]
        public int Year { get; set; }
    }
}
