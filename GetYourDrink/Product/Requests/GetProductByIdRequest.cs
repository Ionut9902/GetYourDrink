using FluentValidation;

namespace GetYourDrink.Api.Product.Requests
{
    public class GetProductByIdRequest
    {
        public int Id { get; set; }

        public class GetProductByIdRequestValidation : AbstractValidator<GetProductByIdRequest>
        {
            public GetProductByIdRequestValidation()
            {
                RuleFor(x => x.Id).NotNull();
            }
        }
    }
}
