using GetYourDrink.Bussiness.Products.Commands;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class AddToFavouritesCommandHandler : IRequestHandler<AddToFavouritesCommand, bool>
    {
        private GetYourDrinkContext _context;

        public AddToFavouritesCommandHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddToFavouritesCommand request, CancellationToken cancellationToken)
        {
            var favourite = new Favourite
            { ProductId = request.ProductId, 
                UserId = request.UserId };

            _context.Favourite.
                Add(favourite);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
