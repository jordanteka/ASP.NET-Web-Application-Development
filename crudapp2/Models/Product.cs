using System.ComponentModel.DataAnnotations;

namespace CrudApp1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.01, 99999, ErrorMessage = "Enter a valid price")]
        public decimal Price { get; set; }
    }
}
