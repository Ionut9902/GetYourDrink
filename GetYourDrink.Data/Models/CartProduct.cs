using GetYourDrink.Data.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models
{
    [EntityTypeConfiguration(typeof(CartProductConfiguration))]

    public class CartProduct
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
