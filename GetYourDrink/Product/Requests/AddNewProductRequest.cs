using FluentValidation;
using GetYourDrink.Data.Models;

namespace GetYourDrink.Api.Product.Requests
{
    public class AddNewProductRequest
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Alcohol { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public float Price { get; set; }

        public class AddProductRequestValidation : AbstractValidator<AddNewProductRequest>
        {
            public AddProductRequestValidation()
            {
                RuleFor(x => x.Name).NotNull().Length(1, 50);
                RuleFor(x => x.Category).NotEmpty();
                RuleFor(x => x.Alcohol).NotEmpty();
                RuleFor(x => x.Stock).NotEmpty();
                RuleFor(x => x.Picture).NotEmpty();
                RuleFor(x => x.Description).NotEmpty().MaximumLength(150);
                RuleFor(x => x.Origin).NotEmpty().MaximumLength(30);
                RuleFor(x => x.Price).NotEmpty().GreaterThanOrEqualTo(1);
            }
        }
    }
}
