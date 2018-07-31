using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using ProductCatalog.Dto.Maps;

namespace ProductCatalog.Dto
{
    public class ProductsDataContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Sku> Sku { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Gotham;User ID=sa;Password=@lp101010");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new SkuMap());
        }
    }
}
