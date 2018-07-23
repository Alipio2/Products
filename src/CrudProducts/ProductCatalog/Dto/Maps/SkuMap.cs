using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Models;

namespace ProductCatalog.Dto.Maps
{
    public class SkuMap : IEntityTypeConfiguration<Sku>
    {
        public void Configure(EntityTypeBuilder<Sku> builder)
        {
            builder.ToTable("Sku");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ean).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("money");
            builder.Property(x => x.SalePrice).IsRequired().HasColumnType("money");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(4000).HasColumnType("varchar(4000)");
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.LastUpdateDate).IsRequired();
            builder.HasOne(x => x.Product).WithMany(x => x.Skus);
        }
    }
}
