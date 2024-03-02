using MediatR;

namespace GetYourDrink.Bussiness.Orders.Commands
{
    public class PlaceNewOrderCommand : IRequest<bool>
    {
        public int UserId { get; set; }
    }
}
