using GetYourDrink.Bussiness.Products.Commands;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class AddNewProductCommandHandler : IRequestHandler<AddNewProductCommand, bool>
    {
        private GetYourDrinkContext _context;

        public AddNewProductCommandHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddNewProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Category = request.Category,
                Alcohol = request.Alcohol,
                Stock = request.Stock,
                Picture = request.Picture,
                Descritpion = request.Description,
                Origin = request.Origin,   
            };

            _context.Products.Add(product);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
