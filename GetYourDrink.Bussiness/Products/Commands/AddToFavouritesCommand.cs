using MediatR;

namespace GetYourDrink.Bussiness.Products.Commands
{
    public class AddToFavouritesCommand : IRequest<bool>
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
