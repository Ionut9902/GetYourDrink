using GetYourDrink.Data.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models
{
    [EntityTypeConfiguration(typeof(OrderConfiguration))]

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int PostCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float TotalPrice { get; set; }
        public Status Status { get; set; }

        public virtual List<OrderProduct> OrderProducts { get; set; }

    }

    public enum Status
    {
        InProgress,
        InDelivery,
        Delivered
    }
}
