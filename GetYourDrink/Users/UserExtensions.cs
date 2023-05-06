using GetYourDrink.Api.Requests;
using GetYourDrink.Bussiness.Users.Queries;

namespace GetYourDrink.Api.Users
{
    public static class UserExtensions
    {
        public static AddNewUserQuery ToQuery(this AddNewUserRequest request)
        {
            return new AddNewUserQuery
            {
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
