using System;
using System.ComponentModel.DataAnnotations;

namespace SingularProductsAPI.Models
{
    public class ProductSales
    {
        [Key]
        public int SaleId { get; set; }

        [MaxLength(100)]
        [Required]
        public string ProductId { get; set; } = "";

        [Required]
        public decimal SalePrice { get; set; } 

        [Required]
        public decimal SaleQty { get; set; }

        [Required]
        public DateTime SaleDate { get; set; } 
    }
}
