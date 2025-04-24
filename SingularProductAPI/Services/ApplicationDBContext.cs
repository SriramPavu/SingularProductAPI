using Microsoft.EntityFrameworkCore;
using SingularProductsAPI.Models;

namespace SingularProductsAPI.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSales> productSales { get; set; }
    }
}
