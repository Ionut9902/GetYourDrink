using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Users.Queries
{
    public class AddNewUserQuery : IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public int PostalCode { get; set; }
        public string ApartNo { get; set; }
    }
}
