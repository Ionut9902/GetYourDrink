using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Alcohol).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Picture).IsRequired();
            builder.Property(x => x.Descritpion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Origin).IsRequired().HasMaxLength(30);
        }
    }
}
