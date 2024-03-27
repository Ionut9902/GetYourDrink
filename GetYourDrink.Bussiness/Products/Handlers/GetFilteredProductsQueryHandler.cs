using GetYourDrink.Bussiness.Products.Models;
using GetYourDrink.Bussiness.Products.Queries;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;
using System.Data.Entity;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class GetFilteredProductsQueryHandler : IRequestHandler<GetFilteredProductsQuery, ProductPage>
    {
        private GetYourDrinkContext _context;
        public GetFilteredProductsQueryHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<ProductPage> Handle(GetFilteredProductsQuery request, CancellationToken cancellationToken)
        {
            IQueryable<Product> products = _context.Products;

            // Apply filters
            if (!string.IsNullOrEmpty(request.Category))
            {
                products = products.Where(p => p.Category == (Category)Enum.Parse(typeof(Category), request.Category));
            }

            if (!string.IsNullOrEmpty(request.Origin))
            {
                products = products.Where(p => p.Origin == request.Origin);
            }

            if (request.MinAlcoholContent.HasValue)
            {
                products = products.Where(p => p.Alcohol >= request.MinAlcoholContent.Value);
            }

            if (request.MaxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= request.MaxPrice.Value);
            }

            if (!string.IsNullOrEmpty(request.Keywords))
            {
                // Search by keywords in product name or description
                products = products.Where(p => p.Name.Contains(request.Keywords) || p.Descritpion.Contains(request.Keywords));
            }

            // Apply pagination
            var pageSize = 30f;
            var pageCount = Math.Ceiling(_context.Products.Count() / pageSize);

            products = products.Skip((request.Page - 1) * (int)pageSize)
                               .Take((int)pageSize);

            // Execute query
            return new ProductPage
            {
                Products = products.ToBLProduct().ToList(),
                CurrentPage = request.Page,
                TotalPages = (int)pageCount
            };

        }
    }
}
