using GetYourDrink.Bussiness.Products.Models;
using GetYourDrink.Bussiness.Products.Queries;
using GetYourDrink.Data.DataContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class GetAllFavouritesQueryHandler : IRequestHandler<GetAllFavouritesQuery, ProductPage>
    {
        private GetYourDrinkContext _context;

        public GetAllFavouritesQueryHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<ProductPage> Handle(GetAllFavouritesQuery request, CancellationToken cancellationToken)
        {
            var pageResults = 30f;
            var pageCount = Math.Ceiling(_context.Favourite.Where(x => x.UserId == request.UserId).Count() / pageResults);

            var products = await _context.Favourite
                .Where(x => x.UserId == request.UserId)
                .Select(x => x.Product)
                .Skip((request.Page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToBLProduct()
                .ToListAsync();

            var response = new ProductPage
            {
                Products = products,
                CurrentPage = request.Page,
                TotalPages = (int)pageCount
            };

            return response;
        }
    }
}
