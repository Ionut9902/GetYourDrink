using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class GetFilteredProductsRequest
    {
        public int Page { get; set; }
        public string? Category { get; set; }
        public string? Origin { get; set; } 
        public double? MinAlcoholContent { get; set; }
        public float? MaxPrice { get; set; }
        public string? Keywords { get; set; }

        public class GetFilteredProductsRequestValidation : AbstractValidator<GetFilteredProductsRequest>
        {
            public GetFilteredProductsRequestValidation()
            {
                RuleFor(x => x.Page).NotNull();
            }
        }
    }
}
