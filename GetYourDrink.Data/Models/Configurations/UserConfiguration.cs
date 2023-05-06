using GetYourDrink.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetYourDrink.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.County).IsRequired().HasMaxLength(25);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Street).IsRequired().HasMaxLength(200);
            builder.Property(x => x.PostalCode).IsRequired();
            builder.Property(x => x.StreetNo).IsRequired().HasMaxLength(10);
            builder.Property(x => x.ApartNo).IsRequired();
        }
    }
}
