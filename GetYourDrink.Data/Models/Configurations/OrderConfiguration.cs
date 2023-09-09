using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(150);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.County).IsRequired().HasMaxLength(30);
            builder.Property(x => x.PostCode).IsRequired();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasMaxLength(30);
        }
    }
}
