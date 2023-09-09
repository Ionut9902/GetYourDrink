using GetYourDrink.Bussiness.Products.Commands;
using GetYourDrink.Data.DataContext;
using GetYourDrink.Data.Models;
using MediatR;

namespace GetYourDrink.Bussiness.Products.Handlers
{
    public class AddProductToCartCommandHandler : IRequestHandler<AddProductToCartCommand, bool>
    {
        private GetYourDrinkContext _context;

        public AddProductToCartCommandHandler(GetYourDrinkContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddProductToCartCommand request, CancellationToken cancellationToken)
        {
            var cartProduct = new CartProduct
            {
                UserId = request.UserId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
            };

            if (ProductAlreadyInCart(cartProduct))
            {
                var cartProduct2 = _context.CartProduct.FirstOrDefault(x => x.ProductId == cartProduct.ProductId && x.UserId == cartProduct.UserId);
                cartProduct2.Quantity++;

                _context.CartProduct.Update(cartProduct2);
                return await _context.SaveChangesAsync() > 0;
            }

            _context.CartProduct.Add(cartProduct);
            return await _context.SaveChangesAsync() > 0;
        }

        public bool ProductAlreadyInCart(CartProduct cartProduct)
        {
            return _context.CartProduct.Any(x => x.ProductId == cartProduct.ProductId && x.UserId == cartProduct.UserId);
        }
    }
}
