using FluentValidation;

namespace GetYourDrink.Api.Order.Requests
{
    public class PlaceNewOrderRequest
    {
        public int UserId { get; set; }

        public class PlaceNewOrderRequestValidation : AbstractValidator<PlaceNewOrderRequest>
        {
            public PlaceNewOrderRequestValidation()
            {
                RuleFor(x => x.UserId).NotEmpty();
            }
        }
    }
}
