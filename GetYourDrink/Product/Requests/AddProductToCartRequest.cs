using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class AddProductToCartRequest
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public class AddProductToCartRequestValidation : AbstractValidator<AddProductToCartRequest>
        {
            public AddProductToCartRequestValidation()
            {
                RuleFor(x => x.UserId).NotEmpty();
                RuleFor(x => x.ProductId).NotEmpty();
                RuleFor(x => x.Quantity).NotEmpty().GreaterThanOrEqualTo(1);
            }
        }
    }
}
