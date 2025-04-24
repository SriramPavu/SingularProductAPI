using System.ComponentModel.DataAnnotations;

namespace SingularProductsAPI.Models
{
    public class Product
    {
        [MaxLength(100)]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Description { get; set; } = "";
        [MaxLength(100)]
        [Required]
        public string SalePrice { get; set; } = "";
        [MaxLength(100)]
        [Required]
        public string Category { get; set; } = "";
        [MaxLength(100)]
        [Required]
        public string Image { get; set; } = "";
    }
}
