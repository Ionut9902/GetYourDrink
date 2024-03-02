using GetYourDrink.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models
{
    [EntityTypeConfiguration(typeof(UserConfiguration))]
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public int PostalCode { get; set; }
        public int ApartNo { get; set; }

        public virtual List<CartProduct> CartProducts { get; set; }
        public virtual Order Order { get; set; }
        public virtual Favourite Favourite { get; set; }
    }

    public enum Role
    {
        User,
        Admin,
        Employee
    }
}
