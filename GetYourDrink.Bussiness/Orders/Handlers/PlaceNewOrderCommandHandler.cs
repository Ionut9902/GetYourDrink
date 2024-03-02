using GetYourDrink.Bussiness.Orders.Commands;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Orders.Handlers
{
    public class PlaceNewOrderCommandHandler : IRequestHandler<PlaceNewOrderCommand, bool>
    {
        private GetYourDrinkContext _context;

        public PlaceNewOrderCommandHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PlaceNewOrderCommand request, CancellationToken cancellationToken)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == request.UserId);
            var order = new Order
            {
                UserId = user.Id,
                Address = user.Street,
                City = user.City,
                County = user.County,
                PostCode = user.PostalCode,
                FirstName = user.FirstName,
                LastName = user.LastName,
                TotalPrice = 0,
                Status = Status.InProgress,
                OrderProducts = new List<OrderProduct>()
            };

            var cartItems = _context.CartProduct
                .Where(c => c.UserId == request.UserId)
                .ToList();

            foreach (var cartItem in cartItems)
            {
                var product = await _context.Products.FindAsync(cartItem.ProductId);
                if (product != null)
                {
                    var orderProduct = new OrderProduct
                    {
                        ProductId = cartItem.ProductId,
                        Quantity = cartItem.Quantity
                    };
                    order.OrderProducts.Add(orderProduct);
                    order.TotalPrice += (product.Price * cartItem.Quantity);
                }
                _context.CartProduct.Remove(cartItem);
            }

            _context.Order.Add(order);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
