using GetYourDrink.Api.Order.Requests;
using GetYourDrink.Bussiness.Orders.Commands;

namespace GetYourDrink.Api.Order
{
    public static class OrdersExtenions
    {
        public static PlaceNewOrderCommand ToCommand(this PlaceNewOrderRequest request)
        {
            return new PlaceNewOrderCommand
            {
                UserId = request.UserId
            };
        }
    }
}
