using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class GetProductsRequest
    {
        public int Page { get; set; }

        public class GetProductsRequestValidation : AbstractValidator<GetProductsRequest>
        {
            public GetProductsRequestValidation()
            {
                RuleFor(x => x.Page).NotNull();
            }
        }
    }
}
