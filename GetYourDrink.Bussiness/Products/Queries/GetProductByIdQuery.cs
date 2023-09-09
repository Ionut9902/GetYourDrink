using GetYourDrink.Bussiness.Products.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Queries
{
    public class GetProductByIdQuery : IRequest<BLProduct>
    {
        public int Id { get; set; }
    }
}
