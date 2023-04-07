using System.ComponentModel.DataAnnotations;

namespace PRODUCT.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Price { get; set; }

    }
}
