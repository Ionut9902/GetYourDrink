using GetYourDrink.Data.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models
{
    [EntityTypeConfiguration(typeof(FavouriteConfiguration))]

    public class Favourite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}
