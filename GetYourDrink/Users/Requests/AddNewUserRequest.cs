using FluentValidation;
using GetYourDrink.Data.Models;

namespace GetYourDrink.Api.Requests
{
    public class AddNewUserRequest
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


        public class AddUserRequestValidation : AbstractValidator<AddNewUserRequest>
        {
            public AddUserRequestValidation()
            {
                RuleFor(x => x.FirstName).NotEmpty().Length(1, 50);
                RuleFor(x => x.LastName).NotEmpty().Length(1, 50);
                RuleFor(x => x.Role).NotEmpty();
                RuleFor(x => x.DateOfBirth).NotEmpty().LessThanOrEqualTo(DateTime.Now);
                RuleFor(x => x.County).NotEmpty().MaximumLength(30);
                RuleFor(x => x.City).NotEmpty().MaximumLength(30);
                RuleFor(x => x.Street).NotEmpty().MaximumLength(200);
                RuleFor(x => x.StreetNo).NotEmpty().MaximumLength(10);
                RuleFor(x => x.PostalCode).NotEmpty();
                RuleFor(x => x.ApartNo).NotEmpty();
            }
        }
    }
}
