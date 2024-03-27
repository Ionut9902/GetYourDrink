using GetYourDrink.Bussiness.Products.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Queries
{
    public class GetFilteredProductsQuery : IRequest<ProductPage>
    {
        public int Page { get; set; }
        public string? Category { get; set; }
        public string? Origin { get; set; }
        public double? MinAlcoholContent { get; set; }
        public float? MaxPrice { get; set; }
        public string? Keywords { get; set; }
    }
}
