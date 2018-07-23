using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Models;

namespace ProductCatalog.Dto.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(4000).HasColumnType("varchar(4000)");
            builder.Property(x => x.BrandName).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.SellersName).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.LastUpdateDate).IsRequired();
        }
    }
}
