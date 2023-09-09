using GetYourDrink.Api.Requests;
using GetYourDrink.Bussiness.Users.Commands;

namespace GetYourDrink.Api.Users
{
    public static class UserExtensions
    {
        public static AddNewUserCommand ToQuery(this AddNewUserRequest request)
        {
            return new AddNewUserCommand
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Role = request.Role,
                DateOfBirth = request.DateOfBirth,
                County = request.County,
                City = request.City,
                Street = request.Street,
                StreetNo = request.StreetNo,
                PostalCode = request.PostalCode,
                ApartNo = request.ApartNo,
            };
        }
    }
}
