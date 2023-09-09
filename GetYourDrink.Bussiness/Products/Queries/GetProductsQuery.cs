using GetYourDrink.Bussiness.Products.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Queries
{
    public class GetProductsQuery : IRequest<ProductPage>
    {
        public int Page { get; set; }
    }
}
