using GetYourDrink.Bussiness.Products.Models;
using GetYourDrink.Bussiness.Products.Queries;
using GetYourDrink.Data.DataContext;
using MediatR;
using System.Net;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, BLProduct>
    {
        private GetYourDrinkContext _context;

        public GetProductByIdQueryHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<BLProduct> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return _context.Products
                .Where(x => x.Id == request.Id)
                .ToBLProduct()
                .FirstOrDefault();
           
        }
    }
}
