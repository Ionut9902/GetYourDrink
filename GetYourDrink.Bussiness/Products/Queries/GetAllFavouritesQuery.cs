using GetYourDrink.Bussiness.Products.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Queries
{
    public class GetAllFavouritesQuery : IRequest<ProductPage>
    {
        public int UserId { get; set; }

        public int Page { get; set; }
    }
}
