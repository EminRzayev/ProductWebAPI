using System.ComponentModel.DataAnnotations;

namespace PRODUCT.Entities
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
