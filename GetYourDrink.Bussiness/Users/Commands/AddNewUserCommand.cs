using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Users.Commands
{
    public class AddNewUserCommand : IRequest<bool>
    {
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
    }
}
