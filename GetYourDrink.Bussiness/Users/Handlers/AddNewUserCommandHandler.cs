using GetYourDrink.Bussiness.Users.Commands;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Users.Handlers
{
    public class AddNewUserCommandHandler : IRequestHandler<AddNewUserCommand, bool>
    {
        private GetYourDrinkContext _context;

        public AddNewUserCommandHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddNewUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
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

            _context.Users.Add(user);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
