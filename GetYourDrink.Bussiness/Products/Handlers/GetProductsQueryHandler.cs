using GetYourDrink.Bussiness.Products.Models;
using GetYourDrink.Bussiness.Products.Queries;
using GetYourDrink.Data.DataContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductPage>
    {
        private GetYourDrinkContext _context;

        public GetProductsQueryHandler(GetYourDrinkContext context)
        {
            _context = context;
        }
        public async Task<ProductPage> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var pageResults = 30f;
            var pageCount = Math.Ceiling(_context.Products.Count() / pageResults);

            var products = await _context.Products.Skip((request.Page - 1) * (int)pageResults).Take((int)pageResults).ToBLProduct().ToListAsync();

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
