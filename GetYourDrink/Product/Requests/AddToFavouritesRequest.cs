using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class AddToFavouritesRequest
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public class AddToFavouritesRequestValidation : AbstractValidator<AddToFavouritesRequest>
        {
            public AddToFavouritesRequestValidation()
            {
                RuleFor(x => x.ProductId).NotEmpty();
                RuleFor(x => x.UserId).NotEmpty();
            }
        }
    }
}
