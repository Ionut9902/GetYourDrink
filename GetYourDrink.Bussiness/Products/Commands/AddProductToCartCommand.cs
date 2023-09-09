using MediatR;

namespace GetYourDrink.Bussiness.Products.Commands
{
    public class AddProductToCartCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
