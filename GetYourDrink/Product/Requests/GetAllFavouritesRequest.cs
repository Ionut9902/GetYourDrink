using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class GetAllFavouritesRequest
    {
        public int UserId { get; set; }

        public int Page { get; set; }

        public class GetAllFavouritesRequestValidation : AbstractValidator<GetAllFavouritesRequest>
        {
            public GetAllFavouritesRequestValidation()
            {
                RuleFor(x => x.UserId).NotNull();
                RuleFor(x => x.Page).NotNull().GreaterThanOrEqualTo(1);
            }
        }
    }
}
