using Microsoft.EntityFrameworkCore;
using PRODUCT.Entities;

namespace PRODUCT.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
